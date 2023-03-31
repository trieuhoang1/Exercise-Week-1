//Console.WriteLine("Enter Value 1 - 10: ");
//int num = int.Parse(Console.ReadLine());
//int max = 9;

//if (num == 1)
//{
//    Console.WriteLine("Beep!");
//}
//else if (num == 2)
//{
//    Console.WriteLine("Boop!");
//}
//else if (num % 3 == 0)
//{
//    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
//}
//else
//{
//    Console.WriteLine("Great! Try again!");
//}

Console.WriteLine("Enter a Value ");
int max = int.Parse(Console.ReadLine());

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
    Console.WriteLine(i);

}


