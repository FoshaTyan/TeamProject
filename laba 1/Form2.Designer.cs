namespace laba_1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            textBoxBrand = new TextBox();
            textBoxModel = new TextBox();
            textBoxColor = new TextBox();
            textBoxEngineSize = new TextBox();
            textBoxFuelType = new TextBox();
            textBoxBodyType = new TextBox();
            textBoxCount = new TextBox();
            textBoxPrice = new TextBox();
            BuyButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(122, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 1;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(230, 24);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 2;
            label2.Text = "Колір";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(458, 24);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 4;
            label3.Text = "Паливо";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(336, 24);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 6;
            label4.Text = "Об'єм двигуна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(564, 24);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 8;
            label5.Text = "Корпус";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(670, 24);
            label6.Name = "label6";
            label6.Size = new Size(142, 21);
            label6.TabIndex = 10;
            label6.Text = "Кількість на складі";
            // 
            // button1
            // 
            button1.Location = new Point(161, 163);
            button1.Name = "button1";
            button1.Size = new Size(127, 33);
            button1.TabIndex = 12;
            button1.Text = "Додаткові функції";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(11, 163);
            button2.Name = "button2";
            button2.Size = new Size(143, 33);
            button2.TabIndex = 13;
            button2.Text = "Стандартні функції";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(14, 24);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 15;
            label7.Text = "Марка";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(14, 48);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.ReadOnly = true;
            textBoxBrand.Size = new Size(100, 23);
            textBoxBrand.TabIndex = 16;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(122, 48);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.ReadOnly = true;
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 17;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(230, 48);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(100, 23);
            textBoxColor.TabIndex = 18;
            // 
            // textBoxEngineSize
            // 
            textBoxEngineSize.Location = new Point(336, 48);
            textBoxEngineSize.Name = "textBoxEngineSize";
            textBoxEngineSize.ReadOnly = true;
            textBoxEngineSize.Size = new Size(100, 23);
            textBoxEngineSize.TabIndex = 19;
            // 
            // textBoxFuelType
            // 
            textBoxFuelType.Location = new Point(458, 48);
            textBoxFuelType.Name = "textBoxFuelType";
            textBoxFuelType.ReadOnly = true;
            textBoxFuelType.Size = new Size(100, 23);
            textBoxFuelType.TabIndex = 20;
            // 
            // textBoxBodyType
            // 
            textBoxBodyType.Location = new Point(564, 48);
            textBoxBodyType.Name = "textBoxBodyType";
            textBoxBodyType.ReadOnly = true;
            textBoxBodyType.Size = new Size(100, 23);
            textBoxBodyType.TabIndex = 21;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(670, 48);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.ReadOnly = true;
            textBoxCount.Size = new Size(100, 23);
            textBoxCount.TabIndex = 22;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(11, 273);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(390, 165);
            textBoxPrice.TabIndex = 23;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(407, 415);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(75, 23);
            BuyButton.TabIndex = 24;
            BuyButton.Text = "Придбати";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(BuyButton);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxBodyType);
            Controls.Add(textBoxFuelType);
            Controls.Add(textBoxEngineSize);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxBrand);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label7;
        private TextBox textBoxBrand;
        private TextBox textBoxModel;
        private TextBox textBoxColor;
        private TextBox textBoxEngineSize;
        private TextBox textBoxFuelType;
        private TextBox textBoxBodyType;
        private TextBox textBoxCount;
        private TextBox textBoxPrice;
        private Button BuyButton;
    }
}