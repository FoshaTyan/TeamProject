using System.Globalization;
using System.Windows.Forms;

namespace laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ���� � ����� � ������� � �������
            string filePath = Path.Combine(Application.StartupPath, "cars.txt");

            // ���������, ���������� �� ����
            if (File.Exists(filePath))
            {
                List<Car> cars = LoadCarsFromFile(filePath);

                if (cars.Count > 0)
                {
                    // ��������� ������ ����������� � ListBox
                    AddCarsToListBox(cars);
                }
                else
                {
                    MessageBox.Show("���� ���� ��� ������ �� ��������� ���������.");
                }
            }
            else
            {
                MessageBox.Show("���� � ������� �� ������!");
            }
        }

        private List<Car> LoadCarsFromFile(string filePath)
        {
            List<Car> cars = new List<Car>();

            // ������ ���� ����� �� �����
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // ���������� ������ �� �������
                string[] fields = line.Split(' ');

                if (fields.Length == 8)  // ��������, ��� ���������� ����� ������������� ������ Car
                {
                    try
                    {
                        // ������ ������ � ������� ������ Car
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
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"������ ������� ������ � ������: {line}\n{ex.Message}");
                    }
                }
            }

            return cars;
        }

        private void AddCarsToListBox(List<Car> cars)
        {
            foreach (var car in cars)
            {
                listBox1.Items.Add($"{car.Brand}");
                listBox2.Items.Add($"{car.Model}");
                listBox3.Items.Add($"{car.Color}");
                listBox4.Items.Add($"{car.EngineSize}");
                listBox5.Items.Add($"{car.BodyType}");
                listBox6.Items.Add($"{car.FuelType}");
                listBox7.Items.Add($"{car.Count}");
                listBox8.Items.Add($"{car.Price}");
            }
        }
    }
}
