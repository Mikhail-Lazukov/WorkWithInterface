using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithInterface
{
    interface IProduction
    {
        int Volume { get; set; }
        int DefectiveVolume { get; set; }
        void DisplayInfo();
        double PercentOfDefectiveProduct(int productVolume, int defectiveProductVolume);
    }
}
