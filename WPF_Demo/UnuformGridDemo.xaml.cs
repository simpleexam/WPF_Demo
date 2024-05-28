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
            //текущему окнов в свойство Name записывается имя для его дальнейшего поиска среди всех окон в текущем приложении
            this.Name = "temp";
        }

        /// <summary>
        /// клик по кнопке "открыть главное окно"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenMainWindowButton_Click(object sender, RoutedEventArgs e)
        {
            //создание объекта окна
            MainWindow mainWindow = new MainWindow();
            //отображение окна
            mainWindow.Show();
            //сокрытие (не закрытие) текущего
            this.Hide();
        }

       
    }
}
