using ClassLibraryCN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Complex_number
{

    public partial class Form1 : Form
    {
        ClassCN a = new ClassCN();
        ClassCN b = new ClassCN(0);
        ClassCN c = new ClassCN(0, 0);
        Point newPoint;

        public Form1()
        {
            InitializeComponent();
            
            realField2.Visible = false;
            imegineryField2.Visible = false;
            pictureSN.Visible = false;

            realField1.Text = "0";
            realField2.Text = "0";
            imegineryField1.Text = "0";
            imegineryField2.Text = "0";

            this.buttonStart.Location = new System.Drawing.Point(77, 95);
            this.labelAnswer.Location = new System.Drawing.Point(208, 95);
            this.ClientSize = new System.Drawing.Size(340, 135);

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex < 3)
            {
                realField2.Visible = true;
                imegineryField2.Visible = true;
                pictureSN.Visible = true;
                this.labelAnswer.Location = new System.Drawing.Point(208, 136);
                this.buttonStart.Location = new System.Drawing.Point(77, 136);
                this.ClientSize = new System.Drawing.Size(340, 175);
            }
            else
            {
                realField2.Visible = false;
                imegineryField2.Visible = false;
                pictureSN.Visible = false;
                this.buttonStart.Location = new System.Drawing.Point(77, 95);
                this.labelAnswer.Location = new System.Drawing.Point(208, 95);
                this.ClientSize = new System.Drawing.Size(340, 135);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            newPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - newPoint.X;
                this.Top += e.Y - newPoint.Y;
            }
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseDown_1(object sender, MouseEventArgs e)
        {
            CloseButton.BackColor = Color.FromArgb(42, 48, 60);
        }


        private void buttonStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (comboBox.SelectedIndex < 3)
            {
                b.Re = Convert.ToDouble(realField2.Text);
                b.Im = Convert.ToDouble(imegineryField2.Text);
            }
            a.Re = Convert.ToDouble(realField1.Text);
            a.Im = Convert.ToDouble(imegineryField1.Text);
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    c = a + b;
                    labelAnswer.Text = c.ToString();
                    break;
                case 1:
                    c = a - b;
                    labelAnswer.Text = c.ToString();
                    break;
                case 2:
                    c = a * b;
                    labelAnswer.Text = c.ToString();
                    break;
                case 3:
                    labelAnswer.Text = string.Format("{0:F4}", a.abs());
                    break;
                case 4:
                    labelAnswer.Text = string.Format("{0:F4}", a.argument());
                    break;
            }
        }

        private void realField1_Enter(object sender, EventArgs e)
        {
            if (realField1.Text == "0")
                realField1.Text = "";
        }

        private void realField1_Leave(object sender, EventArgs e)
        {
            if (realField1.Text == "")
                realField1.Text = "0";
        }

        private void imegineryField1_Enter(object sender, EventArgs e)
        {
            if (imegineryField1.Text == "0")
                imegineryField1.Text = "";
        }

        private void imegineryField1_Leave(object sender, EventArgs e)
        {
            if (imegineryField1.Text == "")
                imegineryField1.Text = "0";
        }

        private void realField2_Enter(object sender, EventArgs e)
        {
            if (realField2.Text == "0")
                realField2.Text = "";
        }

        private void realField2_Leave(object sender, EventArgs e)
        {
            if (realField2.Text == "")
                realField2.Text = "0";
        }

        private void imegineryField2_Enter(object sender, EventArgs e)
        {
            if (imegineryField2.Text == "0")
                imegineryField2.Text = "";
        }

        private void imegineryField2_Leave(object sender, EventArgs e)
        {
            if (imegineryField2.Text == "")
                imegineryField2.Text = "0";
        }

    }
}
