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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(93, 420);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(52, 16);
            this.Result.TabIndex = 2;
            this.Result.Text = "Kết quả";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(212, 108);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(395, 22);
            this.txtNumber1.TabIndex = 3;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(212, 167);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(395, 22);
            this.txtNumber2.TabIndex = 4;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(97, 305);
            this.btnCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(112, 75);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(309, 305);
            this.btnTru.Margin = new System.Windows.Forms.Padding(4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(116, 75);
            this.btnTru.TabIndex = 6;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(508, 308);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(117, 69);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(733, 310);
            this.btnChia.Margin = new System.Windows.Forms.Padding(4);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(111, 65);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(212, 420);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(412, 22);
            this.txtResult.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Caculate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label3;
    }
}

