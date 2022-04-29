namespace MVCVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
