using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using WebAppDataAnalisis.Models;

namespace WebAppDataAnalisis.BLL
{
    public class Writer
    {

        public ComplexType ComputeOut(ComplexType complexType)
        {
            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "data/out/sales.done.dat");
            StringBuilder sb = new StringBuilder();
            string newLine = Environment.NewLine;

            int max = MostExpensiveSale(complexType);

            sb.Append(string.Format(">{0}{1}", 
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                newLine));
            sb.Append(string.Format("Amount of clients: {0}{1}", 
                complexType.amountOfClients,
                newLine));
            sb.Append(string.Format("Amount of salesman: {0}{1}",
                complexType.amountOfSalesman,
                newLine));
            sb.Append(string.Format("Most expensive sale: {0}{1}",
                MostExpensiveSale(complexType), newLine));
            sb.Append(string.Format("Worst salesman: {0}{1}", 
                WorstSalesman(complexType), newLine));


            try{
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(sb);
                }                
            }
            catch(Exception ex){
                
            }

            return complexType;
        }

        public int MostExpensiveSale(ComplexType complexType)
        {
            var res = (complexType.listSales.
                SelectMany(c => c.item, (c, p) => new { res = (p.price * p.quantity), p.salesId, c.salesmanName })
                .OrderByDescending(x => x.res)
                ).First();

            return res.salesId;
        }

        public string WorstSalesman(ComplexType complexType){
            var res = (complexType.listSales
                .SelectMany(c => c.item, (c, p) => new { res = (p.price * p.quantity), p.salesId, c.salesmanName })
                .OrderBy(x => x.res)
                ).First();
            return res.salesmanName;
        }
    }
}