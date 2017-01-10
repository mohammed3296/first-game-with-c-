using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame_v1
{
    public partial class gameGround : Form
    {
        //EventArgs

        private static Keys fireKey;
        private static Keys moveUpKey;
        private static Keys moveDownKey;
        private static Keys moveRightKey;
        private static Keys moveLeftKey;
        private static bool issecondlevel = false;


        bool istogether = true;
        private static int counter = 0;
        bool moveRight = false;
        bool moveLeft = false;
        bool moveUp = false;
        bool moveDown = false;
        bool fire = false;
        public gameGround()
        {
            InitializeComponent();
            SCORE.Text = "00";
            fireKey = Keys.Space;
            moveUpKey = Keys.Up;
            moveDownKey = Keys.Down;
            moveRightKey = Keys.Right;
            moveLeftKey = Keys.Left;
            levelnumber.Text = "1";

        }
        private void gameGround_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == moveRightKey && setting_group.Visible == false)
            {
                moveRight = true;
            }
            else if (e.KeyCode == moveLeftKey && setting_group.Visible == false)
            {
                moveLeft = true;
            }
            else if (e.KeyCode == moveUpKey && setting_group.Visible == false)
            {
                moveUp = true;
            }
            else if (e.KeyCode == moveDownKey && setting_group.Visible == false)
            {
                moveDown = true;
            }

            if (fire == false)
            {

                if (e.KeyCode == fireKey && setting_group.Visible == false)
                {
                    fire = true;
                }
            }


            if (e.KeyCode == Keys.Escape )
            {
                label1_Click(sender, e);
            }

            if (e.KeyCode == Keys.Enter && setting_group.Visible == false)
            {
                label7_Click(sender, e);
            }

            if (e.KeyCode == Keys.P && setting_group.Visible == false)
            {
                label2_Click(sender, e);
            }

            if (e.KeyCode == Keys.R && setting_group.Visible == false)
            {
                label3_Click(sender, e);
            }

            if (e.KeyCode == Keys.N && setting_group.Visible == false)
            {
                label5_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1 && setting_group.Visible == false)
            {
                label4_Click(sender, e);
            }
        }
        private void gameGround_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == moveRightKey)
            {
                moveRight = false;
            }
            else if (e.KeyCode == moveLeftKey)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == moveUpKey)
            {
                moveUp = false;
            }
            else if (e.KeyCode == moveDownKey)
            {
                moveDown = false;
            }

            if (fire == false)
            {

                if (e.KeyCode == fireKey)
                {
                    fire = true;
                }
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (moveRight == true && rocket.Left < (this.Size.Width - 85))
            {
                rocket.Left += 10;
                if (istogether == true)
                {
                    shot.Left += 10;
                }

            }
            else if (moveLeft == true && rocket.Left > 5)
            {
                rocket.Left -= 10;
                if (istogether == true)
                {
                    shot.Left -= 10;
                }
            }
            else if (moveUp == true && rocket.Top > 30)
            {
                rocket.Top -= 10;
                if (istogether == true)
                {
                    shot.Top -= 10;

                }
            }
            else if (moveDown == true && rocket.Top < (this.Size.Height - 90))
            {
                rocket.Top += 10;
                if (istogether == true)
                {
                    shot.Top += 10;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            timerlifetime.Enabled = false;
            timerFire.Enabled = false;
            timer1.Enabled = false;
            if (issecondlevel == true)
            {
                timerrocklevel2.Enabled = false;

            }
            if (issecondlevel == false)
            {
                timerRock.Enabled = false;

            }
            DialogResult result = MessageBox.Show("Are you sure ?", "close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               // MessageBox.Show("Your Score is " + SCORE.Text, "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else if (result == DialogResult.No)
            {
                timerlifetime.Enabled = true;
                timerFire.Enabled = true;
                timer1.Enabled = true;

                if (issecondlevel == true)
                {
                    timerrocklevel2.Enabled = true;

                }
                if (issecondlevel == false)
                {
                    timerRock.Enabled = true;

                }
            }
            else if (result == DialogResult.Cancel)
            {
                timerlifetime.Enabled = true;
                timerFire.Enabled = true;
                timer1.Enabled = true;

                if (issecondlevel == true)
                {
                    timerrocklevel2.Enabled = true;

                }
                if (issecondlevel == false)
                {
                    timerRock.Enabled = true;

                }
            }
        }


        private void timerRock_Tick(object sender, EventArgs e)
        {
            rock.Top += 1;
            rock2.Top += 1;
            rock3.Top += 1;
            rock4.Top += 1;
            rock5.Top += 1;
            rock6.Top += 1;
            rock7.Top += 1;
            rock8.Top += 1;
            rock9.Top += 1;
            rock10.Top += 1;
            rock11.Top += 1;
            rock12.Top += 1;
            rock13.Top += 1;
            if (rock2.Top == this.Size.Height)
            {
                rock2.Top = -50;
            }
            if (rock3.Top == this.Size.Height)
            {
                rock3.Top = -50;
            } if (rock4.Top == this.Size.Height)
            {
                rock4.Top = -100;
            } if (rock5.Top == this.Size.Height)
            {
                rock5.Top = -50;
            } if (rock6.Top == this.Size.Height)
            {
                rock6.Top = -100;
            } if (rock7.Top == this.Size.Height)
            {
                rock7.Top = -100;
            } if (rock8.Top == this.Size.Height)
            {
                rock8.Top = -100;
            } if (rock9.Top == this.Size.Height)
            {
                rock9.Top = -100;
            } if (rock10.Top == this.Size.Height)
            {
                rock10.Top = -100;
            } if (rock11.Top == this.Size.Height)
            {
                rock12.Top = -100;
            } if (rock13.Top == this.Size.Height)
            {
                rock13.Top = -100;
            } if (rock.Top == this.Size.Height)
            {
                rock.Top = -50;
            }
            if (rock.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock.Bounds))
            {
                rock.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock2.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock2.Bounds))
            {
                rock2.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock3.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock3.Bounds))
            {
                rock3.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock4.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock4.Bounds))
            {
                rock4.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock5.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock5.Bounds))
            {
                rock5.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock6.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock6.Bounds))
            {
                rock6.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();

            }
            if (rock7.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock7.Bounds))
            {
                rock7.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock8.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock8.Bounds))
            {
                rock8.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //iscrsed = false;
            }
            if (rock9.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock9.Bounds))
            {
                rock9.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //iscrsed = false;
            }
            if (rock10.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock10.Bounds))
            {
                rock10.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }

            if (rock11.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock11.Bounds))
            {
                rock11.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock12.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock12.Bounds))
            {
                rock12.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock13.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock13.Bounds))
            {
                rock13.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
        }

        private void timerFire_Tick(object sender, EventArgs e)
        {
            //if (shot.Top == 0)
            //{
            //    shot.Top = -50;
            //}
            if (fire == true)
            {
               shot.Location = new Point(shot.Location.X, shot.Location.Y - 50);
               istogether = false;
              //  shot.Top -= 10;
            }

            if (shot.Location.Y < 0)
            {
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                fire = false;
                istogether = true;

            }
        }

        private void timerfire2_Tick(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {
            new_label5.Visible = false;
            start_label.Visible = false;
            quit_label1.Visible = false;
            setting_label4.Visible = false;
            resume_label3.Visible = false;
           puse_label2.Visible = false;

            timerlifetime.Enabled = false;
            timerFire.Enabled = false;
            timer1.Enabled = false;
           
            if (issecondlevel == true)
            {
                timerrocklevel2.Enabled = false;

            }
            if (issecondlevel == false)
            {
                timerRock.Enabled = false;

            }
            setting_group.Visible = true;
            rocket.Visible = false;
            rock2.Visible = false; rock4.Visible = false; rock6.Visible = false;
            rock8.Visible = false; rock10.Visible = false; rock12.Visible = false;
            rock3.Visible = false; rock5.Visible = false; rock7.Visible = false;
            rock9.Visible = false; rock11.Visible = false; rock13.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (w.Checked)
            {
                moveUpKey = Keys.W;
            }
            else if (up.Checked)
            {
                moveUpKey = Keys.Up;
            }
            else if (_8.Checked)
            {
                moveUpKey = Keys.NumPad8;
            }

            if (A.Checked)
            {
                moveLeftKey = Keys.A;
            }
            else if (left.Checked)
            {
                moveLeftKey = Keys.Left;
            }
            else if (_4.Checked)
            {
                moveLeftKey = Keys.NumPad4;
            }

            if (down.Checked)
            {
                moveDownKey = Keys.Down;
            }
            else if (s.Checked)
            {
                moveDownKey = Keys.S;
            }
            else if (_2.Checked)
            {
                moveDownKey = Keys.NumPad2;
            }

            if (spacekey.Checked)
            {
                fireKey = Keys.Space;
            }
            else if (zerokey.Checked)
            {
                fireKey = Keys.NumPad0;
            }
            else if (f.Checked)
            {
                fireKey = Keys.F;
            }

            if (right.Checked)
            {
                moveRightKey = Keys.Right;
            }
            else if (d.Checked)
            {
                moveRightKey = Keys.D;
            }
            else if (_6.Checked)
            {
                moveRightKey = Keys.NumPad6;
            }

            if (black.Checked)
            {
                BackColor = Color.Black;
            }
            if (blue.Checked)
            {
                BackColor = Color.Blue;

                rocket.BackColor = Color.Blue;
                shot.BackColor = Color.Blue;
                rock.BackColor = Color.Blue;
            }
            if (gray.Checked)
            {
                BackColor = Color.Gray;
                rocket.BackColor = Color.Gray;
                shot.BackColor = Color.Gray;
                rock.BackColor = Color.Gray;
            }

            setting_group.Visible = false;

            timerlifetime.Enabled = true;
            timerFire.Enabled = true;
            timer1.Enabled = true;

            if (issecondlevel == true)
            {
                timerrocklevel2.Enabled = true;

            }
            if (issecondlevel == false)
            {
                timerRock.Enabled = true;

            }

            rocket.Visible = true;
            rock2.Visible = true; rock4.Visible = true; rock6.Visible = true;
            rock8.Visible = true; rock10.Visible = true; rock12.Visible = true;
            rock3.Visible = true; rock5.Visible = true; rock7.Visible = true;
            rock9.Visible = true; rock11.Visible = true; rock13.Visible = true;

            new_label5.Visible = true;
            start_label.Visible = true;
            quit_label1.Visible = true;
            setting_label4.Visible = true;
            resume_label3.Visible = true;
            puse_label2.Visible = true;
        }

        private void timerlifetime_Tick(object sender, EventArgs e)
        {
            try
            {
                if (lifeTime.Value >= 25)
                {
                    if (rocket.Bounds.IntersectsWith(rock.Bounds))
                    {
                        rock.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock2.Bounds))
                    {
                        rock2.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock3.Bounds))
                    {
                        rock3.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock4.Bounds))
                    {
                        rock4.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock5.Bounds))
                    {
                        rock5.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock6.Bounds))
                    {
                        rock6.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock7.Bounds))
                    {
                        rock7.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock8.Bounds))
                    {
                        rock8.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock9.Bounds))
                    {
                        rock9.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock10.Bounds))
                    {
                        rock10.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock11.Bounds))
                    {
                        rock11.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock12.Bounds))
                    {
                        rock12.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                    if (rocket.Bounds.IntersectsWith(rock13.Bounds))
                    {
                        rock13.Top = -50;
                        lifeTime.Value -= 25;
                        Console.Beep();
                    }
                }
                else
                {
                    timerRock.Enabled = false;
                    timerlifetime.Enabled = false;
                    DialogResult result = MessageBox.Show("                     Game Over                  \n \n \n                  Your score is "
                           + SCORE.Text + "                  ", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();

                }
            }
            catch (Exception ex) 
            {
                string asdfg = ex.ToString();
                DialogResult result = MessageBox.Show("                     Game Over                  \n \n \n                  Your score is "
                              + SCORE.Text + "                  ", "Killing Over Flow ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timerlifetime.Enabled = false;
            timerFire.Enabled = false;
            timer1.Enabled = false;
            if (issecondlevel == true)
            {
                timerrocklevel2.Enabled = false;

            }
            if (issecondlevel == false)
            {
                timerRock.Enabled = false;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timerlifetime.Enabled = true;
            timerFire.Enabled = true;
            timer1.Enabled = true;

            if (issecondlevel == true)
            {
                timerrocklevel2.Enabled = true;

            }
            if (issecondlevel == false)
            {
                timerRock.Enabled = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

            timerlifetime.Enabled = false;
            timerFire.Enabled = false;
            timer1.Enabled = false;
            if (issecondlevel == true)
            {
                timerrocklevel2.Enabled = false;

            }
            if (issecondlevel == false)
            {
                timerRock.Enabled = false;

            }

            DialogResult result = MessageBox.Show("Do you want to start a new game ?", "New",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lifeTime.Value = 100;
                counter = 0;
                SCORE.Text = "00";
                rock.Top = -100;
                rock2.Top = -50;
                rock3.Top = -150;
                rock4.Top = -20;
                rock5.Top = -200;
                rock6.Top = -300;
                rock7.Top = -500;
                rock8.Top = -8;
                rock9.Top = -25;
                rock10.Top = -100;
                rock11.Top = -6;
                rock12.Top = -100;
                rock13.Top = -10;
                timerlifetime.Enabled = true;
                timerFire.Enabled = true;
                timer1.Enabled = true;
                timerRock.Enabled = true;
                if (issecondlevel == true)
                {
                    timerrocklevel2.Enabled = false;

                }
                timercrossing.Enabled = true;

                rocket.Location = new Point(405, 610);
                shot.Location = new Point(440, 638);
                levelnumber.Text = "1";
            }
            else if (result == DialogResult.No)
            {
                timerlifetime.Enabled = true;
                timerFire.Enabled = true;
                timer1.Enabled = true;

                if (issecondlevel == true)
                {
                    timerrocklevel2.Enabled = true;

                }
                if (issecondlevel == false)
                {
                    timerRock.Enabled = true;

                }
            }
            else if (result == DialogResult.Cancel)
            {
                timerlifetime.Enabled = true;
                timerFire.Enabled = true;
                timer1.Enabled = true;

                if (issecondlevel == true)
                {
                    timerrocklevel2.Enabled = true;

                }
                if (issecondlevel == false)
                {
                    timerRock.Enabled = true;

                }
            }
        }

        private void timerrocklevel2_Tick(object sender, EventArgs e)
        {
            rock.Top += 1;
            rock2.Top += 1;
            rock3.Top += 1;
            rock4.Top += 1;
            rock5.Top += 1;
            rock6.Top += 1;
            rock7.Top += 2;
            rock8.Top += 2;
            rock9.Top += 2;
            rock10.Top += 2;
            rock11.Top += 2;
            rock12.Top += 2;
            rock13.Top += 2;
            // left
            rock.Left += 1;
            rock2.Left += 1;
            rock3.Left += 1;
            rock4.Left += 1;
            rock5.Left += 1;
            rock6.Left += 1;
            rock7.Left -= 1;
            rock8.Left -= 1; 
            rock9.Left -= 1;
            rock10.Left -= 1;
            rock11.Left -= 1;
            rock12.Left -= 1;
            rock13.Left -= 1;
            if (rock2.Top == this.Size.Height || rock2.Left == this.Size.Width)
            {
                rock2.Top = -1000;
                rock2.Left = -1000;
            }
            if (rock3.Top == this.Size.Height || rock2.Left == this.Size.Width)
            {
                rock3.Top = -50;
                rock3.Left = -50;

            } if (rock4.Top == this.Size.Height || rock2.Left == this.Size.Width)
            {
                rock4.Top = -100;
                rock4.Left = -100;
            } if (rock5.Top == this.Size.Height || rock2.Left == this.Size.Width)
            {
                rock5.Top = -35;
                rock5.Left = -35;
            } if (rock6.Top == this.Size.Height || rock2.Left == this.Size.Width)
            {
                rock6.Top = -13;
                rock6.Left = -13;
            }

            if (rock7.Top == this.Size.Height || rock2.Left == 0)
            {
                rock7.Top = -100;
                rock7.Left = 600;
            }

            if (rock8.Top == this.Size.Height || rock8.Left == 0)
            {
                rock8.Top = -100;
                rock8.Left = 500;
            } if (rock9.Top == this.Size.Height || rock9.Left == 0)
            {
                rock9.Top = -900;
                rock9.Left = 900;
            } if (rock10.Top == this.Size.Height || rock10.Left == 0)
            {
                rock10.Top = -900;
                rock10.Left = 900;

            } if (rock11.Top == this.Size.Height || rock12.Left == 0)
            {
                rock12.Top = -700;
                rock12.Left = 700;
            } if (rock13.Top == this.Size.Height || rock13.Top == 0)
            {
                rock13.Top = -1000;
                rock13.Left = 1000;
            } if (rock.Top == this.Size.Height || rock.Top == this.Size.Width)
            {
                rock.Top = -50;
                rock.Left = -50;
            }
            if (rock.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock.Bounds))
            {
                rock.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock2.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock2.Bounds))
            {
                rock2.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock3.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock3.Bounds))
            {
                rock3.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock4.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock4.Bounds))
            {
                rock4.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock5.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock5.Bounds))
            {
                rock5.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
            if (rock6.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock6.Bounds))
            {
                rock6.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();

            }
            if (rock7.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock7.Bounds))
            {
                rock7.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock8.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock8.Bounds))
            {
                rock8.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //iscrsed = false;
            }
            if (rock9.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock9.Bounds))
            {
                rock9.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //iscrsed = false;
            }
            if (rock10.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock10.Bounds))
            {
                rock10.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }


            if (rock11.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock11.Bounds))
            {
                rock11.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock12.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock12.Bounds))
            {
                rock12.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                // iscrsed = false;
            }
            if (rock13.Bounds.IntersectsWith(shot.Bounds) || shot.Bounds.IntersectsWith(rock13.Bounds))
            {
                rock13.Top = -100;
                shot.Location = new Point(rocket.Location.X + 40, rocket.Location.Y + 10);
                counter++;
                SCORE.Text = counter.ToString();
                //  iscrsed = false;
            }
        }

        private void timercrossing_Tick(object sender, EventArgs e)
        {
            if (counter == 10)
            {
                timer1.Enabled = false;
                timercrossing.Enabled = false;
                timerRock.Enabled = false;
                DialogResult result = MessageBox.Show("You Cross The First Level ! \n         Great Job so far !  \n Click Ok to Start The Second level .", "Crossing The First Level !", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Your Score is " + SCORE.Text, "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (result == DialogResult.OK)
                {
                    issecondlevel = true;
                    lifeTime.Value = 100;
                    timerrocklevel2.Enabled = true;
                    timerRock.Enabled = false;
                    levelnumber.Text = "2";
                    timer1.Enabled = true;
                }
                
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timerlifetime.Enabled = true;
            timerFire.Enabled = true;
            timer1.Enabled = true;
            if (issecondlevel == false)
            {
                timerRock.Enabled = true;
            }
        }

        

    }
}
