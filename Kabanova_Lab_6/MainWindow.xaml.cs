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


namespace Kabanova_Lab_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinkedList<double> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new LinkedList<double>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add(double.Parse(InputValue.Text));
            NumberGrid.Items.Add(InputValue.Text);
            InputValue.Clear();
            ;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            list.Remove(double.Parse(NumberGrid.SelectedItem.ToString()));
            NumberGrid.Items.Remove(NumberGrid.SelectedItem.ToString());
        }
    }
}