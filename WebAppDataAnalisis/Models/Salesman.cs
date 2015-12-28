
namespace WebAppDataAnalisis.Models
{
    public class Salesman
    {
        public string cod;
        public string cpf;
        public string name;
        public double salary;

        public Salesman(string _cod, string _cpf, string _name, double _salary)
        {
            cod = _cod;
            cpf = _cpf;
            name = _name;
            salary = _salary;
        }
    }
}