﻿using System.Text;

namespace Task3;
class Program
{
    /*Створити об’єкт з 20 символів. Додати до нього три
    рядки з назвами дисциплін: Історія, Основи програмування, Укр.мова.
    Видалити слово «Основи», замінити слово «Укр.мова» на «Українська
    мова». Додати в кінець рядка дисципліну «Інформатика». Перетворити
    рядок в тип string. Вивести на консоль отриманий рядок, кількість
    символів в ньому і ємність виділеної пам’яті.*/

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder(20);
        sb.Append("Історія");
        sb.Append("\nОснови програмування");
        sb.Append("\nУкр.мова");
        sb.Remove(8, 6);
        sb.Replace("Укр.мова", "Українська мова");
        sb.Append("\nІнформатика");
        sb.ToString();
        Console.WriteLine($"{sb}\nдовжина {sb.Length}, ємність {sb.Capacity}");
    }
}

