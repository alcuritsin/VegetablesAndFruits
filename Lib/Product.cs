namespace Lib
{
    public class Product
    {
        // Enum для SQL очень спорный вариант.
        // Поэтому было принято решение от него отказаться.
        // Но так как по условиям задания создаётся однотабличная БД,
        // то тип и цвет будем хранить в виде текста.
        // Хотя это и нарушает правило единообразия значений...
        
        // public enum TypeProduct
        // {
        //     Vegetable,
        //     Fruit
        // }
        // public enum ColorProduct
        // {
        //     Red, Green, Orange, Yellow, Purple
        // }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int EnergyValue { get; set; }
        
    }
}