/* Задайте массив заполненный случайными положительными трёхзначными числами.
   Напишите программу, которая покажет количество чётных чисел в массиве.
   [345, 897, 568, 234] -> 2
*/

//-----------БЛОК ОПИСАНИЙ---------------------------------------------------

Console.Clear();

int GetSizeArray(string message_num, string error_message, string errorNum_message) 
{
    int size = 0;
    while (true)
    {
        try
        {
            Console.Write(message_num);
            size = int.Parse(Console.ReadLine() ?? "");
            if (size > 0) 
                return size;
            else
                Console.WriteLine(errorNum_message);
        }
        catch
        {
            Console.WriteLine(error_message);
        }      
    }
}

int[] GetArray(int size)
{
    int[] new_array = new int[size];
    for (int i = 0; i < size; i++)
    {  
        new_array[i] = new Random().Next(100, 1000);
    }
    return new_array;
}

int CountEvenNumber(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
        count += (el % 2 == 0) ? 1 : 0;
    return count;
}

//----------------------------------------------------------------------------------------------------

int size = GetSizeArray("Введите размер массива: ", "Ошибка ввода!", "Размер массива должен быть больше нуля.");
// Функция запрашивает у пользователя размер массива и возвращает его

int[] array = GetArray(size); 
// Функция создает новый массив размером size, заполняет его случайными трехзначными числами и возвращает его

int result = CountEvenNumber(array); // Функция возвращает кол-во четных чисел в массиве

Console.Write($"[{String.Join(", ", array)}] -> {result}");
