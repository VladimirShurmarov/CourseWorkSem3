using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkSem3
{
    public partial class Form1 : Form
    {
        public Image chessSprites;
        public int[,] map = new int[8, 8]
        {
            {5,4,3,2,1,3,4,5 },
            {6,6,6,6,6,6,6,6 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {6,6,6,6,6,6,6,6 },
            {5,4,3,2,1,3,4,5 },
        };
        public Form1()
        {
            InitializeComponent();

            chessSprites = new Bitmap("C:\\Users\\AAA\\Desktop\\source\\repos\\CourseWorkSem3\\chessSprites.png");
            Image part = new Bitmap(50,50);
            Graphics graph = Graphics.FromImage(part);
            graph.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0, 0, 150, 150, GraphicsUnit.Pixel);
            //button1.BackgroundImage = part;

            Init();
        }

        public void Init()
        {


            CreateMap();
        }
        public void CreateMap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button butt = new Button();
                    butt.Size = new Size(66, 62);
                    butt.Location = new Point(j * 66, i * 62);
                    this.Controls.Add(butt);
                }
            }
        }
    }
}
