using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;           // for sounds
using System.Threading;      // for pause
using System.IO;             // for random pictures

namespace wumpusprojecy
{
    public partial class Form1 : Form
    {
        //SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"D:\wumpusprojecy\wumpusprojecy\sound\mixkit-fast-small-sweep-transition-166.wav");
       
        int speed = 1, wumpus = 0, safe = 0;
        bool moveUp, moveDown, moveRight, moveLeft;
        private void Agent_Click(object sender, EventArgs e)
        {

        }

        private void s3_Click(object sender, EventArgs e)
        {

        }

        private void p3_Click(object sender, EventArgs e)
        {

        }

        private void b6_Click(object sender, EventArgs e)
        {

        }

        private void b5_Click(object sender, EventArgs e)
        {

        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {

        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {

        }

        private void Start1_Click(object sender, EventArgs e)
        {

        }

        private void g1_Click(object sender, EventArgs e)
        {

        }

        private void s1_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void B4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void w1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void y1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string shuffle;
        List<Image> images;
        List<PictureBox> img = new List<PictureBox>();
      
        public Form1()
        {
            InitializeComponent();
            // For random picture 
            images = new List<Image>();
            DirectoryInfo di = new DirectoryInfo(@"D:\kfueit\sem 4\wumpusprojecy\wumpusprojecy\pic2"); // give a path    
            FileInfo[] finfos = di.GetFiles("*.jpg", SearchOption.AllDirectories);
            foreach (FileInfo fi in finfos)
            images.Add(Image.FromFile(fi.FullName));
            img.Add(B4);
            Thread.Sleep(5000);
            img.Add(S2);
            
            

        }
               // it shuffles the images randomly
        public void shuffleImages()
        {
            
            var rnd = new Random();
            var randomNumbers = Enumerable.Range(0,3).OrderBy(x => rnd.Next()).Take(3).ToList();
            int[] j = new int[3];
            List<int> y = new List<int>();
            foreach (int item in randomNumbers)
            {
                y.Add(item);
            }
            for (int i = 0; i < img.Count; i++)
            {
                j[i] = y[i];
                img[i].Image = images[j[i]];
            }
            
        }
               // boundary for agent
        private void maintimer(object sender, EventArgs e)
        {
            if (moveLeft == true && Agent.Left > 115)
            {
                Agent.Left -= speed;
            }
            if (moveRight == true && Agent.Left < 360)
            {
                Agent.Left += speed;
            }
            if (moveUp == true && Agent.Top > 69)
            {
                Agent.Top -= speed;
            }
            if (moveDown == true && Agent.Top < 275)
            {
                Agent.Top += speed;
            }
            
                  // agent collision loop
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (String)x.Name == "Start1")
                {
                     SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"D:\kfueit\sem 4\wumpusprojecy\wumpusprojecy\sound\mixkit-fast-small-sweep-transition-166.wav");
                    if (Agent.Bounds.IntersectsWith(x.Bounds))
                    {
                        soundPlayer.Play();
                        
                        Thread.Sleep(1500);
                        Agent.Top = 210;
                        Agent.Left = 140;
                        Thread.Sleep(900);
                        shuffle = "pbs1";
                    }

                }
                if (x is PictureBox && (String)x.Name == "b2")
                {
                    if (Agent.Bounds.IntersectsWith(x.Bounds))
                    {

                        //label2.Text = "you feel breeze";

                    }

                }
                if (x is PictureBox && (String)x.Name == "S2")
                {
                    if (Agent.Bounds.IntersectsWith(x.Bounds))
                    {
                        shuffleImages();
                        if (shuffle == "pbs5" && Agent.Top == 193 && Agent.Left == 220)

                        {
                            SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"D:\kfueit\sem 4\wumpusprojecy\wumpusprojecy\sound\mixkit-fast-small-sweep-transition-166.wav");
                            soundPlayer.Play();
                            Thread.Sleep(1500);
                            Agent.Left = 130;
                            shuffle = "pbs6";


                        }


                        S2.BackColor = Color.AliceBlue;
                        Agent.Top = 210;
                        //label2.Text = "You are in a safe zone";

                        if (shuffle == "pbs2" && Agent.Left == 210)
                        {
                            Thread.Sleep(1500);
                            Agent.Top = 98;


                            shuffle = "pbs3";

                        }


                        



                   
                    }

                }
            
                if (x is PictureBox && (String)x.Name == "g1")
                {
                    if (Agent.Bounds.IntersectsWith(x.Bounds))
                    {


                       
                        g1.BackColor = Color.Gold;
                        SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"D:\kfueit\wumpusprojecy\wumpusprojecy\sound\mixkit-unlock-new-item-game-notification-254.wav");
                        soundPlayer.Play();
                       
                                   // move down to s2
                        if (shuffle == "pbs3" && Agent.Top == 98)
                        {
                            soundPlayer.Play();
                            Thread.Sleep(1700);
                            Agent.Top = 193;
                            Agent.Left = 220;
                            shuffle = "pbs5";


                        }


                    }
                }
                

                if (x is PictureBox && (String)x.Name == "B1")
                {
                    if (Agent.Bounds.IntersectsWith(x.Bounds))
                    {

                       


                    }

                }


                if (x is PictureBox && (String)x.Name == "B4")
                {
                    if (Agent.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        shuffleImages();
                        
                        
                        
                        
                        if (shuffle == "pbs6" && Agent.Left == 130)

                            // return to start
                        {

                            SoundPlayer ssp = new SoundPlayer(soundLocation: @"D:\kfueit\sem 4\wumpusprojecy\wumpusprojecy\sound\mixkit-video-game-win-2016.wav");
                            ssp.Play();
                            Agent.Top = 270;
                            Agent.Left = 130;
                            Thread.Sleep(2000);
                            this.Close();
                            
                            
                           

                            shuffle = "pbs7";


                        }
                            // move towards s2
                        if (shuffle == "pbs1" && Agent.Top == 210 && Agent.Left == 140)
                        {

                            Agent.Left = 210;
                            Thread.Sleep(400);

                            shuffle = "pbs2";


                        }
                    }
                }




                {
                    if (x is PictureBox && (String)x.Name == "w1")
                    {
                        
                        {
                            if (wumpus == 0)
                            {
                                w1.BackColor = Color.Red;
                                w1.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/wumpus.jfif");
                                this.w1.SizeMode = PictureBoxSizeMode.StretchImage;
                                label4.Text = "Wumpus";

                            }


                           


                        }





                    }
                    if (x is PictureBox && (String)x.Name == "s1")
                    {
                        if (Agent.Bounds.IntersectsWith(x.Bounds))
                        {
                            
                            s1.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/stench.jfif");
                            this.s1.SizeMode = PictureBoxSizeMode.StretchImage;



                        }
                    }

                    if (x is PictureBox && (String)x.Name == "y1")
                    {
                        if (Agent.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (safe == 0)
                                // moveUp = true;
                                label6.Text = "safe";
                            y1.BackColor = Color.White;

                           



                        }
                    }

                   
                    


                    if (x is PictureBox && (String)x.Name == "b3")
                    {
                        if (Agent.Bounds.IntersectsWith(x.Bounds))
                        {
                            
                            b3.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/breeze.png");
                            this.b3.SizeMode = PictureBoxSizeMode.StretchImage;


                        }
                    }
                    if (x is PictureBox && (String)x.Name == "b5")
                    {
                        if (Agent.Bounds.IntersectsWith(x.Bounds))
                        {

                            

                            b5.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/breeze.png");
                            this.b5.SizeMode = PictureBoxSizeMode.StretchImage;

                        }
                    }

                    if (x is PictureBox && (String)x.Name == "b6")
                    {
                        if (Agent.Bounds.IntersectsWith(x.Bounds))
                        {
                            
                            b6.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/breeze.png");
                            this.b6.SizeMode = PictureBoxSizeMode.StretchImage;


                        }
                    }

                    if (x is PictureBox && (String)x.Name == "s3")
                    {
                        if (Agent.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (safe == 0)
                                s3.BackColor = Color.White;

                            




                        }
                    }

                    if (x is PictureBox && (String)x.Name == "p1")
                    {
                        
                        {
                            
                            p1.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/pit.jpg");
                            this.p1.SizeMode = PictureBoxSizeMode.StretchImage;




                        }
                    }

                    if (x is PictureBox && (String)x.Name == "p2")
                    {


                           Thread.Sleep(1500);
                            
                           p2.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/pit.jpg");
                           this.p2.SizeMode = PictureBoxSizeMode.StretchImage;


                        
                        
                    }

                    if (x is PictureBox && (String)x.Name == "p3")
                    {

                                  Thread.Sleep(1500);
                               
                                  p3.Image = new Bitmap("D:/kfueit/sem 4/AI/wumpusprojecy/wumpusprojecy/pics/pit.jpg");
                                  this.p3.SizeMode = PictureBoxSizeMode.StretchImage;



                        
                    }
                }
                

            }
            
        }
                 // it works when key is pressed
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            
        }
                   // it works when key is release
        private void keyisup(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        moveLeft = false;
                    }

                    if (e.KeyCode == Keys.Right)
                    {
                        moveRight = false;
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        moveDown = false;
                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        moveUp = false;
                    }
                }
            }
        }
    


    
