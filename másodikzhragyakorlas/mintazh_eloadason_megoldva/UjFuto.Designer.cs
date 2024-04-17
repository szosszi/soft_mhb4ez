namespace mintazh_eloadason_megoldva
{
    partial class UjFuto
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
            components = new System.ComponentModel.Container();
            ok = new Button();
            cancel = new Button();
            textBox1 = new TextBox();
            futokBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ok
            // 
            ok.DialogResult = DialogResult.OK;
            ok.Location = new Point(442, 620);
            ok.Name = "ok";
            ok.Size = new Size(112, 34);
            ok.TabIndex = 0;
            ok.Text = "OK";
            ok.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new Point(259, 620);
            cancel.Name = "cancel";
            cancel.Size = new Size(112, 34);
            cancel.TabIndex = 1;
            cancel.Text = "CANCEL";
            cancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futokBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(93, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 31);
            textBox1.TabIndex = 2;
            // 
            // futokBindingSource
            // 
            futokBindingSource.DataSource = typeof(Futok);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", futokBindingSource, "Nev", true));
            textBox2.Location = new Point(93, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(486, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", futokBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(93, 319);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(486, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", futokBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(93, 419);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(488, 31);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", futokBindingSource, "Kategoria", true));
            textBox5.Location = new Point(93, 523);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(484, 31);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 66);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 7;
            label1.Text = "ID (int)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 167);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 8;
            label2.Text = "Nev";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 279);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 9;
            label3.Text = "nemeztiseg";
            // 
            // UjFuto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 727);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cancel);
            Controls.Add(ok);
            Name = "UjFuto";
            Text = "UjFuto";
            Load += UjFuto_Load;
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok;
        private Button cancel;
        private TextBox textBox1;
        private BindingSource futokBindingSource;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}