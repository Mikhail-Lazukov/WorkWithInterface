using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithInterface
{
    class Stationery : IProduction
    {
        public int Volume { get; set; }
        public int DefectiveVolume { get; set; }
        public string Name { get; set; }

        public Stationery()
        {
            Volume = 0;
            DefectiveVolume = 0;
            Name = "Неизвестный продукт";
        }

        public Stationery(int volume, int defectiveVolume, string name)
        {
            Volume = volume;
            DefectiveVolume = defectiveVolume;
            Name = name;
        }

        public double PercentOfDefectiveProduct(int volume, int defectiveVolume)
        {
            Volume = volume;
            DefectiveVolume = defectiveVolume;
            if (Volume > 0)
                return DefectiveVolume * 100 / Volume;
            else
                return 0;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Название канцелярского товара: {Name} \n" +
                $"Объем продукции: {Volume}\n" +
                $"Объем бракованной продукции: {DefectiveVolume}");
            if (!double.IsNaN(PercentOfDefectiveProduct(Volume, DefectiveVolume)))
            {
                Console.WriteLine("Процент бракованной продукции: " + PercentOfDefectiveProduct(Volume, DefectiveVolume) + "%\n");
            }
        }
    }
}
