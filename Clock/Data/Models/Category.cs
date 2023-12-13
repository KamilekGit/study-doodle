namespace Clock.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string Desc { get; set; }
        public List<Car> Cars { get; set; }

    }
}
