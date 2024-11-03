using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private GroupBox groupBox1;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton13;
        private ListBox listBox1;

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton13);
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton9);
            groupBox1.Controls.Add(radioButton10);
            groupBox1.Controls.Add(radioButton11);
            groupBox1.Controls.Add(radioButton12);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 487);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(543, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 484);
            listBox1.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Марка";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Модель";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 97);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Колір";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(50, 19);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "Ціна";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 122);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(103, 19);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "об’єм двигуна";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 147);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(64, 19);
            radioButton6.TabIndex = 4;
            radioButton6.TabStop = true;
            radioButton6.Text = "бензин";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 172);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(41, 19);
            radioButton7.TabIndex = 11;
            radioButton7.TabStop = true;
            radioButton7.Text = "газ";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(6, 197);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(81, 19);
            radioButton8.TabIndex = 10;
            radioButton8.TabStop = true;
            radioButton8.Text = "електрика";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(6, 222);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(97, 19);
            radioButton9.TabIndex = 9;
            radioButton9.TabStop = true;
            radioButton9.Text = "газ та бензин";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(6, 247);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(58, 19);
            radioButton10.TabIndex = 8;
            radioButton10.TabStop = true;
            radioButton10.Text = "Седан";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(6, 272);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(51, 19);
            radioButton11.TabIndex = 7;
            radioButton11.TabStop = true;
            radioButton11.Text = "Купе";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(6, 297);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(101, 19);
            radioButton12.TabIndex = 6;
            radioButton12.TabStop = true;
            radioButton12.Text = "Внедорожник";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(6, 322);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(68, 19);
            radioButton13.TabIndex = 12;
            radioButton13.TabStop = true;
            radioButton13.Text = "хачтбек";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            ClientSize = new Size(831, 511);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
