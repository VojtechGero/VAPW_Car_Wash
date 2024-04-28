using System.Diagnostics;
namespace GeroCarWash;

public class CarWash : IDisposable
{
    public enum Semafor
    {
        Red,
        Green
    }

    public bool InputVrataOpen {  get; private set; }
    public bool OutputVrataOpen {  get; private set; }
    public Semafor InputSemafor { get; private set; }
    public Semafor OutputSemafor { get; private set; }

    private int WorkingCycleMs=0;
    private CarWashDTO _CarWashState { get; set; }
    public CarWashDTO CarWashState { get { return _CarWashState; } private set { var changed = value != _CarWashState; _CarWashState = value; if (changed) OnCarWashStateChanged?.Invoke(this, _CarWashState); } }


    public delegate void ChangedCarWashState(object sender, CarWashDTO CarWashState);
    public event ChangedCarWashState OnCarWashStateChanged;

    private bool Running { get; set; } = false;
    private bool Washing { get; set; } = false;
    private bool Open { get; set; } = false;
    private bool Finished {  get; set; } = false;

    private Thread _thread = new Thread(new ParameterizedThreadStart(ThreadProcedure));


    private static void ThreadProcedure(object obj)
    {
        var carWash = (CarWash)obj;
        var processStopwatch = Stopwatch.StartNew();
        short state = 0;
        carWash.InputSemafor = Semafor.Red;
        carWash.OutputSemafor = Semafor.Red;
        carWash.InputVrataOpen = false;
        carWash.OutputVrataOpen = false;
        carWash.CarWashState = UpdateDTO(carWash);

        while (carWash.Running)
        {
            Stopwatch timingStopwatch = Stopwatch.StartNew();
            processStopwatch.Stop();
            var elapsedTimeSeconds = processStopwatch.Elapsed.TotalSeconds;
            if (elapsedTimeSeconds > 0)
            {
                switch (state)
                {
                    case 0:
                        if (carWash.Open)
                        {
                            carWash.InputSemafor = Semafor.Green;
                            carWash.InputVrataOpen = true;
                            carWash.CarWashState = UpdateDTO(carWash);
                            state = 1;
                        }
                        break;
                    case 1:
                        if (carWash.Washing)
                        {
                            carWash.InputSemafor = Semafor.Red;
                            carWash.OutputVrataOpen = false;
                            carWash.CarWashState = UpdateDTO(carWash);
                            state = 2;
                        }
                        break;
                    case 2:
                        if (!carWash.Washing)
                        {
                            carWash.OutputSemafor = Semafor.Green;
                            carWash.OutputVrataOpen = true;
                            carWash.Finished = true;
                            state = 3;
                        }
                        break;
                    case 3:
                        if (!carWash.Finished)
                        {
                            carWash.InputSemafor = Semafor.Red;
                            carWash.OutputSemafor = Semafor.Red;
                            carWash.InputVrataOpen = false;
                            carWash.OutputVrataOpen = false;
                            carWash.Running = false;
                            state = 0;
                        }
                        break;
                }
            }
            processStopwatch.Restart();

            timingStopwatch.Stop();
            if (carWash.Washing)
            {
                var toWaitMs = carWash.WorkingCycleMs - (int)timingStopwatch.ElapsedMilliseconds;
                toWaitMs = toWaitMs < 1 ? 1 : toWaitMs;
                try
                {
                    Thread.Sleep(toWaitMs);
                }
                catch (ThreadInterruptedException)
                {
                    carWash.Washing = false;
                }
            }
        }
    }

    private static CarWashDTO UpdateDTO(CarWash self)
    {
        var DTO=new CarWashDTO(self.InputVrataOpen, self.OutputVrataOpen, self.InputSemafor, self.OutputSemafor);
        return DTO;
    }

    public static int GetWashDuration(WashStyle style)
    {
        return style switch
        {
            WashStyle.FULL => 10,
            WashStyle.Basic => 5,
            WashStyle.Quick => 2,
            _ => throw new ArgumentException("Invalid wash style"),
        };
    }

    public CarWash()
    {
        Running = true;
        _thread.Start(this);
    }

    public void CarReady()
    {
        if (!Washing)
        {
            Open = true;
        }
    }

    public void Leave()
    {
        if (!Finished)
        {
            throw new InvalidOperationException("Car is not washed");
        }
        Finished = false;
    }

    public void CarIn()
    {
        if (!Open)
        {
            throw new InvalidOperationException("Door is not Open");
        }
        Washing = true;
    }

    public void ChooseStyle(WashStyle style)
    {
        int time = 1000 * GetWashDuration(style);
        WorkingCycleMs = time;
    }

    public void Dispose()
    {
        try
        {
            _thread.Interrupt();
            _thread.Join();
        }
        catch (Exception)
        {

        }
    }
}

