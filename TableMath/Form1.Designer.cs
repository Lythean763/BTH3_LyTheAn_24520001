namespace TableMath
{
    partial class Form1
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            textDapan = new TextBox();
            lblAbswer = new Label();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.BorderStyle = BorderStyle.FixedSingle;
            txtNumber1.Location = new Point(146, 92);
            txtNumber1.Multiline = true;
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(272, 35);
            txtNumber1.TabIndex = 0;
            txtNumber1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.BorderStyle = BorderStyle.FixedSingle;
            txtNumber2.Location = new Point(146, 150);
            txtNumber2.Multiline = true;
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(272, 36);
            txtNumber2.TabIndex = 1;
            txtNumber2.TextChanged += txtNumber2_TextChanged;
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber1.Location = new Point(40, 99);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(104, 28);
            lblNumber1.TabIndex = 2;
            lblNumber1.Text = "Number 1:";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber2.Location = new Point(40, 158);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(104, 28);
            lblNumber2.TabIndex = 3;
            lblNumber2.Text = "Number 2:";
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCong.Location = new Point(25, 230);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(76, 55);
            btnCong.TabIndex = 4;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTru.Location = new Point(130, 230);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(76, 55);
            btnTru.TabIndex = 5;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhan.Location = new Point(245, 230);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(76, 55);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChia.Location = new Point(365, 230);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(76, 55);
            btnChia.TabIndex = 7;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // textDapan
            // 
            textDapan.BorderStyle = BorderStyle.FixedSingle;
            textDapan.Location = new Point(146, 326);
            textDapan.Multiline = true;
            textDapan.Name = "textDapan";
            textDapan.Size = new Size(272, 36);
            textDapan.TabIndex = 8;
            textDapan.TextChanged += textDapan_TextChanged;
            // 
            // lblAbswer
            // 
            lblAbswer.AutoSize = true;
            lblAbswer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbswer.Location = new Point(65, 334);
            lblAbswer.Name = "lblAbswer";
            lblAbswer.Size = new Size(79, 28);
            lblAbswer.TabIndex = 9;
            lblAbswer.Text = "Answer:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(lblAbswer);
            Controls.Add(textDapan);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Lab02-Example";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label lblNumber1;
        private Label lblNumber2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private TextBox textDapan;
        private Label lblAbswer;
    }
}
