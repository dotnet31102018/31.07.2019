using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FligthCenterCore
{
    public class AnonymouseFacade
    {
        private List<Flight> flights;
        public AnonymouseFacade()
        {
            flights = new List<Flight>();
            flights.Add(new Flight { Id = 1, Name = "EL AL", Vacancy = 1 });
            flights.Add(new Flight { Id = 2, Name = "ARKIYA", Vacancy = 0 });
            flights.Add(new Flight { Id = 3, Name = "American airlines", Vacancy = 23 });
            flights.Add(new Flight { Id = 4, Name = "Turkish", Vacancy = 0 });
        }
        public List<Flight> GetAllFlights()
        {
            return flights;
        }
        public Flight GetFlightById(int id)
        {
            return flights.Find((f) => { return f.Id == id; });
        }
    }
}
