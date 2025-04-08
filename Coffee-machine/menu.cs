using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_machine
{
    internal class Menu
    {
        public void Showmenu()
        {
            Console.WriteLine("--------------------------Hot drinks machine--------------------------");
            Console.WriteLine("[[[[[ ADMIN MENU ]]]]]\r\n" +
                 "1.Loading the machine with water, coffee, tea, sugar\r\n" +
                 "2.Output of statistics on the availability of ingredients for making drinks\r\n" +
                 "3.Change in prices for drinks\r\n" +
                 "4.Removing the cache\r\n" +
                 "5.Save Settings\r\n" +
                 "6.Show All\r\n" +
                 "4.Add new drink\r\n" +
                 "5.Removing the cache\r\n" +
                 "6.Save Settings\r\n" +
                 "7.Show Drink\r\n" +
                 "8.Show Componens\r\n" +
                 "9.Find Drink\r\n" +
                "----------------------------------------------------------------------");
        }
        public void ShowLoginmenu()
        {
            Console.WriteLine("--------------------------Welcome--------------------------");
            Console.WriteLine("[[[[[ WHAT YOU ARE ]]]]]\r\n" +
                 "0.Exit\r\n" +
                 "1.User\r\n" +
                 "2.Admin\r\n" +
                 
                "----------------------------------------------------------------------");
        }

        public void ShowUsermenu()
        {
            Console.WriteLine("--------------------------USER MENU--------------------------");
            Console.WriteLine("\tUSER MENU\n" +
                          "0. Exit\n" +
                          "1. Buy Drink");
            Console.WriteLine("______________________________");
        }
        public int AskUserInput()
        {
            Console.Write("Your choice: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
