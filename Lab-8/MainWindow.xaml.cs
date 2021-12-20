using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_8
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
        WorkerPaterfamilias _worker1;
        WorkerPaterfamilias _worker2;


        public void InfoWorker_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != string.Empty && surname.Text != string.Empty
                           && patronymic.Text != string.Empty && position.Text != string.Empty
                           && int.TryParse(children.Text, out int children1) == true && int.TryParse(age.Text, out int age1) == true)
            {
                _worker1 = new WorkerPaterfamilias(name.Text, surname.Text, patronymic.Text,
                     children1, position.Text, age1);

            if (Check1.IsChecked == true) { firstWorker.Text = _worker1.EmployeeInformation(); }
            else { secondWorker.Text = _worker2.EmployeeInformation(); }          
            }
            else
            {
                MessageBox.Show("Поля заполнены неправильно или не заполнены");
            }
        }

        private void CloneWorker_Click(object sender, RoutedEventArgs e)
        {
            if (_worker1 != null)
            {
               _worker2 = (WorkerPaterfamilias)_worker1.Clone();
               secondWorker.Text = _worker2.EmployeeInformation();
            }
            else
            {
                MessageBox.Show("Создайте информацию о первом работнике");
            }
        }

        private void CompareWorker_Click(object sender, RoutedEventArgs e)
        {
            if (_worker1 != null)
            {
                if (_worker1.CompareTo(_worker2) == 1) { MessageBox.Show("Фамилия первого работника больше, чем у второго"); }
                if (_worker1.CompareTo(_worker2) == -1) { MessageBox.Show("Фамилия второго работника больше, чем у первого"); }
                if (_worker1.CompareTo(_worker2) == 0) { MessageBox.Show("Фамилии у работников одинаковые"); }
            }
            else
            {
                MessageBox.Show("Поля первого работника и второго работника незаполнены");
            }
        }

        private void ChangeData_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != string.Empty && surname.Text != string.Empty
                          && patronymic.Text != string.Empty && position.Text != string.Empty
                          && int.TryParse(children.Text, out int children1) == true && int.TryParse(age.Text, out int age1) == true)
            {

                if (Check1.IsChecked == true)
                {
               
                    _worker1 = new WorkerPaterfamilias(name.Text, surname.Text, patronymic.Text,
                     children1, position.Text, age1);
                    firstWorker.Text = _worker1.EmployeeInformation();
                }
               
                if (Check2.IsChecked == true)
                {
                    _worker2 = new WorkerPaterfamilias(name.Text, surname.Text, patronymic.Text,
                     children1, position.Text, age1);
                    secondWorker.Text = _worker2.EmployeeInformation();
                }
            }
            else
            {
                MessageBox.Show("Поля заполнены неправильно или не заполнены");
            }
        }

        private void Exite_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейсы - работник и отец-семейства. Создать класс работника-отца семейства." +
                "Класс должен включать конмтруктор, функцию для формирования строки информации о работнике." +
                "Сравнение производить по фамилиию");
        }

        private void Reset_Cllick(object sender, RoutedEventArgs e)
        {
            name.Clear();
            surname.Clear();
            patronymic.Clear();
            position.Clear();
            children.Clear();
            age.Clear();
            firstWorker.Clear();
            secondWorker.Clear();
        }
    }
}
