using System;

namespace Piesa
{
    class piesa : IDisposable
    {
        private string name;
        private string author;
        private string style;
        private int year;

        public piesa(string name, string author, string style, int year)
        {
            this.name = name;
            this.author = author;
            this.style = style;
            this.year = year;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Style
        {
            get { return style; }
            set { style = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void PiesaInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Style}");
            Console.WriteLine($"Год выпуска: {Year}");
        }
        ~piesa()
        {
            Console.WriteLine($"Объект пьесы \"{Name}\" удален.");
        }
        public void Dispose()
        {
            Console.WriteLine($"Объект пьесы \"{Name}\" удален.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            piesa p1 = new piesa("Гамлет", "Уильям Шекспир", "Трагедия", 1603);
            p1.PiesaInfo();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
