namespace InfoStudent
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
            label1 = new Label();
            txtMSSV = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            cbChuyenNganh = new ComboBox();
            label4 = new Label();
            cNam = new CheckBox();
            cNu = new CheckBox();
            label5 = new Label();
            listBoxMonHoc = new ListBox();
            listBoxMonHocDaChon = new ListBox();
            btnChon = new Button();
            btnBoChon = new Button();
            btnLuuThongTin = new Button();
            btnXoaChon = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 69);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(233, 62);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(301, 27);
            txtMSSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 107);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(233, 100);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(301, 27);
            txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 147);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Chuyên Ngành";
            // 
            // cbChuyenNganh
            // 
            cbChuyenNganh.FormattingEnabled = true;
            cbChuyenNganh.Location = new Point(233, 147);
            cbChuyenNganh.Name = "cbChuyenNganh";
            cbChuyenNganh.Size = new Size(301, 28);
            cbChuyenNganh.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 193);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Giới Tính";
            // 
            // cNam
            // 
            cNam.AutoSize = true;
            cNam.Location = new Point(233, 193);
            cNam.Name = "cNam";
            cNam.Size = new Size(63, 24);
            cNam.TabIndex = 7;
            cNam.Text = "Nam";
            cNam.UseVisualStyleBackColor = true;
            // 
            // cNu
            // 
            cNu.AutoSize = true;
            cNu.Location = new Point(316, 193);
            cNu.Name = "cNu";
            cNu.Size = new Size(51, 24);
            cNu.TabIndex = 8;
            cNu.Text = "Nữ";
            cNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 231);
            label5.Name = "label5";
            label5.Size = new Size(201, 20);
            label5.TabIndex = 9;
            label5.Text = "Chọn các Môn Học Tham Gia";
            // 
            // listBoxMonHoc
            // 
            listBoxMonHoc.FormattingEnabled = true;
            listBoxMonHoc.Location = new Point(109, 269);
            listBoxMonHoc.Name = "listBoxMonHoc";
            listBoxMonHoc.Size = new Size(275, 104);
            listBoxMonHoc.TabIndex = 10;
            // 
            // listBoxMonHocDaChon
            // 
            listBoxMonHocDaChon.FormattingEnabled = true;
            listBoxMonHocDaChon.Location = new Point(460, 269);
            listBoxMonHocDaChon.Name = "listBoxMonHocDaChon";
            listBoxMonHocDaChon.Size = new Size(275, 104);
            listBoxMonHocDaChon.TabIndex = 11;
            // 
            // btnChon
            // 
            btnChon.FlatStyle = FlatStyle.Flat;
            btnChon.Location = new Point(390, 288);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(64, 29);
            btnChon.TabIndex = 12;
            btnChon.Text = ">";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnBoChon
            // 
            btnBoChon.FlatStyle = FlatStyle.Flat;
            btnBoChon.Location = new Point(390, 323);
            btnBoChon.Name = "btnBoChon";
            btnBoChon.Size = new Size(64, 29);
            btnBoChon.TabIndex = 13;
            btnBoChon.Text = "<";
            btnBoChon.UseVisualStyleBackColor = true;
            btnBoChon.Click += btnBoChon_Click;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.FlatStyle = FlatStyle.Flat;
            btnLuuThongTin.Location = new Point(271, 379);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(123, 29);
            btnLuuThongTin.TabIndex = 14;
            btnLuuThongTin.Text = "Lưu Thông Tin";
            btnLuuThongTin.UseVisualStyleBackColor = true;
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.FlatStyle = FlatStyle.Flat;
            btnXoaChon.Location = new Point(411, 379);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(99, 29);
            btnXoaChon.TabIndex = 15;
            btnXoaChon.Text = "Xóa Chọn";
            btnXoaChon.UseVisualStyleBackColor = true;
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(26, 414);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 252);
            dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "MSSV";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ Tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "Chuyên Ngành";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới Tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Số Môn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 678);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoaChon);
            Controls.Add(btnLuuThongTin);
            Controls.Add(btnBoChon);
            Controls.Add(btnChon);
            Controls.Add(listBoxMonHocDaChon);
            Controls.Add(listBoxMonHoc);
            Controls.Add(label5);
            Controls.Add(cNu);
            Controls.Add(cNam);
            Controls.Add(label4);
            Controls.Add(cbChuyenNganh);
            Controls.Add(label3);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtMSSV);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMSSV;
        private Label label2;
        private TextBox txtHoTen;
        private Label label3;
        private ComboBox cbChuyenNganh;
        private Label label4;
        private CheckBox cNam;
        private CheckBox cNu;
        private Label label5;
        private ListBox listBoxMonHoc;
        private ListBox listBoxMonHocDaChon;
        private Button btnChon;
        private Button btnBoChon;
        private Button btnLuuThongTin;
        private Button btnXoaChon;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
