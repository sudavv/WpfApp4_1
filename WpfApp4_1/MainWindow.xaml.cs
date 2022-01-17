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

namespace WpfApp4_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (USD1.Text != "0" && USD2.Text != "0")
            {
                try
                {
                    USD3.Text = Math.Round((Convert.ToDouble(USD2.Text.Replace('.', ',')) * Convert.ToDouble(USD1.Text.Replace('.', ','))), 2).ToString() + " руб.";
                }
                catch
                {
                    USD3.Text = "Введите числа";
                }
            }
            else USD3.Text = "null";


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (EUR1.Text != "0" && EUR2.Text != "0")
            {
                try
            {
                EUR3.Text = Math.Round((Convert.ToDouble(EUR2.Text.Replace('.', ',')) * Convert.ToDouble(EUR1.Text.Replace('.', ','))), 2).ToString() + " руб.";

            }
            catch
            {
                EUR3.Text = "Введите числа";
            }
            }
            else EUR3.Text = "null";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (UAH1.Text != "0" && UAH2.Text != "0")
            {
                try
            {
                UAH3.Text = Math.Round((Convert.ToDouble(UAH2.Text.Replace('.', ',')) * Convert.ToDouble(UAH1.Text.Replace('.', ','))), 2).ToString() + " руб.";

            }
            catch
            {
                UAH3.Text = "Введите числа";
            }
            }
            else UAH3.Text = "null";
        }

        public Output Converter()
        {
            double conv = 0;
            string name = "";
           //Array arr = new Array[2];

            if ((bool)mm.IsChecked)
            {
                conv = 10;
                name = "мм";
            }
            else if ((bool)cm.IsChecked)
            {
                conv = 1;
                name = "см";
            }
            else if ((bool)m.IsChecked)
            {
                conv = 0.01;
                name = "м";
            }
            else if ((bool)km.IsChecked)
            {
                conv = 0.00001;
                name = "км";
            }
            
            Output ret = new Output();
            ret.name = name;
            ret.conv = conv;

            return ret;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (AMD1.Text != "0" && AMD2.Text != "0")
            {
                try
            {
                AMD3.Text = Math.Round((Convert.ToDouble(AMD2.Text.Replace('.', ',')) * Convert.ToDouble(AMD1.Text.Replace('.', ','))), 2).ToString() + " руб.";

            }
            catch
            {
                AMD3.Text = "Введите числа";
            }
            }
            else AMD3.Text = "null";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {//inch

            Output dict = Converter();

            double conv = (double)dict.conv;
            string name = (string)dict.name;

            try
            {
                Inch2.Text = ((Convert.ToDouble(Inch1.Text) * conv)*3.93701).ToString() + " " + name;// 39,3701
            }
            catch
            {

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {//foot
            Output dict = Converter();

            double conv = (double)dict.conv;
            string name = (string)dict.name;

            try
            {
                Foot2.Text = ((Convert.ToDouble(Foot1.Text) * conv) * 30.48).ToString() + " " + name;// 30,48
            }
            catch
            {

            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {//miles
            Output dict = Converter();

            double conv = (double)dict.conv;
            string name = (string)dict.name;

            try
            {
                Mile2.Text = ((Convert.ToDouble(Mile1.Text) * conv) * 160934).ToString() + " " + name;// 160934
            }
            catch
            {

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {//verst
            Output dict = Converter();

            double conv = (double)dict.conv;
            string name = (string)dict.name;

            try
            {
                Verst2.Text = ((Convert.ToDouble(Verst1.Text) * conv) * 106680).ToString() + " " + name;// 106680
            }
            catch
            {

            }
        }

        public class Output
        {
            public object name { get; set; }
            public object conv { get; set; }
        }
    }
}

        

