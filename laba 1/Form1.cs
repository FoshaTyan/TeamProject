using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace laba_1
{
    public partial class Form1 : Form
    {

        private List<Car> cars = new List<Car>(); // Список автомобилей в памяти
        public string filePath = Path.Combine(Application.StartupPath, "cars.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 newForm = new Form2();
            //newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e) //покупка
        {
            if (listBox1.SelectedIndex >= 0)
            {
                int selectedIndex = listBox1.SelectedIndex;

                if (cars[selectedIndex].Count > 0)
                {
                    // Передаём весь список и индекс выбранной машины
                    Form2 newForm = new Form2(cars, selectedIndex);
                    newForm.FormClosed += (s, args) => UpdateListBoxes(); // Обновляем интерфейс после закрытия формы
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Машин больше нет в наличии");
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль из списка");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Проверяем, существует ли файл
            if (File.Exists(filePath))
            {
                cars = LoadCarsFromFile(filePath);
                UpdateListBoxes();
            }
            else
            {
                MessageBox.Show("Файл с данными не найден");
            }
        }

        private List<Car> LoadCarsFromFile(string filePath)
        {
            List<Car> cars = new List<Car>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] fields = line.Split(' ');

                if (fields.Length == 8)
                {
                    try
                    {
                        string brand = fields[0];
                        string model = fields[1];
                        string color = fields[2];
                        double engineSize = double.Parse(fields[3], CultureInfo.InvariantCulture);
                        string bodyType = fields[4];
                        string fuelType = fields[5];
                        int count = int.Parse(fields[6]);
                        double price = double.Parse(fields[7], CultureInfo.InvariantCulture);

                        Car car = new Car(brand, model, color, engineSize, bodyType, fuelType, count, price);
                        cars.Add(car);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при чтении данных: {ex.Message}");
                    }
                }
            }

            return cars;
        }

        private void UpdateListBoxes()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();

            foreach (var car in cars)
            {
                listBox1.Items.Add(car.Brand);
                listBox2.Items.Add(car.Model);
                listBox3.Items.Add(car.Color);
                listBox4.Items.Add(car.EngineSize.ToString("0.0", CultureInfo.InvariantCulture));
                listBox5.Items.Add(car.BodyType);
                listBox6.Items.Add(car.FuelType);
                listBox7.Items.Add(car.Count);
                listBox8.Items.Add(car.Price);
            }
        }

        private void SaveCarsToFile(string filePath)
        {
            List<string> lines = new List<string>();

            foreach (Car car in cars)
            {
                string line = $"{car.Brand} {car.Model} {car.Color} {car.EngineSize.ToString(CultureInfo.InvariantCulture)} {car.BodyType} {car.FuelType} {car.Count} {car.Price.ToString(CultureInfo.InvariantCulture)}";
                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
