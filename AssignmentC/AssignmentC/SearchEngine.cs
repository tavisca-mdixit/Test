using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AssignmentC
{
    public class SearchEngine
    {
    
        public List<Itinerary> Process(List<Itinerary> discounted)
        {
            if(discounted == null)
                throw new ArgumentException();

            for (int index = 0; index < discounted.Count; index++)
            {
                weightGeneration(discounted[index]);
            }
            return discounted.OrderByDescending(weight => weight.Weigth).ToList();
        }
        private void weightGeneration(Itinerary itinerary)
        {

            if (itinerary == null)
                throw new ArgumentException();

            Weights weight = new Weights();
            weight.Price(itinerary);
            weight.CheckMarkup(itinerary);
            weight.IsSouthWestCarrier(itinerary);
            weight.IsAirlineOfMonth(itinerary);
            weight.IsSpiritAirways(itinerary);
            weight.NumberOfStops(itinerary);
            weight.IsMonthDecember(itinerary);
        }
    }
}

