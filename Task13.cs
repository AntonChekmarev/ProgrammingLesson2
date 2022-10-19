namespace Task13
{
    //ЗАДАЧА 13: на входе число различной разрядности, а на выходе цифра 3-го разряда этого числа.
    public class DZ
    {
        public void Start() // Выполнение задачи
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ЗАДАЧА 13: на входе число различной разрядности, а на выходе цифра 3-го разряда этого числа.");
            Console.ResetColor();

            string str = ""; //вводимые данные
            int a; // число
            List<int> al = new List<int>(); // список преобразованного по разрядам числа

            Console.WriteLine("");
            Console.Write("Введите число: ");                
            while (int.TryParse(str = Console.ReadLine()!, out a) == false) // ввод числа и проверка на соответствие типу integer
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("err: несоответствие типу integer!");
                Console.ResetColor();
                Console.Write("Введите число: ");
            }

            a = int.Parse(str); // присвоение
            al = IntToList(a); // преобразование

            Console.WriteLine("");
            if (al.Count > 2) Console.WriteLine("Цифра 3-го разряда: [" + al[2] + "]"); // вуаля. и без работы со строками =)
            else Console.WriteLine("В веденном числе отсутствует цифра 3-го разряда.");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("для завершения задачи нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey(true);


            // Функция записи int в List по разрядам
            List<int> IntToList(int number)
            {
                number = (int)Math.Abs(number);
                List<int> temp = new List<int>();
                List<int> rezult = new List<int>();
                while (number > 9)
                {
                    temp.Add(number % 10);
                    number /= 10;
                }
                rezult.Add(number);
                for (int i = temp.Count - 1; i > -1; i--)
                {
                    rezult.Add(temp[i]);
                }
                return rezult;
            }
        }
    }







    //На случай запуска Task13.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}