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

namespace _3107
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";
            e.Handled = true;
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = "Click event is bubbled to Stack Panel";
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            txt3.Text = "Click event is bubbled to Window";
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
            MessageBox.Show("Button mouse");
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Stack panel mouse");
        }
    }
}
