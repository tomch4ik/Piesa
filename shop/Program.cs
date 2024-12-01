using System;
namespace shop
{
    class Shop : IDisposable
    {
        private string name;
        private string address;
        private string type;

        public Shop(string name, string address, string type)
        {
            this.name = name;
            this.address = address;
            this.type = type;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название магазина: {Name}");
            Console.WriteLine($"Адрес магазина: {Address}");
            Console.WriteLine($"Тип магазина: {Type}");
        }

        ~Shop()
        {
            Console.WriteLine($"Объект магазина \"{Name}\" удален.");
        }

        public void Dispose()
        {
            Console.WriteLine($"Объект магазина \"{Name}\" удален.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Le Silpo", "ул. Генуэзская, 24 Б", "Продовольственный");
            shop.ShowInfo();
            shop.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
