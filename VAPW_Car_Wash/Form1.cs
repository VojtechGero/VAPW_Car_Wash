namespace VAPW_Car_Wash;

public partial class Form1 : Form
{
    WashStyle style=WashStyle.Basic;
    public Form1()
    {
        InitializeComponent();
    }
    bool hadleEvents;
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
}
