namespace calculator
{
	partial class calculate
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Result = new System.Windows.Forms.Label();
			this.txtNumber1 = new System.Windows.Forms.TextBox();
			this.txtNumber2 = new System.Windows.Forms.TextBox();
			this.btnCong = new System.Windows.Forms.Button();
			this.btnTru = new System.Windows.Forms.Button();
			this.btnNhan = new System.Windows.Forms.Button();
			this.btnChia = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số 2";
			// 
			// Result
			// 
			this.Result.AutoSize = true;
			this.Result.Location = new System.Drawing.Point(70, 341);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(44, 13);
			this.Result.TabIndex = 2;
			this.Result.Text = "Kết quả";
			// 
			// txtNumber1
			// 
			this.txtNumber1.Location = new System.Drawing.Point(159, 88);
			this.txtNumber1.Name = "txtNumber1";
			this.txtNumber1.Size = new System.Drawing.Size(297, 20);
			this.txtNumber1.TabIndex = 3;
			// 
			// txtNumber2
			// 
			this.txtNumber2.Location = new System.Drawing.Point(159, 136);
			this.txtNumber2.Name = "txtNumber2";
			this.txtNumber2.Size = new System.Drawing.Size(297, 20);
			this.txtNumber2.TabIndex = 4;
			// 
			// btnCong
			// 
			this.btnCong.Location = new System.Drawing.Point(73, 248);
			this.btnCong.Name = "btnCong";
			this.btnCong.Size = new System.Drawing.Size(84, 61);
			this.btnCong.TabIndex = 5;
			this.btnCong.Text = "Cộng";
			this.btnCong.UseVisualStyleBackColor = true;
			// 
			// btnTru
			// 
			this.btnTru.Location = new System.Drawing.Point(232, 248);
			this.btnTru.Name = "btnTru";
			this.btnTru.Size = new System.Drawing.Size(87, 61);
			this.btnTru.TabIndex = 6;
			this.btnTru.Text = "Trừ";
			this.btnTru.UseVisualStyleBackColor = true;
			// 
			// btnNhan
			// 
			this.btnNhan.Location = new System.Drawing.Point(381, 250);
			this.btnNhan.Name = "btnNhan";
			this.btnNhan.Size = new System.Drawing.Size(88, 56);
			this.btnNhan.TabIndex = 7;
			this.btnNhan.Text = "Nhân";
			this.btnNhan.UseVisualStyleBackColor = true;
			// 
			// btnChia
			// 
			this.btnChia.Location = new System.Drawing.Point(550, 252);
			this.btnChia.Name = "btnChia";
			this.btnChia.Size = new System.Drawing.Size(83, 53);
			this.btnChia.TabIndex = 8;
			this.btnChia.Text = "Chia";
			this.btnChia.UseVisualStyleBackColor = true;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(159, 341);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(310, 20);
			this.txtResult.TabIndex = 9;
			// 
			// calculate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnChia);
			this.Controls.Add(this.btnNhan);
			this.Controls.Add(this.btnTru);
			this.Controls.Add(this.btnCong);
			this.Controls.Add(this.txtNumber2);
			this.Controls.Add(this.txtNumber1);
			this.Controls.Add(this.Result);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "calculate";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.calculate_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Result;
		private System.Windows.Forms.TextBox txtNumber1;
		private System.Windows.Forms.TextBox txtNumber2;
		private System.Windows.Forms.Button btnCong;
		private System.Windows.Forms.Button btnTru;
		private System.Windows.Forms.Button btnNhan;
		private System.Windows.Forms.Button btnChia;
		private System.Windows.Forms.TextBox txtResult;
	}
}

