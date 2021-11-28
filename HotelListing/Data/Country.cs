namespace HotelListing.Data
{
    public class Country
    {
        // This is an entity 
        // The table in our db will eb countries ( plural of this class model 

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
