namespace ManageAccount
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
            txtSTK = new TextBox();
            label1 = new Label();
            txtTKH = new TextBox();
            label2 = new Label();
            txtDCKH = new TextBox();
            label3 = new Label();
            txtSoTienTrongTaiKhoan = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnThemHoacCapNhat = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label6 = new Label();
            txtTongTien = new TextBox();
            SuspendLayout();
            // 
            // txtSTK
            // 
            txtSTK.BorderStyle = BorderStyle.FixedSingle;
            txtSTK.Location = new Point(214, 87);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(458, 27);
            txtSTK.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 91);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 1;
            label1.Text = "Số tài khoản";
            // 
            // txtTKH
            // 
            txtTKH.BorderStyle = BorderStyle.FixedSingle;
            txtTKH.Location = new Point(214, 120);
            txtTKH.Name = "txtTKH";
            txtTKH.Size = new Size(458, 27);
            txtTKH.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 124);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            // 
            // txtDCKH
            // 
            txtDCKH.BorderStyle = BorderStyle.FixedSingle;
            txtDCKH.Location = new Point(214, 153);
            txtDCKH.Name = "txtDCKH";
            txtDCKH.Size = new Size(458, 27);
            txtDCKH.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 157);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 5;
            label3.Text = "Địa chỉ khách hàng";
            // 
            // txtSoTienTrongTaiKhoan
            // 
            txtSoTienTrongTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtSoTienTrongTaiKhoan.Location = new Point(214, 186);
            txtSoTienTrongTaiKhoan.Name = "txtSoTienTrongTaiKhoan";
            txtSoTienTrongTaiKhoan.Size = new Size(458, 27);
            txtSoTienTrongTaiKhoan.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 190);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 7;
            label4.Text = "Số tiền trong tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(63, 9);
            label5.Name = "label5";
            label5.Size = new Size(680, 60);
            label5.TabIndex = 8;
            label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // btnThemHoacCapNhat
            // 
            btnThemHoacCapNhat.BackColor = SystemColors.Control;
            btnThemHoacCapNhat.FlatStyle = FlatStyle.Flat;
            btnThemHoacCapNhat.Location = new Point(301, 219);
            btnThemHoacCapNhat.Name = "btnThemHoacCapNhat";
            btnThemHoacCapNhat.Size = new Size(135, 29);
            btnThemHoacCapNhat.TabIndex = 9;
            btnThemHoacCapNhat.Text = "Thêm / Cập Nhật";
            btnThemHoacCapNhat.UseVisualStyleBackColor = false;
            btnThemHoacCapNhat.Click += btnThemHoacCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Location = new Point(474, 219);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.Control;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(589, 219);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(83, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(22, 254);
            listView1.Name = "listView1";
            listView1.Size = new Size(749, 208);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã tài khoản";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên khách hàng";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số tiền";
            columnHeader5.Width = 150;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(364, 472);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 13;
            label6.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = SystemColors.Control;
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.Location = new Point(457, 468);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(314, 27);
            txtTongTien.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(txtTongTien);
            Controls.Add(label6);
            Controls.Add(listView1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThemHoacCapNhat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSoTienTrongTaiKhoan);
            Controls.Add(label3);
            Controls.Add(txtDCKH);
            Controls.Add(label2);
            Controls.Add(txtTKH);
            Controls.Add(label1);
            Controls.Add(txtSTK);
            Name = "Form1";
            Text = "Quản Lý Tài Khoản";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSTK;
        private Label label1;
        private TextBox txtTKH;
        private Label label2;
        private TextBox txtDCKH;
        private Label label3;
        private TextBox txtSoTienTrongTaiKhoan;
        private Label label4;
        private Label label5;
        private Button btnThemHoacCapNhat;
        private Button btnXoa;
        private Button btnThoat;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label6;
        private TextBox txtTongTien;
    }
}
