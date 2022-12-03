using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Store_Boxes
{
    class Box
    {
        public string SerialNum { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }
        public double ItemPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split().ToArray();

                string serialNum = commandArgs[0];
                string item = commandArgs[1];
                int itemQuantity = int.Parse(commandArgs[2]);
                double itemPrice = double.Parse(commandArgs[3]);

                Box box = new Box()
                {
                    SerialNum = serialNum,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    ItemPrice = itemPrice,
                    BoxPrice = itemQuantity * itemPrice
                };

                boxes.Add(box);
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNum);
                Console.WriteLine($"-- {box.Item} - ${box.ItemPrice:f2}: { box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }

    }

}
