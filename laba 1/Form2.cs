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

    public partial class Form2 : Form
    {
        private List<Car> cars;   // Ссылка на общий список
        private int selectedIndex; // Индекс выбранной машины
        public Form2(List<Car> cars, int selectedIndex)
        {
            InitializeComponent();
            this.cars = cars; // Сохраняем ссылку на список
            this.selectedIndex = selectedIndex;
            DisplayCarDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
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
                textBoxCount.Text = $"{car.Count}";
                textBoxPrice.Text = $"{car.Price}";
            }
        }
        private void SaveCarsToFile()
        {
            string filePath = "cars.txt"; // Укажите путь к файлу
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
    }
}
