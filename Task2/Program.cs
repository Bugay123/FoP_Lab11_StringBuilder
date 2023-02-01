using System.Text;

namespace Task2;
class Program
{
    /*Створити об’єкт і ініціалізувати його при створенні
    реченням "Мова програмування C#". Видалити слово
    «програмування». Додати в кінець рядка речення «Є сучасною мовою
    програмування». Результат вивести на консоль.*/

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Мова програмування C#");
        sb.Remove(5, 13);
        sb.Append(" є сучасною мовою програмування.");
        Console.WriteLine(sb);
    }
}

