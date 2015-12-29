using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using WebAppDataAnalisis.Models;

namespace WebAppDataAnalisis.BLL
{
    public class Reader
    {
        protected const char separator = 'ç';

        public ComplexType ComputeIn()
        {
            ComplexType complexType;
            //---"C:/HOST/IIS/WebAppDataAnalisis/WebAppDataAnalisis/io/data/in/sales.dat"
            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "io/data/in/sales.dat");

            try
            {
                complexType = new ComplexType();
                using(StreamReader sr = new
                    StreamReader(path, Encoding.GetEncoding("iso-8859-1")))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(separator);
                        string cod = values[0];

                        switch (cod)
                        {
                            case ("001"):
                                Salesman salesman = new Salesman(cod, values[1], values[2], double.Parse(values[3]));
                                complexType.listSalesman.Add(salesman);
                                break;
                            case ("002"):
                                Customer customer = new Customer(cod, values[1], values[2], values[3]);
                                complexType.listCustomer.Add(customer);
                                break;
                            case("003"):
                                var itensWrapped = values[2];
                                itensWrapped = itensWrapped.Replace("[", "").Replace("]", "");
                                string[] itemComplex = itensWrapped.Split(',');

                                Item item;
                                List<Item> listItem = new List<Item>();
                                foreach (var ic in itemComplex)
	                            {
                                    var temp = ic.Split('-');
                                    item = new Item(int.Parse(temp[0]), int.Parse(temp[1]), double.Parse(temp[2]));
                                    listItem.Add(item);
	                            }

                                Sales sales = new Sales(values[0], listItem, values[2]);
                                complexType.listSales.Add(sales);
                                break;
                            default:
                                break;
                        }
                    }
                    
                    //---statistic with Linq
                    complexType.amountOfSalesman = complexType.listSalesman.Count;
                    complexType.amountOfClients = complexType.listCustomer.Count;

                    //complexType.amountOfClients = complexType.co

                    return complexType;
                }
            }
            catch (Exception e)
            {
                complexType = new ComplexType();
                complexType.errors.Add("The file could not be read: "+e.Message);
                return complexType;
            }
        }
    }
}