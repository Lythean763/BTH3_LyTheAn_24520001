using System.Windows.Forms;

namespace ChangeColorUseMenuAndDiaLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)

                {
                    this.BackColor = colorDialog.Color;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
