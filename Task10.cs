namespace Task10
{
    //ЗАДАЧА 10: на входе трёхзначное число, а на выходе цифра 2-го разряда этого числа.
    public class DZ
    {
        public void Start() // Выполнение задачи
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ЗАДАЧА 10: на входе трёхзначное число, а на выходе цифра 2-го разряда этого числа.");
            Console.ResetColor();

            string str = ""; //вводимые данные
            int a; // число

            Console.WriteLine("");           
            do
            {
                Console.Write("Введите число: ");
                while (int.TryParse(str = Console.ReadLine()!, out a) == false) // ввод числа и проверка на соответствие типу integer
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: несоответствие типу integer!");
                    Console.ResetColor();
                    Console.Write("Введите число: ");
                }

                a = (int)Math.Abs(int.Parse(str)); // присвоение в абсолютном значении

                if (a < 100 || a > 999) // проверка на несоответствие трехзначным числам
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: не трехзначное число!");
                    Console.ResetColor();
                }
            } while (a < 100 || a > 999);

            a /= 10; // удаление третьего разряда
            a %= 10; // получение второго разряда           

            Console.WriteLine("");
            Console.WriteLine("Цифра 2-го разряда: [" + a + "]");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("для завершения задачи нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }







    //На случай запуска Task10.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}