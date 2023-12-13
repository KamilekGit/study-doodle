namespace Clock.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string image {  get; set; }
        public ushort price {  get; set; }
        public bool IsFav {  get; set; }
        public bool available {  get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
