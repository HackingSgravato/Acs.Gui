using Acs.Core.Helpers;

namespace Acs.Gui.Forms;

public partial class AcsFinder : Form
{
    public AcsFinder()
    {
        InitializeComponent();
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void SelectFilesBtn_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new();
        ofd.Multiselect = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            foreach (string file in ofd.FileNames)
            {
                filesList.Items.Add(file);
            }
        }
    }

    private void filesList_SelectedIndexChanged(object sender, EventArgs e)
    {
        filesList.Items.Remove(filesList.SelectedItem);
    }

    private void OpenRecLogBtn_Click(object sender, EventArgs e)
    {
        if (recentLogs.SelectedItem is not null)
        {
            Assets.OpenFile(recentLogs.SelectedItem.ToString()!);
        }
    }

    private void SearchBtn_Click(object sender, EventArgs e)
    {
        preSearchProcess();

        if (filesList.Items.Count >= 2)
        {
            if (differencesOption.Checked)
            {
                string result = Core.Services.AcsFinder.GetDifferences(filesList.Items.Cast<string>().ToList());
                recentLogs.Items.Add(result);
                latestLog.Text = result;
            }
            else if (occurrencesOption.Checked)
            {
                string result = Core.Services.AcsFinder.GetOccurrences(filesList.Items.Cast<string>().ToList());
                recentLogs.Items.Add(result);
                latestLog.Text = result;
            }
        }
        else
        {
            MessageBox.Show("Please select at least two file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        postSearchProcess();
    }

    private void SearchInFilesBtn_Click(object sender, EventArgs e)
    {
        preSearchProcess();
        
        string stringToSearchFor = stringToSearchForBox.Text;

        if (!string.IsNullOrEmpty(stringToSearchFor))
        {
            if (filesList.Items.Count >= 1)
            {
                string result = Core.Services.AcsFinder.GetOccurrences(filesList.Items.Cast<string>().ToList(), stringToSearchFor);
                recentLogs.Items.Add(result);
                latestLog.Text = result;
            }
        }

        postSearchProcess();
    }

    private void latestLog_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(latestLog.Text))
        {
            Assets.OpenFile(latestLog.Text);
        }
    }

    private void latestLog_MouseHover(object sender, EventArgs e)
    {
        toolTip.SetToolTip(latestLog, $"{latestLog.Text} \nClick to open.");
    }

    private void preSearchProcess()
    {
        SelectFilesBtn.Enabled = false;
        SearchBtn.Enabled = false;
        SearchInFilesBtn.Enabled = false;
        filesList.Enabled = false;
    }

    private void postSearchProcess()
    {
        SelectFilesBtn.Enabled = true;
        SearchBtn.Enabled = true;
        SearchInFilesBtn.Enabled = true;
        filesList.Enabled = true;
    }
}
