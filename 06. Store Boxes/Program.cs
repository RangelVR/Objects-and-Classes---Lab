
string[] info = Console.ReadLine().Split().ToArray();

List<Box> boxes = new List<Box>();

while (info[0] != "end")
{
    string seriaNumber = info[0];
    string item = info[1];
    int quantity = int.Parse(info[2]);
    decimal price = decimal.Parse(info[3]);

    Item currItem = new Item
    {
        Name = item,
        Price = price
    };

    Box currBox = new Box
    {
        SerialNumber = seriaNumber,
        Item = currItem,
        ItemQuantity = quantity,
        Price = quantity * price
    };

    boxes.Add(currBox);

    info = Console.ReadLine().Split();
}

foreach (Box box in boxes.OrderByDescending(x => x.Price))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.Price:f2}");
}


class Box
{
    public string SerialNumber { get; set; }

    public Item Item { get; set;}

    public int ItemQuantity { get; set; }

    public decimal Price { get; set; } 
}

class Item
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}
