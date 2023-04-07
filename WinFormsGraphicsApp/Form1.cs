using System.Drawing.Drawing2D;

namespace WinFormsGraphicsApp
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle rect;
        Brush brush2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            Pen pen = new Pen(Brushes.Red, 10);

            g.DrawEllipse(pen, 100, 50, 200, 100);
            g.DrawRectangle(new(Brushes.Blue, 5), 50, 50, 300, 150);


            rect = new(350, 200, 200, 100);
            Brush brush1 = new SolidBrush(Color.Green);
            brush2 = new LinearGradientBrush(
                                new Point(350, 200),
                                new Point(550, 300),
                                Color.Yellow,
                                Color.Aqua);

            g.FillRectangle(brush2, rect);

            Image img = new Bitmap(@"D:\img01.png");
            img = new Bitmap(img, new Size(200, 200));

            g.DrawImage(img, new Point(50, 50));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
                
        }
    }
}