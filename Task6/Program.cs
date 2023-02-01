using System.Text.RegularExpressions;

namespace Task6;
class Program
{
    /*Створити у коді рядок тексту «МНТУ – це
    заклад вищої освіти. В МНТУ навчаються студенти за різними
    спеціальностями». Замінити всі слова МНТУ на ISTU. Результати
    вивести на консоль.*/

    static void Main(string[] args)
    {
        string t = "МНТУ – це заклад вищої освіти. В МНТУ навчаються студенти за різними спеціальностями.";//Початковий текст
        string t2 = "МНТУ";//Текс, що потрібно замінити
        string t3 = "ISTU";//Текст, на який замінюємо
        string res = Regex.Replace(t, t2, t3);
        Console.WriteLine(res);//Виводимо результат
    }
}
