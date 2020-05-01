namespace AutoSurveyV2
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonFaculty = new System.Windows.Forms.Button();
            this.buttonLab = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(107, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an action below:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(5, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(128, 15);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Welcome, [username]";
            // 
            // buttonFaculty
            // 
            this.buttonFaculty.BackColor = System.Drawing.Color.Yellow;
            this.buttonFaculty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFaculty.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaculty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaculty.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonFaculty.Location = new System.Drawing.Point(0, 79);
            this.buttonFaculty.Name = "buttonFaculty";
            this.buttonFaculty.Size = new System.Drawing.Size(453, 55);
            this.buttonFaculty.TabIndex = 1;
            this.buttonFaculty.Text = "Answer Faculty Evaluation";
            this.buttonFaculty.UseVisualStyleBackColor = false;
            this.buttonFaculty.Click += new System.EventHandler(this.buttonFaculty_Click);
            // 
            // buttonLab
            // 
            this.buttonLab.BackColor = System.Drawing.Color.Yellow;
            this.buttonLab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLab.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonLab.FlatAppearance.BorderSize = 0;
            this.buttonLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLab.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonLab.Location = new System.Drawing.Point(0, 134);
            this.buttonLab.Name = "buttonLab";
            this.buttonLab.Size = new System.Drawing.Size(453, 50);
            this.buttonLab.TabIndex = 2;
            this.buttonLab.Text = "Answer Laboratory Assesment";
            this.buttonLab.UseVisualStyleBackColor = false;
            this.buttonLab.Click += new System.EventHandler(this.buttonLab_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonExit.Location = new System.Drawing.Point(0, 184);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(453, 26);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(453, 210);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonFaculty);
            this.Controls.Add(this.buttonLab);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonFaculty;
        private System.Windows.Forms.Button buttonLab;
        private System.Windows.Forms.Button buttonExit;
    }
}