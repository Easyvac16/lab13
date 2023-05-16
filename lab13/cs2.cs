using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public class Performance : IDisposable
    {
        public string PerformanceName { get; set; }
        public string TheaterName { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public List<string> CastList { get; set; }

        //Конструктор класу
        public Performance(string performanceName, string theaterName, string genre, string duration, List<string> castList)
        {
            this.PerformanceName = performanceName;
            this.TheaterName = theaterName;
            this.Genre = genre;
            this.Duration = duration;
            this.CastList = castList;
        }

        //Метод для виведення
        public void Show()
        {
            Console.WriteLine($"Perfomance name:{PerformanceName}");
            Console.WriteLine($"Theater studio:{TheaterName}");
            Console.WriteLine($"Genre of perfomance:{Genre}");
            Console.WriteLine($"Perfomance duration:{Duration}");
            Console.WriteLine("List of cast:" +string.Join(", ", CastList));
            

        }

        //Метод для очищення даних
        public void Dispose()
        {
            PerformanceName = null;
            TheaterName = null;
            Genre = null;
            Duration = null;
            CastList = null;
            Console.WriteLine("Дані видаленні");
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            Console.OutputEncoding = Encoding.Unicode;
            List<string> cast = new List<string>();
            cast.Add("Валерій");
            cast.Add("Бориc");
            cast.Add("Артем");
            cast.Add("Ігор");
            cast.Add("Марія");
            cast.Add("Анна");
            cast.Add("Дарина");

            using (Performance performance = new Performance("Кайдаші", "Театр Старицького", "Трагікомедія", "2 год. 20 хв", cast))
            {
                performance.Show();
            }

            Console.WriteLine();
        }
    }
}
