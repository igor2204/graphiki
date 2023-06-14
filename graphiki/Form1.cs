namespace graphiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.radioButton1.CheckedChanged += new System.EventHandler(this.button1_Click);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.button2_Click);
            this.radioButton3.CheckedChanged += new System.EventHandler(this.button3_Click);
            this.radioButton4.CheckedChanged += new System.EventHandler(this.button4_Click);
            this.radioButton5.CheckedChanged += new System.EventHandler(this.button5_Click);
            this.button7.Click += new System.EventHandler(button1_Click) + button2_Click + button3_Click + button4_Click + button5_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[700];
            for (int x = -300, y, i = 0; x < 300; x++, i++)
            {
                y = -(x * x / 100) + 350;
                point[i] = new Point(x + 350, y);
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(350, 0), new Point(350, 700) };
            Point[] pointx = new Point[2] { new Point(0, 350), new Point(700, 350) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[700];

            for (int x, y, i = 0; i < 700; i++)
            {
                float PI = (float)(Math.PI / (700 - 1));
                x = i - 350;
                y = (int)(float)(125 * Math.Sin(i * 10 * PI) + 350);
                point[i] = new Point(x + 350, y);
            }

            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(350, 0), new Point(350, 700) };
            Point[] pointx = new Point[2] { new Point(0, 350), new Point(700, 350) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[700];
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(350, 0), new Point(350, 700) };
            Point[] pointx = new Point[2] { new Point(0, 350), new Point(700, 350) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[700];
            for (int x = -350, y, i = 0; x < 350; x++, i++)
            {
                y = -(x * x * x / 555) + 350;
                point[i] = new Point(x + 350, y);
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(350, 0), new Point(350, 700) };
            Point[] pointx = new Point[2] { new Point(0, 350), new Point(700, 350) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[700];
            for (int x = -350, y, i = 0; x < 351; x++, i++)
            {

                if (x != 0)
                {
                    y = (500 / x) + 350;
                    point[i] = new Point(x + 350, y);
                }
                else
                {
                    i--;
                }
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(350, 0), new Point(350, 700) };
            Point[] pointx = new Point[2] { new Point(0, 350), new Point(700, 350) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}