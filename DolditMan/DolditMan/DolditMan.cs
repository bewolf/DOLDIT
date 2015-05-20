using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DolditMan
{
    public partial class DolditMan : Form
    {
        private int X1;
        private int X2;
        Thread t;
        public DolditMan()
        {
            InitializeComponent();
            X1 = 0;
            X2 = 1090;
            t = new Thread(new ThreadStart(BackgroundMove));
            foreach (var item in ReadScore())
            {
                dataGridView1.Rows.Add(item);
            }
        }
         public static List<string[]> ReadScore()
        {
            List<string[]> scoreResault = new List<string[]>();
            StreamReader reader = new StreamReader("Score.txt");
            using(reader)
            {
                
                while(true)
                {
                    string line = reader.ReadLine();
                    if(line==null)
                    {
                        break;
                    }
                    string[] splitedLine = line.Split(' ');
                    scoreResault.Add(splitedLine); 
                }
                
            }
            return scoreResault;
        }
        private void BackgroundMove() //Metoda s koito dvijim bakcgrounda
        {
            while (true)
            {
                if (X1 == -1090)
                {
                    X1 = 1090;
                }
                if (X2 == -1090)
                {
                    X2 = 1090;
                }
                X1 -= 1;
                X2 -= 1;
                Invalidate();
                Thread.Sleep(15);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            t.Start();
            playButton.Enabled = false;
            playButton.Visible = false;
                
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Не пишете нищо
        }

        private void DolditMan_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            using (var image = new Bitmap("Full.png"))
            {
                canvas.DrawImage(image, X1, 28, 1090, 552);
            }
            using (var image = new Bitmap("Full.png"))
            {
                canvas.DrawImage(image, X2, 28, 1090, 552);
            }

        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            t.Suspend();
        }
    }
}
