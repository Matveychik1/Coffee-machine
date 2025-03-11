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
using System.Xml.Linq;

var item = new Drink();


while (true)
{
    Console.Clear();

    Console.WriteLine("--------------------------Hot drinks machine--------------------------");
    Console.WriteLine("[[[[[ ADMIN MENU ]]]]]\r\n" +
        "1.Loading the machine with water, coffee, tea, sugar\r\n" +
        "2.Output of statistics on the availability of ingredients for making drinks\r\n" +
        "3.Change in prices for drinks\r\n" +
        "4.Removing the cache\r\n" +
        "5.Save Settings\r\n" +
        "6.Show All\r\n" +
        "----------------------------------------------------------------------");


    Console.Write("Your choice:");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            item.ReadFromConsole();
            break;

        case 6:
            item.Show();
            break;
    }
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
        Console.WriteLine($"Volume:{Volume}$");
    }
}


public class Component
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Weight: {Weight}"); 
    }
}
