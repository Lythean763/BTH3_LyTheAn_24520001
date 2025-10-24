using System;
using System.Windows.Forms;

namespace ManageAccount
{
    public partial class Form1 : Form
    {
        double tong = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtSTK.Text = item.SubItems[1].Text;
                txtTKH.Text = item.SubItems[2].Text;
                txtDCKH.Text = item.SubItems[3].Text;
                txtSoTienTrongTaiKhoan.Text = item.SubItems[4].Text;
            }
        }

        private void btnThemHoacCapNhat_Click(object sender, EventArgs e)
        {
            if (txtSTK.Text == "" || txtTKH.Text == "" || txtDCKH.Text == "" || txtSoTienTrongTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            int count = listView1.Items.Count + 1;
            string[] row = { count.ToString(), txtSTK.Text, txtTKH.Text, txtDCKH.Text, txtSoTienTrongTaiKhoan.Text };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
            double soTien;
            if (double.TryParse(txtSoTienTrongTaiKhoan.Text, out soTien))
            {
                tong += soTien;
                txtTongTien.Text = tong.ToString();
            }
            txtSTK.Clear();
            txtTKH.Clear();
            txtDCKH.Clear();
            txtSoTienTrongTaiKhoan.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soTKCanXoa = txtSTK.Text.Trim();
            if (soTKCanXoa == "")
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!");
                return;
            }

            bool found = false;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == soTKCanXoa)
                {
                    found = true;
                    DialogResult confirm = MessageBox.Show(
                        "Bạn có chắc muốn xóa tài khoản này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        double soTienXoa;
                        if (double.TryParse(item.SubItems[4].Text, out soTienXoa))
                        {
                            tong -= soTienXoa;
                            txtTongTien.Text = tong.ToString("N0");
                        }

                        listView1.Items.Remove(item);
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
