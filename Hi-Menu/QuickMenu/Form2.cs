using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMenu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    var Btn = (Button)item;
                    Btn.MouseDown += Btn_MouseDown;
                    Btn.MouseMove += Btn_MouseMove;
                    Btn.MouseUp += Btn_MouseUp;
                }
            }
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            var Btn = (Button)sender;
            Btn.Text = btnText;
        }
        public string kate;
        public string kati;
        Point point;
        string btnText = "";
        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var Btn = (Button)sender;
                Btn.Left += e.X - point.X;
                Btn.Top += e.Y - point.Y;
            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            var Btn = (Button)sender;
            btnText = Btn.Text;
            Btn.Text = "Taşı";
            point = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kate = textBox1.Text;
            kati = textBox2.Text;
            this.Close();
        }
    }
}
