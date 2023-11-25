namespace WF_App_8._0
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBoxName = new TextBox();
			labelTip = new Label();
			labelMsg = new Label();
			buttonSubmit = new Button();
			SuspendLayout();
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(212, 188);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(350, 38);
			textBoxName.TabIndex = 0;
			textBoxName.TextAlign = HorizontalAlignment.Center;
			// 
			// labelTip
			// 
			labelTip.Location = new Point(212, 75);
			labelTip.Name = "labelTip";
			labelTip.Size = new Size(350, 62);
			labelTip.TabIndex = 1;
			labelTip.Text = "Your Name Please:";
			labelTip.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelMsg
			// 
			labelMsg.Location = new Point(112, 374);
			labelMsg.Name = "labelMsg";
			labelMsg.Size = new Size(550, 62);
			labelMsg.TabIndex = 2;
			labelMsg.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonSubmit
			// 
			buttonSubmit.Location = new Point(312, 277);
			buttonSubmit.Name = "buttonSubmit";
			buttonSubmit.Size = new Size(120, 50);
			buttonSubmit.TabIndex = 3;
			buttonSubmit.Text = "O K";
			buttonSubmit.UseVisualStyleBackColor = true;
			buttonSubmit.Click += buttonSubmit_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(14F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(774, 529);
			Controls.Add(buttonSubmit);
			Controls.Add(labelMsg);
			Controls.Add(labelTip);
			Controls.Add(textBoxName);
			Name = "MainForm";
			Text = "WinForm App (.NET 8.0)";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxName;
		private Label labelTip;
		private Label labelMsg;
		private Button buttonSubmit;
	}
}
