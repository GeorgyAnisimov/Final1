/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
 void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position == (count - 1))
        {
            Console.Write($"{col[position]}");
            position++;
        }
        else
        {
            Console.Write($"{col[position]},");
            position++;
        }
    }
    Console.Write("]");
}

System.Console.WriteLine("Введите кол-во элементов в массиве : ");

int arrayLength = Convert.ToInt32(Console.ReadLine());

string[] stringArray = new string[arrayLength];

System.Console.WriteLine("Заполните массив символами ");

for (int i = 0; i < stringArray.Length; i++)
{
    stringArray[i] = Console.ReadLine();
}

int temp = 3;

string[] copyArray = new string[stringArray.Length];

for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= temp)
    {
        copyArray[i] = stringArray[i];
    }
}

copyArray=copyArray.Where(x => x != null).ToArray(); 

PrintArray(stringArray);

PrintArray(copyArray);










