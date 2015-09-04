using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC
{
    public class Weights
    {

        public void Price(Itinerary itinerary)
        {
            itinerary.Weigth += itinerary.TotalFareInUSD;
        }

        public void IsSouthWestCarrier(Itinerary itinerary)
        {
            if (itinerary.Airline == "SouthWestAirways" && itinerary.OriginAirportCode == "Dallas") itinerary.Weigth += 1000;
        }

        public void CheckMarkup(Itinerary itinerary)
        {
            if (itinerary.BaseFareInUSD == 0) throw new ArgumentException();

            if (itinerary.MarkupInUSD > 0 && itinerary.MarkupInUSD <= (itinerary.BaseFareInUSD / 10)) itinerary.Weigth += 1000;

            if (itinerary.MarkupInUSD > itinerary.BaseFareInUSD / 10 && itinerary.MarkupInUSD <= (itinerary.BaseFareInUSD / 20)) itinerary.Weigth += 2000;

            if (itinerary.MarkupInUSD > itinerary.BaseFareInUSD / 20 && itinerary.MarkupInUSD <= (itinerary.BaseFareInUSD / 30)) itinerary.Weigth += 3000;
        }

        public void IsAirlineOfMonth(Itinerary itinerary)
        {
            if (itinerary.Airline == "SouthWestAirways") itinerary.Weigth += 100;
        }

        public void IsSpiritAirways(Itinerary itinerary)
        {
            if (itinerary.Airline == "SpiritAirways" && (itinerary.UtcDepartureTime - DateTime.UtcNow).Days > 3) itinerary.Weigth += 1000;
        }

        public void NumberOfStops(Itinerary itinerary)
        {

            if (itinerary.NumberOfStops < 2) itinerary.Weigth += 1000;

            if (itinerary.NumberOfStops > 2) itinerary.Weigth += 500;

            if (itinerary.NumberOfStops > 5) itinerary.Weigth += 100;
        }

        public void IsMonthDecember(Itinerary itinerary)
        {
            if (itinerary.Airline == "DeltaAirways" && itinerary.UtcDepartureTime.Month == 12 && (itinerary.UtcReturnFlighTime - itinerary.UtcDepartureTime).Days >= 5)
                itinerary.Weigth += 1000;
        }

    }
}
