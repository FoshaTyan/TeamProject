namespace laba_1
{
    partial class CarSearch
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
            comboBoxBrand = new ComboBox();
            comboBoxEngineVolume = new ComboBox();
            comboBoxFuelType = new ComboBox();
            comboBoxBodyType = new ComboBox();
            numericUpDownMin = new NumericUpDown();
            numericUpDownMax = new NumericUpDown();
            buttonSearch = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 434);
            dataGridView1.TabIndex = 0;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(12, 12);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(121, 23);
            comboBoxBrand.TabIndex = 1;
            // 
            // comboBoxEngineVolume
            // 
            comboBoxEngineVolume.FormattingEnabled = true;
            comboBoxEngineVolume.Location = new Point(12, 41);
            comboBoxEngineVolume.Name = "comboBoxEngineVolume";
            comboBoxEngineVolume.Size = new Size(121, 23);
            comboBoxEngineVolume.TabIndex = 2;
            // 
            // comboBoxFuelType
            // 
            comboBoxFuelType.FormattingEnabled = true;
            comboBoxFuelType.Location = new Point(12, 70);
            comboBoxFuelType.Name = "comboBoxFuelType";
            comboBoxFuelType.Size = new Size(121, 23);
            comboBoxFuelType.TabIndex = 3;
            // 
            // comboBoxBodyType
            // 
            comboBoxBodyType.FormattingEnabled = true;
            comboBoxBodyType.Location = new Point(12, 99);
            comboBoxBodyType.Name = "comboBoxBodyType";
            comboBoxBodyType.Size = new Size(121, 23);
            comboBoxBodyType.TabIndex = 4;
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Location = new Point(6, 23);
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(120, 23);
            numericUpDownMin.TabIndex = 5;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Location = new Point(6, 52);
            numericUpDownMax.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(120, 23);
            numericUpDownMax.TabIndex = 6;
            numericUpDownMax.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(52, 274);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(122, 37);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Пошук";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDownMin);
            groupBox1.Controls.Add(numericUpDownMax);
            groupBox1.Location = new Point(12, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 102);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ціна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 60);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Макс";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "Мін";
            // 
            // Sorting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 450);
            Controls.Add(groupBox1);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxBodyType);
            Controls.Add(comboBoxFuelType);
            Controls.Add(comboBoxEngineVolume);
            Controls.Add(comboBoxBrand);
            Controls.Add(dataGridView1);
            Name = "Sorting";
            Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxBrand;
        private ComboBox comboBoxEngineVolume;
        private ComboBox comboBoxFuelType;
        private ComboBox comboBoxBodyType;
        private NumericUpDown numericUpDownMin;
        private NumericUpDown numericUpDownMax;
        private Button buttonSearch;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
    }
}