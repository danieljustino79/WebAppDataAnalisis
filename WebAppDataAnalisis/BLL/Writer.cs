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

        public ComplexType ComputeOut(ComplexType objComplex)
        {
            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "io/data/out/sales.done.dat");
            StringBuilder sb = new StringBuilder();

            try{
                using (FileStream fs = File.OpenWrite(path))
                using(BinaryWriter bw = new BinaryWriter(fs)){
                    bw.Write("oi");
                }
                
            }
            catch(Exception ex){
                
            }

            return objComplex;
        }
    }
}