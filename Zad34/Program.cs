// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); 
}

int Chet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
            count++;
        
    }
    return count;
    
}

Console.Clear();
Console.Write("Vvedite kol-vo elem-ov v massive: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
Console.WriteLine($"Kol-vo chetnih chisel v massive: {Chet(array)}");
