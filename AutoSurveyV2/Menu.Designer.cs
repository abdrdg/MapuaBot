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
            this.buttonStud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select an action below:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(110, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Welcome, [username]";
            // 
            // buttonFaculty
            // 
            this.buttonFaculty.BackColor = System.Drawing.Color.Teal;
            this.buttonFaculty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFaculty.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaculty.ForeColor = System.Drawing.Color.White;
            this.buttonFaculty.Location = new System.Drawing.Point(0, 57);
            this.buttonFaculty.Name = "buttonFaculty";
            this.buttonFaculty.Size = new System.Drawing.Size(453, 55);
            this.buttonFaculty.TabIndex = 2;
            this.buttonFaculty.Text = "Answer Faculty Evaluation";
            this.buttonFaculty.UseVisualStyleBackColor = false;
            this.buttonFaculty.Click += new System.EventHandler(this.buttonFaculty_Click);
            // 
            // buttonLab
            // 
            this.buttonLab.BackColor = System.Drawing.Color.Teal;
            this.buttonLab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLab.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLab.ForeColor = System.Drawing.Color.White;
            this.buttonLab.Location = new System.Drawing.Point(0, 112);
            this.buttonLab.Name = "buttonLab";
            this.buttonLab.Size = new System.Drawing.Size(453, 50);
            this.buttonLab.TabIndex = 3;
            this.buttonLab.Text = "Answer Laboratory Assesment";
            this.buttonLab.UseVisualStyleBackColor = false;
            this.buttonLab.Click += new System.EventHandler(this.buttonLab_Click);
            // 
            // buttonStud
            // 
            this.buttonStud.BackColor = System.Drawing.Color.Teal;
            this.buttonStud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStud.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStud.ForeColor = System.Drawing.Color.White;
            this.buttonStud.Location = new System.Drawing.Point(0, 162);
            this.buttonStud.Name = "buttonStud";
            this.buttonStud.Size = new System.Drawing.Size(453, 48);
            this.buttonStud.TabIndex = 4;
            this.buttonStud.Text = "Answer Student Satisfaction";
            this.buttonStud.UseVisualStyleBackColor = false;
            this.buttonStud.Click += new System.EventHandler(this.buttonStud_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonFaculty);
            this.Controls.Add(this.buttonLab);
            this.Controls.Add(this.buttonStud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonFaculty;
        private System.Windows.Forms.Button buttonLab;
        private System.Windows.Forms.Button buttonStud;
    }
}