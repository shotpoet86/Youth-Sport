//Programmer: Austin Parker
//Assignment: Chapter 10/ PE 4/ Youth Sports
//Description: Programs allows students to enter name and select sport they want to play


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouthSport
{
    public partial class YouthSport : Form
    {
        public YouthSport()
        {
            InitializeComponent();

            //This message shows at start of program giving direction
            MessageBox.Show(" - Welcome to the Youth Sports selector!\n - Please enter your name in the space provided.\n" +
                " - Next select from the menu to the left what sport you wish to play!");

            //Clears the form of any images 
            footballPictureBox.Hide();
            basketballPictureBox.Hide();
            soccerPictureBox.Hide();
            golfPictureBox.Hide();
            lacrossePictureBox.Hide();
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void footballRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void basketballRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void SoccerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void golfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void lacrosseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            //variables for finished window
            var finishSignUp = "You have completed sign up!";
            var studentName = "Student Name: ";
            var selectedSport = "Selected sport: ";

            //Messages for each selected sport
            if (footballRadioButton.Checked)
            {
                footballPictureBox.Show();
                MessageBox.Show(finishSignUp + "\n" +
                    studentName + nameTextBox.Text + "\n" +
                 selectedSport + "Football\n" +
                 "Bring your helmet and shoulder pads!");

            }
            else if (basketballRadioButton.Checked)
            {
                basketballPictureBox.Show();
                MessageBox.Show(finishSignUp + "\n" +
                    studentName + nameTextBox.Text + "\n" +
                selectedSport + "Basketball\n" +
                "Let's see you ball like Jordan!");

            }
            else if (soccerRadioButton.Checked)
            {
                soccerPictureBox.Show();
                MessageBox.Show(finishSignUp + "\n" +
                    studentName + nameTextBox.Text + "\n" +
                selectedSport + "Soccer\n" +
                "It's called Football in every country but America! Have fun!");
            }
            else if (golfRadioButton.Checked)
            {
                golfPictureBox.Show();
                MessageBox.Show(finishSignUp + "\n" +
                    studentName + nameTextBox.Text + "\n" +
                 selectedSport + "Golf\n" +
                 "Bring your clubs and enjoy the fresh cut grass!");
            }
            else if (lacrosseRadioButton.Checked)
            {
                lacrossePictureBox.Show();
                MessageBox.Show(finishSignUp + "\n" +
                    studentName + nameTextBox.Text + "\n" +
                selectedSport + "Lacrosse\n" +
                "Bring your stick and helmet, this is a full contact sport!");

            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Closes program
            this.Close();
        }

        //Resets the entire form
        private void resetButton_Click(object sender, EventArgs e)
        {

            foreach (Control control in YouthSport.ActiveForm.Controls)

            {
                var type = control.GetType();

                if (type.Name == "RadioButton")

                {

                    RadioButton rb = control as RadioButton;

                    if (rb != null)

                        rb.Checked = false;
                }
                else if (type.Name == "TextBox")

                {
                    TextBox tb = control as TextBox;

                    tb.Text = "";
                }
                else if (type.Name == "PictureBox")
                {
                    PictureBox pb = control as PictureBox;

                    pb.Visible = false;
                }
            }
        }
    }
}
