// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина котрых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int FillArray1(string[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент(строку) массива =>");
        array[i] = Console.ReadLine();
        if (array[i].Length <= 3) number++;
    }
    return number;
}

void FillArray2(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Задайте ваш исходный массив строк, а компьютер укажет те строки, длина которых меньше или равна 3-м символам");
Console.Write("Укажите, сколько элементов (строк) будет в вашем массиве(1-50)=>");
int elements = Convert.ToInt32(Console.ReadLine());

if (elements < 0)
{
    Console.WriteLine("Некорректно задан параметр величины массива!");
}

else
{
    string[] YourArray = new string[elements];
    int yourNumber = 0;

    yourNumber = FillArray1(YourArray, yourNumber);

    Console.Clear();
    Console.WriteLine("Вы задали массив, состоящий из следующих строк:");
    PrintArray(YourArray);

    if (yourNumber == 0) Console.WriteLine("В заданном массиве нет строк с длиной символов меньше или равно 3-м");
    else
    {
        string[] NewArray = new string[yourNumber];
        FillArray2(YourArray, NewArray);
        Console.WriteLine("А это новый массив из строк длиной меньше или равно 3-м элементам:");
        PrintArray(NewArray);

    }
}
