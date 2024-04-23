namespace GoodDeedsDestinationsAPI.Models
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }

        public ICollection<Traveller> Traveller { get; set; }

    }
}
