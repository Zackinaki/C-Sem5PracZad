
double RaznicMaxMin(double[] array)
{
    double RMM = 0,Max=array[0],Min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>Max)
            Max=array[i];
            else
            Min=array[i];

    }
    RMM=Max-Min;
 
    return RMM;
    
}

Console.Clear();
Console.Write("Vvedite kol-vo elem-ov v massive: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Vvedite {i + 1} element massiva: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"Massiv: [{string.Join("; ", array)}]");

Console.WriteLine($"Raznica mezhdu max i min elem-ov massiva: {RaznicMaxMin(array)}");

