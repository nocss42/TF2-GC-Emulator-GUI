namespace TF2_GC_GUI
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 220);
            button1.Name = "button1";
            button1.Size = new Size(154, 44);
            button1.TabIndex = 0;
            button1.Text = "Open inventory.txt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(416, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 364);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(416, 244);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(274, 220);
            button2.Name = "button2";
            button2.Size = new Size(154, 43);
            button2.TabIndex = 4;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 336);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 5;
            label1.Text = "All Items";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 6;
            label2.Text = "Inventory";
            // 
            // button3
            // 
            button3.Location = new Point(12, 270);
            button3.Name = "button3";
            button3.Size = new Size(154, 46);
            button3.TabIndex = 7;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 335);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 341);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Search";
            label3.Click += label3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(274, 270);
            button4.Name = "button4";
            button4.Size = new Size(154, 46);
            button4.TabIndex = 10;
            button4.Text = "Random Item!";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 618);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "TF2 Inventory Editor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox textBox1;
        private Label label3;
        private Button button4;
    }
}
