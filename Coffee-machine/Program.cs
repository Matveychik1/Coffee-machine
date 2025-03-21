//Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
//Створити програму для роботи Автомату у  режимах адмін та користувач
//У режимі адміна передбачити 	
//	Завантаження автомату водою, кава, чай, цукор
//	Вивід статистики наявності складових для приготування напоїв
//	Зміна цін на напої
//	Вилучення кешу
//У режимі користувача передбачити 		
//Замовлення напою(+ оплата)	

using System.Diagnostics;
using System.Text.Json;
using System.Xml.Linq;
List<Drink> items = new()
{
    new Drink() { Name = "COFFE", Price = 230230, Volume = 20 },
    new Drink() { Name = "CANADIANO", Price = 230230, Volume = 20 },
    new Drink() { Name = "KAVA", Price = 230230, Volume = 20 },
};

List<Component> Components = new()
{
    new Component() { Name = "COFFE", Weight=30 },
    new Component() { Name ="Water", Weight=30 },
};
while (true)
{
    Console.Clear();

    Console.WriteLine("--------------------------Hot drinks machine--------------------------");
    Console.WriteLine("[[[[[ ADMIN MENU ]]]]]\r\n" +
        "1.Loading the machine with water, coffee, tea, sugar\r\n" +
        "2.Output of statistics on the availability of ingredients for making drinks\r\n" +
        "3.Change in prices for drinks\r\n" +
        "4.Add new drink\r\n" +
        "5.Removing the cache\r\n" +
        "6.Save Drinks\n" +
        "7.Show Drink\r\n" +
        "8.Show Componens\r\n" +
        "9.Find Drink\r\n" +
        "10.Load Drinks\n" +
        "----------------------------------------------------------------------");


    Console.Write("Your choice:");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Component newItem = new();
            newItem.ReadFromConsole();
            Components.Add(newItem);
            break;
        case 4:
            Drink newItem2 = new();
            newItem2.ReadFromConsole();
            items.Add(newItem2);
            break;
        case 6:
            var json = JsonSerializer.Serialize(items);
            File.WriteAllText("database.json", json);
            break;

        case 7:
            foreach (Drink item in items)
                item.Show();
            break;
        case 8:
            foreach (Component item in Components)
                item.Show();
            break;

        case 9:
            Console.Write("Enter product name to search: ");
            string name = Console.ReadLine();

            // логіка пошуку продукта
            var found = items.Find(x => x.Name == name);
            if (found == null)
            {
                Console.WriteLine("Product not found!");
                break;
            }

            found.Show();
            break;
        case 10:
            var jsonData = File.ReadAllText("database.json");
            items = JsonSerializer.Deserialize<List<Drink>>(jsonData);
            break;
    }
    Console.WriteLine("Натистінь щось для продовження...");
    Console.ReadKey();
}

public class Drink
{
    public string Name { get; set; }       
    public double Price { get; set; } 
    public double Volume { get; set; }
    public void ReadFromConsole()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();
        Console.Write("Enter price: ");
        Price = double.Parse(Console.ReadLine());
        Console.Write("Enter volume:");
        Volume = double.Parse(Console.ReadLine());
    }
    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}$");
        Console.WriteLine($"Volume:{Volume}(ml)");
    }
}


public class Component

{
    public string Name { get; set; }
    public double Weight { get; set; }
    
public void ReadFromConsole()
{
    Console.Write("Enter name: ");
    Name = Console.ReadLine();
    Console.Write("Enter Weight: ");
    Weight = double.Parse(Console.ReadLine());
}
public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Weight: {Weight}(mg)"); 
    }
}
