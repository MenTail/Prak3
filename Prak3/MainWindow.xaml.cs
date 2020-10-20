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

namespace Prak3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gor.IsChecked = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool BS1 = (bool) rog.IsChecked;
            bool BS2 = (bool) H1.IsChecked; 
            int BS3 = 0;
            switch (Log.Text)
            {
                case "Дерево": BS3 = 2; break;
                case "Метал": BS3 = 0; break;
                case "Металопластик": BS3 = 1; break;
            }
            double x = Convert.ToDouble(Bss1.Text)* Convert.ToDouble(Bss2.Text);
            double y = (0.05 + 0.1* BS3) + (0.05 * Convert.ToInt32(BS1));
            Bart.Content = "Вартість: " + (x*y+(35 * Convert.ToInt32(BS2))) + " грн";
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
