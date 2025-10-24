namespace Calculator
{
    public partial class Form1 : Form
    {
        double memory = 0;
        double a = 0, b = 0;
        string operation = "";
        bool isTyping = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtHienthimanhinh.Text == "0" || !isTyping)
            {
                txtHienthimanhinh.Text = btn.Text;
            }
            else
            {
                txtHienthimanhinh.Text += btn.Text;
            }
            isTyping = true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienthimanhinh.Text);
            operation = "+";
            isTyping = false;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienthimanhinh.Text);
            operation = "-";
            isTyping = false;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienthimanhinh.Text);
            operation = "*";
            isTyping = false;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienthimanhinh.Text);
            operation = "/";
            isTyping = false;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            b = double.Parse(txtHienthimanhinh.Text);
            switch (operation)
            {
                case "+": txtHienthimanhinh.Text = (a + b).ToString(); break;
                case "-": txtHienthimanhinh.Text = (a - b).ToString(); break;
                case "*": txtHienthimanhinh.Text = (a * b).ToString(); break;
                case "/":
                    if (b != 0)
                        txtHienthimanhinh.Text = (a / b).ToString();
                    else
                        txtHienthimanhinh.Text = "Error";
                    break;
                default:
                    break;
            }
            isTyping = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtHienthimanhinh.Text = "0";
            a = b = 0;
            operation = "";
            isTyping = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtHienthimanhinh.Text = "0";
            isTyping = false;
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtHienthimanhinh.Text.Length > 1)
            {
                txtHienthimanhinh.Text = txtHienthimanhinh.Text.Substring(0, txtHienthimanhinh.Text.Length - 1);
            }
            else
            {
                txtHienthimanhinh.Text = "0";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double values = Convert.ToDouble(txtHienthimanhinh.Text);
            if (values >= 0)
            {
                txtHienthimanhinh.Text = Math.Sqrt(values).ToString();
            }
            else
            {
                Console.Write("error");
            }
            isTyping = false;
        }

        private void btnMauso_Click(object sender, EventArgs e)
        {
            double values = Convert.ToDouble(txtHienthimanhinh.Text);
            if (values != 0)
            {
                txtHienthimanhinh.Text = (1 / values).ToString();
            }
            isTyping = false;
        }

        private void btnPhanTram_Click(object sender, EventArgs e)
        {
            double values = Convert.ToDouble(txtHienthimanhinh.Text);
            txtHienthimanhinh.Text = (values / 100).ToString();
            isTyping = false;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!isTyping)
            {
                txtHienthimanhinh.Text = "0";
                isTyping = true;
            }
            if (!txtHienthimanhinh.Text.Contains("."))
            {
                txtHienthimanhinh.Text += ".";
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtHienthimanhinh.Text = memory.ToString();
            isTyping = false;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(txtHienthimanhinh.Text);
            isTyping = false;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDouble(txtHienthimanhinh.Text);
            isTyping = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCongVaTru_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtHienthimanhinh.Text);
            value = -value;
            txtHienthimanhinh.Text = value.ToString("0.##");
            isTyping = false;
        }
    }
}
