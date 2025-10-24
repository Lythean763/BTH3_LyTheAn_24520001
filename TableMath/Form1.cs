using System.Diagnostics.Eventing.Reader;

namespace TableMath
{
    public partial class Form1 : Form
    {
       public double n, m;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(txtNumber1.Text, out n) && double.TryParse(txtNumber2.Text, out m))
            {
                double tong = n + m;
                textDapan.Text = tong.ToString();
            }
            else
            {
                MessageBox.Show("Loi du lieu");
            }
        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDapan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out n) && double.TryParse(txtNumber2.Text, out m))
            {
                double hieu = n - m;
                textDapan.Text = hieu.ToString();
            }
            else
            {
                MessageBox.Show("Loi du lieu");
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out n) && double.TryParse(txtNumber2.Text, out m))
            {
                double nhan = n * m;
                textDapan.Text = nhan.ToString();
            }
            else
            {
                MessageBox.Show("loi du lieu");
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out n) && double.TryParse(txtNumber2.Text, out m))
            {
                double chia = n / m;
                textDapan.Text = chia.ToString();
            }
            else
            {
                MessageBox.Show("loi du lieu");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
