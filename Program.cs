// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//         длина которых меньше, либо равна 3 символам. 
//         Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//         При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
//          [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//          [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//          [“Russia”, “Denmark”, “Kazan”] → []


string[] GetArrayString(string messSizeArray, string message)
{
    Console.Write(messSizeArray + ": ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] input = new string[size];

    Console.WriteLine(message);
    input = Convert.ToString(Console.ReadLine()).Split(" ");
    return input;
}

int DetermineSizeOfNewArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size++;
    }
    return size;
}

string[] CreateNewArrayString(string[] arr)
{
    int length = DetermineSizeOfNewArray(arr);
    string[] newArray = new string[length];
    int index = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[index] = arr[i];
            index++;
        }
    }
    return newArray;
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.WriteLine("]");
}

string[] arrStringDefault = GetArrayString("Введите колличество слов",
                                           "Введите ваши слова через пробел");
string[] newArrayString = CreateNewArrayString(arrStringDefault);

Console.Write("Исходный массив: ");
PrintArray(arrStringDefault);

Console.Write("Итоговый массив: ");
PrintArray(newArrayString);