namespace WF_App_4._7._2
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelTip = new System.Windows.Forms.Label();
			this.labelMsg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Location = new System.Drawing.Point(327, 284);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(120, 50);
			this.buttonSubmit.TabIndex = 0;
			this.buttonSubmit.Text = "O K";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(212, 186);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(350, 35);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelTip
			// 
			this.labelTip.Location = new System.Drawing.Point(212, 100);
			this.labelTip.Name = "labelTip";
			this.labelTip.Size = new System.Drawing.Size(350, 23);
			this.labelTip.TabIndex = 2;
			this.labelTip.Text = "Your Name Please:";
			this.labelTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelMsg
			// 
			this.labelMsg.Location = new System.Drawing.Point(112, 397);
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.Size = new System.Drawing.Size(550, 24);
			this.labelMsg.TabIndex = 3;
			this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 529);
			this.Controls.Add(this.labelMsg);
			this.Controls.Add(this.labelTip);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.buttonSubmit);
			this.Name = "MainForm";
			this.Text = "WinForm App (.NET Framework 4.7.2)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelTip;
		private System.Windows.Forms.Label labelMsg;
	}
}

