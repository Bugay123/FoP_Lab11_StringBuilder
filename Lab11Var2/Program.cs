using System.Text;

namespace Lab11Var2;
class Program
{
    /*Створити порожній об’єкт. Додати до нього три
    дисципліни окремими методами Append.Вивести на консоль
    отриманий рядок, його довжину і ємність.*/

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder(); //створюємо об'єкт класу StringBuilder
        sb.Append("Java ");//Додаємо слово
        sb.Append(".NET ");
        sb.Append("JavaScript");
        Console.WriteLine($"{sb}, довжина {sb.Length}, ємність {sb.Capacity}");//Виводимо в консоль об'єкт
        }
}

