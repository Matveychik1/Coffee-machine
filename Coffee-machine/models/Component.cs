//Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
//Створити програму для роботи Автомату у  режимах адмін та користувач
//У режимі адміна передбачити 	
//	Завантаження автомату водою, кава, чай, цукор
//	Вивід статистики наявності складових для приготування напоїв
//	Зміна цін на напої
//	Вилучення кешу
//У режимі користувача передбачити 		
//Замовлення напою(+ оплата)	

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
