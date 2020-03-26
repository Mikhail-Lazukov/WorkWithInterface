using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithInterface
{
    class Info
    {
        public double AllowablePercentageOfDefProd { get; set; }
        public Info()
        {
            Console.WriteLine("Введите допустимый процент бракованных товаров: ");
            AllowablePercentageOfDefProd = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayInfo(IProduction production)
        {
          
            if (production.PercentOfDefectiveProduct(production.Volume, production.DefectiveVolume) > 
                AllowablePercentageOfDefProd)
            {
                production.DisplayInfo();
            }
        }
    }
}
