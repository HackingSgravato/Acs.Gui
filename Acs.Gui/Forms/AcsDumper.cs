using System.Diagnostics;
using Acs.Core.Helpers;
using Dumper = Acs.Core.Services.AcsDumper;

namespace Acs.Gui.Forms;

public partial class AcsDumper : Form
{
    public AcsDumper()
    {
        InitializeComponent();
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void RefreshProcessesBtn_Click(object sender, EventArgs e)
    {
        processList.Rows.Clear();

        Process[] processes = Process.GetProcesses();
        foreach (Process process in processes)
        {
            processList.Rows.Add(process.ProcessName, process.Id, process.PagedMemorySize64 / 1024 / 1024);
        }
    }

    private void DumpSelectedBtn_Click(object sender, EventArgs e)
    {
        preDumpProcess();

        List<int> processesId = new();

        foreach (DataGridViewRow process in processList.SelectedRows)
        {
            int processId = int.Parse(process.Cells[1].Value.ToString()!);

            processesId.Add(processId);
        }

        lastRecentLogs.Items.Clear();

        string[] results = Dumper.Dump(processesId);

        foreach (string result in results)
        {
            recentLogs.Items.Add(result);
            lastRecentLogs.Items.Add(result);
        }

        postDumpProcess();
    }

    private void OpenRecLogBtn_Click(object sender, EventArgs e)
    {
        if (recentLogs.SelectedItem is not null)
        {
            Assets.OpenFile(recentLogs.SelectedItem.ToString()!);
        }
    }

    private void lastRecentLogs_SelectedIndexChanged(object sender, EventArgs e)
    {
        Assets.OpenFile(lastRecentLogs.SelectedItem.ToString()!);
    }

    private void preDumpProcess()
    {
        DumpSelectedBtn.Enabled = false;
        DumpAvailableBtn.Enabled = false;
        RefreshProcessesBtn.Enabled = false;
    }

    private void postDumpProcess()
    {
        DumpSelectedBtn.Enabled = true;
        DumpAvailableBtn.Enabled = true;
        RefreshProcessesBtn.Enabled = true;
    }

    private void DumpAvailableBtn_Click(object sender, EventArgs e)
    {
        preDumpProcess();

        lastRecentLogs.Items.Clear();

        string[] results = Dumper.DumpAvailable();

        foreach (string result in results)
        {
            recentLogs.Items.Add(result);
            lastRecentLogs.Items.Add(result);
        }

        postDumpProcess();
    }
}
