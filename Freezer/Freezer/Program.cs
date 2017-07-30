using Freezer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freezer
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            Product p1 = new Product
            {
                Name = "Test",
                ManufactureDate = new DateTime(2007, 2, 2)
            };
            context.ProductSet.Add(p1);
            context.SaveChanges(); 
        }
    }
}

