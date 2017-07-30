using Freezer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freezer.Actions
{
    static class FreezerAction
    {
        public static void AddNewProduct()
        {
            Console.Clear();
            Console.WriteLine("Add New Product");
            Console.Write("Product Name: ");
            string currentProductName = Console.ReadLine();
            Console.Write("Date of Manufacture: ");
            DateTime? currentDateOfManufacture = DateTime.Parse(Console.ReadLine());
            Console.Write("Expiration Date: ");
            DateTime? currentExpirationDate = DateTime.Parse(Console.ReadLine());

            Product currentProduct = new Product
            {
                Name = currentProductName,
                ManufactureDate = currentDateOfManufacture,
                ExpirationDate = currentExpirationDate
            };

            Context context = new Context();
            context.ProductSet.Add(currentProduct);
            context.SaveChanges();
        }

        public static void ShowProducts()
        {
            Console.Clear();
            Console.WriteLine("List of Products");
            Context context = new Context();
            foreach (Product product in context.ProductSet)
            {
                Console.WriteLine("------------");
            }
        }
    }
}
