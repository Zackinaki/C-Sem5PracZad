// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём 
// таких разложений может быть несколько. Впервые гипотезу о существовании данного разложения 
// сформулировал математик Х. Гольдбах.
// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного
//  чётного числа. Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти 
//  пару, содержащую наименьшее простое число.

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


