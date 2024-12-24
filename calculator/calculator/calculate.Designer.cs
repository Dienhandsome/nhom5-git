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
            this.lblso1 = new System.Windows.Forms.Label();
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
            // lblso1
            // 
            this.lblso1.AutoSize = true;
            this.lblso1.Location = new System.Drawing.Point(140, 175);
            this.lblso1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(56, 25);
            this.lblso1.TabIndex = 0;
            this.lblso1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(140, 656);
            this.Result.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(86, 25);
            this.Result.TabIndex = 2;
            this.Result.Text = "Kết quả";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(318, 169);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(590, 31);
            this.txtNumber1.TabIndex = 3;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(318, 261);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(590, 31);
            this.txtNumber2.TabIndex = 4;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(146, 477);
            this.btnCong.Margin = new System.Windows.Forms.Padding(6);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(168, 117);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(464, 477);
            this.btnTru.Margin = new System.Windows.Forms.Padding(6);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(174, 117);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(762, 481);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(6);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(176, 108);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(1100, 484);
            this.btnChia.Margin = new System.Windows.Forms.Padding(6);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(166, 102);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(318, 656);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(616, 31);
            this.txtResult.TabIndex = 9;
            // 
            // calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblso1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "calculate";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblso1;
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

