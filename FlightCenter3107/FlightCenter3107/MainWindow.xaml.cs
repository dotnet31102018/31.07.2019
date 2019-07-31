using FligthCenterCore;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace FlightCenter3107
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public DelegateCommand BuyCommand { get; set; }

        public DelegateCommand SearchFlightCommand { get; set; }
        public int FlightNumber { get; set; }

        public Flight MyFLight { get; set; }

        private AnonymouseFacade facade;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            facade = FlightCenterSystem.GetInstacne().GetAnonymousFacade();

            BuyCommand = new DelegateCommand(() => { MessageBox.Show("Hello"); }, () => { return MyFLight != null && MyFLight.Vacancy > 0; });

            SearchFlightCommand = new DelegateCommand(() => {
                MyFLight = facade.GetFlightById(FlightNumber);

                BuyCommand.RaiseCanExecuteChanged();

                PropertyChanged(this, new PropertyChangedEventArgs("MyFLight"));
            }, () => { return true; });


        }

        public event PropertyChangedEventHandler PropertyChanged;

   

    }
}