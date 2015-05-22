﻿using System;
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

        private int score;
        private int firstBackgroundX;
        private int secondBackgroundX;
        private int X3;
        private int Speed;
        Thread t;
        List<Ground> grounds = new List<Ground>();
        public DolditMan()
        {
            InitializeComponent();
            ScoreBoard.Visible = false;
            ScoreBoard.Enabled = false;
            score = 0;
            firstBackgroundX = 0;
            secondBackgroundX = 1090;
            X3 = 1000;
            Speed = 20;
            
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
                
                if (firstBackgroundX == -1090)
                {
                    firstBackgroundX = 1090;
                }
                if (secondBackgroundX == -1090)
                {
                    secondBackgroundX = 1090;
                }
                firstBackgroundX -= 1;
                secondBackgroundX -= 1;
                X3 -= 1;
                Invalidate();
                Thread.Sleep(Speed);
                score += 2;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            grounds.Clear();
            Ground ground = new Ground();
            ground.X = 500;
            ground.Size = 10;
            ground.Start();
            grounds.Add(ground);
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
                canvas.DrawImage(image, firstBackgroundX, 28, 1090, 560);
                canvas.DrawImage(image, secondBackgroundX, 28, 1090, 560);

            }
            using (var image = new Bitmap("ground.png"))
            {



                foreach (var block in grounds)
                {
                    if (block.X + block.Size*100> 0)
                    {
                        Rectangle destRect = new Rectangle(block.X, 530, block.Size * 100, 100);
                        Rectangle srcRect = new Rectangle(0, 0, block.Size*100, 65);
                        GraphicsUnit units = GraphicsUnit.Pixel;
                        canvas.DrawImage(image, destRect, srcRect, units);
                    }
                }
            }
        }
        

        private void scoreButton_Click(object sender, EventArgs e)
        {
            t.Abort();
            foreach(var ground in grounds)
            {
                ground.Stop();
            }
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
