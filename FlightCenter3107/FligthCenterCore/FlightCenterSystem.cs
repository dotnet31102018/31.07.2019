using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FligthCenterCore
{
    public class FlightCenterSystem
    {
        private FlightCenterSystem()
        {

        }

        // shortcut - not real code!!!!!!!!!!!
        public static FlightCenterSystem GetInstacne()
        {
            return new FlightCenterSystem();
        }

        public AnonymouseFacade GetAnonymousFacade()
        {
            return new AnonymouseFacade();
        }
    }
}
