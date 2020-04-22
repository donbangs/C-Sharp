
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przetwarzanie_CSV
{
    public class Car
    {
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined { get; set; }

    
        internal static Car TransformToCar(string line)
        {
             string[] columns = line.Split(',');

            return new Car
                {
                    Year = int.Parse(Convert.ToString(columns[0])),
                    Manufacturer = Convert.ToString(columns[1]),
                    Name = Convert.ToString(columns[2]),
                    Displacement = double.Parse(Convert.ToString(columns[3])),
                    Cylinders = int.Parse(Convert.ToString(columns[4])),
                    City = int.Parse(Convert.ToString(columns[5])),
                    Highway = int.Parse(Convert.ToString(columns[6])),
                    Combined = int.Parse(Convert.ToString(columns[7]))

                };
            
            
           
        }
    }
}
