﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPS.InventoryManagement
{
    class InventoryDetailsManagement
    {
        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsonData);
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + "\n" + data.Price + "\n" + data.Weight);
            }
        }
    }
}
