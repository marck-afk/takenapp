namespace TakenAppV2
{
    partial class UCTask
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LblSubject = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblPriority = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDelete.Location = new System.Drawing.Point(0, 171);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 29);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete task";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEdit.Location = new System.Drawing.Point(0, 142);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(200, 29);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit task";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // LblSubject
            // 
            this.LblSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSubject.Location = new System.Drawing.Point(0, 0);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(200, 42);
            this.LblSubject.TabIndex = 2;
            this.LblSubject.Text = "Subject";
            this.LblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblStatus.Location = new System.Drawing.Point(0, 42);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(100, 100);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "Status:\r\nTO DO";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPriority
            // 
            this.LblPriority.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblPriority.Location = new System.Drawing.Point(100, 42);
            this.LblPriority.Name = "LblPriority";
            this.LblPriority.Size = new System.Drawing.Size(100, 100);
            this.LblPriority.TabIndex = 4;
            this.LblPriority.Text = "Priority:\r\nLOW";
            this.LblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPriority);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblSubject);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Name = "UCTask";
            this.Size = new System.Drawing.Size(200, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label LblSubject;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblPriority;
    }
}
