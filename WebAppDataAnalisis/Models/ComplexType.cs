using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppDataAnalisis.Models
{
    public class ComplexType
    {
        //public enum Cod
        //{
        //    [Description("001")]
        //    Salesman,
        //    Customer,
        //    Sales
        //};

        public int amountOfClients;
        public int amountOfSalesman;
        public string idOfMostSale;
        public string worstSalesman;

        public List<Salesman> listSalesman = new List<Salesman>();
        public List<Customer> listCustomer = new List<Customer>();
        public List<Sales> listSales = new List<Sales>();

        public List<string> errors = new List<string>();

        public ComplexType() { }
    }
}