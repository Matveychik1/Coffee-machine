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
Menu menu = new();

CoffeeMachine1 coffee_Machine = new();

menu.ShowLoginmenu();
int roleChoice = menu.AskUserInput();

if(roleChoice == 1)
{
    Console.Clear(); 
    Console.WriteLine("------------- Welcome to Supermarket for User! -------------");

    menu.ShowUsermenu();
    int choice = menu.AskUserInput();

    switch (choice)
    {
        case 0: return 0;
        case 1:
            Console.WriteLine("You can buy something!");
            break;
    }
}

if (roleChoice == 2)
{

    while (true)
    {
        Console.Clear();

        menu.Showmenu();
        int choice = menu.AskUserInput();


        switch (choice)
        {
            case 0:
                Console.WriteLine("PAKA!");
                break;


            case 1:
                coffee_Machine.AddNewDrinkWeight();
                break;


            case 2:
                coffee_Machine.Drinkname();
                break;

            case 3:
                coffee_Machine.AddDrink();
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

}
Console.WriteLine("Гарного дня!");
return 0;