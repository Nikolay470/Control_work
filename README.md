# Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.          

## 1 Определение методов для выполнения программы.
### 1.1 `Метод для получения данных.`
```c#
string[] GetArrayString(string messSizeArray, string message)
{
    // получаем размер массива
    Console.Write(messSizeArray + ": ");
    int size = Convert.ToInt32(Console.ReadLine());
    // создаем массив 
    string[] input = new string[size];
    // получаем слова от пользователя 
    Console.WriteLine(message);
    // кладем их в массив разделяя по пробелу
    input = Convert.ToString(Console.ReadLine()).Split(" ");
    // возвращаем массив
    return input;
}
```
### 1.2 `Метод для получения размера итогового массива.`
```c#
int DetermineSizeOfNewArray(string[] arr)
{
    // определяем переменную в котрой будет
    // хранится размер массива
    int size = 0;
    // проверяем в цикле сколько элементов в 
    // исходном массиве состоят из 3-ех  
    // символов или меньше 
    // сколько элементов найдем такой
    // и будет размер нового массива
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size++;
    }
    // возвращаем значение
    return size;
}
```
### 1.3 `Метод для создания нового массива.`
```c#
string[] CreateNewArrayString(string[] arr)
{
    // получаем длинну нового массива
    int length = DetermineSizeOfNewArray(arr);
    // создаем массив
    string[] newArray = new string[length];
    // индекс элемента нового массива
    int index = 0;
    // перебираем исходный массив, находим
    // все элементы которые состоят из 3-ех
    // символов или меньше и кладем их в новый массив
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[index] = arr[i];
            index++;
        }
    }
    // возвращаем массив
    return newArray;
}
```
### 1.4 `Метод для печати массива`
```c#
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
```

## 2. Выполнение программы.
### 2.1 `Получениие данных от пользователя`
```c#
string[] arrStringDefault = GetArrayString("Введите колличество слов",
 "Введите ваши слова через пробел");
```
### 2.2 `Создание итогового массива.`
```c#
string[] newArrayString = CreateNewArrayString(arrStringDefault);
```
### 2.3 `Вывод в консоль исходного массива.`
```c#
Console.Write("Исходный массив: ");
PrintArray(arrStringDefault);
```
### 2.4 `Вывод в консоль итогового массива.`
```c#
Console.Write("Итоговый массив: ");
PrintArray(newArrayString);
```