﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockTest
{
    public partial class ClockTestForm : Form
    {
        public ClockTestForm()
        {
            InitializeComponent();
        }

        private void digitalClock1_AlarmActivated(object sender, EventArgs e)
        {
            this.digitalClock1.AlarmActivated -= new System.EventHandler(this.digitalClock1_AlarmActivated);
            MessageBox.Show("WAKE UP!!");
        }

        private void digitalClock1_Load(object sender, EventArgs e)
        {
            
        }
    }
    }

