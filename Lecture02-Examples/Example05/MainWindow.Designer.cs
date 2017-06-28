namespace Example05
{
	partial class MainWindow
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.convertButton = new System.Windows.Forms.Button();
			this.scorelabel = new System.Windows.Forms.Label();
			this.gpaLabel = new System.Windows.Forms.Label();
			this.scoreTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(98, 231);
			this.convertButton.Margin = new System.Windows.Forms.Padding(5);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(125, 36);
			this.convertButton.TabIndex = 0;
			this.convertButton.Text = "轉換為GPA: ";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// scorelabel
			// 
			this.scorelabel.AutoSize = true;
			this.scorelabel.Location = new System.Drawing.Point(95, 44);
			this.scorelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.scorelabel.Name = "scorelabel";
			this.scorelabel.Size = new System.Drawing.Size(204, 19);
			this.scorelabel.TabIndex = 1;
			this.scorelabel.Text = "請輸入百分制原始成績:";
			// 
			// gpaLabel
			// 
			this.gpaLabel.AutoSize = true;
			this.gpaLabel.Location = new System.Drawing.Point(405, 131);
			this.gpaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.gpaLabel.Name = "gpaLabel";
			this.gpaLabel.Size = new System.Drawing.Size(55, 19);
			this.gpaLabel.TabIndex = 2;
			this.gpaLabel.Text = "GPA: ";
			// 
			// scoreTextBox
			// 
			this.scoreTextBox.Location = new System.Drawing.Point(98, 131);
			this.scoreTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.scoreTextBox.Name = "scoreTextBox";
			this.scoreTextBox.Size = new System.Drawing.Size(164, 30);
			this.scoreTextBox.TabIndex = 3;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 413);
			this.Controls.Add(this.scoreTextBox);
			this.Controls.Add(this.gpaLabel);
			this.Controls.Add(this.scorelabel);
			this.Controls.Add(this.convertButton);
			this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainWindow";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.Label scorelabel;
		private System.Windows.Forms.Label gpaLabel;
		private System.Windows.Forms.TextBox scoreTextBox;
	}
}

