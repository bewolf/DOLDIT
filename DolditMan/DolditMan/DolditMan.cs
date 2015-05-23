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
        private bool GAMEOVER;
        private int score;
        private int firstBackgroundX;
        private int secondBackgroundX;
        private string username;
        private int level;
        private int levelTimer;
        private int levelUp;
        string backgraundImagePath = "BackgraundOne.png";
        string groundImagePath = "ground.png";
        string characterName = "Characters/cartman.png";
        private bool JumpUP;
        private bool JumpDown;
        private int JumpHigh;
        private bool MovingLeft;
        private bool MovingRight;
        private Random randomSize = new Random();
        Character character = new Character();
        Thread t;
        Thread t2;
        List<Ground> grounds = new List<Ground>();
        public DolditMan()
        {
            
            JumpHigh = 0;
            MovingLeft = MovingRight = JumpUP = JumpDown = false;
            this.KeyPreview = true;
            level = 10;
            InitializeComponent();
            ScoreBoard.Visible = false;
            ScoreBoard.Enabled = false;
            score = 0;
            firstBackgroundX = 0;
            secondBackgroundX = 1090;
            character.X = 30;
            character.Y = 465;
            GAMEOVER = true;
        }
        public void CharacterCreation()
        {
            characterName = character.ChosenCharacter(characterSelection.SelectedItem.ToString());
            characterSelection.Enabled = false;
            character.X = 30;
            character.Y = 465;
        }
        public void StartGame()
        {
            levelTimer = 0;
            levelUp = 1500;
            t = new Thread(new ThreadStart(Gameplay));
            t.Start();
            t2 = new Thread(new ThreadStart(Movements));
            t2.Start();
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
        private void Gameplay() //Metoda s koito dvijim bakcgrounda
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
                Invalidate();
                if(character.X>0)
                {
                    character.X -= 1;
                }
                Thread.Sleep(level*2);
                if (GAMEOVER)
                {
                    score++;
                    levelTimer++;
                }
                if((grounds[grounds.Count-1].X+(grounds[grounds.Count-1].Size*100))<1090)
                {
                    Ground ground = new Ground();
                    ground.X = 1200;
                    ground.Size = randomSize.Next(1,level+2);
                    ground.Speed = level;
                    ground.Start();
                    grounds.Add(ground);
                }
                if(levelTimer>=levelUp && level > 2)
                {
                    levelUp += 2000;
                    level--;
                    levelTimer = 0;
                    foreach (var item in grounds)
                    {
                        item.Speed = level;
                    }
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text; 
            if (username == null || username == "")
            {
                MessageBox.Show("Enter your name.", "NAME NOT FOUND");
            }else if(characterSelection.SelectedItem==null)
            {
                MessageBox.Show("Choose your character!");
            }
              
            else
            {

                CharacterCreation();
                grounds.Clear();
                Ground ground = new Ground();
                ground.X = 2;
                ground.Size = 20;
                ground.Speed = level;
                ground.Start();
                grounds.Add(ground);
                StartGame();
                playButton.Enabled = false;
                ScoreBoard.Visible = false;
                scoreButton.Enabled = false;
                usernameTextBox.Enabled = false;
                yourScoreLabel.Visible = false;
                scoreLabel.Visible = false;
                gameOverLabel.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Не пишете нищо
        }

        private void DolditMan_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics canvas = e.Graphics;
            var backgraundImage = new Bitmap(backgraundImagePath);
            var groundImage = new Bitmap(groundImagePath);
            var characterImage = new Bitmap(characterName);
            using (backgraundImage)
            {
                canvas.DrawImage(backgraundImage, firstBackgroundX, 28, 1090, 560);
                canvas.DrawImage(backgraundImage, secondBackgroundX, 28, 1090, 560);
            }
            using (characterImage)
            {
                canvas.DrawImage(characterImage, character.X , character.Y, 65, 65);
            }
            using (groundImage)
            {
                for (int i = 0; i < grounds.Count; i++)
                {
                    if (grounds[i].X + grounds[i].Size * 100 > 0)
                    {
                        Rectangle destRect = new Rectangle(grounds[i].X, 530, grounds[i].Size * 100, 100);
                        Rectangle srcRect = new Rectangle(0, 0, grounds[i].Size * 15, 65);
                        GraphicsUnit units = GraphicsUnit.Pixel;
                        canvas.DrawImage(groundImage, destRect, srcRect, units);
                    }
                }
            }
            if(!GAMEOVER)
            {
                gameOverLabel.Visible = true;
                scoreLabel.Visible = true;
                yourScoreLabel.Visible = true;
                yourScoreLabel.Text = score.ToString();
                playButton.Enabled = true;
                scoreButton.Enabled = true;
                usernameTextBox.Enabled = true;
                characterSelection.Enabled = true;
            }
        }
        

        private void scoreButton_Click(object sender, EventArgs e)
        {
                ScoreBoard.Visible = true;
                ScoreBoard.Enabled = true;
                ScoreBoard.Rows.Clear();
                ScoreBoard.Refresh();
                ScoreTableSettings();
                playButton.Enabled = true;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DolditMan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && JumpUP == false && JumpDown == false)
            {
                JumpUP = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                MovingRight = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                MovingLeft = true;
            }

          
    
            Invalidate();
        }
        private void Movements()
        {
            while (true)
            {
                GAMEOVER = false;
                for (int i = 0; i < grounds.Count; i++)
                {
                   GAMEOVER= GAMEOVER || !(!((character.X >= grounds[i].X || character.X+65 > grounds[i].X)
                       && character.X < grounds[i].X + grounds[i].Size * 100) && character.Y == 465);
                }
                if(!GAMEOVER)
                {
                    while(character.Y<550)
                    {
                        character.Y++;
                        Thread.Sleep(10);
                    }
                    t.Abort();
                    t2.Abort();
           
                    foreach(var ground in grounds)
                    {
                        ground.Stop();
                    }
                 
                }

                if (MovingLeft && character.X >= 0)
                {
                    character.X -= 1;
                }
                if(MovingRight && character.X <=1090)
                {
                    character.X += 3;
                }
                if (JumpUP)
                {
                    character.Y -= 2;
                    JumpHigh++;
                    if (JumpHigh >= 25)
                    {
                        JumpUP = false;
                        JumpDown = true;
                    }

                }
                else if (JumpDown)
                {
                    character.Y += 2;
                    JumpHigh--;
                    if (JumpHigh == 0)
                    {
                        JumpDown = false;
                    }
                }
                Thread.Sleep(15);
            }
        }

        private void DolditMan_KeyUp(object sender, KeyEventArgs e)
        {
            if(Keys.Left == e.KeyCode)
            {
                MovingLeft = false;
            }
            if(Keys.Right == e.KeyCode)
            {
                MovingRight = false;
            }
        }

        private void characterSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
