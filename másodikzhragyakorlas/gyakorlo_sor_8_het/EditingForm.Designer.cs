﻿namespace gyakorlo_sor_8_het
{
    partial class EditingForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            OK = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Szam", true));
            textBox1.Location = new Point(79, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 31);
            textBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Feladat);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Kerdes", true));
            textBox2.Location = new Point(81, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "V1", true));
            textBox3.Location = new Point(79, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(330, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "V2", true));
            textBox4.Location = new Point(79, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(330, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "V3", true));
            textBox5.Location = new Point(79, 412);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(330, 31);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "HelyesValasz", true));
            textBox6.Location = new Point(79, 609);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(328, 31);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 36);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 6;
            label1.Text = "sorszam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 116);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 7;
            label2.Text = "kerdes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 203);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 8;
            label3.Text = "valasz1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 291);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 9;
            label4.Text = "valasz2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 381);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 10;
            label5.Text = "valasz3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 568);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 11;
            label6.Text = "jovalasz";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "Kep", true));
            textBox7.Location = new Point(79, 511);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(330, 31);
            textBox7.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 465);
            label7.Name = "label7";
            label7.Size = new Size(35, 25);
            label7.TabIndex = 13;
            label7.Text = "pic";
            // 
            // OK
            // 
            OK.DialogResult = DialogResult.OK;
            OK.Location = new Point(458, 628);
            OK.Name = "OK";
            OK.Size = new Size(85, 59);
            OK.TabIndex = 14;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 699);
            Controls.Add(OK);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EditingForm";
            Text = "EditingForm";
            Load += EditingForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private BindingSource bindingSource1;
        private TextBox textBox7;
        private Label label7;
        private Button OK;
    }
}