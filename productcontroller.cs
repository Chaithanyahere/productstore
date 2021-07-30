using System;
using System.Collections.Generic;
using System.Text;

namespace productstore
{
    class productcontroller
    {
       
        
        private List<product> products;
        public productcontroller()
        {
            products = new List<product>();
        }
        public void addItem(product product)
        {
            products.Add(product);
        }
        public void display()
        {
            foreach (product p in products)
            {
                Console.WriteLine("------------");
                Console.WriteLine("id:" + p.id);
                Console.WriteLine("Name:" + p.name);
                Console.WriteLine("price:" + p.price);
                Console.WriteLine("model:" + p.model);
                Console.WriteLine("color:" + p.color);

                Console.WriteLine("------------");

            }

        }

    }

}
