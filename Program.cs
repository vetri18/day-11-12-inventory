namespace StocksInventory
{
    class Program
    {
        public static void Main(string[] args)
        {
            StockPortfolio stockPortfolio = new StockPortfolio();
            string filepath = ".\\..\\..\\..\\JSONDATA.json";

            Stocks inventory = stockPortfolio.ReadFromFile(filepath);

            Console.WriteLine("Total Stocks value: " + stockPortfolio.GetInventoryTotalValue());

            Console.WriteLine("Total Textile stocks price: " + stockPortfolio.m_inventoryFactory.GetTextilePrice());
            Console.WriteLine("Total Paper stocks price: " + stockPortfolio.m_inventoryFactory.GetPaperPrice());
            Console.WriteLine("Total Packaging stocks price: " + stockPortfolio.m_inventoryFactory.GetPackagingPrice());
        }
    }
}