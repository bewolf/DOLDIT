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
        delegate void SetTextCallback(string text);
        private int score;
        private int X1;
        private int X2;
        Thread t;
        public DolditMan()
        {
            InitializeComponent();
            ScoreBoard.Visible = false;
            ScoreBoard.Enabled = false;
            score = 0;
            X1 = 0;
            X2 = 1090;
            
            
        }
        public void StartGame()
        {
            t = new Thread(new ThreadStart(BackgroundMove));
            t.Start();
        }
        private void ScoreTableSettings()
        {
            foreach (var item in ReadScore())
            {
                ScoreBoard.Rows.Add(item);
            }
        }
         private static List<string[]> ReadScore()
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
            BubbleSort(scoreResault);
            return scoreResault;
        }
         private static void BubbleSort(List<string[]> list)
         {
             string[] stringSwaping = new string[2];
             bool bubbleSortComplete = true;
             do
             {
                 bubbleSortComplete = true;
                 for (int i = 0; i < list.Count - 1; i++)
                 {
                     if (int.Parse(list[i][1]) < int.Parse(list[i + 1][1]))
                     {
                         stringSwaping = list[i];
                         list[i] = list[i + 1];
                         list[i + 1] = stringSwaping;
                         bubbleSortComplete = false;
                     }
                 }
             } while (!bubbleSortComplete);

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
                score += 2;
                this.SetText(score.ToString());
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            StartGame();
            playButton.Enabled = false;
            ScoreBoard.Visible = false;

                
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
                scoreNumbers.Text = score.ToString();
            }
            using (var image = new Bitmap("Full.png"))
            {
                canvas.DrawImage(image, X2, 28, 1090, 552);
                
            }
            
        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.scoreNumbers.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.scoreNumbers.Text = text;
            }
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            t.Abort();
            if (!t.IsAlive)
            {
                ScoreBoard.Visible = true;
                ScoreBoard.Enabled = true;
                ScoreBoard.Rows.Clear();
                ScoreBoard.Refresh();
                ScoreTableSettings();
                playButton.Enabled = true;
            }

        }
    }
}
