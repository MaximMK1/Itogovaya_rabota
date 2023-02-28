# Описание решения задачи.

## Условие задачи
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

## Решение     
* Шаг 1

Задаем массив и считаем сколько в нем элементов, удовлетворяющих условию задачи: **длина которых
меньше либо равна 3 символа**. Полученное значение храним в переменной *count*.

    string[] array = { "hello", "2", "world", ":-)" };

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
* Шаг 2

Создаем новый массив с количеством элементов равным значению *count* из предыдущего шага. И заполняем его элементами из заданного массива, удовлетворяющие условию задачи. Делаем это с помощью счетчика *step* и временной переменной *temp*.

    string[] resultArray = new string[count];

    int step = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int temp = step;
        if (array[i].Length <= 3) step++;
        if (temp != step) resultArray[step-1] = array[i];
    }

* Шаг 3

Выводим получившийся массив в консоль.

    Console.Write("[");
    for (int i = 0; i < resultArray .Length; i++)
    {
        Console.Write($"{resultArray [i]}, ");
    }
    Console.Write("\b\b]");

* Результат

Для запуска программы вводим в консоль команду 

*dotnet run*

    [2, :-)] 