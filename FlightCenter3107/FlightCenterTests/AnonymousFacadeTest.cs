using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FligthCenterCore;

namespace FlightCenterTests
{
    [TestClass]
    public class AnonymousFacadeTest
    {
        [TestMethod]
        public void AnonymouseFacade_GetFlightById_FlightFound()
        {
            AnonymouseFacade facade = FlightCenterSystem.GetInstacne().GetAnonymousFacade();

            Flight f = facade.GetFlightById(TestResource.AnonymouseFacade_GetFlightById_FlightFound_FLIGHT_ID);

            Assert.AreNotEqual(f, null);

            Assert.AreEqual(f.Id, TestResource.AnonymouseFacade_GetFlightById_FlightFound_FLIGHT_ID);
            Assert.AreEqual(f.Name, TestResource.AnonymouseFacade_GetFlightById_NAME);
            Assert.AreEqual(f.Vacancy, TestResource.AnonymouseFacade_GetFlightById_VACANCY);

        }
    }
}
