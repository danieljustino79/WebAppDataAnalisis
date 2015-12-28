
namespace WebAppDataAnalisis.Models
{
    public class Customer
    {
        public string cod;
        public string cnpj;
        public string name;
        public string businessArea;

        public Customer(string _cod, string _cnpj, string _name, string _businessArea)
        {
            cod = _cod;
            cnpj = _cnpj;
            name = _name;
            businessArea = _businessArea;
        }
    }
}