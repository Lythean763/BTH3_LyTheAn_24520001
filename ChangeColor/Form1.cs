namespace BHT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Color doimau = Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255));
            this.BackColor = doimau;
        }
    }
}
