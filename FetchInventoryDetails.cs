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
        public Food ReadRice(string path)
        {
            using (StreamReader file = new StreamReader(path))  // Using -- keyword will close the file as soon as the end of the scope reached
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<Food>(json);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public Food ReadWheat(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Food>(json);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public Food ReadPulse(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Food>(json);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}