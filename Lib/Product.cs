namespace Lib
{
    public class Product
    {
        public enum TypeProduct
        {
            Vegetable,
            Fruit
        }
        public enum ColorProduct
        {
            Red, Green, Orange, Yellow, Purple
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public TypeProduct Type { get; set; }
        public ColorProduct Color { get; set; }
        public int EnergyValue { get; set; }
        
    }
}