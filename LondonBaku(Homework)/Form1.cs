using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LondonBaku_Homework_
{
    public partial class Form1 : Form
    {
        Timer Timer = new Timer();
        char ch = 'b';
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.baku;
            Timer.Tick += Timer_Tick;
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ch == 'b')
                this.Text = DateTime.Now.ToString();
            else if(ch=='l')
            {
                var date = DateTime.Now;
                var lnd = date.AddHours(-4);
                this.Text = lnd.ToString();
            }
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            Image bakuimg = Properties.Resources.baku;
            this.BackgroundImage = bakuimg;
            BakuBtn.BackColor = Color.Green;
            LondonBtn.BackColor = default;
            ch = 'b';
        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            Image londonimg = Properties.Resources.London;
            this.BackgroundImage = londonimg;
            LondonBtn.BackColor = Color.Green;
            BakuBtn.BackColor = default;
            ch = 'l';
        }

        private void BakuBtn_MouseEnter(object sender, EventArgs e)
        {
            if (!(BakuBtn.BackColor == Color.Green))
                BakuBtn.BackColor = Color.LightBlue;
        }

        private void LondonBtn_MouseEnter(object sender, EventArgs e)
        {
            if (!(LondonBtn.BackColor == Color.Green))
                LondonBtn.BackColor = Color.LightBlue;
        }

        private void LondonBtn_MouseLeave(object sender, EventArgs e)
        {
            if (LondonBtn.BackColor == Color.LightBlue)
                LondonBtn.BackColor = default;
        }

        private void BakuBtn_MouseLeave(object sender, EventArgs e)
        {
            if (BakuBtn.BackColor == Color.LightBlue)
                BakuBtn.BackColor = default;
        }
    }
}
