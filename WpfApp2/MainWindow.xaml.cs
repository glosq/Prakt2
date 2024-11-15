using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void N_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение числа n из текстового поля
                int n = int.Parse(N.Text);

                // Создание массива для хранения чисел
                int[] numbers = new int[n];

                // Заполнение массива числами из текстового поля
                string[] inputNumbers = Rez.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (inputNumbers.Length != n)
                {
                    MessageBox.Show("Некорректное количество чисел!");
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(inputNumbers[i]);
                }

                // Обработка чисел и вывод результатов
                string result = "";
                foreach (int number in numbers)
                {
                    if (number < 0)
                    {
                        int squared = number * number;
                        result += $"Число {number}: {squared}\n";
                    }
                    else
                    {
                        result += $"Число {number}: {number}\n";
                    }
                }

                // Вывод результата в текстовое поле
                Rez.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (((MenuItem)sender).Header.ToString() == "Выход")
            {
                Close();
            }
            else if (((MenuItem)sender).Header.ToString() == "О программе")
            {
                MessageBox.Show("Программа для обработки целых чисел. \nВычисляет квадрат отрицательных чисел.", "О программе");
            }
        }

        private void N_TextChange(object sender, TextChangedEventArgs e)
        {
            // Очистка текстового поля результата при изменении n
            Rez.Text = "";
        }

        private void Rez_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Очистка текстового поля результата при изменении n
            Rez.Text = "";
        }
    }
}
