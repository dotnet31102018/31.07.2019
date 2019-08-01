using FligthCenterCore;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FlightCenter3107
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public DelegateCommand BuyCommand { get; set; }

        public DelegateCommand SearchFlightCommand { get; set; }

        public int FlightNumber { get; set; }

        public Flight MyFlight { get; set; }

        private AnonymouseFacade facade;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            FlightNumber = 0;

            facade = FlightCenterSystem.GetInstacne().GetAnonymousFacade();

            BuyCommand = new DelegateCommand(() => { MessageBox.Show("Buying ticket! yeah!"); }, () => { return MyFlight != null && MyFlight.Vacancy > 0; });

            SearchFlightCommand = new DelegateCommand(() => {
                MyFlight = facade.GetFlightById(FlightNumber);

                PropertyChanged(this, new PropertyChangedEventArgs("MyFlight"));

                BuyCommand.RaiseCanExecuteChanged();
            }, () => { return true; });
        }

    }
}
