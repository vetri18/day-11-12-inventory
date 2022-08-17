using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksInventory
{
    public class StockPortfolio
    {
        public Stocks m_inventoryFactory;
        public Stocks ReadFromFile(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    m_inventoryFactory = JsonConvert.DeserializeObject<Stocks>(json);
                    return m_inventoryFactory;
                }
                catch (Exception)
                {
                    return null;
                }

            }
        }
        public string GetInventoryTotalValue()
        {
            if (m_inventoryFactory != null)
                return m_inventoryFactory.GetInventoryTotalValue();
            return "";
        }
    }
}