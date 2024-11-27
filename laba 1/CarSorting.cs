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
    public partial class CarSorting : Form
    {
        private List<Car> cars;
        public CarSorting(List<Car> cars)
        {
            InitializeComponent();
            this.cars = cars;
            comboBoxElement.Items.Add("Марка");
            comboBoxElement.Items.Add("Об'єм двигуна");
            comboBoxElement.Items.Add("Тип палива");
            comboBoxElement.Items.Add("Тип корпуса");
            comboBoxElement.SelectedIndex = 0;
            comboBoxCost.Items.Add("За зростанням");
            comboBoxCost.Items.Add("За зниженням");
            comboBoxCost.SelectedIndex = 0;
        }

        private void CarSorting_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedElement = comboBoxElement.SelectedItem.ToString();

            comboBoxChoosedEl.Items.Clear();
            comboBoxChoosedEl.Items.Add("Всі"); // Добавляем опцию "Всі"

            switch (selectedElement)
            {
                case "Марка":
                    comboBoxChoosedEl.Items.AddRange(cars.Select(car => car.Brand).Distinct().ToArray());
                    break;
                case "Об'єм двигуна":
                    comboBoxChoosedEl.Items.AddRange(cars.Select(car => car.EngineSize.ToString("0.0")).Distinct().ToArray());
                    break;
                case "Тип палива":
                    comboBoxChoosedEl.Items.AddRange(cars.Select(car => car.FuelType).Distinct().ToArray());
                    break;
                case "Тип корпусу":
                    comboBoxChoosedEl.Items.AddRange(cars.Select(car => car.BodyType).Distinct().ToArray());
                    break;
                default:
                    break;
            }

            // Устанавливаем "Всі" по умолчанию, если ничего не выбрано
            comboBoxChoosedEl.SelectedIndex = 0;
        }
        private void sort()
        {
            string selectedElement = comboBoxElement.SelectedItem.ToString();
            string selectedItem = comboBoxChoosedEl.SelectedItem?.ToString() ?? "Всі"; // Добавляем дефолтное значение

            List<Car> filteredCars;

            switch (selectedElement)
            {
                case "Марка":
                    filteredCars = selectedItem == "Всі" ? cars : cars.Where(car => car.Brand == selectedItem).ToList();
                    break;
                case "Об'єм двигуна":
                    filteredCars = selectedItem == "Всі" ? cars : cars.Where(car => car.EngineSize.ToString("0.0") == selectedItem).ToList();
                    break;
                case "Тип палива":
                    filteredCars = selectedItem == "Всі" ? cars : cars.Where(car => car.FuelType == selectedItem).ToList();
                    break;
                case "Тип корпусу":
                    filteredCars = selectedItem == "Всі" ? cars : cars.Where(car => car.BodyType == selectedItem).ToList();
                    break;
                default:
                    filteredCars = cars;
                    break;
            }

            dataGridViewShow(filteredCars);
        }
        private void dataGridViewShow(List<Car> filteredCars)
        {
            string costSort = comboBoxCost.SelectedItem?.ToString() ?? "За зростанням";

            if (costSort == "За зростанням")
            {
                filteredCars = filteredCars.OrderBy(car => car.Price).ToList();
            }
            else if (costSort == "За зниженням")
            {
                filteredCars = filteredCars.OrderByDescending(car => car.Price).ToList();
            }

            dataGridView1.DataSource = filteredCars;
        }

        private void comboBoxChoosedEl_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort();
        }

        private void comboBoxCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort();
        }
    }
}
