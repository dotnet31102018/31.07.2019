using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Observable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> persons = new ObservableCollection<Person>();
        public MainWindow()
        {
            persons.Add(new Person() { Name = "a" });
            persons.Add(new Person() { Name = "b" });
            persons.Add(new Person() { Name = "c" });
            InitializeComponent();

            this.DataContext = persons;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            persons[0].Name = "????"; // will not be updated!

            persons.Add(new Person() { Name = "d" });
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
