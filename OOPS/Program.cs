using OOPS.InventoryManagement;
using System;

namespace OOPS
{
    class Program
    {
        static string inventoryFilePath = @"C:\Users\91942\Desktop\Bridgelabz\OOPS\OOPS\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);
        }
    }
}
