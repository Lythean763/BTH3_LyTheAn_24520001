namespace LifeCycleEventForm
{
    public partial class VongDoi : Form
    {
        
        public VongDoi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("→ Sự kiện: Form_Load (Khi form bắt đầu tải)");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Add("→ Sự kiện: Form_Shown (Khi form hiển thị lần đầu)");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Add("→ Sự kiện: Form_Activated (Khi form được kích hoạt)");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            listBox1.Items.Add("→ Sự kiện: Form_Deactivate (Khi form mất tiêu điểm)");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBox1.Items.Add("→ Sự kiện: Form_FormClosing (Khi form sắp đóng)");
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Add("→ Sự kiện: Form_FormClosed (Form đã đóng)");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
