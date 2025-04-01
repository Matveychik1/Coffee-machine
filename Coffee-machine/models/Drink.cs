//Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
//Створити програму для роботи Автомату у  режимах адмін та користувач
//У режимі адміна передбачити 	
//	Завантаження автомату водою, кава, чай, цукор
//	Вивід статистики наявності складових для приготування напоїв
//	Зміна цін на напої
//	Вилучення кешу
//У режимі користувача передбачити 		
//Замовлення напою(+ оплата)	

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
