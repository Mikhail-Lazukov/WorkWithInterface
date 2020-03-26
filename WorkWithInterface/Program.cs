using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            List<IProduction> goods = new List<IProduction>();

            goods.Add(new Equipment());
            goods.Add(new Equipment(123, 1, "Утюги"));
            goods.Add(new Equipment(14, 7, "Холодильники"));
            goods.Add(new Equipment(53, 6, "Печи"));
            goods.Add(new Equipment(183, 32, "Смартфоны"));

            goods.Add(new Stationery());
            goods.Add(new Stationery(10, 1, "Ручки"));
            goods.Add(new Stationery(54, 7, "Карандаши"));
            goods.Add(new Stationery(13, 6, "Ластики"));
            goods.Add(new Stationery(1183, 32, "Строгалки"));

            Info info = new Info();
            for (int i = 0; i < n; i++)
            {
                info.DisplayInfo(goods[i]);
            }

            Console.Read();
        }

    }
}
