using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class FetchInventoryDetails
    {
        public InventoryFactory ReadRice(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryFactory>(json);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public InventoryFactory ReadWheat(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryFactory>(json);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public InventoryFactory ReadPulse(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryFactory>(json);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}