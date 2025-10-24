namespace Calculator
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
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            txtHienthimanhinh = new TextBox();
            btnBackspace = new Button();
            btnCE = new Button();
            btnC = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnChia = new Button();
            btnSqrt = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btnCongVaTru = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnCham = new Button();
            btnNhan = new Button();
            btnTru = new Button();
            btnCong = new Button();
            btnPhanTram = new Button();
            btnMauso = new Button();
            btnBang = new Button();
            btnMC = new Button();
            btnMR = new Button();
            btnMS = new Button();
            btnMplus = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(432, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // txtHienthimanhinh
            // 
            txtHienthimanhinh.BorderStyle = BorderStyle.FixedSingle;
            txtHienthimanhinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHienthimanhinh.Location = new Point(12, 63);
            txtHienthimanhinh.Multiline = true;
            txtHienthimanhinh.Name = "txtHienthimanhinh";
            txtHienthimanhinh.Size = new Size(408, 42);
            txtHienthimanhinh.TabIndex = 1;
            txtHienthimanhinh.Text = "0.";
            txtHienthimanhinh.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBackspace
            // 
            btnBackspace.FlatAppearance.BorderColor = Color.Blue;
            btnBackspace.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnBackspace.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnBackspace.ForeColor = Color.Red;
            btnBackspace.Location = new Point(146, 127);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(98, 40);
            btnBackspace.TabIndex = 2;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnCE
            // 
            btnCE.FlatAppearance.BorderColor = Color.Blue;
            btnCE.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCE.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnCE.ForeColor = Color.Red;
            btnCE.Location = new Point(250, 127);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(88, 40);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.FlatAppearance.BorderColor = Color.Blue;
            btnC.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnC.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnC.ForeColor = Color.Red;
            btnC.Location = new Point(344, 127);
            btnC.Name = "btnC";
            btnC.Size = new Size(76, 40);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btn7
            // 
            btn7.FlatAppearance.BorderColor = Color.Blue;
            btn7.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn7.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(146, 173);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 40);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.FlatAppearance.BorderColor = Color.Blue;
            btn8.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn8.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(202, 173);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 40);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.FlatAppearance.BorderColor = Color.Blue;
            btn9.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn9.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(258, 173);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 40);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnChia
            // 
            btnChia.FlatAppearance.BorderColor = Color.Blue;
            btnChia.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnChia.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnChia.ForeColor = Color.Red;
            btnChia.Location = new Point(314, 173);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(50, 40);
            btnChia.TabIndex = 8;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.FlatAppearance.BorderColor = Color.Blue;
            btnSqrt.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnSqrt.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnSqrt.ForeColor = Color.Blue;
            btnSqrt.Location = new Point(370, 173);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(50, 40);
            btnSqrt.TabIndex = 9;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btn4
            // 
            btn4.FlatAppearance.BorderColor = Color.Blue;
            btn4.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn4.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(146, 219);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 40);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.FlatAppearance.BorderColor = Color.Blue;
            btn1.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn1.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(146, 265);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 40);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn0
            // 
            btn0.FlatAppearance.BorderColor = Color.Blue;
            btn0.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn0.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(146, 311);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 40);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.FlatAppearance.BorderColor = Color.Blue;
            btn5.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn5.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(202, 219);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 40);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.FlatAppearance.BorderColor = Color.Blue;
            btn2.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn2.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(202, 265);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 40);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btnCongVaTru
            // 
            btnCongVaTru.FlatAppearance.BorderColor = Color.Blue;
            btnCongVaTru.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCongVaTru.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnCongVaTru.ForeColor = Color.Blue;
            btnCongVaTru.Location = new Point(202, 311);
            btnCongVaTru.Name = "btnCongVaTru";
            btnCongVaTru.Size = new Size(50, 40);
            btnCongVaTru.TabIndex = 15;
            btnCongVaTru.Text = "+/-";
            btnCongVaTru.UseVisualStyleBackColor = true;
            btnCongVaTru.Click += btnCongVaTru_Click;
            // 
            // btn6
            // 
            btn6.FlatAppearance.BorderColor = Color.Blue;
            btn6.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn6.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(258, 219);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 40);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.FlatAppearance.BorderColor = Color.Blue;
            btn3.FlatAppearance.MouseDownBackColor = Color.Blue;
            btn3.FlatAppearance.MouseOverBackColor = Color.Blue;
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(258, 265);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 40);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btnCham
            // 
            btnCham.FlatAppearance.BorderColor = Color.Blue;
            btnCham.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCham.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnCham.ForeColor = Color.Blue;
            btnCham.Location = new Point(258, 311);
            btnCham.Name = "btnCham";
            btnCham.Size = new Size(50, 40);
            btnCham.TabIndex = 18;
            btnCham.Text = ".";
            btnCham.UseVisualStyleBackColor = true;
            btnCham.Click += btnCham_Click;
            // 
            // btnNhan
            // 
            btnNhan.FlatAppearance.BorderColor = Color.Blue;
            btnNhan.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnNhan.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnNhan.ForeColor = Color.Red;
            btnNhan.Location = new Point(314, 219);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(50, 40);
            btnNhan.TabIndex = 19;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnTru
            // 
            btnTru.FlatAppearance.BorderColor = Color.Blue;
            btnTru.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnTru.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnTru.ForeColor = Color.Red;
            btnTru.Location = new Point(314, 265);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(50, 40);
            btnTru.TabIndex = 20;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnCong
            // 
            btnCong.FlatAppearance.BorderColor = Color.Blue;
            btnCong.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCong.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnCong.ForeColor = Color.Red;
            btnCong.Location = new Point(314, 311);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(50, 40);
            btnCong.TabIndex = 21;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnPhanTram
            // 
            btnPhanTram.FlatAppearance.BorderColor = Color.Blue;
            btnPhanTram.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnPhanTram.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnPhanTram.ForeColor = Color.Blue;
            btnPhanTram.Location = new Point(370, 219);
            btnPhanTram.Name = "btnPhanTram";
            btnPhanTram.Size = new Size(50, 40);
            btnPhanTram.TabIndex = 22;
            btnPhanTram.Text = "%";
            btnPhanTram.UseVisualStyleBackColor = true;
            btnPhanTram.Click += btnPhanTram_Click;
            // 
            // btnMauso
            // 
            btnMauso.FlatAppearance.BorderColor = Color.Blue;
            btnMauso.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnMauso.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnMauso.ForeColor = Color.Blue;
            btnMauso.Location = new Point(370, 265);
            btnMauso.Name = "btnMauso";
            btnMauso.Size = new Size(50, 40);
            btnMauso.TabIndex = 23;
            btnMauso.Text = "1/x";
            btnMauso.UseVisualStyleBackColor = true;
            btnMauso.Click += btnMauso_Click;
            // 
            // btnBang
            // 
            btnBang.FlatAppearance.BorderColor = Color.Blue;
            btnBang.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnBang.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnBang.ForeColor = Color.Red;
            btnBang.Location = new Point(370, 311);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(50, 40);
            btnBang.TabIndex = 24;
            btnBang.Text = "=";
            btnBang.UseVisualStyleBackColor = true;
            btnBang.Click += btnBang_Click;
            // 
            // btnMC
            // 
            btnMC.FlatAppearance.BorderColor = Color.Blue;
            btnMC.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnMC.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnMC.ForeColor = Color.Red;
            btnMC.Location = new Point(12, 173);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(98, 40);
            btnMC.TabIndex = 25;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.FlatAppearance.BorderColor = Color.Blue;
            btnMR.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnMR.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnMR.ForeColor = Color.Red;
            btnMR.Location = new Point(12, 219);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(98, 40);
            btnMR.TabIndex = 26;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += btnMR_Click;
            // 
            // btnMS
            // 
            btnMS.FlatAppearance.BorderColor = Color.Blue;
            btnMS.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnMS.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnMS.ForeColor = Color.Red;
            btnMS.Location = new Point(12, 265);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(98, 40);
            btnMS.TabIndex = 27;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += btnMS_Click;
            // 
            // btnMplus
            // 
            btnMplus.FlatAppearance.BorderColor = Color.Blue;
            btnMplus.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnMplus.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnMplus.ForeColor = Color.Red;
            btnMplus.Location = new Point(12, 311);
            btnMplus.Name = "btnMplus";
            btnMplus.Size = new Size(98, 40);
            btnMplus.TabIndex = 28;
            btnMplus.Text = "M+";
            btnMplus.UseVisualStyleBackColor = true;
            btnMplus.Click += btnMplus_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(28, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(54, 42);
            panel1.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(432, 373);
            Controls.Add(panel1);
            Controls.Add(btnMplus);
            Controls.Add(btnMS);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnBang);
            Controls.Add(btnMauso);
            Controls.Add(btnPhanTram);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnCham);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btnCongVaTru);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btnSqrt);
            Controls.Add(btnChia);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBackspace);
            Controls.Add(txtHienthimanhinh);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox txtHienthimanhinh;
        private Button btnBackspace;
        private Button btnCE;
        private Button btnC;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnChia;
        private Button btnSqrt;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btn5;
        private Button btn2;
        private Button btnCongVaTru;
        private Button btn6;
        private Button btn3;
        private Button btnCham;
        private Button btnNhan;
        private Button btnTru;
        private Button btnCong;
        private Button btnPhanTram;
        private Button btnMauso;
        private Button btnBang;
        private Button btnMC;
        private Button btnMR;
        private Button btnMS;
        private Button btnMplus;
        private Panel panel1;
    }
}
