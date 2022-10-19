namespace Task15
{
    //ЗАДАЧА 15: на входк число, соответствующее дню недели, а на выходе информация рабочий или выходной это день.
    public class DZ
    {
        public void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ЗАДАЧА 15: на входе число, соответствующее дню недели, а на выходе информация рабочий или выходной это день.");
            Console.ResetColor();

            string str = ""; //вводимые данные
            int a; // число

            Console.WriteLine("");
            Console.WriteLine("Понедельник: 1");
            Console.WriteLine("Вторник: 2");
            Console.WriteLine("Среда: 3");
            Console.WriteLine("Четверг: 4");
            Console.WriteLine("Пятница: 5");
            Console.WriteLine("Суббота: 6");
            Console.WriteLine("Воскресенье: 7");

            Console.WriteLine("");
            do
            {
                Console.Write("Введите число дня недели: ");
                while (int.TryParse(str = Console.ReadLine()!, out a) == false) // ввод числа и проверка на соответствие типу integer
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: некорректный ввод!");
                    Console.ResetColor();
                    Console.Write("Введите число дня недели: ");
                }
                a = int.Parse(str); // присвоение

                if (a < 1 || a > 7) // проверка на соответствие диапазону допустимых значений
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: некорректный ввод!");
                    Console.ResetColor();
                }
            } while (a < 1 || a > 7);

            Console.WriteLine("");
            Console.Write("Результат: ");
            if (a >= 1 & a <= 5) Console.Write("рабочий день.");
            else Console.Write("выходным  день.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("для завершения задачи нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }




    //На случай запуска Task15.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}