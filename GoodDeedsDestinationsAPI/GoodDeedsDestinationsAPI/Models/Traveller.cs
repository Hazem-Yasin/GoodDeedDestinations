namespace GoodDeedsDestinationsAPI.Models
{
    public class Traveller
    {
        public int TravellerID { get; set; }

        public string TravellerName { get; set; }


        public ICollection<Destination> Destination { get; set; }
    }
}
