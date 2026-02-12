namespace rest_laptop.model
{
    public class Laptop
    {
        public int Id { get; set; }
        public int price { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Price: {price}, Model: {Model}";
        }
    }
}
