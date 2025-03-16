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
using System.IO;
using EmployeesSalary.Classes;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace EmployeesSalary
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClsEmployees oemployee=new ClsEmployees(); string masseg;
            var list= oemployee.ShowEmployeesData(out masseg);
           
            if (!String.IsNullOrEmpty(masseg))
            {
                MessageBox.Show(masseg);
                return;
            }
            GridEmployees.ItemsSource = list;   
        }
    }
}   
