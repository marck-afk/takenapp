﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakenAppV2
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void AddNewTask(object sender, EventArgs e)
        {
            TaskCreater taskCreater = new TaskCreater();
            taskCreater.Show();
        }
    }
}
