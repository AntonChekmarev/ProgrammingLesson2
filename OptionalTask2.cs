namespace OptionalTask2
{
    //ДОП. ЗАДАЧА 2: на входе число, равное кол-ву программистов, а на выходе прописной эквивалент с правильным склонением
    public class DZ
    {
        public void Start() // Выполнение задачи
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ДОП. ЗАДАЧА 2: на входе число, равное кол-ву программистов, а на выходе прописной эквивалент с правильным склонением.");
            Console.ResetColor();

            string str = ""; //вводимые данные
            int a; // число

            Console.WriteLine("");
            do
            {
                Console.Write("Введите кол-во программистов: ");
                while (int.TryParse(str = Console.ReadLine()!, out a) == false) // ввод числа и проверка на соответствие типу integer
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: несоответствие типу integer!");
                    Console.ResetColor();
                    Console.Write("Введите кол-во программистов: ");
                }
                a = int.Parse(str); // присвоение
                if (a < 0) // проверка на неверное значение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: кол-во не может быть отрицательным!");
                    Console.ResetColor();
                }
            } while (a < 0);


            Console.WriteLine("");
            Console.WriteLine("Результат: " + IntToText(a) + " " + ProgrammerText(a));

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("нажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ResetColor();
            Console.ReadKey(true);
        


            // Функция формирования склонения слова "программист"
            string ProgrammerText(int number)
            {
                number = (int)Math.Abs(number);
                int n;
                string rezult = "";
                
                n = number % 100;
                if (n >= 10 & n <= 14) rezult = "программистов";
                else
                {
                    n = number % 10;
                    if (n == 1) rezult = "программист";
                    else if (n >= 2 & n <= 4) rezult = "программиста";
                    else rezult = "программистов";
                }
               
                return rezult;
            }

            // Функция преобразования Int в прописной аналог String
            string IntToText(int number)
            {
                number = (int)Math.Abs(number);
                int[] array_int = new int[4]; // для разбития числа по сотням
                string[,] array_string = new string[4, 3] // для чисел больше миллиона
                {
                    { " миллиард", " миллиарда", " миллиардов" },
                    { " миллион", " миллиона", " миллионов" },
                    { " тысяча", " тысячи", " тысяч" },
                    { "", "", "" }
                };

                array_int[0] = (number - (number % 1000000000)) / 1000000000;
                array_int[1] = ((number % 1000000000) - (number % 1000000)) / 1000000;
                array_int[2] = ((number % 1000000) - (number % 1000)) / 1000;
                array_int[3] = number % 1000;

                string result = "";

                if (number == 0) result = "ноль";
                else for (int i = 0; i < 4; i++)
                    {
                        if (array_int[i] != 0)
                        {
                            if (((array_int[i] - (array_int[i] % 100)) / 100) != 0)
                                switch (((array_int[i] - (array_int[i] % 100)) / 100))
                                {
                                    case 1: result += " сто"; break;
                                    case 2: result += " двести"; break;
                                    case 3: result += " триста"; break;
                                    case 4: result += " четыреста"; break;
                                    case 5: result += " пятьсот"; break;
                                    case 6: result += " шестьсот"; break;
                                    case 7: result += " семьсот"; break;
                                    case 8: result += " восемьсот"; break;
                                    case 9: result += " девятьсот"; break;
                                }
                            if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)
                            {
                                switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)
                                {
                                    case 2: result += " двадцать"; break;
                                    case 3: result += " тридцать"; break;
                                    case 4: result += " сорок"; break;
                                    case 5: result += " пятьдесят"; break;
                                    case 6: result += " шестьдесят"; break;
                                    case 7: result += " семьдесят"; break;
                                    case 8: result += " восемьдесят"; break;
                                    case 9: result += " девяносто"; break;
                                }
                                switch (array_int[i] % 10)
                                {
                                    case 1: if (i == 2) result += " одна"; else result += " один"; break;
                                    case 2: if (i == 2) result += " две"; else result += " два"; break;
                                    case 3: result += " три"; break;
                                    case 4: result += " четыре"; break;
                                    case 5: result += " пять"; break;
                                    case 6: result += " шесть"; break;
                                    case 7: result += " семь"; break;
                                    case 8: result += " восемь"; break;
                                    case 9: result += " девять"; break;
                                }
                            }
                            else switch (array_int[i] % 100)
                                {
                                    case 10: result += " десять"; break;
                                    case 11: result += " одиннадцать"; break;
                                    case 12: result += " двенадцать"; break;
                                    case 13: result += " тринадцать"; break;
                                    case 14: result += " четырнадцать"; break;
                                    case 15: result += " пятнадцать"; break;
                                    case 16: result += " шестнадцать"; break;
                                    case 17: result += " семнадцать"; break;
                                    case 18: result += " восемнадцать"; break;
                                    case 19: result += " девятнадцать"; break;
                                }
                            if (array_int[i] % 100 >= 10 && array_int[i] % 100 <= 19) result += array_string[i, 2];
                            else switch (array_int[i] % 10)
                                {
                                    case 1: result += array_string[i, 0]; break;
                                    case 2:
                                    case 3:
                                    case 4: result += array_string[i, 1]; break;
                                    case 5:
                                    case 6:
                                    case 7:
                                    case 8:
                                    case 9:
                                    case 0: result += array_string[i, 2]; break;
                                }
                        }
                    }
                return result.TrimStart();
            }
        }
    }







    //На случай запуска OptionalTask2.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}