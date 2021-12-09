using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesClusterization
{
    public partial class DendrogramForm : Form
    {
        //drawing tools
        private Bitmap bmp;
        private Graphics gr;
        private Pen blackPen;
        private Pen greenPen;
        private Pen dashPen;
        private Font font;
        private Brush blackBrush;
        private Brush whiteBrush;

        public DendrogramForm(List<StageOfClustering> stages)
        {
            InitializeComponent();
            pictureBox.Size = new Size(stages[stages.Count - 1].CombinedCluster.Items.Count * 22 + 50, 600);
            bmp = new Bitmap(stages[stages.Count - 1].CombinedCluster.Items.Count * 22 + 50, 575);
            pictureBox.Image = bmp;
            if (pictureBox.Image.Width > this.Width)
                this.Width = panel1.Width + 50;
            else
                this.Width = pictureBox.Image.Width + 40;
            gr = Graphics.FromImage(bmp);
            blackPen = new Pen(new SolidBrush(Color.Black), 2);
            greenPen = new Pen(new SolidBrush(Color.LimeGreen), 3);
            dashPen = new Pen(new SolidBrush(Color.Black), 1);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            font = new Font(FontFamily.GenericSansSerif, 9);
            blackBrush = new SolidBrush(Color.Black);
            whiteBrush = new SolidBrush(Color.White);
            drawDendrogram(stages);
            drawAxis(stages[stages.Count-1].Distance);
        }

        private void drawAxis(float maxDistance)
        {
            gr.DrawLine(blackPen, 50, 10, 50, 550);
            gr.DrawLine(blackPen, 50, 550, 4990, 550);
            float I = (maxDistance - (maxDistance % 20))/20;
            for(float i=0; i<=maxDistance; i += I)
            {
                gr.DrawLine(dashPen, 50, 550 - (i * 540 / maxDistance), 4990, 550 - (i * 540 / maxDistance));
                gr.DrawString(i.ToString(), font, blackBrush, 20, 550 - (i * 550 / maxDistance));
            }
            gr.DrawLine(dashPen, 50, 10, 4990, 10);
            pictureBox.Image = bmp;
        }

        public void drawDendrogram(List<StageOfClustering> stages)
        {
            if(stages[stages.Count-1].Distance<10)
                stages.ForEach(s => s.Distance *= 100);
            if (stages[0].Distance > 0)
                stages.ForEach(s => s.Distance += stages[0].Distance+1);
            int dendrogramWidth = stages[stages.Count - 1].CombinedCluster.Items.Count * 22;
            int widthForCountry = dendrogramWidth / stages[stages.Count - 1].CombinedCluster.Items.Count;
            int maxY = 540;
            float maxDistance = stages[stages.Count - 1].Distance;
            float x, y, width;
            List<Country> countries = stages[stages.Count - 1].CombinedCluster.Items;
            for(int i=0; i<countries.Count; i++)
            {
                gr.DrawString(countries[i].ShortName, font, blackBrush, 50 + i * widthForCountry, 555);
            }
            for(int i=stages.Count-1; i>=0; i--)
            {
                x = findClusterCenter(stages[i].PairOfClusters[0], countries)*widthForCountry;
                width = findClusterCenter(stages[i].PairOfClusters[1], countries)*widthForCountry - x;
                y = stages[i].Distance * maxY / maxDistance;
                gr.DrawRectangle(greenPen, x + 60, 550 - y, width, y);
                gr.FillRectangle(whiteBrush, x + 61, 551 - y, width-2, y);
            }
            pictureBox.Image = bmp;
        }
        private int findClusterCenter(Cluster cl, List<Country> countries)
        {
            int i1=0, i2=0;
            for(int i=0; i<countries.Count; i++)
            {
                if (countries[i].ShortName == cl.Items[0].ShortName)
                    i1 = i;
                if (countries[i].ShortName == cl.Items[cl.Items.Count-1].ShortName)
                    i2 = i;
            }
            return (i1 + i2) / 2;
        }
    }
}
