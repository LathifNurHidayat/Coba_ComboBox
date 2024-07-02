namespace WinFormsApp1
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
            treeView1 = new TreeView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            comboBox2 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            panel4 = new Panel();
            button5 = new Button();
            comboBox3 = new ComboBox();
            checkedListBox2 = new CheckedListBox();
            btnNext = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(4, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(347, 224);
            treeView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(103, 233);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 1;
            button1.Text = "List Kendaraan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.AccessibleName = "";
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // button2
            // 
            button2.Location = new Point(24, 107);
            button2.Name = "button2";
            button2.Size = new Size(127, 39);
            button2.TabIndex = 3;
            button2.Text = "Delete Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(204, 107);
            button3.Name = "button3";
            button3.Size = new Size(127, 39);
            button3.TabIndex = 4;
            button3.Text = "Clear All";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(treeView1);
            panel1.Location = new Point(9, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 275);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(8, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 154);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(checkedListBox1);
            panel3.Location = new Point(379, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 227);
            panel3.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(218, 168);
            button4.Name = "button4";
            button4.Size = new Size(130, 33);
            button4.TabIndex = 2;
            button4.Text = "Add Item";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(18, 169);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(172, 33);
            comboBox2.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(365, 144);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(button5);
            panel4.Controls.Add(comboBox3);
            panel4.Controls.Add(checkedListBox2);
            panel4.Location = new Point(379, 242);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 155);
            panel4.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(218, 114);
            button5.Name = "button5";
            button5.Size = new Size(130, 33);
            button5.TabIndex = 2;
            button5.Text = "Add Item";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(18, 114);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(172, 33);
            comboBox3.TabIndex = 1;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(3, 7);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(368, 88);
            checkedListBox2.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(465, 405);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(212, 41);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 450);
            Controls.Add(btnNext);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private CheckedListBox checkedListBox1;
        private Button button4;
        private ComboBox comboBox2;
        private Panel panel4;
        private Button button5;
        private ComboBox comboBox3;
        private CheckedListBox checkedListBox2;
        private Button btnNext;
    }
}
