try
{
    // ГЛАВНОЕ МЕНЮ ДЗ 2
    PrintMainMenu();

    ConsoleKey ck;
    
    do
    {
        ck = Console.ReadKey(true).Key;
       
        if (ck == ConsoleKey.D1 || (ck) == ConsoleKey.NumPad1) // [1]
        {
            try
            {
                Task10.DZ dz = new Task10.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage("Задачи 10", e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D2 || (ck) == ConsoleKey.NumPad2) // [2]
        {
            try
            {
                Task13.DZ dz = new Task13.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage("Задачи 13", e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D3 || (ck) == ConsoleKey.NumPad3) // [3]
        {
            try
            {
                Task15.DZ dz = new Task15.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage("Задачи 15", e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D4 || (ck) == ConsoleKey.NumPad4) // [4]
        {
            try
            {
                OptionalTask1.DZ dz = new OptionalTask1.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage("Доп Задачи 1", e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D5 || (ck) == ConsoleKey.NumPad5) // [5]
        {
            try
            {
                OptionalTask2.DZ dz = new OptionalTask2.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage("Доп Задачи 2", e.Message);
            }
            PrintMainMenu();
        }
    }
    while (ck != ConsoleKey.Q);
}
catch (Exception e)
{
    ExceptionMessage("Program.cs", e.Message);
}


//отрисовка главного меню
void PrintMainMenu()
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("[1] - Задача № 10");
    Console.WriteLine("");
    Console.WriteLine("[2] - Задача № 13");
    Console.WriteLine("");
    Console.WriteLine("[3] - Задача № 15");
    Console.WriteLine("");
    Console.WriteLine("[4] - Доп Задача № 1");
    Console.WriteLine("");
    Console.WriteLine("[5] - Доп Задача № 2");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("* инициируйте выполнение Задач клавишами [1] [2] [3] [4] [5] или нажмите [Q] для выхода из программы...");
    Console.ResetColor();
}

// вывод исключения
void ExceptionMessage(string taskName, string eMessage)
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Ошибка выполнения " + taskName + ": " + eMessage);
    Console.ResetColor();
    Console.WriteLine("");
    Console.Write("нажмите любую клавишу...");
    Console.ReadKey(true);

}
