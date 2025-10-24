namespace InfoStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbChuyenNganh.Items.AddRange(new string[]
            {
                "Hệ Thống Thông Tin",
                "Khoa Học Máy Tính",
                "Công Nghệ Phần Mềm"
            });
            cbChuyenNganh.SelectedIndex = 0;

            listBoxMonHoc.Items.AddRange(new string[]
            {
                "Cơ Sở Dữ Liệu",
                "Cơ Sở DL NC",
                "PTTK Hệ Thống thông tin"
            });
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (listBoxMonHoc.SelectedItem != null)
            {
                listBoxMonHocDaChon.Items.Add(listBoxMonHoc.SelectedItem);
                listBoxMonHoc.Items.Remove(listBoxMonHoc.SelectedItem);
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            if (listBoxMonHocDaChon.SelectedItem != null)
            {
                listBoxMonHoc.Items.Add(listBoxMonHocDaChon.SelectedItem);
                listBoxMonHocDaChon.Items.Remove(listBoxMonHocDaChon.SelectedItem);
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string chuyenNganh = cbChuyenNganh.Text;
            string gioiTinh = cNam.Checked ? "Nam" : (cNu.Checked ? "Nữ" : "");
            int soMon = listBoxMonHocDaChon.Items.Count;

            if (mssv == "" || hoten == "" || gioiTinh == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(mssv, hoten, chuyenNganh, gioiTinh, soMon);

            txtMSSV.Clear();
            txtHoTen.Clear();
            cNam.Checked = cNu.Checked = false;
            listBoxMonHocDaChon.Items.Clear();
            listBoxMonHoc.Items.Clear();
            listBoxMonHoc.Items.AddRange(new string[]
            {
                "Cơ Sở Dữ Liệu",
                "Cơ Sở DL NC",
                "PTTK Hệ Thống thông tin"
            });
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            listBoxMonHocDaChon.Items.Clear();
            listBoxMonHoc.Items.Clear();
            listBoxMonHoc.Items.AddRange(new string[]
            {
                "Cơ Sở Dữ Liệu",
                "Cơ Sở DL NC",
                "PTTK Hệ Thống thông tin"
            });
        }
    }
}
