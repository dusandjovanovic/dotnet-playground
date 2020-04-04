using System;
using System.Text;

namespace dotnet_shell
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock()
            {
                Name = "Stock",
                Shares = 122L
            };

            House house = new House()
            {
                Name = "House",
                Montage = 122M
            };

            Asset asset = stock;

            if (asset is Stock s && s.Shares > 100)
            {
                Console.WriteLine(s.Shares);
            }
        }
    }

    public class Asset
    {
        public string Name;

        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
    }

    public class Stock : Asset
    {
        public long Shares;
    }

    public class House : Asset
    {
        public decimal Montage;
    }
}
