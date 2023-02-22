using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TakenAppV2
{
    public partial class UCTask : UserControl
    {
        public UCTask(string subject, string status, string priority)
        {
            InitializeComponent();
            LblSubject.Text = subject;
            LblStatus.Text = status; 
            LblPriority.Text = priority;
        }

        public UCTask()
        {
            InitializeComponent();
            LblSubject.Text = "Subject";
            LblStatus.Text = "Status:\n";
            LblPriority.Text = "Priority:\n";
        }

        private void EditTask(object sender, EventArgs e)
        {

        }

        private void DeleteTask(object sender, EventArgs e)
        {
            
        }
    }
}
