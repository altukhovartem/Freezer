using Freezer.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freezer.UI
{
    static class CUI
    {
        public static object Freezeraction { get; private set; }

        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Avalable Options:");
                Console.WriteLine("1 - Add New Product Into Freezer");
                Console.WriteLine("2 - Show Freezed Products");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": FreezerAction.AddNewProduct() ; break;  
                }
            }
        }

    }
}
