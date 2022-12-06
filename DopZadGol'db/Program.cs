
Console.Clear();
Console.Write("Vvedite chetnoe chislo bol'she 2: ");
int n = Convert.ToInt32(Console.ReadLine());

bool[] array = new bool[n];
int a=2,b=2;
for(int i=2;i<n;i++)
{
    array[i]=true;
}

for(int i=2;i*i<n;i++)
    {
        if(array[i])
        {
            for(int j=i+i;j<n;j=j+i)
        {
            array[j]=false;
            i=2;
        }
        }
    
    while(!(array[i]&&array[n-i]))
    {
        i++;
    
    }
    
    a=i;
    b=n-a;
    }
    
    Console.WriteLine($"Dva prostih chisla: ({a}; {b}) v summe ravni chislu {n}");
    Console.WriteLine($"Pri etom: ({a}) naimeshee prostoe chislo");


