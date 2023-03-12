// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
   
//------------------БЛОК ОПИСАНИЙ----------------------------
int GetSizeArray(string message_num, string error_message)  // Функция запрашивает у пользователя размер массива
{                                                           
    int num;
    while (true)
    {
        Console.Write(message_num);
        if (int.TryParse(Console.ReadLine(), out num) && num > 0)
            return num;
        Console.WriteLine(error_message);
    }
}

double[] GetArray(int size)  // Функция создает массив вещественных чисел от -50 до 50
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
     {
        arr[i] = new Random().NextDouble() * 100 - 50;
     }
    return arr;
}

double FindDelta(double[] arr)   // Функция находит разницу между максимальным и минимальным элементом массива
{
    double max_massiv = FindMax(arr);
    double min_massiv = FindMin(arr);
    double result = max_massiv - min_massiv;
    return result;
}

double FindMax(double[] arr)  // Функция находит максимальный элемент массива
{
    double max_arr = arr[0];
    for (int i = 1; i < arr.Length; i++)
    { 
        if (arr[i] > max_arr) 
            max_arr = arr[i];
    }
    return max_arr;
}

double FindMin(double[] arr)    // Функция находит минимальный элемент массива
{
    double min_arr = arr[0];
    for (int i = 1; i < arr.Length; i++)
    { 
        if (arr[i] < min_arr) 
            min_arr = arr[i];
    }
    return min_arr;
}


//------------------------------------------------------------
Console.Clear();

int size_array = GetSizeArray("Введите размер массива: ", "Ошибка ввода!"); 
double[] array = GetArray(size_array);
double delta = FindDelta(array);
Console.Write($"[{string.Join(" ", array)}] -> {string.Format("{0:f2}", delta)}");
