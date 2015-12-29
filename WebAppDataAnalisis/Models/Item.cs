
namespace WebAppDataAnalisis.Models
{
    public class Item
    {
        public int id;
        public int quantity;
        public double price;
        public int salesId;

        public Item(int _salesId, int _id, int _quantity, double _price)
        {
            salesId = _salesId;
            id = _id;
            quantity = _quantity;
            price = _price;

        }
    }
}