//Print 1 to 10 using for loop
Console.WriteLine("Print 1 to 10 using for loop:");
for(int i=1; i<=10; i++)
{
    Console.Write(i + " ");
}

Console.WriteLine(" ");

//Print even number from 1 to 20 using for loop
Console.WriteLine("Print even number from 1 to 20 using for loop:");
for(int i=1; i<=20; i++)
{
    if(i%2 == 0) Console.Write(i + " ");
}

Console.ReadKey();