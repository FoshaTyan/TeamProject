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

        private void InitializeComponent()
        {
            comboBoxElement = new ComboBox();
            comboBoxChoosedEl = new ComboBox();
            comboBoxCost = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxElement
            // 
            comboBoxElement.FormattingEnabled = true;
            comboBoxElement.Location = new Point(25, 30);
            comboBoxElement.Name = "comboBoxElement";
            comboBoxElement.Size = new Size(121, 23);
            comboBoxElement.TabIndex = 0;
            // 
            // comboBoxChoosedEl
            // 
            comboBoxChoosedEl.FormattingEnabled = true;
            comboBoxChoosedEl.Location = new Point(25, 77);
            comboBoxChoosedEl.Name = "comboBoxChoosedEl";
            comboBoxChoosedEl.Size = new Size(121, 23);
            comboBoxChoosedEl.TabIndex = 1;
            // 
            // comboBoxCost
            // 
            comboBoxCost.FormattingEnabled = true;
            comboBoxCost.Location = new Point(25, 384);
            comboBoxCost.Name = "comboBoxCost";
            comboBoxCost.Size = new Size(121, 23);
            comboBoxCost.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 357);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 3;
            label1.Text = "Ціна";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(488, 496);
            dataGridView1.TabIndex = 4;
            // 
            // Form5
            // 
            ClientSize = new Size(831, 511);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBoxCost);
            Controls.Add(comboBoxChoosedEl);
            Controls.Add(comboBoxElement);
            Name = "Form5";
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox comboBoxElement;
        private ComboBox comboBoxChoosedEl;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBoxCost;
    }
}
