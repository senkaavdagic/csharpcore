﻿namespace LegacyWinForms
{
    partial class Form1
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
            this.btnGoToSomewhere = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAmraBDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToSomewhere
            // 
            this.btnGoToSomewhere.Location = new System.Drawing.Point(338, 37);
            this.btnGoToSomewhere.Name = "btnGoToSomewhere";
            this.btnGoToSomewhere.Size = new System.Drawing.Size(132, 42);
            this.btnGoToSomewhere.TabIndex = 0;
            this.btnGoToSomewhere.Text = "Senka\'s birthday";
            this.btnGoToSomewhere.UseVisualStyleBackColor = true;
            this.btnGoToSomewhere.Click += new System.EventHandler(this.btnGoToSomewhere_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(32, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btnAmraBDay
            // 
            this.btnAmraBDay.Location = new System.Drawing.Point(338, 105);
            this.btnAmraBDay.Name = "btnAmraBDay";
            this.btnAmraBDay.Size = new System.Drawing.Size(132, 42);
            this.btnAmraBDay.TabIndex = 4;
            this.btnAmraBDay.Text = "Amra\'s birthday";
            this.btnAmraBDay.UseVisualStyleBackColor = true;
            this.btnAmraBDay.Click += new System.EventHandler(this.btnAmraBDay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAmraBDay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnGoToSomewhere);
            this.Name = "Form1";
            this.Text = "Proba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnGoToSomewhere;
        public System.Windows.Forms.Button btnAmraBDay;
    }
}

