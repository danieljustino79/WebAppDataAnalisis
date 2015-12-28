
namespace WebAppDataAnalisis.Models
{
    public class Item
    {
        public int id;
        public int quantity;
        public double price;

        public Item(int _id, int _quantity, double _price)
        {
            id = _id;
            quantity = _quantity;
            price = _price;

        }
    }
}