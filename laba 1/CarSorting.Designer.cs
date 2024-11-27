namespace laba_1
{
    partial class CarSorting
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
            dataGridView1 = new DataGridView();
            comboBoxChoosedEl = new ComboBox();
            comboBoxElement = new ComboBox();
            comboBoxCost = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 368);
            dataGridView1.TabIndex = 0;
            // 
            // comboBoxChoosedEl
            // 
            comboBoxChoosedEl.FormattingEnabled = true;
            comboBoxChoosedEl.Location = new Point(8, 66);
            comboBoxChoosedEl.Name = "comboBoxChoosedEl";
            comboBoxChoosedEl.Size = new Size(121, 23);
            comboBoxChoosedEl.TabIndex = 1;
            comboBoxChoosedEl.SelectedIndexChanged += comboBoxChoosedEl_SelectedIndexChanged;
            // 
            // comboBoxElement
            // 
            comboBoxElement.FormattingEnabled = true;
            comboBoxElement.Location = new Point(8, 37);
            comboBoxElement.Name = "comboBoxElement";
            comboBoxElement.Size = new Size(121, 23);
            comboBoxElement.TabIndex = 2;
            comboBoxElement.SelectedIndexChanged += comboBoxElement_SelectedIndexChanged;
            // 
            // comboBoxCost
            // 
            comboBoxCost.FormattingEnabled = true;
            comboBoxCost.Location = new Point(8, 353);
            comboBoxCost.Name = "comboBoxCost";
            comboBoxCost.Size = new Size(121, 23);
            comboBoxCost.TabIndex = 3;
            comboBoxCost.SelectedIndexChanged += comboBoxCost_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 335);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Ціна";
            // 
            // CarSorting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 379);
            Controls.Add(label1);
            Controls.Add(comboBoxCost);
            Controls.Add(comboBoxElement);
            Controls.Add(comboBoxChoosedEl);
            Controls.Add(dataGridView1);
            Name = "CarSorting";
            Text = "Сортування";
            Load += CarSorting_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxChoosedEl;
        private ComboBox comboBoxElement;
        private ComboBox comboBoxCost;
        private Label label1;
    }
}