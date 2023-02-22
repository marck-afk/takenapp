using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TakenAppV2
{
    public partial class TaskCreater : Form
    {
        public TaskCreater()
        {
            InitializeComponent();
        }

        private void CreateTask(object sender, EventArgs e)
        {
            UCTask ucTask = new UCTask(TbxSubject.Text, CbxStatus.Text, CbxPriority.Text);
            
        }
    }
}
