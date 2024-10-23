namespace GRU_Mazz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int reset = new Point(510, 165);
        int y = 165;
        bool pos = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (y > 0)
            {
                y = y - 10;
                pictureBox1.Location = new Point(510, y);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (y < 285)
            {
                y = y + 10;
                pictureBox1.Location = new Point(510, y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(510, 165);
        }
    }
}