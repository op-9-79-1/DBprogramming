﻿namespace MarketBrowser
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttdonOpenCSV = new System.Windows.Forms.Button();
			this.textBoxCSVViewer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttdonOpenCSV
			// 
			this.buttdonOpenCSV.Location = new System.Drawing.Point(25, 12);
			this.buttdonOpenCSV.Name = "buttdonOpenCSV";
			this.buttdonOpenCSV.Size = new System.Drawing.Size(238, 37);
			this.buttdonOpenCSV.TabIndex = 0;
			this.buttdonOpenCSV.Text = "CSV 열기";
			this.buttdonOpenCSV.UseVisualStyleBackColor = true;
			this.buttdonOpenCSV.Click += new System.EventHandler(this.buttdonOpenCSV_Click);
			// 
			// textBoxCSVViewer
			// 
			this.textBoxCSVViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCSVViewer.Location = new System.Drawing.Point(25, 55);
			this.textBoxCSVViewer.Multiline = true;
			this.textBoxCSVViewer.Name = "textBoxCSVViewer";
			this.textBoxCSVViewer.Size = new System.Drawing.Size(737, 383);
			this.textBoxCSVViewer.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxCSVViewer);
			this.Controls.Add(this.buttdonOpenCSV);
			this.Name = "MainForm";
			this.Text = "전통시장 탐색기";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttdonOpenCSV;
		private System.Windows.Forms.TextBox textBoxCSVViewer;
	}
}

