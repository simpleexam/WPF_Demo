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
using System.Windows.Shapes;

namespace WPF_Demo
{
    /// <summary>
    /// Логика взаимодействия для UnuformGridDemo.xaml
    /// </summary>
    public partial class UnuformGridDemo : Window
    {
        public UnuformGridDemo()
        {
            InitializeComponent();
            this.Name = "temp";
        }

        private void OpenMainWindowButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

       
    }
}
