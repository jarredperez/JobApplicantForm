namespace WindowsFormsApp1
{
    partial class Form3
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
            this.listViewApplicant = new System.Windows.Forms.ListView();
            this.txtLastNameF3 = new System.Windows.Forms.TextBox();
            this.ButtonSearchLastName = new System.Windows.Forms.Button();
            this.ButtonAddStrength = new System.Windows.Forms.Button();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.listViewStrengths = new System.Windows.Forms.ListView();
            this.ButtonDeleteStrength = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClear2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewApplicant
            // 
            this.listViewApplicant.HideSelection = false;
            this.listViewApplicant.Location = new System.Drawing.Point(115, 83);
            this.listViewApplicant.Name = "listViewApplicant";
            this.listViewApplicant.Size = new System.Drawing.Size(741, 97);
            this.listViewApplicant.TabIndex = 0;
            this.listViewApplicant.UseCompatibleStateImageBehavior = false;
            this.listViewApplicant.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewApplicant_MouseDoubleClick);
            // 
            // txtLastNameF3
            // 
            this.txtLastNameF3.Location = new System.Drawing.Point(115, 44);
            this.txtLastNameF3.Name = "txtLastNameF3";
            this.txtLastNameF3.Size = new System.Drawing.Size(100, 22);
            this.txtLastNameF3.TabIndex = 1;
            // 
            // ButtonSearchLastName
            // 
            this.ButtonSearchLastName.Location = new System.Drawing.Point(221, 43);
            this.ButtonSearchLastName.Name = "ButtonSearchLastName";
            this.ButtonSearchLastName.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearchLastName.TabIndex = 2;
            this.ButtonSearchLastName.Text = "Search";
            this.ButtonSearchLastName.UseVisualStyleBackColor = true;
            this.ButtonSearchLastName.Click += new System.EventHandler(this.ButtonSearchLastName_Click);
            // 
            // ButtonAddStrength
            // 
            this.ButtonAddStrength.Location = new System.Drawing.Point(330, 239);
            this.ButtonAddStrength.Name = "ButtonAddStrength";
            this.ButtonAddStrength.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddStrength.TabIndex = 3;
            this.ButtonAddStrength.Text = "Add";
            this.ButtonAddStrength.UseVisualStyleBackColor = true;
            this.ButtonAddStrength.Click += new System.EventHandler(this.ButtonAddStrength_Click);
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(115, 239);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(209, 22);
            this.txtStrength.TabIndex = 4;
            // 
            // listViewStrengths
            // 
            this.listViewStrengths.HideSelection = false;
            this.listViewStrengths.Location = new System.Drawing.Point(115, 283);
            this.listViewStrengths.Name = "listViewStrengths";
            this.listViewStrengths.Size = new System.Drawing.Size(741, 322);
            this.listViewStrengths.TabIndex = 5;
            this.listViewStrengths.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonDeleteStrength
            // 
            this.ButtonDeleteStrength.Location = new System.Drawing.Point(411, 239);
            this.ButtonDeleteStrength.Name = "ButtonDeleteStrength";
            this.ButtonDeleteStrength.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteStrength.TabIndex = 6;
            this.ButtonDeleteStrength.Text = "Delete";
            this.ButtonDeleteStrength.UseVisualStyleBackColor = true;
            this.ButtonDeleteStrength.Click += new System.EventHandler(this.ButtonDeleteStrength_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(302, 43);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 7;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonClear2
            // 
            this.ButtonClear2.Location = new System.Drawing.Point(492, 238);
            this.ButtonClear2.Name = "ButtonClear2";
            this.ButtonClear2.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear2.TabIndex = 8;
            this.ButtonClear2.Text = "Clear";
            this.ButtonClear2.UseVisualStyleBackColor = true;
            this.ButtonClear2.Click += new System.EventHandler(this.ButtonClear2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(960, 634);
            this.Controls.Add(this.ButtonClear2);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonDeleteStrength);
            this.Controls.Add(this.listViewStrengths);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.ButtonAddStrength);
            this.Controls.Add(this.ButtonSearchLastName);
            this.Controls.Add(this.txtLastNameF3);
            this.Controls.Add(this.listViewApplicant);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewApplicant;
        private System.Windows.Forms.TextBox txtLastNameF3;
        private System.Windows.Forms.Button ButtonSearchLastName;
        private System.Windows.Forms.Button ButtonAddStrength;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.ListView listViewStrengths;
        private System.Windows.Forms.Button ButtonDeleteStrength;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonClear2;
    }
}