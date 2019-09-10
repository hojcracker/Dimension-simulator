using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimension_simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double Xx = Convert.ToDouble(X.Text) - 1;
            X.Text = Convert.ToString(Xx);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if(found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1,3);
                if(dice == 2)
                {
                    int line_number = rnd.Next(1,605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Xx = Convert.ToDouble(X.Text) + 1;
            X.Text = Convert.ToString(Xx);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double Yy = Convert.ToDouble(Y.Text) - 1;
            Y.Text = Convert.ToString(Yy);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double Yy = Convert.ToDouble(Y.Text) + 1;
            Y.Text = Convert.ToString(Yy);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double Zz = Convert.ToDouble(Z.Text) - 1;
            Z.Text = Convert.ToString(Zz);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double Zz = Convert.ToDouble(Z.Text) + 1;
            Z.Text = Convert.ToString(Zz);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            double Uu = Convert.ToDouble(U.Text) - 1;
            U.Text = Convert.ToString(Uu);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            double Uu = Convert.ToDouble(U.Text) + 1;
            U.Text = Convert.ToString(Uu);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;
                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            double Vv = Convert.ToDouble(V.Text) - 1;
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;
                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
            V.Text = Convert.ToString(Vv);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            double Vv = Convert.ToDouble(V.Text) + 1;
            V.Text = Convert.ToString(Vv);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            double Ww = Convert.ToDouble(W.Text) - 1;
            W.Text = Convert.ToString(Ww);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            double Ww = Convert.ToDouble(W.Text) + 1;
            W.Text = Convert.ToString(Ww);
            bool found = false;
            for (int i = 0; i < SeenList.Items.Count; i++)
            {
                
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                if (SeenList.Items[i].ToString().Contains(Coordenates))
                {
                    SeenList.Items.Add(SeenList.Items[i].ToString());
                    found = true;
                    
                    break;
                }
            }
            if (found == false)
            {
                string Coordenates = X.Text + ";" + Y.Text + ";" + Z.Text + ";" + U.Text + ";" + V.Text + ";" + W.Text;
                Random rnd = new Random();
                int dice = rnd.Next(1, 3);
                if (dice == 2)
                {
                    int line_number = rnd.Next(1, 605);
                    string path = Directory.Text;

                    string thing_name = Convert.ToString(File.ReadLines(Directory.Text).Skip(line_number).Take(1).First());
                    SeenList.Items.Add(Coordenates + " " + thing_name);
                }
            }
        }
    }
}
