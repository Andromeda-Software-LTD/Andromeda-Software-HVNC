using System;
using System.Windows.Forms;

namespace HVNC
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new Forms.Frm_Terms());
		}
	}
}
