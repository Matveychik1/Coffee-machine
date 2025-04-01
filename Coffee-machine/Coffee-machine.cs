using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Coffee_machine
{
    internal class Coffee_machine
    {
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
        public void AddNewDrink()
        {
            Component newItem = new();
            newItem.ReadFromConsole();
            Components.Add(newItem);
        }
        public void Drinkname()
        {
            Console.Write("Enter drink name to change price: ");
            string drinkName = Console.ReadLine();
            var drink = items.Find(x => x.Name == drinkName);
            if (drink != null)
            {
                Console.Write("Enter new price: ");
                double newPrice = double.Parse(Console.ReadLine());
                drink.Price = newPrice;
                Console.WriteLine("Price updated successfully!");
            }
            else
            {
                Console.WriteLine("Drink not found!");
            }
        }
        public void hz ()
        {
            Drink newItem2 = new();
            newItem2.ReadFromConsole();
            items.Add(newItem2);
            
        }
        public void Deletedrink()
        {
            Console.Write("Enter DRINK name to delete: ");
            string name2 = Console.ReadLine();

            var found2 = items.Find(x => x.Name == name2);
            if (found2 == null)
            {
                Console.WriteLine("DRINK not found!");
                
            }

            items.Remove(found2);
        }
        public void SaveAll()
        {
            var json = JsonSerializer.Serialize(items);
            File.WriteAllText("database.json", json);
        }
        public void ShowDrink()
        {
            foreach (Drink item in items)
                item.Show();
        }
        public void ShowComponens()
        {
            foreach (Component item in Components)
                item.Show();
        }
        public void FindDrink()
        {
            Console.Write("Enter product name to search: ");
            string name = Console.ReadLine();

            // логіка пошуку продукта
            var found = items.Find(x => x.Name == name);
            if (found == null)
            {
                Console.WriteLine("Product not found!");
                
            }

            found.Show();
        }
        public void LoadDrinks()
        {
            var jsonData = File.ReadAllText("database.json");
            items = JsonSerializer.Deserialize<List<Drink>>(jsonData);
        }
    }
}
