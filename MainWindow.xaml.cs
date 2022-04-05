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

namespace zadanie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Machine m;

        public MainWindow()
        {
            InitializeComponent();
            m = new Machine();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //wyjmij
            if (m.IsMachineEmpty() == false)
                result.Content = m.GetRandomToken() + "\n -- Wykonano operacje GetRandomToken() --";
            else
                result.Content = "Brak słów w maszynie";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            //włóż
            //m. type_here.Text
            m.AddToken(type_here.Text);
            result.Content = " -- Wykonano operacje AddToken() --";
            ShowList();
        }

        private void ShowList()
        {
            all.Content = "Lista słów: ";
            List<string> list = m.ShowAll();
            foreach (var item in list)
            {
                all.Content += ("\n" + item);
            }
            all.Content +=" --- wykonano operacje ShowAll()";
        }
    }
}
