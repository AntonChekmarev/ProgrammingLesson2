namespace OptionalTask1
{
    //ДОП. ЗАДАЧА 1: на входе число различной разрядности, а на выходе оно же, но с удаленной цифрой 2-го разряда
    public class DZ
    {
        public void Start() // Выполнение задачи
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ДОП. ЗАДАЧА 1: на входе число различной разрядности, а на выходе оно же, но с удаленной цифрой 2-го разряда");
            Console.ResetColor();

            string str = ""; //вводимые данные
            int a; // число
            List<int> al = new List<int>(); // список преобразованного по разрядам числа
            bool otr = false; // метка отрицательности числа

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
            if (a < 0) otr = true; // метка отрицательности
            al = IntToList(a); // преобразование
            if (al.Count > 1) al.RemoveAt(1); // удаление числа второго разряда
            a = 0; 
            foreach (int item in al) // сбор нового числа
            {
                if (a == 0) a = item;
                else a = a * 10 + item;
            }
            if (otr == true) a *= -1; // возврат отрицательности

            Console.WriteLine("");
            Console.WriteLine("Результат: [" + a + "]"); // вуаля. и без работы со строками =)

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







    //На случай запуска OptionalTask1.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}