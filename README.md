# Знакомство с языками программирования - ДЗ № 2

## Содержание ДЗ

* **`Program.cs`** - главное меню домашней работы. Для его работоспособности, в одной дерриктории с ним должны располагаться все файлы данного репозитория (за исключением README.md).

* **`Task10.cs`** - Задача № 10 - *на входе трёхзначное число, а на выходе цифра 2-го разряда этого числа.* Организован контроль ввода, допустимо использование отрицательных и положительных трехзначных чисел, соответствующих типу Integer.

* **`Task13.cs`** - Задача № 13 - *на входе число различной разрядности, а на выходе цифра 3-го разряда этого числа.* Организован контроль ввода, допустимо использование любых отрицательных и положительных чисел, соответствующих типу Integer.

* **`Task15.cs`** - Задача № 15 - *на входе число, соответствующее дню недели, а на выходе информация рабочий или выходной это день.* Организован контроль ввода, допустимо использование чисел от 1 до 7 включительно, соответствующих типу Integer.

* **`OptionalTask1.cs`** - Доп. Задача № 1 - *на входе число различной разрядности, а на выходе оно же, но с удаленной цифрой 2-го разряда.* Организован контроль ввода, допустимо использование любых отрицательных и положительных чисел, соответствующих типу Integer.

* **`OptionalTask2.cs`** - Доп. Задача № 2 - *на входе число, равное кол-ву программистов, а на выходе прописной эквивалент с правильным склонением слова 'программист'.* Организован контроль ввода, допустимо использование любых положительных чисел, соответствующих типу Integer.

## P.S.

* Позволил себе расширить функционал Доп. Задачи № 2. Не только лишь склоняю слово 'программист', но и трансформирую числовые значения в строчный эквивалет. Трансформация работает на числах любой величины, допускаемой типом Integer.

* Связи между главным меню и задачами реализованы через публичные классы и методы. Однако, все файлы задач предусматривают выполнение кода не только из под Главного Меню, но и в качестве самостоятельного проекта. Для этого в каждой задаче прописан свой метод Main класса Program.

* При обработке данных и получения результата, мной фактически соблюдено правило "без использования строк". Понимаю мотивы выставления такого требования, однако я все же чуть-чуть упростил реализацию :) Замечу, что чем более легким и лаконичным путем решается задача в программировании, тем лучше, а через строки решалось бы все одной-двумя функциями.