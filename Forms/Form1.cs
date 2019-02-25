﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plane;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialGame();
        }
        public void InitialGame()
        {
            SingleObject.GetSingle().AddGameObeject(new BackGround(0, -850, 5));
            SingleObject.GetSingle().AddGameObeject(new PlaneHero(100, 100, 5, 3, Direction.up));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SingleObject.GetSingle().Draw(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.AllPaintingInWmPaint, true);
        }
        private void TimerBG_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
