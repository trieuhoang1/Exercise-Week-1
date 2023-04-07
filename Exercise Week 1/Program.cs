

using System.Runtime.CompilerServices;
using System.Text;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Value ");
            int max = int.Parse(Console.ReadLine());
            CloseInput();

            for (int i = 0; i < max; i++)

            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that. ");
                }
                else if (i.ToString().Contains("1"))
                {
                    Console.WriteLine("Beep!");
                }
                else if (i.ToString().Contains("2"))
                {
                    Console.WriteLine("Beep!");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        static void CloseInput()
            {
                Console.WriteLine("Try a Larger Value ");
                Console.ReadLine();
            }
        }
    }
}




