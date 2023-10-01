/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
*/

//Метод, создающий массив и заполниющий его строками
string[] MakeArray()
{
    Console.Write("Введите количество элементов, которое будет в исходном массиве: ");
    int n = int.Parse(Console.ReadLine()!);

    string[] array = new string[n];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку - элемент массива с индексом {i}: ");
        array[i] = Console.ReadLine()!;
        Console.WriteLine();
    }
    return array;
}

// Метод, определяющий количество элементов в массиве, которые содеожат строки,
// длина которых меньше или равна трем символам

int CheckSimbol(string[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) k++;
    }
    return k;
}


// Метод, заполняющий новый массив строками, длина которых меньше или равна 3-м символам и
// который взяты из исходного массива

string[] GiveArray(string[] array, int len3)
{
    if (len3 == 0) Console.Write("В исходном массиве нет ни одного элемента, состоящего из строк длиной 3 символа и менее."); 
    string[] array2 = new string[len3];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];   
            j++;
        }
    }
    return array2;
}

// Сама программа:
Console.Clear();
string[] arr = MakeArray();

int length3 = CheckSimbol(arr);
Console.WriteLine();

string[] arr2 = GiveArray(arr, length3);

Console.WriteLine();

if (arr2.Length != 0)
{
    Console.WriteLine("Исходный массив:");
    Console.WriteLine($"[{string.Join(", ", arr)}]");

    Console.WriteLine("Искомый массив, состоящий из элементов, являющихся строками, длина которых равна или менее 3:");
    Console.WriteLine($"[{string.Join(", ", arr2)}]");
}
else
{
    Console.WriteLine("Исходный массив:");
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}