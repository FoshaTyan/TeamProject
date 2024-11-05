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
            // Создаем несколько объектов Car
            List<Car> cars = new List<Car>
            {
                new Car("Toyota", "Camry", "Red", 2.5, "Sedan", "Gasoline", 3, 3000000),
                new Car("Honda", "Accord", "Blue", 2.0, "Sedan", "Diesel", 2, 2500000),
                new Car("Ford", "Mustang", "Black", 5.0, "Coupe", "Gasoline", 1, 5500000)
            };

            // Вызываем метод для добавления данных
            AddCarsToListBox(cars);
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
