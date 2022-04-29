namespace MVCVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
