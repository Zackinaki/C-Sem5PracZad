// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100); 
}

int SumNeChet(int[] array)
{
    int SumNCh = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i%2==1)
            SumNCh=SumNCh+array[i];
        
    }
    return SumNCh;
    
}

Console.Clear();
Console.Write("Vvedite kol-vo elem-ov v massive: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
Console.WriteLine($"Summa elementov v massive na ne chet poziciah: {SumNeChet(array)}");