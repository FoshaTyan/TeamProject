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
            button5 = new Button();
            listBox1 = new ListBox();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(9, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(514, 124);
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
            Controls.Add(button5);
            Name = "Form1";
            Text = "Вибір марки автобіля";
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private ListBox listBox1;
        private Button button10;
        private Button button11;
    }
}
