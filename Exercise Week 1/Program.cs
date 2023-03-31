
Console.WriteLine("Enter a Value ");
int max = int.Parse(Console.ReadLine());
string s = "Beep";
s = s.Replace('1', '2');

for (int i = 0; i < max; i++)

{
    if (i == 1)
    {
        Console.WriteLine("Beep! ");
        continue;
    }
    if (i == 2)
    {
        Console.WriteLine("Boop! ");
        continue;
    }
    if (i % 3 == 0)
    {
        Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that. ");
        continue;
    }
    else
    {
        Console.WriteLine(i);
    }
}


