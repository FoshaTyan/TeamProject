using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{

    public partial class CarBuyingWindow : Form
    {
        private List<Car> cars;   // Ссылка на общий список
        private int selectedIndex; // Индекс выбранной машины
        private double PriceWithVAT; // Цена с ПДВ
        private double StandartPrice; // Стандартная цена
        public CarBuyingWindow(List<Car> cars, int selectedIndex)
        {
            InitializeComponent();
            this.cars = cars; // Сохраняем ссылку на список
            this.selectedIndex = selectedIndex;
            this.PriceWithVAT = CalculatePriceWithVAT();
            this.StandartPrice = CalculatePriceWithVAT();
            DisplayCarDetails(); 
            PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {PriceWithVAT.ToString()}";
            BuyButton.Enabled = false;
        }

        private double CalculatePriceWithVAT()
        {
            // Начальная цена
            double basePrice = cars[selectedIndex].Price;

            // Цена  расчитанная с ПДВ
            double priceWithVAT = basePrice + (basePrice * 0.2);

            return priceWithVAT;
        }

        private void CarBuyingWindow_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void DisplayCarDetails()
        {
            Car car = cars[selectedIndex];

            {
                textBoxBrand.Text = $"{car.Brand}";
                textBoxModel.Text = $"{car.Model}";
                textBoxColor.Text = $"{car.Color}";
                textBoxEngineSize.Text = $"{car.EngineSize}";
                textBoxBodyType.Text = $"{car.BodyType}";
                textBoxFuelType.Text = car.EngineSize.ToString("0.0", CultureInfo.InvariantCulture);
                textBoxCount.Text = $"{car.Count}\n";
                textBoxPrice.Text = $"Початкова ціна: {car.Price}";
            }
        }
        private void SaveCarsToFile()
        {
            string filePath = "cars.txt"; 
            List<string> lines = new List<string>();

            foreach (Car car in cars)
            {
                string line = $"{car.Brand} {car.Model} {car.Color} {car.EngineSize.ToString("0.0", CultureInfo.InvariantCulture)} {car.BodyType} {car.FuelType} {car.Count} {car.Price.ToString(CultureInfo.InvariantCulture)}";
                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

        // Уменьшаем количество машин
            if (cars[selectedIndex].Count > 0)
            {
                cars[selectedIndex].Count--;
                MessageBox.Show("Покупка успешна!");
                // Обновляем файл
                SaveCarsToFile();
                // Закрываем форму после покупки               
                this.Close();
            }
            else
            {
                MessageBox.Show("Машин больше нет в наличии");
            }          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Car car = cars[selectedIndex];
            if (radioButton2.Checked == true)
            {
                BuyButton.Enabled = true;
                groupBox1.Show();
            }
            else
            {
                BuyButton.Enabled = true;
                groupBox1.Hide();
                textBoxPrice.Text = $"Початкова ціна: {car.Price}";
                PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {StandartPrice.ToString()}";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int additionalPrice = 20000;
            if (checkBox1.Checked)
            {
                PriceWithVAT += additionalPrice;
                // Добавляем строку, если CheckBox активен
                if (!textBoxPrice.Text.Contains("+ 20000"))
                {
                    textBoxPrice.Text += Environment.NewLine + "+ 20000";
                }
            }
            else
            {
                PriceWithVAT -= additionalPrice;
                // Удаляем строку, если CheckBox не активен
                textBoxPrice.Text = textBoxPrice.Text.Replace(Environment.NewLine + "+ 20000", "").Trim();
            }
            PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {PriceWithVAT.ToString()}";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int additionalPrice = 25000;
            if (checkBox2.Checked)
            {
                PriceWithVAT += additionalPrice;
                // Добавляем строку, если CheckBox активен
                if (!textBoxPrice.Text.Contains("+ 25000"))
                {
                    textBoxPrice.Text += Environment.NewLine + "+ 25000";
                }
            }
            else
            {
                PriceWithVAT -= additionalPrice;
                // Удаляем строку, если CheckBox не активен
                textBoxPrice.Text = textBoxPrice.Text.Replace(Environment.NewLine + "+ 25000", "").Trim();
            }
            PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {PriceWithVAT.ToString()}";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int additionalPrice = 15000;
            if (checkBox3.Checked)
            {
                PriceWithVAT += additionalPrice;
                // Добавляем строку, если CheckBox активен
                if (!textBoxPrice.Text.Contains("+ 15000"))
                {
                    textBoxPrice.Text += Environment.NewLine + "+ 15000";
                }
            }
            else
            {
                PriceWithVAT -= additionalPrice;
                // Удаляем строку, если CheckBox не активен
                textBoxPrice.Text = textBoxPrice.Text.Replace(Environment.NewLine + "+ 15000", "").Trim();
            }
            PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {PriceWithVAT.ToString()}";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int additionalPrice = 30000;
            if (checkBox4.Checked)
            {
                PriceWithVAT += additionalPrice;
                // Добавляем строку, если CheckBox активен
                if (!textBoxPrice.Text.Contains("+ 30000"))
                {
                    textBoxPrice.Text += Environment.NewLine + "+ 30000";
                }
            }
            else
            {
                PriceWithVAT -= additionalPrice;
                // Удаляем строку, если CheckBox не активен
                textBoxPrice.Text = textBoxPrice.Text.Replace(Environment.NewLine + "+ 30000", "").Trim();
            }
            PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {PriceWithVAT.ToString()}";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int additionalPrice = 10000;
            if (checkBox5.Checked)
            {
                PriceWithVAT += additionalPrice;
                // Добавляем строку, если CheckBox активен
                if (!textBoxPrice.Text.Contains("+ 10000"))
                {
                    textBoxPrice.Text += Environment.NewLine + "+ 10000";
                }
            }
            else
            {
                PriceWithVAT -= additionalPrice;
                // Удаляем строку, если CheckBox не активен
                textBoxPrice.Text = textBoxPrice.Text.Replace(Environment.NewLine + "+ 10000", "").Trim();
            }
            PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {PriceWithVAT.ToString()}";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int additionalPrice = 17000;
            if (checkBox6.Checked)
            {
                PriceWithVAT += additionalPrice;
                // Добавляем строку, если CheckBox активен
                if (!textBoxPrice.Text.Contains("+ 17000"))
                {
                    textBoxPrice.Text += Environment.NewLine + "+ 17000";
                }
            }
            else
            {
                PriceWithVAT -= additionalPrice;
                // Удаляем строку, если CheckBox не активен
                textBoxPrice.Text = textBoxPrice.Text.Replace(Environment.NewLine + "+ 17000", "").Trim();
            }
            PriceTotal.Text = $"Кінцева ціна(з ПДВ 20%): {PriceWithVAT.ToString()}";
        }
    }
}
