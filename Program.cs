namespace Inventory
{
    class InventoryManager
    {
        public static void Main(string[] args)
        {
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();

            string filepath = "C:\\source\\repos\\BridgeLabz\\CSharp\\TestJason\\TestJason\\Data.json";
            int total_Price;
            InventoryFactory dataRice = fetchInventoryDetails.ReadRice(filepath);
            Console.WriteLine("Name of the Rice : " + dataRice.typesofRice.name);
            Console.WriteLine("Price per Kg : " + dataRice.typesofRice.price);
            Console.WriteLine("Weight of the Rice Bag : " + dataRice.typesofRice.weight);
            total_Price = dataRice.typesofRice.price * dataRice.typesofRice.weight;
            Console.WriteLine("Total Price of the Bag : " + total_Price);

            Console.WriteLine("-----------------------------------");

            InventoryFactory dataWheat = fetchInventoryDetails.ReadWheat(filepath);
            Console.WriteLine("Name of the Wheat : " + dataWheat.typesofWheat.name);
            Console.WriteLine("Price per Kg : " + dataWheat.typesofWheat.price);
            Console.WriteLine("Weight of the Wheat Bag : " + dataWheat.typesofWheat.weight);
            total_Price = dataRice.typesofWheat.price * dataRice.typesofWheat.weight;
            Console.WriteLine("Total Price of the Bag : " + total_Price);

            Console.WriteLine("-----------------------------------");

            InventoryFactory dataPulse = fetchInventoryDetails.ReadPulse(filepath);
            Console.WriteLine("Name of the Wheat : " + dataPulse.typesofPulse.name);
            Console.WriteLine("Price per Kg : " + dataPulse.typesofPulse.price);
            Console.WriteLine("Weight of the Wheat Bag : " + dataPulse.typesofPulse.weight);
            total_Price = dataRice.typesofPulse.price * dataRice.typesofPulse.weight;
            Console.WriteLine("Total Price of the Bag : " + total_Price);

            Console.WriteLine("-----------------------------------");
        }
    }
}