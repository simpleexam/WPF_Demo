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

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// конструктор по умолчанию для окна
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// нажатие на кнопку "закрыть окно"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //просмотр всего списка окон в текущем приложении
            foreach (Window window in App.Current.Windows)
            {
                //если найдено окно со свойством Name == temp, то оно отображается а текущее закрывается
                if (window.Name == "temp")
                    window.Show();
                this.Close();
            }
        }
    }
}
