using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace laba_1
{
    public partial class Sorting : Form
    {
        private List<Car> cars;
        public Sorting(List<Car> cars)
        {
            InitializeComponent();
            this.cars = cars;
            comboBoxBrand.Items.Add("Всі");//Додаємо у comboBox елементи, взяті зі списку автомобілів
            comboBoxBrand.Items.AddRange(cars.Select(car => car.Brand).Distinct().ToArray());
            comboBoxBrand.SelectedIndex = 0;
            comboBoxEngineVolume.Items.Add("Всі");
            comboBoxEngineVolume.Items.AddRange(cars.Select(car => car.EngineSize.ToString()).Distinct().ToArray());
            comboBoxEngineVolume.SelectedIndex = 0;
            comboBoxFuelType.Items.Add("Всі");
            comboBoxFuelType.Items.AddRange(cars.Select(car => car.FuelType).Distinct().ToArray());
            comboBoxFuelType.SelectedIndex = 0;
            comboBoxBodyType.Items.Add("Всі");
            comboBoxBodyType.Items.AddRange(cars.Select(car => car.BodyType).Distinct().ToArray());
            comboBoxBodyType.SelectedIndex = 0;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (cars == null || !cars.Any())
            {
                MessageBox.Show("Список автомобилей пуст или не загружен!");
                return;
            }

            string brand = comboBoxBrand.SelectedItem?.ToString() ?? "Всі";
            string engvol = comboBoxEngineVolume.SelectedItem?.ToString() ?? "Всі";
            string fuelt = comboBoxFuelType.SelectedItem?.ToString() ?? "Всі";
            string bodyt = comboBoxBodyType.SelectedItem?.ToString() ?? "Всі";


            try
            {
                var filteredCars = cars.Where(car =>
                    (brand == "Всі" || car.Brand != null && car.Brand == brand) &&
                    (engvol == "Всі" || car.EngineSize.ToString() == engvol) &&
                    (fuelt == "Всі" || car.FuelType != null && car.FuelType == fuelt) &&
                    (bodyt == "Всі" || car.BodyType != null && car.BodyType == bodyt) &&
                    (car.Price >= (double)numericUpDownMin.Value && car.Price <= (double)numericUpDownMax.Value)).ToList();

                dataGridView1.DataSource = filteredCars;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}
