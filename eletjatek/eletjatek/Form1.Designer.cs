﻿namespace eletjatek
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dataGridViewPálya = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPálya).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPálya
            // 
            dataGridViewPálya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPálya.Location = new Point(12, 60);
            dataGridViewPálya.Name = "dataGridViewPálya";
            dataGridViewPálya.RowHeadersWidth = 62;
            dataGridViewPálya.Size = new Size(1021, 627);
            dataGridViewPálya.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 635);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 827);
            Controls.Add(label1);
            Controls.Add(dataGridViewPálya);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPálya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewPálya;
        public System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
