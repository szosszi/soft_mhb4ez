namespace gyakorlo_sor_8_het
{
    partial class szerkesztoForm
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
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ok = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Szam", true));
            textBox1.Location = new Point(82, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 31);
            textBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Feladat);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Kerdes", true));
            textBox2.Location = new Point(82, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(401, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "V1", true));
            textBox3.Location = new Point(82, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(401, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "V2", true));
            textBox4.Location = new Point(82, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(401, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "V3", true));
            textBox5.Location = new Point(82, 389);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(401, 31);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Kep", true));
            textBox6.Location = new Point(82, 496);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(401, 31);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "HelyesValasz", true));
            textBox7.Location = new Point(82, 572);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(401, 31);
            textBox7.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 7;
            label1.Text = "sorszam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 138);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 8;
            label2.Text = "kerdes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 200);
            label3.Name = "label3";
            label3.Size = new Size(31, 25);
            label3.TabIndex = 9;
            label3.Text = "v1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 270);
            label4.Name = "label4";
            label4.Size = new Size(31, 25);
            label4.TabIndex = 10;
            label4.Text = "v2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 349);
            label5.Name = "label5";
            label5.Size = new Size(31, 25);
            label5.TabIndex = 11;
            label5.Text = "v3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 443);
            label6.Name = "label6";
            label6.Size = new Size(35, 25);
            label6.TabIndex = 12;
            label6.Text = "pic";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 544);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 13;
            label7.Text = "correct";
            // 
            // ok
            // 
            ok.DialogResult = DialogResult.OK;
            ok.Location = new Point(82, 632);
            ok.Name = "ok";
            ok.Size = new Size(112, 34);
            ok.TabIndex = 14;
            ok.Text = "OK";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // szerkesztoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 678);
            Controls.Add(ok);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            DataBindings.Add(new Binding("Text", bindingSource1, "Szam", true));
            Name = "szerkesztoForm";
            Text = "szerkesztoForm";
            Load += szerkesztoForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private BindingSource bindingSource1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ok;
    }
}