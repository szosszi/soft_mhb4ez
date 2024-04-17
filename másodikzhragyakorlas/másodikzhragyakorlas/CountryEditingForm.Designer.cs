namespace másodikzhragyakorlas
{
    partial class CountryEditingForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 54);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Country name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 165);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Population:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 297);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Area in km:";
            // 
            // name
            // 
            name.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            name.Location = new Point(76, 105);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(386, 46);
            name.TabIndex = 3;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(countryData);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBox1.Location = new Point(76, 229);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 46);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBox2.Location = new Point(76, 360);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(386, 46);
            textBox2.TabIndex = 5;
            // 
            // save
            // 
            save.Location = new Point(169, 485);
            save.Name = "save";
            save.Size = new Size(159, 63);
            save.TabIndex = 6;
            save.Text = "OK";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // CountryEditingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 624);
            Controls.Add(save);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CountryEditingForm";
            Text = "CountryEditingForm";
            Load += CountryEditingForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox textBox1;
        private TextBox textBox2;
        private BindingSource bindingSource1;
        private Button save;
    }
}