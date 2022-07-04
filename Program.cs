/*
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив 
из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
**Примеры**:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

void FillArray(string[] newArray) // функция создающая массив с типом string и дающая возможность пользователю вносить в него элементы вручную
{
    System.Console.Write("Задайте элементы массива:  ");
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write($"[{i}]"); ;
        newArray[i] = Console.ReadLine()!;
    }

}

void PrintArray (string[] arrayToPrint) // функция печати массива
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.ForegroundColor=ConsoleColor.White;
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if(i != arrayToPrint.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.ForegroundColor=ConsoleColor.White;
    Console.WriteLine();
}

string[] FindShortElement(string[] shortElement) // эта функция находит короткие элементы в исходном массиве и заполняет ими итоговый массив
{

    int count = 0;
    string element = String.Empty;
    for (int i = 0; i < shortElement.Length; i++)
    {
        element = shortElement[i];
        if (element.Length < 4)
        {
            count++;
        }
    }
    string[] resultArray = new string[count];
    count = 0;
    for (int i = 0; i < shortElement.Length; i++)
    {
       
        element = shortElement[i];
        if (element.Length <= 3)
        {
            resultArray[count] = element;
            count++;
        }
    }
    return resultArray;
}

System.Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];
FillArray(array);
string[] resultArray = FindShortElement(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Итоговый массив");
PrintArray(resultArray);