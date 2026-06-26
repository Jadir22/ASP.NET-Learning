// Print number from 1 to 10 using while loop
int i = 1;

while (true)
{
    if (i > 10)
    {
        break;
    }
    Console.Write(i + " ");

    i++;
}

Console.WriteLine(" ");

// Print number 1 to 20 excluding divisible by 5
int j = 1;
while (j <= 20)
{
    if(j%5 == 0)
    {
        j++;
        continue;
    }
    Console.Write(j + " ");
    j++;
}

//print from 11 to 20 using do while loop

Console.WriteLine(" ");
int k = 1;
do
{
    Console.Write(k + " ");
    k++;
    
} while (k <= 20);

Console.ReadKey();