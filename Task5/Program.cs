using System.Text.RegularExpressions;

namespace Task5;
class Program
{

    /*Створити у програмі фрагмент тексту. Текст
    містить фрагмент лекції 11 або інший. Перевірити, чи є в цьому тексті
    підрядок «регулярні вирази» або інший, який є в тексті. Результати
    вивести на консоль.*/

    static void Main(string[] args)
    {
        string t = "Класи StringBuilder та String надають достатню функціональність для\nроботи з рядками. Проте .NET пропонує ще один потужний інструмент –\nрегулярні вирази.";
        Regex reg = new Regex("регулярні вирази");
        if (reg.IsMatch(t))
        {
            Console.WriteLine("У реченні є підрядок");
        }
        else
        Console.WriteLine("У реченні немає підрядка");
    }
}

