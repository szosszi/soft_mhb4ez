namespace ezmarvalami
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
            ok = new Button();
            megse = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ok
            // 
            ok.DialogResult = DialogResult.OK;
            ok.Location = new Point(583, 361);
            ok.Name = "ok";
            ok.Size = new Size(112, 34);
            ok.TabIndex = 0;
            ok.Text = "ok";
            ok.UseVisualStyleBackColor = true;
            // 
            // megse
            // 
            megse.DialogResult = DialogResult.Cancel;
            megse.Location = new Point(448, 361);
            megse.Name = "megse";
            megse.Size = new Size(112, 34);
            megse.TabIndex = 1;
            megse.Text = "button1";
            megse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 31);
            textBox1.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(megse);
            Controls.Add(ok);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok;
        private Button megse;
        public TextBox textBox1;
    }
}