using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentC.Tests
{
    [TestClass]
    public class SearchEngineTest
    {
        [TestMethod]
        public void SpiritAirwaysTestTrue()
        {
            SearchEngine search = new SearchEngine();
            List<Itinerary> itineraryList = new List<Itinerary>();
            List<Itinerary> itineraryListTwo = new List<Itinerary>();
            Itinerary obj = new Itinerary();
            Itinerary obj1 = new Itinerary();
            Itinerary obj2 = new Itinerary();
            Itinerary obj3 = new Itinerary();


            obj.OriginAirportCode = "Dallas";
            obj.DestinationAirportCode = "JFK";
            obj.FlightTime = TimeSpan.Zero;
            obj.NumberOfStops = 2;
            obj.TotalLayoverTime = TimeSpan.Zero;
            obj.Airline = "DeltaAirways";
            obj.UtcDepartureTime = new DateTime(2008, 6, 19, 7, 0, 0);
            obj.UtcArrivalTime = new DateTime(2008, 6, 20, 7, 0, 0);
            obj.BaseFareInUSD = 190;
            obj.MarkupInUSD = 10;

            itineraryList.Add(obj);

            obj1.OriginAirportCode = "Dallas";
            obj1.DestinationAirportCode = "JFK";
            obj1.FlightTime = TimeSpan.Zero;
            obj1.NumberOfStops = 5;
            obj1.TotalLayoverTime = TimeSpan.Zero;
            obj1.Airline = "SouthWestAirways";
            obj1.UtcDepartureTime = new DateTime(2008, 6, 19, 7, 0, 0);
            obj1.UtcArrivalTime = new DateTime(2008, 6, 20, 7, 0, 0);
            obj1.BaseFareInUSD = 180;
            obj1.MarkupInUSD = 36;

            itineraryList.Add(obj1);

            obj2.OriginAirportCode = "Dallas";
            obj2.DestinationAirportCode = "JFK";
            obj2.FlightTime = TimeSpan.Zero;
            obj2.NumberOfStops = 5;
            obj2.TotalLayoverTime = TimeSpan.Zero;
            obj2.Airline = "SpiritAirways";
            obj2.UtcDepartureTime = new DateTime(2015, 12, 4, 7, 0, 0);
            obj2.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
            obj2.BaseFareInUSD = 180;
            obj2.MarkupInUSD = 36;

            itineraryList.Add(obj2);

            obj3.OriginAirportCode = "Dallas";
            obj3.DestinationAirportCode = "JFK";
            obj3.FlightTime = TimeSpan.Zero;
            obj3.NumberOfStops = 5;
            obj3.TotalLayoverTime = TimeSpan.Zero;
            obj3.Airline = "SpiritAirways";
            obj3.UtcDepartureTime = new DateTime(2015, 8, 7, 7, 0, 0);
            obj3.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
            obj3.BaseFareInUSD = 180;
            obj3.MarkupInUSD = 36;

            itineraryList.Add(obj3);

            List<Itinerary> newList = search.Process(itineraryList);

            itineraryListTwo.Add(obj1);
            itineraryListTwo.Add(obj2);
            itineraryListTwo.Add(obj);
            itineraryListTwo.Add(obj3);
            
            CollectionAssert.AreEqual(newList, itineraryListTwo);
        }
           [TestMethod]
        public void SpiritAirwaysTestFalse()
        {
            SearchEngine search = new SearchEngine();
            List<Itinerary> itineraryList = new List<Itinerary>();
            List<Itinerary> itineraryListTwo = new List<Itinerary>();
            Itinerary obj = new Itinerary();
            Itinerary obj1 = new Itinerary();
            Itinerary obj2 = new Itinerary();
            Itinerary obj3 = new Itinerary();


            obj.OriginAirportCode = "Dallas";
            obj.DestinationAirportCode = "JFK";
            obj.FlightTime = TimeSpan.Zero;
            obj.NumberOfStops = 2;
            obj.TotalLayoverTime = TimeSpan.Zero;
            obj.Airline = "SpiritAirways";
            obj.UtcDepartureTime = new DateTime(2008, 6, 19, 7, 0, 0);
            obj.UtcArrivalTime = new DateTime(2008, 6, 20, 7, 0, 0);
            obj.BaseFareInUSD = 190;
            obj.MarkupInUSD = 10;

            itineraryList.Add(obj);

            obj1.OriginAirportCode = "Dallas";
            obj1.DestinationAirportCode = "JFK";
            obj1.FlightTime = TimeSpan.Zero;
            obj1.NumberOfStops = 5;
            obj1.TotalLayoverTime = TimeSpan.Zero;
            obj1.Airline = "SouthWestAirways";
            obj1.UtcDepartureTime = new DateTime(2008, 6, 19, 7, 0, 0);
            obj1.UtcArrivalTime = new DateTime(2008, 6, 20, 7, 0, 0);
            obj1.BaseFareInUSD = 180;
            obj1.MarkupInUSD = 36;

            itineraryList.Add(obj1);

            obj2.OriginAirportCode = "Dallas";
            obj2.DestinationAirportCode = "JFK";
            obj2.FlightTime = TimeSpan.Zero;
            obj2.NumberOfStops = 5;
            obj2.TotalLayoverTime = TimeSpan.Zero;
            obj2.Airline = "SpiritAirways";
            obj2.UtcDepartureTime = new DateTime(2015, 12, 4, 7, 0, 0);
            obj2.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
            obj2.BaseFareInUSD = 180;
            obj2.MarkupInUSD = 36;

            itineraryList.Add(obj2);

            obj3.OriginAirportCode = "Dallas";
            obj3.DestinationAirportCode = "JFK";
            obj3.FlightTime = TimeSpan.Zero;
            obj3.NumberOfStops = 5;
            obj3.TotalLayoverTime = TimeSpan.Zero;
            obj3.Airline = "SpiritAirways";
            obj3.UtcDepartureTime = new DateTime(2015, 8, 7, 7, 0, 0);
            obj3.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
            obj3.BaseFareInUSD = 180;
            obj3.MarkupInUSD = 36;

            itineraryList.Add(obj3);

            List<Itinerary> newList = search.Process(itineraryList);

            itineraryListTwo.Add(obj1);
            itineraryListTwo.Add(obj);
            itineraryListTwo.Add(obj2);
            itineraryListTwo.Add(obj3);
            
            CollectionAssert.AreNotEqual(newList, itineraryListTwo);
        }

           [TestMethod]
           public void DeltaAirwaysHolidayOfferTestTrue()
           {
               SearchEngine search = new SearchEngine();
               List<Itinerary> itineraryList = new List<Itinerary>();
               List<Itinerary> itineraryListTwo = new List<Itinerary>();
               Itinerary obj = new Itinerary();
               Itinerary obj1 = new Itinerary();
               Itinerary obj2 = new Itinerary();
               Itinerary obj3 = new Itinerary();


               obj.OriginAirportCode = "Dallas";
               obj.DestinationAirportCode = "JFK";
               obj.FlightTime = TimeSpan.Zero;
               obj.NumberOfStops = 2;
               obj.TotalLayoverTime = TimeSpan.Zero;
               obj.Airline = "DeltaAirways";
               obj.UtcDepartureTime = new DateTime(2008, 12, 12, 7, 0, 0);
               obj.UtcArrivalTime = new DateTime(2008, 6, 7, 7, 0, 0);
               obj.UtcReturnFlighTime = new DateTime(2008, 12, 17, 7, 0, 0);
             
               obj.BaseFareInUSD = 190;
               obj.MarkupInUSD = 10;

               itineraryList.Add(obj);

               obj1.OriginAirportCode = "Washington";
               obj1.DestinationAirportCode = "Dallas";
               obj1.FlightTime = TimeSpan.Zero;
               obj1.NumberOfStops = 5;
               obj1.TotalLayoverTime = TimeSpan.Zero;
               obj1.Airline = "DeltaAirways";
               obj1.UtcDepartureTime = new DateTime(2008, 6, 1, 7, 0, 0);
               obj1.UtcArrivalTime = new DateTime(2008, 6, 2, 7, 0, 0);
               obj1.BaseFareInUSD = 180;
               obj1.MarkupInUSD = 36;

               itineraryList.Add(obj1);

               obj2.OriginAirportCode = "Newark";
               obj2.DestinationAirportCode = "JFK";
               obj2.FlightTime = TimeSpan.Zero;
               obj2.NumberOfStops = 5;
               obj2.TotalLayoverTime = TimeSpan.Zero;
               obj2.Airline = "SpiritAirways";
               obj2.UtcDepartureTime = new DateTime(2015, 12, 4, 7, 0, 0);
               obj2.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
               obj2.BaseFareInUSD = 180;
               obj2.MarkupInUSD = 36;

               itineraryList.Add(obj2);

               obj3.OriginAirportCode = "Newark";
               obj3.DestinationAirportCode = "DC";
               obj3.FlightTime = TimeSpan.Zero;
               obj3.NumberOfStops = 5;
               obj3.TotalLayoverTime = TimeSpan.Zero;
               obj3.Airline = "SpiritAirways";
               obj3.UtcDepartureTime = new DateTime(2015, 8, 7, 7, 0, 0);
               obj3.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
               obj3.BaseFareInUSD = 180;
               obj3.MarkupInUSD = 36;

               itineraryList.Add(obj3);

               List<Itinerary> newList = search.Process(itineraryList);

               itineraryListTwo.Add(obj);
               itineraryListTwo.Add(obj2);
               itineraryListTwo.Add(obj1);
               itineraryListTwo.Add(obj3);

               CollectionAssert.AreEqual(newList, itineraryListTwo);
           }

           [TestMethod]
           public void DeltaAirwaysHolidayOfferTestFalse()
           {
               SearchEngine search = new SearchEngine();
               List<Itinerary> itineraryList = new List<Itinerary>();
               List<Itinerary> itineraryListTwo = new List<Itinerary>();
               Itinerary obj = new Itinerary();
               Itinerary obj1 = new Itinerary();
               Itinerary obj2 = new Itinerary();
               Itinerary obj3 = new Itinerary();


               obj.OriginAirportCode = "Dallas";
               obj.DestinationAirportCode = "JFK";
               obj.FlightTime = TimeSpan.Zero;
               obj.NumberOfStops = 2;
               obj.TotalLayoverTime = TimeSpan.Zero;
               obj.Airline = "DeltaAirways";
               obj.UtcDepartureTime = new DateTime(2008, 12, 12, 7, 0, 0);
               obj.UtcArrivalTime = new DateTime(2008, 6, 7, 7, 0, 0);
               obj.UtcReturnFlighTime = new DateTime(2008, 12, 17, 7, 0, 0);

               obj.BaseFareInUSD = 190;
               obj.MarkupInUSD = 10;

               itineraryList.Add(obj);

               obj1.OriginAirportCode = "Washington";
               obj1.DestinationAirportCode = "Dallas";
               obj1.FlightTime = TimeSpan.Zero;
               obj1.NumberOfStops = 5;
               obj1.TotalLayoverTime = TimeSpan.Zero;
               obj1.Airline = "DeltaAirways";
               obj1.UtcDepartureTime = new DateTime(2008, 6, 1, 7, 0, 0);
               obj1.UtcArrivalTime = new DateTime(2008, 6, 2, 7, 0, 0);
               obj1.BaseFareInUSD = 180;
               obj1.MarkupInUSD = 36;

               itineraryList.Add(obj1);

               obj2.OriginAirportCode = "Newark";
               obj2.DestinationAirportCode = "JFK";
               obj2.FlightTime = TimeSpan.Zero;
               obj2.NumberOfStops = 5;
               obj2.TotalLayoverTime = TimeSpan.Zero;
               obj2.Airline = "SpiritAirways";
               obj2.UtcDepartureTime = new DateTime(2015, 12, 4, 7, 0, 0);
               obj2.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
               obj2.BaseFareInUSD = 180;
               obj2.MarkupInUSD = 36;

               itineraryList.Add(obj2);

               obj3.OriginAirportCode = "Newark";
               obj3.DestinationAirportCode = "DC";
               obj3.FlightTime = TimeSpan.Zero;
               obj3.NumberOfStops = 5;
               obj3.TotalLayoverTime = TimeSpan.Zero;
               obj3.Airline = "SpiritAirways";
               obj3.UtcDepartureTime = new DateTime(2015, 8, 7, 7, 0, 0);
               obj3.UtcArrivalTime = new DateTime(2008, 9, 8, 7, 0, 0);
               obj3.BaseFareInUSD = 180;
               obj3.MarkupInUSD = 36;

               itineraryList.Add(obj3);

               List<Itinerary> newList = search.Process(itineraryList);

               itineraryListTwo.Add(obj);
               itineraryListTwo.Add(obj1);
               itineraryListTwo.Add(obj2);
               itineraryListTwo.Add(obj3);

               CollectionAssert.AreNotEqual(newList, itineraryListTwo);
           }

    }
}
