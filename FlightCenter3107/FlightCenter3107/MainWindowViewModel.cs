using FligthCenterCore;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FlightCenter3107
{
    public class MainWindowViewModel
    {
        public Object FlightNumber { get; set; }

        public ICommand GetFlightCommand { get; set; }

        public Flight CurrentFlight { get; set; }

        public MainWindowViewModel()
        {
            //FlightNumber = "20";
            CurrentFlight = new Flight { Id = 1, Name = "a", Vacancy = 10 };
            GetFlightCommand = new DelegateCommand(() => { MessageBox.Show(CurrentFlight.Id.ToString()); }, () => { return true; });
        }

    }
}
