namespace laba_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label2 = new Label();
            button9 = new Button();
            listBox1 = new ListBox();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(93, 25);
            button1.TabIndex = 14;
            button1.Text = "BMW";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(52, 64);
            label1.Name = "label1";
            label1.Size = new Size(17, 25);
            label1.TabIndex = 1;
            label1.Text = " ";
            // 
            // button2
            // 
            button2.Location = new Point(12, 43);
            button2.Name = "button2";
            button2.Size = new Size(93, 25);
            button2.TabIndex = 2;
            button2.Text = "AUDI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 74);
            button3.Name = "button3";
            button3.Size = new Size(93, 25);
            button3.TabIndex = 4;
            button3.Text = "Porsche";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 105);
            button4.Name = "button4";
            button4.Size = new Size(93, 25);
            button4.TabIndex = 6;
            button4.Text = "Nissan";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(9, 409);
            button5.Name = "button5";
            button5.Size = new Size(96, 29);
            button5.TabIndex = 7;
            button5.Text = "Купить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(127, 105);
            button6.Name = "button6";
            button6.Size = new Size(116, 25);
            button6.TabIndex = 12;
            button6.Text = "Mitsubishi";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(127, 74);
            button7.Name = "button7";
            button7.Size = new Size(116, 25);
            button7.TabIndex = 11;
            button7.Text = "Jaguar";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(127, 43);
            button8.Name = "button8";
            button8.Size = new Size(116, 25);
            button8.TabIndex = 10;
            button8.Text = "Mercedes Benz";
            button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(167, 64);
            label2.Name = "label2";
            label2.Size = new Size(17, 25);
            label2.TabIndex = 9;
            label2.Text = " ";
            // 
            // button9
            // 
            button9.Location = new Point(127, 12);
            button9.Name = "button9";
            button9.Size = new Size(116, 25);
            button9.TabIndex = 8;
            button9.Text = "Mazda";
            button9.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 152);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 124);
            listBox1.TabIndex = 13;
            // 
            // button10
            // 
            button10.Location = new Point(111, 409);
            button10.Name = "button10";
            button10.Size = new Size(96, 29);
            button10.TabIndex = 15;
            button10.Text = "Сортировка";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(213, 409);
            button11.Name = "button11";
            button11.Size = new Size(96, 29);
            button11.TabIndex = 16;
            button11.Text = "Поиск";
            button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(listBox1);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Вибір марки автобіля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label2;
        private Button button9;
        private ListBox listBox1;
        private Button button10;
        private Button button11;
    }
}
