using GeroCarWash;
namespace VAPW_Car_Wash_Gero;

public partial class Form1 : Form
{
    WashStyle style = WashStyle.Basic;
    CarWash wash;
    bool hadleEvents;
    public Form1()
    {
        InitializeComponent();
        hadleEvents = true;
        wash = new CarWash();
        wash.OnCarWashStateChanged += OnChangedCarWashState;
    }

    private void OnChangedCarWashState(object sender, CarWashDTO CarWashState)
    {
        if(hadleEvents)
        {
            if (CarWashState.InputSemafor == CarWash.Semafor.Green)
            {
                InSemafor.BackColor = Color.Green;
            }
            else
            {
                InSemafor.BackColor= Color.Red;
            }
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
        this.Invoke(new Action(() =>
        {
            wash.ChooseStyle(style);
            wash.CarReady();
        }));
        pictureBox1.Visible = true;
    }

    private void CarEntryButton_Click(object sender, EventArgs e)
    {
        killError();
        try
        {
            this.Invoke(new Action(() =>
            {
                wash.CarIn();
            }));
        }
        catch (InvalidOperationException ex)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = ex.Message;
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Invoke( new Action(() =>
        {
            wash?.Dispose();
        }));
    }
}
