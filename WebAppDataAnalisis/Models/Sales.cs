using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDataAnalisis.Models
{
    public class Sales
    {
        public string cod;
        public List<Item> item = new List<Item>();
        public string salesmanName;

        public Sales(string _cod, List<Item> _item, string _salesmanName)
        {
            cod = _cod;
            item = _item;
            salesmanName = _salesmanName;
        }
    }
}