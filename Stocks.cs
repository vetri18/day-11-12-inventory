using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksInventory
{
    public class Stocks
    {

        public List<StocksModel> Textile;
        public List<StocksModel> Paper;
        public List<StocksModel> Packaging;

        private int textilePrice = 0;
        private int PaperPrice = 0;
        private int PackagingPrice = 0;

        public string GetTextilePrice()
        {
            return textilePrice.ToString();
        }

        public string GetPaperPrice()
        {
            return PaperPrice.ToString();
        }

        public string GetPackagingPrice()
        {
            return PackagingPrice.ToString();
        }


        public string GetInventoryTotalValue()
        {
            textilePrice = 0;
            PaperPrice = 0;
            PackagingPrice = 0;

            foreach (var textile in Textile)
            {
                textilePrice += textile.shares * textile.price;
            }
            //Console.WriteLine("Total value of Textile: "+ textilePrice);
            //pulses
            foreach (var paper in Paper)
            {
                PaperPrice += paper.shares * paper.price;
            }
            // Console.WriteLine("Total value of Paper: " + PaperPrice);

            //Wheats
            foreach (var packaging in Packaging)
            {
                PackagingPrice += packaging.shares * packaging.price;
            }
            //Console.WriteLine("Total value of Packaging: " + PackagingPrice);

            return (textilePrice + PaperPrice + PackagingPrice).ToString();
        }

    }
}