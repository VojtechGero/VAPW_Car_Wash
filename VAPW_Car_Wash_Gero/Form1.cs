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
        wash = new CarWash();
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
        wash.ChooseStyle(style);
        wash.CarReady();
        pictureBox1.Visible = true;

    }

    private void CarEntryButton_Click(object sender, EventArgs e)
    {
        killError();
        try
        {
            wash.CarIn();
        }
        catch (InvalidOperationException ex)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = ex.Message;
        }

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        wash.Dispose();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        wash?.Dispose();
    }
}
