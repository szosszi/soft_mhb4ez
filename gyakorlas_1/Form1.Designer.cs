namespace gyakorlas_1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hitelossz = new TextBox();
            havikam = new TextBox();
            havitorl = new TextBox();
            megejeleníto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)megejeleníto).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 345);
            button1.Name = "button1";
            button1.Size = new Size(189, 34);
            button1.TabIndex = 0;
            button1.Text = "kiszamolom";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 58);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 1;
            label1.Text = "hitelösszeg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 149);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 2;
            label2.Text = "havikamat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 232);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 3;
            label3.Text = "havitorleszto";
            // 
            // hitelossz
            // 
            hitelossz.Location = new Point(101, 103);
            hitelossz.Name = "hitelossz";
            hitelossz.Size = new Size(150, 31);
            hitelossz.TabIndex = 4;
            hitelossz.Text = "5000000";
            // 
            // havikam
            // 
            havikam.Location = new Point(110, 186);
            havikam.Name = "havikam";
            havikam.Size = new Size(150, 31);
            havikam.TabIndex = 5;
            havikam.Text = "0,3";
            // 
            // havitorl
            // 
            havitorl.Location = new Point(114, 281);
            havitorl.Name = "havitorl";
            havitorl.Size = new Size(150, 31);
            havitorl.TabIndex = 6;
            havitorl.Text = "200000";
            // 
            // megejeleníto
            // 
            megejeleníto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            megejeleníto.Location = new Point(364, 65);
            megejeleníto.Name = "megejeleníto";
            megejeleníto.RowHeadersWidth = 62;
            megejeleníto.Size = new Size(413, 358);
            megejeleníto.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(megejeleníto);
            Controls.Add(havitorl);
            Controls.Add(havikam);
            Controls.Add(hitelossz);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)megejeleníto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox hitelossz;
        private TextBox havikam;
        private TextBox havitorl;
        private DataGridView megejeleníto;
    }
}
