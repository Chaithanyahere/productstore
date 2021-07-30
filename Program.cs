using System;
using System.Collections.Generic;

namespace productstore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> products = new List<product>();
            productcontroller controller = new productcontroller();
            Console.WriteLine("---------PRODUCT STORE----------\n");
            bool showmenu = true;
            Console.WriteLine("----------car store----\n");
            while (showmenu)
            {
                Console.WriteLine("----------Select a option------\n");
                Console.WriteLine("----------1.Add Product----\n");
                Console.WriteLine("----------2.Display all Product----\n");
                Console.WriteLine("----------3.Delect a Product----\n");
                Console.WriteLine("----------4.Exit----\n");
                Console.WriteLine("----------Enter a option----\n");
                int key = Int32.Parse(Console.ReadLine());

                if (key == 1)
                {

                    Console.WriteLine("Enter product id:");
                    int id = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter product name:");
                    String name = (Console.ReadLine());

                    Console.WriteLine("Enter product price:");
                    int price = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter product model:");
                    String model = (Console.ReadLine());

                    Console.WriteLine("Enter product color:");
                    String color = (Console.ReadLine());


                    controller.addItem(new product(){id = id, name = name, price = price, model = model, color =color});
                    Console.WriteLine("Product added successfully");
                    Console.ReadLine(); 

                }
                else if (key == 2)
                {
                    controller.display();
                    Console.ReadLine();
                }
                else if (key == 3)
                {
                    Console.WriteLine("Enter a product id:");
                    int index =Int32.Parse(Console.ReadLine());
                    products.RemoveAt(index);
                    Console.WriteLine("Product delected successfully");
                    Console.ReadLine();
                }
                else if (key == 4)
                {
                    Environment.Exit(0);
                }
            }
        }
    }

}
        
    

