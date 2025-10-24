namespace PaintEvent
{
    public partial class Form1 : Form
    {
        int x, y;
        private Random rd= new Random();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Minh hoa su kien tren Paint";
            this.Size = new Size(1000, 650);
            this.Paint += Form1_Paint;
            btnRef.Click += (s, e) => Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            x=rd.Next(0,ClientSize.Width-50);
            y=rd.Next(0,ClientSize.Height-50);
            
            e.Graphics.DrawString("Paint Event", this.Font, Brushes.Blue, x, y);
        }
    }
}
