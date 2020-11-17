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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static string al = "абвгдеёжзийклмнопрстуфхцчшщъьыэюяабвгдеёжзиклмнопрстуфхцчшщъьыэюя";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = ori(tb1.Text);
        }
        public string ori(string inp)
        {
            StringBuilder code = new StringBuilder();
            string s = tb1.Text;
            string sd = tb3.Text;
            int step = Convert.ToInt32(sd);
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < al.Length; j++)
                    if (s[i] == al[j]) code.Append(al[(j + step) % al.Length]);
            return code.ToString();

        }
    }
}
