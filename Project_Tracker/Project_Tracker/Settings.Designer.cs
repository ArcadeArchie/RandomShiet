namespace Project_Tracker
{
    partial class Settings
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpreadsheetID_button = new System.Windows.Forms.Button();
            this.SetTablerange_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SpreadsheetID";
            // 
            // SpreadsheetID_button
            // 
            this.SpreadsheetID_button.Location = new System.Drawing.Point(15, 54);
            this.SpreadsheetID_button.Name = "SpreadsheetID_button";
            this.SpreadsheetID_button.Size = new System.Drawing.Size(121, 23);
            this.SpreadsheetID_button.TabIndex = 2;
            this.SpreadsheetID_button.Text = "Set SpreadsheetID";
            this.SpreadsheetID_button.UseVisualStyleBackColor = true;
            this.SpreadsheetID_button.Click += new System.EventHandler(this.SpreadsheetID_button_Click);
            // 
            // SetTablerange_button
            // 
            this.SetTablerange_button.Location = new System.Drawing.Point(205, 53);
            this.SetTablerange_button.Name = "SetTablerange_button";
            this.SetTablerange_button.Size = new System.Drawing.Size(97, 23);
            this.SetTablerange_button.TabIndex = 5;
            this.SetTablerange_button.Text = "Set Tablerange";
            this.SetTablerange_button.UseVisualStyleBackColor = true;
            this.SetTablerange_button.Click += new System.EventHandler(this.SetTablerange_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table Range";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 113);
            this.Controls.Add(this.SetTablerange_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SpreadsheetID_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SpreadsheetID_button;
        private System.Windows.Forms.Button SetTablerange_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}