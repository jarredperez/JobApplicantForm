namespace WindowsFormsApp1
{
    partial class Form2
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
            this.txtLastNameF2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.txtBoxIdReturn = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name Search";
            // 
            // txtLastNameF2
            // 
            this.txtLastNameF2.Location = new System.Drawing.Point(177, 157);
            this.txtLastNameF2.Name = "txtLastNameF2";
            this.txtLastNameF2.Size = new System.Drawing.Size(100, 22);
            this.txtLastNameF2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(674, 252);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(283, 157);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // txtBoxIdReturn
            // 
            this.txtBoxIdReturn.Location = new System.Drawing.Point(460, 157);
            this.txtBoxIdReturn.Name = "txtBoxIdReturn";
            this.txtBoxIdReturn.Size = new System.Drawing.Size(100, 22);
            this.txtBoxIdReturn.TabIndex = 4;
            this.txtBoxIdReturn.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(364, 157);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.txtBoxIdReturn);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtLastNameF2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Last Name Search ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastNameF2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox txtBoxIdReturn;
        private System.Windows.Forms.Button buttonClear;
    }
}