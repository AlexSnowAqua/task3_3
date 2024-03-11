// //Задача 3: Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 3, 4, 5, 6, 7, 8, 9, 0 }; //задаем массив
        print_array_reverse(array, 0);
    }

    static void print_array_reverse(int[] m, int iter) //тут два параметра: массив m и iter, который отслеживает текущую итерацию.
    {
        if (iter < m.Length) //Если iter меньше длины массива m, происходит рекурсивный вызов print_array_reverse с увеличением iter на 1.
        {
            print_array_reverse(m, iter + 1); //счетчик
            Console.WriteLine(m[iter]);
        }
    }
}

//продолжается до тех пор, пока не будет достигнут базовый случай, когда iter становится равным длине массива m.
