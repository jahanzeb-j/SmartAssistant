﻿namespace VoiceRecognition
{
    partial class FrmList
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
            this.lb_process = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_process
            // 
            this.lb_process.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb_process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_process.ForeColor = System.Drawing.Color.Black;
            this.lb_process.FormattingEnabled = true;
            this.lb_process.ItemHeight = 25;
            this.lb_process.Location = new System.Drawing.Point(4, 5);
            this.lb_process.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_process.Name = "lb_process";
            this.lb_process.Size = new System.Drawing.Size(517, 602);
            this.lb_process.TabIndex = 0;
            this.lb_process.SelectedIndexChanged += new System.EventHandler(this.lb_process_SelectedIndexChanged);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 631);
            this.Controls.Add(this.lb_process);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "FrmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_process;
    }
}