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
using Record.Core.Model;

namespace Record
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Transaction transaction;
        public MainWindow()
        {
            InitializeComponent();
            transaction = new Transaction();
        }

        private void date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((DatePicker)sender).SelectedDate.ToString());
            transaction.DateTime = (DateTime)((DatePicker)sender).SelectedDate;
        }

        private void currencyComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // ... A List.
            List<string> data = new List<string>();
            data.Add("CAD");
            data.Add("USD");
            data.Add("CNY");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
           comboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            MessageBox.Show( "Selected: " + value);
        }

        private void cardTypeComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // ... A List.
            List<string> data = new List<string>();
            data.Add("DEBIT");
            data.Add("VISA");
            data.Add("MASTER");
            data.Add("AMERICAN EXPRESS");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }
    }
}
