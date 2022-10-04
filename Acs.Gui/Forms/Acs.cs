namespace Acs.Gui.Forms;

public partial class Acs : Form
{
    public Acs()
    {
        InitializeComponent();

        systemTrace.ContextMenuStrip = new();
        systemTrace.ContextMenuStrip.Items.Add("New AcsFinder", null, NewFinder);
        systemTrace.ContextMenuStrip.Items.Add("New AcsDumper", null, NewDumper);
        systemTrace.ContextMenuStrip.Items.Add("Exit", null, Exit);
    }

    private void NewDumper(object? sender, EventArgs e)
    {
        new AcsDumper().Show();
    }

    private void NewFinder(object? sender, EventArgs e)
    {
        new AcsFinder().Show();
    }

    private void Exit(object? sender, EventArgs e)
    {
        Application.Exit();
    }

    private void hideBtn_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void systemTrace_DoubleClick(object sender, EventArgs e)
    {
        Show();
    }

    private void NewAcsFinderBtn_Click(object sender, EventArgs e)
    {
        new AcsFinder().Show();
    }

    private void NewAcsDumperBtn_Click(object sender, EventArgs e)
    {
        new AcsDumper().Show();
    }
}
