/* Задайте одномерный массив, заполненный случайными числами.
   Найдите сумму элементов, стоящих на нечётных позициях.
   [3, 7, 23, 12] -> 19
   [-4, -6, 89, 6] -> 0
   Нечетными позициям (1, 3, 5, ...) соответствуют четные индексы [0, 2, 4, ...]
*/

//-----------------------БЛОК ОПИСАНИЙ--------------------------------
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

int GetNumber(string message_num, string error_message)
{
    //int num;
    while (true)
    {
        Console.Write(message_num);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.WriteLine(error_message);
    }
}

int[] GetArray(int size, int min_num, int max_num)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min_num, max_num + 1);
    }
    return arr;
}

int SumElementsOddPosition(int[] arr)
{
    int i = 0;
    int result = 0;
    while (i < arr.Length)
        {
            result = result + arr[i];
            i = i + 2;
        }
    return result;
}

//--------------------------------------------------------------------

Console.Clear();

int size_array = GetSizeArray("Введите размер массива: ", "Ошибка ввода!", "Размер массива должен быть больше нуля.");
int min_value = GetNumber("Введите минимальное число массива: ", "Ошибка ввода!");
int max_value = GetNumber("Введите максимальное число массива: ", "Ошибка ввода!");

int[] array = GetArray(size_array, min_value, max_value);
// Функция создает новый массив

int sum = SumElementsOddPosition(array);
// Функция вычисляет сумму элементов массива, находящихся на нечетных позициях (с четными интексами)

Console.WriteLine($"[{String.Join(", ", array)}] -> {sum}"); // Вывод на результата на экран
