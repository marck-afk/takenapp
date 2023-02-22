namespace TakenAppV2
{
    partial class Overview
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlpTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.PnlFilters = new System.Windows.Forms.Panel();
            this.CbxPriority = new System.Windows.Forms.ComboBox();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpTasks
            // 
            this.FlpTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlpTasks.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FlpTasks.Location = new System.Drawing.Point(0, 0);
            this.FlpTasks.Name = "FlpTasks";
            this.FlpTasks.Size = new System.Drawing.Size(759, 406);
            this.FlpTasks.TabIndex = 0;
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAddTask.Location = new System.Drawing.Point(709, 0);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(50, 50);
            this.BtnAddTask.TabIndex = 1;
            this.BtnAddTask.Text = "+";
            this.BtnAddTask.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbxSearch
            // 
            this.TbxSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxSearch.Location = new System.Drawing.Point(93, 6);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(167, 38);
            this.TbxSearch.TabIndex = 3;
            // 
            // PnlFilters
            // 
            this.PnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFilters.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlFilters.Controls.Add(this.CbxPriority);
            this.PnlFilters.Controls.Add(this.CbxStatus);
            this.PnlFilters.Controls.Add(this.label3);
            this.PnlFilters.Controls.Add(this.label2);
            this.PnlFilters.Controls.Add(this.BtnAddTask);
            this.PnlFilters.Controls.Add(this.TbxSearch);
            this.PnlFilters.Controls.Add(this.label1);
            this.PnlFilters.Location = new System.Drawing.Point(0, 406);
            this.PnlFilters.Name = "PnlFilters";
            this.PnlFilters.Size = new System.Drawing.Size(759, 50);
            this.PnlFilters.TabIndex = 4;
            // 
            // CbxPriority
            // 
            this.CbxPriority.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxPriority.FormattingEnabled = true;
            this.CbxPriority.Items.AddRange(new object[] {
            "URGENT",
            "HIGH",
            "NORMAL",
            "LOW",
            "NONE"});
            this.CbxPriority.Location = new System.Drawing.Point(579, 6);
            this.CbxPriority.Name = "CbxPriority";
            this.CbxPriority.Size = new System.Drawing.Size(122, 39);
            this.CbxPriority.TabIndex = 7;
            // 
            // CbxStatus
            // 
            this.CbxStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxStatus.FormattingEnabled = true;
            this.CbxStatus.Items.AddRange(new object[] {
            "TO DO",
            "IN PROGRESS",
            "DONE",
            "NONE"});
            this.CbxStatus.Location = new System.Drawing.Point(353, 5);
            this.CbxStatus.Name = "CbxStatus";
            this.CbxStatus.Size = new System.Drawing.Size(122, 39);
            this.CbxStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(481, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Priority:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(266, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 455);
            this.Controls.Add(this.PnlFilters);
            this.Controls.Add(this.FlpTasks);
            this.Name = "Overview";
            this.Text = "Form1";
            this.PnlFilters.ResumeLayout(false);
            this.PnlFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpTasks;
        private System.Windows.Forms.Button BtnAddTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxSearch;
        private System.Windows.Forms.Panel PnlFilters;
        private System.Windows.Forms.ComboBox CbxPriority;
        private System.Windows.Forms.ComboBox CbxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
