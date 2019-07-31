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

namespace _3107_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Person obj { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            obj = new Person() { Name = "hi im person" };
            this.DataContext = this;
        }

        public class Person
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return $"Person name {Name}";
            }
        }
    }
}
