int num = Convert.ToInt32(Console.ReadLine());
string message = "";

if(num < 0 || num  > 100)
{
    message = "Number should be 0 to 100";
}
else if(num >= 50)
{
    message = "You have passed.";
}
else
{
    message = "You have fail.";
}

Console.WriteLine(message);
Console.ReadKey();