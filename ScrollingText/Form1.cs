namespace ScrollingText
{
    public partial class Form1 : Form
    {
        private Point OriginalPoint;
        private int remint;
        private int vX;
        private int vY;
        private int ScrollAmount = 15;

        public Form1()
        {
            InitializeComponent();
            InitLabelLogic();
        }

        private void InitLabelLogic()
        {
            remint = label1.Size.Width + this.Size.Width;
            label1.Location = new Point((this.Size.Width), label1.Location.Y);
            CenterLabel();
            vX = label1.Location.X;
            vY = label1.Location.Y;
            OriginalPoint = label1.Location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remint > 0)
            {
                label1.Location = new Point((label1.Location.X - ScrollAmount), vY);
                remint -= ScrollAmount;
            }
            else
            {
                remint = label1.Size.Width + this.Size.Width;
                label1.Location = new Point((this.Size.Width), vY);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void CenterLabel()
        {
            label1.Location = new Point(label1.Location.X, this.Size.Height / 2 - (label1.Size.Height / 2));
            vY = label1.Location.Y;
        }
    }
}
