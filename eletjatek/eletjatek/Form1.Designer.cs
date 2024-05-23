namespace eletjatek
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
            start = new Button();
            stop_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPálya).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPálya
            // 
            dataGridViewPálya.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPálya.Location = new Point(12, 60);
            dataGridViewPálya.Name = "dataGridViewPálya";
            dataGridViewPálya.RowHeadersWidth = 62;
            dataGridViewPálya.Size = new Size(1053, 737);
            dataGridViewPálya.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 700;
            timer1.Tick += timer1_Tick;
            // 
            // start
            // 
            start.Location = new Point(12, 12);
            start.Name = "start";
            start.Size = new Size(112, 34);
            start.TabIndex = 4;
            start.Text = "START";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop_clear
            // 
            stop_clear.Location = new Point(160, 12);
            stop_clear.Name = "stop_clear";
            stop_clear.Size = new Size(208, 34);
            stop_clear.TabIndex = 7;
            stop_clear.Text = "STOPandCLEAR";
            stop_clear.UseVisualStyleBackColor = true;
            stop_clear.Click += stop_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 827);
            Controls.Add(stop_clear);
            Controls.Add(start);
            Controls.Add(dataGridViewPálya);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPálya).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewPálya;
        public System.Windows.Forms.Timer timer1;
        private Button start;
        private Button stop_clear;
    }
}
