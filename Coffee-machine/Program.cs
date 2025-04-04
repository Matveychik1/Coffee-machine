//Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
//Створити програму для роботи Автомату у  режимах адмін та користувач
//У режимі адміна передбачити 	
//	Завантаження автомату водою, кава, чай, цукор
//	Вивід статистики наявності складових для приготування напоїв
//	Зміна цін на напої
//	Вилучення кешу
//У режимі користувача передбачити 		
//Замовлення напою(+ оплата)	

using Coffee_machine;
using System.Diagnostics;
using System.Text.Json;
using System.Xml.Linq;

Console.OutputEncoding = System.Text.Encoding.UTF8;

CoffeeMachine1 coffee_Machine = new();

while (true)
{
    Console.Clear();

    Console.WriteLine("--------------------------Hot drinks machine--------------------------");
    Console.WriteLine("[[[[[ ADMIN MENU ]]]]]\r\n" +
        "0.EXIT\r\n" +
        "1.Loading the machine with water, coffee, tea, sugar\r\n" +
        "2.Change in prices for drinks\r\n" +
        "3.Add new drink\r\n" +
        "4.Removing\r\n" +
        "5.Save Drinks\n" +
        "6.Show Drink\r\n" +
        "7.Show Componens\r\n" +
        "8.Find Drink\r\n" +
        "9.Load Drinks\n" +
        "----------------------------------------------------------------------");


    Console.Write("Your choice:");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 0:
            Console.WriteLine("PAKA!");
            return;
            

        case 1:
            coffee_Machine.AddNewDrink();
            break;

       
        case 2:
            coffee_Machine.Drinkname();
            break;

        case 3:
            coffee_Machine.hz();
            break;

        case 4:
            coffee_Machine.Deletedrink();
            break;

        case 5:
            coffee_Machine.SaveAll();
            break;
            
        case 6:
            coffee_Machine.ShowDrink();
            break;
        case 7:
            coffee_Machine.ShowComponens();
            break;

        case 9:
            coffee_Machine.FindDrink();
            break;
        case 10:
            coffee_Machine.LoadDrinks();
            break;
    }
    Console.WriteLine("Натистінь щось для продовження...");
    Console.ReadKey();
}

