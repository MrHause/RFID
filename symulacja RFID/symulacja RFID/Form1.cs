using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace symulacja_RFID
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private List<Circle> Sensors = new List<Circle>();
        private List<Circle> Range = new List<Circle>();
        private List<Circle> Range_temp = new List<Circle>();
        private List<int> realposx = new List<int>();
        private List<int> realposy = new List<int>();
        private List<int> systemposx = new List<int>();
        private List<int> systemposy = new List<int>();
        private List<double> systemorient = new List<double>();
        private Circle food = new Circle();
        private Circle reference = new Circle();
        private Circle reference2 = new Circle();
        private Circle reference3 = new Circle();
        private Circle front = new Circle();
        public int sensors_number,move_flag=1,flag_space,flag_type,control=0;
        public Form1()
        {
            InitializeComponent();
            lblpos1.Text = "";
            new Settings();
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            sensors_number = Convert.ToInt32(textBox1.Text);
            Settings.sens_range = Convert.ToInt32(textBox2.Text);
            Settings.sens_range_temp = Convert.ToInt32(textBox2.Text);
            Settings.noise = Convert.ToInt32(textnoise.Text);
            Settings.broken = Convert.ToInt32(textbroken.Text);
            if (comboBox.Text == "Random sensor")
                flag_type = 1;
            else if (comboBox.Text == "The closest sensor")
                flag_type = 0;

            if (combo_ster.Text == "Keyboard")
                control = 0;
            else if (combo_ster.Text == "Speeds")
                control = 1;
            textBox1.Enabled = false;
            buttonStart.Enabled = false;
            textBox2.Enabled = false;
            comboBox.Enabled = false;
            textnoise.Enabled = false;
            textbroken.Enabled = false;
            SaveValues.Enabled = false;
            combo_ster.Enabled = false;

            text_vlin.Enabled = false;
            text_vrot.Enabled = false;
            Button_apply.Enabled = false;
            if (control == 0)
            {
                text_vlin.Enabled = false;
                text_vrot.Enabled = false;
                Button_apply.Enabled = false;
            }

            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;

            //new Settings();
            reference.X = 58;
            reference.Y = 110;
            reference.Orient = 0;

            reference2.X = 58;
            reference2.Y = 120;
            reference2.Orient = 0;

            //create new sensor

            Snake.Clear();
            //Circle head = new Circle();
            //head.X = 66;
            //head.Y = 100;
            //Snake.Add(head);
            //Circle head1 = new Circle();
            //head1.X = 50;
            //head1.Y = 100;
            //Snake.Add(head1);
            //Circle head2 = new Circle();
            //head2.X = 66;
            //head2.Y = 120;
            //Snake.Add(head2);
            //Circle head3 = new Circle();
            //head3.X = 50;
            //head3.Y = 120;
            //Snake.Add(head3);
            Circle head = new Circle();
            head.X = 66;
            head.Y = 120;
            Snake.Add(head);
            Circle head1 = new Circle();
            head1.X = 66;
            head1.Y = 100;
            Snake.Add(head1);
            Circle head2 = new Circle();
            head2.X = 50;
            head2.Y = 120;
            Snake.Add(head2);
            Circle head3 = new Circle();
            head3.X = 50;
            head3.Y = 100;
            Snake.Add(head3);

            Circle sens = new Circle();
            sens.X = Snake[0].X - Settings.sens_range;
            sens.Y = Snake[0].Y - Settings.sens_range;
            Range.Add(sens);
            Range_temp.Add(sens);
            Circle sens1 = new Circle();
            sens1.X = Snake[1].X - Settings.sens_range;
            sens1.Y = Snake[1].Y - Settings.sens_range;
            Range.Add(sens1);
            Range_temp.Add(sens1);
            Circle sens2 = new Circle();
            sens2.X = Snake[2].X - Settings.sens_range;
            sens2.Y = Snake[2].Y - Settings.sens_range;
            Range.Add(sens2);
            Range_temp.Add(sens2);
            Circle sens3 = new Circle();
            sens3.X = Snake[3].X - Settings.sens_range;
            sens3.Y = Snake[3].Y - Settings.sens_range;
            Range.Add(sens3);
            Range_temp.Add(sens3);

            //lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            //*********Genereting pasive sensors********//
            int maxXpos = pbCanvas.Size.Width / Settings.Width;
            int maxYpos = pbCanvas.Size.Height / Settings.Height;

            int lentgh = 250 / sensors_number; //250 size of room 250x250, constant value
 
            for(int i=0;i<250;i=i+lentgh)
            {
                for(int j=0;j<250;j=j+lentgh)
                {
                    Circle point = new Circle();
                    point.X = i;
                    point.Y = j;
                    Sensors.Add(point);
                }
            }
            int broken_sens = Sensors.Count;
            broken_sens = (Settings.broken * broken_sens)/100;
            Random random = new Random();
            for (int i=0;i<broken_sens;i++)
            {

                int val = random.Next(1, Sensors.Count);
                Sensors.RemoveAt(val);
            }
            //****************************************//

            /*
            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXpos);
            food.Y = random.Next(0, maxYpos);
            */
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            if(Settings.GameOver)
            {
                if(Inputs.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if(control==0)
                {
                    if (Inputs.KeyPressed(Keys.NumPad6) && Settings.direction != Direction.Left)
                    {
                        if (Settings.direction == Direction.Down)
                        {
                            Snake[1].Y = Snake[0].Y + 16;
                            Snake[1].X = Snake[0].X;
                        }
                        else if (Settings.direction == Direction.Up)
                        {
                            Snake[0].Y = Snake[1].Y - 16;
                            Snake[0].X = Snake[1].X;
                        }
                        else if (Settings.direction == Direction.Rightup)
                        {
                            Snake[0].Y = Snake[1].Y - 16;
                            Snake[0].X = Snake[1].X;
                        }
                        else if (Settings.direction == Direction.Rightdown)
                        {
                            Snake[1].Y = Snake[0].Y + 16;
                            Snake[1].X = Snake[0].X;
                        }
                        else if (Settings.direction == Direction.Leftdown)
                        {
                            Snake[1].Y = Snake[0].Y + 16;
                            Snake[1].X = Snake[0].X;
                        }
                        else if (Settings.direction == Direction.Leftup)
                        {
                            Snake[0].Y = Snake[1].Y - 16;
                            Snake[0].X = Snake[1].X;
                        }
                        Settings.direction = Direction.Right;
                    }
                    else if (Inputs.KeyPressed(Keys.NumPad4) && Settings.direction != Direction.Right)
                    {
                        if (Settings.direction == Direction.Down)
                        {
                            Snake[0].Y = Snake[1].Y + 16;
                            Snake[0].X = Snake[1].X;
                        }
                        else if (Settings.direction == Direction.Up)
                        {
                            Snake[1].Y = Snake[0].Y - 16;
                            Snake[1].X = Snake[0].X;
                        }
                        else if (Settings.direction == Direction.Rightup)
                        {
                            Snake[1].Y = Snake[0].Y - 16;
                            Snake[1].X = Snake[0].X;
                        }
                        else if (Settings.direction == Direction.Rightdown)
                        {
                            Snake[0].Y = Snake[1].Y + 16;
                            Snake[0].X = Snake[1].X;
                        }
                        else if (Settings.direction == Direction.Leftdown)
                        {
                            Snake[0].Y = Snake[1].Y + 16;
                            Snake[0].X = Snake[1].X;
                        }
                        else if (Settings.direction == Direction.Leftup)
                        {
                            Snake[1].Y = Snake[0].Y - 16;
                            Snake[1].X = Snake[0].X;
                        }
                        Settings.direction = Direction.Left;
                    }
                    else if (Inputs.KeyPressed(Keys.NumPad8) && Settings.direction != Direction.Down)
                    {
                        if (Settings.direction == Direction.Left)
                        {
                            Snake[0].X = Snake[1].X - 16;
                            Snake[0].Y = Snake[1].Y;
                        }
                        else if (Settings.direction == Direction.Right)
                        {
                            Snake[1].X = Snake[0].X + 16;
                            Snake[1].Y = Snake[0].Y;
                        }
                        else if (Settings.direction == Direction.Rightup)
                        {
                            Snake[1].X = Snake[0].X + 16;
                            Snake[1].Y = Snake[0].Y;
                        }
                        else if (Settings.direction == Direction.Rightdown)
                        {
                            Snake[1].X = Snake[0].X + 16;
                            Snake[1].Y = Snake[0].Y;
                        }
                        else if (Settings.direction == Direction.Leftdown)
                        {
                            Snake[0].X = Snake[1].X - 16;
                            Snake[0].Y = Snake[1].Y;
                        }
                        else if (Settings.direction == Direction.Leftup)
                        {
                            Snake[0].X = Snake[1].X - 16;
                            Snake[0].Y = Snake[1].Y;
                        }
                        Settings.direction = Direction.Up;
                    }
                    else if (Inputs.KeyPressed(Keys.NumPad2) && Settings.direction != Direction.Up)
                    {
                        if (Settings.direction == Direction.Left)
                        {
                            Snake[1].X = Snake[0].X - 16;
                            Snake[1].Y = Snake[0].Y;
                        }
                        else if (Settings.direction == Direction.Right)
                        {
                            Snake[0].X = Snake[1].X + 16;
                            Snake[0].Y = Snake[1].Y;
                        }
                        else if (Settings.direction == Direction.Rightup)
                        {
                            Snake[0].X = Snake[1].X + 16;
                            Snake[0].Y = Snake[1].Y;
                        }
                        else if (Settings.direction == Direction.Rightdown)
                        {
                            Snake[0].X = Snake[1].X + 16;
                            Snake[0].Y = Snake[1].Y;
                        }
                        else if (Settings.direction == Direction.Leftdown)
                        {
                            Snake[1].X = Snake[0].X - 16;
                            Snake[1].Y = Snake[0].Y;
                        }
                        else if (Settings.direction == Direction.Leftup)
                        {
                            Snake[1].X = Snake[0].X - 16;
                            Snake[1].Y = Snake[0].Y;
                        }
                        Settings.direction = Direction.Down;
                    }
                    else if (Inputs.KeyPressed(Keys.NumPad9) && Settings.direction != Direction.Leftdown)
                    {
                        if (Settings.direction == Direction.Left)
                        {
                            Snake[0].X = Snake[1].X - 11;
                            Snake[0].Y = Snake[1].Y - 11;
                        }
                        else if (Settings.direction == Direction.Right)
                        {
                            Snake[1].X = Snake[0].X + 11;
                            Snake[1].Y = Snake[0].Y + 11;
                        }
                        else if (Settings.direction == Direction.Down)
                        {
                            Snake[1].X = Snake[0].X + 11;
                            Snake[1].Y = Snake[0].Y + 11;
                        }
                        else if (Settings.direction == Direction.Rightdown)
                        {
                            Snake[1].X = Snake[0].X + 11;
                            Snake[1].Y = Snake[0].Y + 11;
                        }
                        else if (Settings.direction == Direction.Up)
                        {
                            Snake[0].X = Snake[1].X - 11;
                            Snake[0].Y = Snake[1].Y - 11;
                        }
                        else if (Settings.direction == Direction.Leftup)
                        {
                            Snake[0].X = Snake[1].X - 11;
                            Snake[0].Y = Snake[1].Y - 11;
                        }
                        Settings.direction = Direction.Rightup;
                    }
                    else if (Inputs.KeyPressed(Keys.NumPad3) && Settings.direction != Direction.Leftup)
                    {
                        if (Settings.direction == Direction.Left)
                        {
                            Snake[1].X = Snake[0].X - 11;
                            Snake[1].Y = Snake[0].Y + 11;
                        }
                        else if (Settings.direction == Direction.Right)
                        {
                            Snake[0].X = Snake[1].X + 11;
                            Snake[0].Y = Snake[1].Y - 11;
                        }
                        else if (Settings.direction == Direction.Down)
                        {
                            Snake[1].X = Snake[0].X - 11;
                            Snake[1].Y = Snake[0].Y + 11;
                        }
                        else if (Settings.direction == Direction.Rightup)
                        {
                            Snake[0].X = Snake[1].X + 11;
                            Snake[0].Y = Snake[1].Y - 11;
                        }
                        else if (Settings.direction == Direction.Up)
                        {
                            Snake[0].X = Snake[1].X + 11;
                            Snake[0].Y = Snake[1].Y - 11;
                        }
                        else if (Settings.direction == Direction.Leftdown)
                        {
                            Snake[1].X = Snake[0].X - 11;
                            Snake[1].Y = Snake[0].Y + 11;
                        }
                        Settings.direction = Direction.Rightdown;
                    }
                    else if (Inputs.KeyPressed(Keys.NumPad7) && Settings.direction != Direction.Rightdown)
                    {
                        if (Settings.direction == Direction.Left)
                        {
                            Snake[0].X = Snake[1].X - 11;
                            Snake[0].Y = Snake[1].Y + 11;
                        }
                        else if (Settings.direction == Direction.Right)
                        {
                            Snake[1].X = Snake[0].X + 11;
                            Snake[1].Y = Snake[0].Y - 11;
                        }
                        else if (Settings.direction == Direction.Down)
                        {
                            Snake[0].X = Snake[1].X - 11;
                            Snake[0].Y = Snake[1].Y + 11;
                        }
                        else if (Settings.direction == Direction.Rightup)
                        {
                            Snake[1].X = Snake[0].X + 11;
                            Snake[1].Y = Snake[0].Y - 11;
                        }
                        else if (Settings.direction == Direction.Up)
                        {
                            Snake[1].X = Snake[0].X + 11;
                            Snake[1].Y = Snake[0].Y - 11;
                        }
                        else if (Settings.direction == Direction.Leftdown)
                        {
                            Snake[0].X = Snake[1].X - 11;
                            Snake[0].Y = Snake[1].Y + 11;
                        }
                        Settings.direction = Direction.Leftup;
                    }
                    else if (Inputs.KeyPressed(Keys.NumPad1) && Settings.direction != Direction.Rightup)
                    {
                        if (Settings.direction == Direction.Left)
                        {
                            Snake[1].X = Snake[0].X - 11;
                            Snake[1].Y = Snake[0].Y - 11;
                        }
                        else if (Settings.direction == Direction.Right)
                        {
                            Snake[0].X = Snake[1].X + 11;
                            Snake[0].Y = Snake[1].Y + 11;
                        }
                        else if (Settings.direction == Direction.Down)
                        {
                            Snake[0].X = Snake[1].X + 11;
                            Snake[0].Y = Snake[1].Y + 11;
                        }
                        else if (Settings.direction == Direction.Leftup)
                        {
                            Snake[1].X = Snake[0].X - 11;
                            Snake[1].Y = Snake[0].Y - 11;
                        }
                        else if (Settings.direction == Direction.Up)
                        {
                            Snake[1].X = Snake[0].X - 11;
                            Snake[1].Y = Snake[0].Y - 11;
                        }
                        else if (Settings.direction == Direction.Rightdown)
                        {
                            Snake[0].X = Snake[1].X + 11;
                            Snake[0].Y = Snake[1].Y + 11;
                        }
                        Settings.direction = Direction.Leftdown;
                    }
                }
                else if(control==1) {
                    if (Inputs.KeyPressed(Keys.Right))
                        Settings.vrot--;
                    else if (Inputs.KeyPressed(Keys.Left))
                        Settings.vrot++;
                    else if (Inputs.KeyPressed(Keys.Up))
                        Settings.vlin++;
                    else if (Inputs.KeyPressed(Keys.Down))
                        Settings.vlin--;
                }

                //*********pause simulation********//
                if (Inputs.KeyPressed(Keys.Space))
                {
                    if (flag_space == 1)
                    {
                        move_flag = 0;
                        flag_space = 0;
                        SaveValues.Enabled = true;
                    }
                    else
                    {
                        move_flag = 1;
                        flag_space = 1;
                        SaveValues.Enabled = false;
                    }
                }
                if(move_flag==1)
                {
                    pbCanvas.Invalidate(); //trigger pbCanvas.Paint
                    MovePlayer();
                }

                
            }

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //za każdym razem jak pbcanvas.invalidate jest wyzwalane
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.GameOver)
            {

                Brush snakeColour;

                canvas.FillRectangle(Brushes.Black,
                new Rectangle(reference.X * 4,
                reference.Y * 4, 4, 4));

                canvas.FillRectangle(Brushes.Black,
                new Rectangle(front.X * 4,
                front.Y * 4, 4, 4));



                for (int i=0;i<Snake.Count;i++)
                {
                   

                    canvas.FillRectangle(Brushes.Blue,
                new Rectangle(Range[i].X * 4,
                Range[i].Y * 4, 2 * Settings.sens_range * 4 + 4, 2 * Settings.sens_range * 4 + 4));

                    
                    snakeColour = Brushes.Black;

                    //draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * 4,
                                      Snake[i].Y * 4,
                                      4, 4));

                    //draw food
                    /*
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
                        */

                }
                
                for (int j = 0; j < Sensors.Count; j++)
                {
                    canvas.FillEllipse(Brushes.Red,
                    new Rectangle(Sensors[j].X * 4,
                                  Sensors[j].Y * 4,
                                  4, 4));
                }
            }
            else
            {
                string gameOver = "Out of a room";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }
        private void MovePlayer()
        {
            string posX="", posY="",out1="", outreal = "";
            double temp_orient;
            lblvlin.Text = Settings.vlin.ToString();
            lblvrot.Text = Settings.vrot.ToString();
            lblsysorient.Text = "";
            List<Circle> Sys_orient = new List<Circle>();
            bool isempty;
            isempty = Snake.Any();
            //calculate object orientation
            if (isempty)
            {
                int xval, yval;
                double radians, angle;
                yval = Snake[1].Y - Snake[0].Y;
                xval = Snake[1].X - Snake[0].X;
                radians = Math.Atan2(-yval, xval);
                angle = radians * (180 / Math.PI)-90;
                if (angle < 0)
                    angle = 360 + angle;

                lblrealang.Text = angle.ToString();
            }
            
            if (control == 1)
            {
                //move reference point
                double rad2 = 270* Math.PI / 180;
                double rad = 90 * Math.PI / 180;
                //reference point, middle of the robot
                reference.Orient = reference.Orient + Settings.vrot;
                temp_orient = reference.Orient * Math.PI / 180; //radians
                reference.X = Convert.ToInt32(reference.X + Settings.vlin * Math.Cos(temp_orient));
                reference.Y = Convert.ToInt32(reference.Y - Settings.vlin * Math.Sin(temp_orient));

                //temp points
                reference2.X = Convert.ToInt32(reference.X + 10 * Math.Cos(temp_orient+rad2));
                reference2.Y = Convert.ToInt32(reference.Y - 10 * Math.Sin(temp_orient+rad2));

                front.X = Convert.ToInt32(reference.X + 8 * Math.Cos(temp_orient));
                front.Y = Convert.ToInt32(reference.Y - 8 * Math.Sin(temp_orient));

                reference3.X = Convert.ToInt32(reference.X + 10 * Math.Cos(temp_orient + rad));
                reference3.Y = Convert.ToInt32(reference.Y - 10 * Math.Sin(temp_orient + rad));

                //move active sensors
                Snake[1].X = Convert.ToInt32(reference3.X + 8 * Math.Cos(temp_orient));
                Snake[1].Y = Convert.ToInt32(reference3.Y - 8 * Math.Sin(temp_orient));

                Snake[3].X = Convert.ToInt32(reference3.X - 8 * Math.Cos(temp_orient));
                Snake[3].Y = Convert.ToInt32(reference3.Y + 8 * Math.Sin(temp_orient));

                Snake[0].X = Convert.ToInt32(reference2.X + 8 * Math.Cos(temp_orient));
                Snake[0].Y = Convert.ToInt32(reference2.Y - 8 * Math.Sin(temp_orient));

                Snake[2].X = Convert.ToInt32(reference2.X - 8 * Math.Cos(temp_orient));
                Snake[2].Y = Convert.ToInt32(reference2.Y + 8 * Math.Sin(temp_orient));

            }
            for (int i=0;i<Snake.Count;i++)
            {
                if(control==0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            //Range[i].X++;
                            //Range_temp[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            //Range[i].X--;
                            //Range_temp[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            //Range[i].Y--;
                            //Range_temp[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            //Range[i].Y++;
                            //Range_temp[i].Y++;
                            break;
                        case Direction.Rightup:
                            Snake[i].Y--;
                            Snake[i].X++;
                            //Range[i].Y++;
                            //Range_temp[i].Y++;
                            break;
                        case Direction.Rightdown:
                            Snake[i].Y++;
                            Snake[i].X++;
                            //Range[i].Y++;
                            //Range_temp[i].Y++;
                            break;
                        case Direction.Leftup:
                            Snake[i].Y--;
                            Snake[i].X--;
                            //Range[i].Y++;
                            //Range_temp[i].Y++;
                            break;
                        case Direction.Leftdown:
                            Snake[i].Y++;
                            Snake[i].X--;
                            //Range[i].Y++;
                            //Range_temp[i].Y++;
                            break;
                    }
                }

                    
                    //*************Szum***************//
                    //Bez szumu Odkomentowac w movie Range.[i].X !!!!
                    //for (int j = 0; j < Snake.Count; j++)
                    //{
                        Random random2 = new Random();
                        int val1 = random2.Next(-Settings.noise, Settings.noise + 1);
                        Range_temp[i].X = Snake[i].X - Settings.sens_range_temp;
                        Range_temp[i].Y = Snake[i].Y - Settings.sens_range_temp;
                        Range[i].X = Range_temp[i].X - val1;
                        Range[i].Y = Range_temp[i].Y - val1;
                        Settings.sens_range = Settings.sens_range_temp + val1;
                    //}
                    //*****************************//

                    //**********Pozycjonowanie**********//
                    int temp = Settings.sens_range;
                    int temp2 = temp;
                    List<Circle> Active = new List<Circle>();
                


                    for (int j=0;j<Sensors.Count;j++)
                    {
                        if(Snake[i].X-temp<=Sensors[j].X && Snake[i].X + temp2 >= Sensors[j].X && Snake[i].Y - temp <= Sensors[j].Y && Snake[i].Y + temp2 >= Sensors[j].Y)
                        {
                            Circle sens = new Circle();
                            sens.X = Sensors[j].X;
                            sens.Y = Sensors[j].Y;
                            Active.Add(sens);
                            lblPosition.Text = "";
                            
                            

                            //to comment
                            //posX = Sensors[j].X.ToString();
                            //posY = Sensors[j].Y.ToString();
                            //out1 = "X: " + posX + "\nY: " + posY;
                            //lblpos1.Text = out1;
                            //
                        }
                    }
                    bool isEmpty = Active.Any(); //if range of active is beetwen passive sens and possition should be unknown. (Add isEmpty to condition below)

                    if (flag_type == 1 && isEmpty) //********RANDOM SENS***********//
                    {
                    Circle point = new Circle();
                    
                        Random random = new Random();
                        int num = Active.Count;
                        int val = random.Next(0, num);
                        posX = Active[val].X.ToString();
                        posY = Active[val].Y.ToString();
                    point.X = Active[val].X;
                    point.Y = Active[val].Y;
                    Sys_orient.Add(point);
                        out1 += "X" + (i+1) +": " + posX + "\nY" +(i+1)+": "+ posY+"\n";
                        lblpos1.Text = out1;
                    }
                    else if(flag_type == 0 && isEmpty)  //**************CLOSEST SENS****************//
                    {
                    Circle point = new Circle();
                    int closeX, closeY;
                        double distance;
                        closeX = Active[0].X;
                        closeY = Active[0].Y;
                        int closeX1 = System.Math.Abs(Snake[i].X - closeX);
                        int closeY1 = System.Math.Abs(Snake[i].Y - closeY);
                        distance = System.Math.Sqrt(closeX1 * closeX1 + closeY1 * closeY1);
                        for (int j = 1; j < Active.Count; j++)
                        {
                            int tempX = System.Math.Abs(Snake[i].X - Active[j].X);
                            int tempY = System.Math.Abs(Snake[i].Y - Active[j].Y);
                            double temp_dist = System.Math.Sqrt(tempX * tempX + tempY * tempY);
                            if (temp_dist < distance)
                            {
                                closeX = Active[j].X;
                                closeY = Active[j].Y;
                                distance = temp_dist;
                            }
                        }
                    point.X = closeX;
                    point.Y = closeY;
                    Sys_orient.Add(point);
                    posX = closeX.ToString();
                        posY = closeY.ToString();
                        out1 += "X" + (i+1) + ": " + posX + "\nY" + (i+1) + ": " + posY+"\n";
                        lblpos1.Text = out1;
                    }
                    string tempposx, tempposy;
                    tempposx = Snake[i].X.ToString();
                    tempposy = Snake[i].Y.ToString();
                    outreal += "X" + (i + 1) + ": " + tempposx + "\nY" + (i + 1) + ": " + tempposy+"\n";
                    lblRealpos1.Text = outreal;
                //******orientation****//
                

                    //******save trajectory***********//
                    
                    if(i==0)
                    {
                    realposx.Add(Snake[i].X);
                    realposy.Add(Snake[i].Y);
                    if (posX == "")
                        posX = "0";
                    if (posY == "")
                        posY = "0";
                    systemposx.Add(Convert.ToInt32(posX));
                    systemposy.Add(Convert.ToInt32(posY));
                    }
                    
                    
                    //*******************************//

                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }
            }
            //orientation
            List<double> median = new List<double>();
        isempty = Sys_orient.Any();
            if(isempty)
            {
                double korekcja= Math.Atan(20 / 16)*180/Math.PI;
                int xval, yval;
                double radians, angle;
                if(Sys_orient.Count > 1)
                {
                    yval = Sys_orient[1].Y - Sys_orient[0].Y;
                    xval = Sys_orient[1].X - Sys_orient[0].X;
                    radians = Math.Atan2(-yval, xval);
                    angle = radians * (180 / Math.PI)-90;
                    if (angle < 0)
                        angle = 360 + angle;

                    median.Add(angle);
                    lblsysorient.Text += angle.ToString()+"\n";
                    if(Sys_orient.Count==4)
                    {
                        yval = Sys_orient[3].Y - Sys_orient[2].Y;
                        xval = Sys_orient[3].X - Sys_orient[2].X;
                        radians = Math.Atan2(-yval, xval);
                        angle = radians * (180 / Math.PI) - 90;
                        if (angle < 0)
                            angle = 360 + angle;
                        median.Add(angle);
                        lblsysorient.Text += angle.ToString() + "\n";


                        yval = Sys_orient[3].Y - Sys_orient[0].Y;
                        xval = Sys_orient[3].X - Sys_orient[0].X;
                        radians = Math.Atan2(-yval, xval);
                        angle = radians * (180 / Math.PI) - 90 - korekcja;
                        if (angle < 0)
                            angle = 360 + angle;
                        median.Add(angle);
                        lblsysorient.Text += angle.ToString() + "\n";

                        median.Sort();
                        lblsysorient.Text += median[1].ToString();

                        //save orientation
                        systemorient.Add(median[1]);
                    }

                }
            }


        }
        
        private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
           // Settings.Score += Settings.Points;
           // lblScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Button_apply_Click(object sender, EventArgs e)
        {
            Settings.vlin = Convert.ToInt32(text_vlin.Text);
            Settings.vrot = Convert.ToInt32(text_vrot.Text);
        }

        private void SaveValues_Click(object sender, EventArgs e)
        {
            FileDialog oDialog = new SaveFileDialog();
            oDialog.DefaultExt = "txt";
            oDialog.FileName = "realposX";
            if(oDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@oDialog.FileName))
                {
                    foreach(int line in realposx)
                    {
                        file.WriteLine(line);
                    }
                    foreach (int line in realposy)
                    {
                        file.WriteLine(line);
                    }
                    foreach (int line in systemposx)
                    {
                        file.WriteLine(line);
                    }
                    foreach (int line in systemposy)
                    {
                        file.WriteLine(line);
                    }
                }
            }
           
            oDialog.DefaultExt = "txt";
            oDialog.FileName = "angle";
            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@oDialog.FileName))
                {
                    foreach (double line in systemorient)
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, false);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, true);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
