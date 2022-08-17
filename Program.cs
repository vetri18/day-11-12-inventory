namespace Inventory
{
    class Program
    {
        public static void Main(string[] args)
        {
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();

            string filepath = "C:\\source\\repos\\BridgeLabz\\CSharp\\TestJason\\TestJason\\Data.json";

            Food dataRice = fetchInventoryDetails.ReadRice(filepath);
            Console.WriteLine(dataRice.typesofRice.name);
            Console.WriteLine(dataRice.typesofRice.price);
            Console.WriteLine(dataRice.typesofRice.weight);

            Console.WriteLine("-----------------------------------");

            Food dataWheat = fetchInventoryDetails.ReadWheat(filepath);
            Console.WriteLine(dataWheat.typesofWheat.name);
            Console.WriteLine(dataWheat.typesofWheat.price);
            Console.WriteLine(dataWheat.typesofWheat.weight);

            Console.WriteLine("-----------------------------------");

            Food dataPulse = fetchInventoryDetails.ReadPulse(filepath);
            Console.WriteLine(dataPulse.typesofPulse.name);
            Console.WriteLine(dataPulse.typesofPulse.price);
            Console.WriteLine(dataPulse.typesofPulse.weight);

            Console.WriteLine("-----------------------------------");

        }
    }
}