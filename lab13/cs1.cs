using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public class Film : IDisposable
    {
        public string Name { get; set; }
        public string FilmStudio { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string Year { get; set; }

        //Конструктор класу
        public Film(string name, string filmStudio, string genre, string duration, string year)
        {
            this.Name = name;
            this.FilmStudio = filmStudio;
            this.Genre = genre;
            this.Duration = duration;
            this.Year = year;
        }

        //Метод для виведення
        public void Show()
        {
            Console.WriteLine($"Film name:{Name}");
            Console.WriteLine($"Film studio:{FilmStudio}");
            Console.WriteLine($"Genre of film:{Genre}");
            Console.WriteLine($"Film duration:{Duration}");
            Console.WriteLine($"Film of year:{Year}");

        }

        //Метод для очищення даних
        public void Dispose()
        {
            Name = null;
            FilmStudio = null;
            Genre = null;
            Duration = null;
            Year = null;
            Console.WriteLine("Дані видаленні");
        }
    }
    internal class cs1
    {
        
        public static void task_1()
        {
            Console.OutputEncoding = Encoding.Unicode;
            using (Film film = new Film("Thor 2", "Marvel Studios", "Action/Adventure", "1 hour 52 minutes", "2013"))
            {
                film.Show();
            }
            Console.WriteLine();

        }
    }
}
