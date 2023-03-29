// Home work 2
namespace homework2
{
    class test1
    {
        static void Main(string[] args)
        {
            long Chislo;
            byte BChislo;
            string TypeChisla = "byte";
            while (true)
            {
                Console.WriteLine($"Введите число");
                //string? input = Console.ReadLine();
                bool result = long.TryParse(Console.ReadLine(), out Chislo); // todo: не учитывает числа превышающие тип long
                if (result == true) //проверка ввода
                {
                    if (Chislo >= sbyte.MinValue & Chislo <= sbyte.MaxValue) //аналогично для остальных типов
                    {
                        BChislo = (byte)Chislo;
                        Console.WriteLine("Ваше число, приведенное к типу " + TypeChisla + " : " + BChislo);
                    }
                    else Console.WriteLine("Для приведения числа " + Chislo + " к типу " + TypeChisla + " число не может быть больше " +
                        sbyte.MaxValue + " и меньше " + sbyte.MinValue);
                }
                else //в слчучае если число вовсе не число
                    Console.WriteLine("Введенные данные не являются числом");
                //Console.WriteLine(isValid);
                //Console.WriteLine("");
            }
        }
    }
}

