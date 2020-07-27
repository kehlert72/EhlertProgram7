namespace EhlertProgram7
{
    partial class PresentationGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSleepAmt = new System.Windows.Forms.TextBox();
            this.txtAverageSleepAmt = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblSleepAmt = new System.Windows.Forms.Label();
            this.lblAverageSleepAmt = new System.Windows.Forms.Label();
            this.btnShowStudent = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(29, 48);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(29, 92);
            this.lblAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 24);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(132, 87);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(72, 29);
            this.txtAge.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 131);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 29);
            this.txtID.TabIndex = 5;
            // 
            // txtSleepAmt
            // 
            this.txtSleepAmt.Location = new System.Drawing.Point(363, 213);
            this.txtSleepAmt.Name = "txtSleepAmt";
            this.txtSleepAmt.Size = new System.Drawing.Size(125, 29);
            this.txtSleepAmt.TabIndex = 6;
            // 
            // txtAverageSleepAmt
            // 
            this.txtAverageSleepAmt.Location = new System.Drawing.Point(363, 259);
            this.txtAverageSleepAmt.Name = "txtAverageSleepAmt";
            this.txtAverageSleepAmt.Size = new System.Drawing.Size(125, 29);
            this.txtAverageSleepAmt.TabIndex = 7;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(29, 136);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(96, 24);
            this.lblStudentID.TabIndex = 8;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblSleepAmt
            // 
            this.lblSleepAmt.AutoSize = true;
            this.lblSleepAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleepAmt.Location = new System.Drawing.Point(216, 218);
            this.lblSleepAmt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSleepAmt.Name = "lblSleepAmt";
            this.lblSleepAmt.Size = new System.Drawing.Size(127, 24);
            this.lblSleepAmt.TabIndex = 9;
            this.lblSleepAmt.Text = "Sleep amount";
            // 
            // lblAverageSleepAmt
            // 
            this.lblAverageSleepAmt.AutoSize = true;
            this.lblAverageSleepAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSleepAmt.Location = new System.Drawing.Point(81, 259);
            this.lblAverageSleepAmt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAverageSleepAmt.Name = "lblAverageSleepAmt";
            this.lblAverageSleepAmt.Size = new System.Drawing.Size(262, 24);
            this.lblAverageSleepAmt.TabIndex = 10;
            this.lblAverageSleepAmt.Text = "Sleep amount for most people";
            // 
            // btnShowStudent
            // 
            this.btnShowStudent.Location = new System.Drawing.Point(195, 391);
            this.btnShowStudent.Name = "btnShowStudent";
            this.btnShowStudent.Size = new System.Drawing.Size(148, 40);
            this.btnShowStudent.TabIndex = 11;
            this.btnShowStudent.Text = "Show Student";
            this.btnShowStudent.UseVisualStyleBackColor = true;
            this.btnShowStudent.Click += new System.EventHandler(this.btnShowStudent_Click);
            // 
            // PresentationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.btnShowStudent);
            this.Controls.Add(this.lblAverageSleepAmt);
            this.Controls.Add(this.lblSleepAmt);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtAverageSleepAmt);
            this.Controls.Add(this.txtSleepAmt);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PresentationGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PresentationGUI_LOAD);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSleepAmt;
        private System.Windows.Forms.TextBox txtAverageSleepAmt;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblSleepAmt;
        private System.Windows.Forms.Label lblAverageSleepAmt;
        private System.Windows.Forms.Button btnShowStudent;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

