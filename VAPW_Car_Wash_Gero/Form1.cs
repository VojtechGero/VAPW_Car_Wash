using GeroCarWash;
using VAPW_Car_Wash_Gero.Properties;
using Timer = System.Windows.Forms.Timer;
namespace VAPW_Car_Wash_Gero;

public partial class Form1 : Form
{
    WashStyle style = WashStyle.Basic;
    CarWash wash;
    bool hadleEvents = false;
    Point originalLocation;
    Timer timer = new Timer();
    public Form1()
    {
        InitializeComponent();
        wash = new CarWash();
        wash.OnCarWashStateChanged += OnChangedCarWashState;
        originalLocation = Car.Location;
        timer.Tick += new EventHandler(CheckCarWash);
        timer.Interval = 100;
        timer.Start();
        if (hadleEvents)
        {
            ConnectionLabel.Text = "Using events";
        }
        else ConnectionLabel.Text = "Using timer";
    }

    private void CheckCarWash(object? sender, EventArgs e)
    {
        if (!hadleEvents)
        {
            doSemaphor(InSemafor, wash.InputSemafor);
            doSemaphor(OutSemafor, wash.OutputSemafor);
            doGates(InGate, wash.InputVrataOpen);
            doGates(OutGate, wash.OutputVrataOpen);
        }
        timer.Start();
    }

    private void doGates(Panel panel, bool open)
    {
        if (open)
        {
            panel.Visible = false;
        }
        else panel.Visible = true;
    }

    private void doSemaphor(Panel panel, Semafor color)
    {
        if (color == Semafor.Green)
        {
            panel.BackColor = Color.Green;
        }
        else panel.BackColor = Color.Red;
    }

    private void OnChangedCarWashState(object sender, CarWashDTO CarWashState)
    {
        if (hadleEvents)
        {
            Invoke(new Action(() =>
            {
                doSemaphor(InSemafor, CarWashState.InputSemafor);
                doSemaphor(OutSemafor, CarWashState.OutputSemafor);
                doGates(InGate, CarWashState.InputVrataOpen);
                doGates(OutGate, CarWashState.OutputVrataOpen);
            }));
        }
    }

    private void killError()
    {
        ErrorLabel.Visible = false;
    }
    private void KillAll()
    {
        FullButton.Checked = false;
        BasicButton.Checked = false;
        QuickButton.Checked = false;
    }

    private void FullButton_Click(object sender, EventArgs e)
    {
        KillAll();
        FullButton.Checked = true;
        style = WashStyle.FULL;
    }

    private void BasicButton_Click(object sender, EventArgs e)
    {
        KillAll();
        BasicButton.Checked = true;
        style = WashStyle.Basic;
    }

    private void QuickButton_Click(object sender, EventArgs e)
    {
        KillAll();
        QuickButton.Checked = true;
        style = WashStyle.Quick;
    }

    private void CarHereButton_Click(object sender, EventArgs e)
    {
        killError();
        if (Car.Location == new Point(originalLocation.X + 600, originalLocation.Y) || Car.Location == originalLocation)
        {
            if (Car.Location != originalLocation)
            {
                Car.Location = originalLocation;
            }
            Car.Image = Resources.SadCar;

            Invoke(new Action(() =>
            {
                wash.CarReady();
            }));
            Car.Visible = true;
        }
        else
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = "Car is already here";
        }

    }

    private void CarEntryButton_Click(object sender, EventArgs e)
    {
        killError();
        try
        {
            Invoke(new Action(() =>
            {
                wash.ChooseStyle(style);
                wash.CarIn();
            }));
            Car.Location = new Point(Car.Location.X + 300, Car.Location.Y);
        }
        catch (InvalidOperationException ex)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = ex.Message;
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Invoke(new Action(() =>
        {
            wash?.Dispose();
        }));
    }

    private void LeaveButton_Click(object sender, EventArgs e)
    {
        killError();
        try
        {
            Invoke(new Action(() =>
            {
                wash.Leave();
            }));
            Car.Location = new Point(Car.Location.X + 300, Car.Location.Y);
            Car.Image = Resources.HappyCar;
        }
        catch (InvalidOperationException ex)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = ex.Message;
        }
    }

    private void modelConnectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var configForm = new ConfigurationFrom(hadleEvents);
        configForm.ShowDialog();
        hadleEvents = configForm.EventsSelected;
        if(hadleEvents)
        {
            ConnectionLabel.Text = "Using events";
        }else ConnectionLabel.Text = "Using timer";
    }
}
