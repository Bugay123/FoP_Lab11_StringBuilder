using System.Text.RegularExpressions;

namespace Task4;
class Program
{
    /*Написати метод, який перевіряє правильність
    числового виразу (всі цифри, 6 цифр). Вираз передати в метод як
    параметр. Результат методу true або false. Викликати метод з Main.
    Результати вивести на консоль.*/

    static bool Num(string a)   //Метод для перевірки числа
    {
        Regex myReg = new Regex(@"^(\d{1,6}$)");
        if (myReg.IsMatch(a))
        {
            return true;
        }
        else
            return false;
    }
        static void Main(string[] args)
        {
            string num = "111111";  //Число
            Console.WriteLine(Num(num));
        }
    }

