﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class reportes : Form
    {
        public reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verreporteprodter rep = new verreporteprodter();
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verreporteordenes rep = new verreporteordenes();
            rep.Show();
        }
    }
}
