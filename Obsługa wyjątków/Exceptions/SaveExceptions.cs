using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions
{
    class SaveExceptions:Exception
    {
       string sciezka = @"D:\c sharp\Exceptions\log.txt";
       public void Save(Exception ex)
        {
           
            using (StreamWriter sw = new StreamWriter(sciezka,append:true))
            {
               
                sw.Write(ex);
                sw.Write(DateTime.Now+Environment.NewLine);
                sw.Write(Environment.NewLine);
             

            }
        }
    }
}
