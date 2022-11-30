// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых
// меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = new string[7] {"hello", "world", "123", "rope", "777","peace","hope"};
string[] array2 = new string[3];

int j = 0;
for (int i = 0; i < array.Length; i=i+2)
{             
    if(j < 3)
    {
    array2[j] = array[i];
    j++;
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
PrintArray(array);
PrintArray(array2);