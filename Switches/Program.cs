namespace Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int test = 3;
            // Switch Case Abzweigung
            switch (test)
            {
                // Direkter Case Variable ist Wert
                case 0: Console.WriteLine("Wert ist 0"); break;
                // Wertebereich alles Kleiner oder Groesser als Wertg
                case <=3: Console.WriteLine("Wert ist 1"); break;
                // leerer Case ohne break wird uebersprungen wenn true
                case 4:
                case 5: Console.WriteLine("Wert ist 5"); break;
                case 10: Console.WriteLine("Wert ist 10"); break;
                // entspricht dem else wenn alles andere nicht zutrifft
                default: Console.WriteLine("Default"); break;

            }
            */
            
            int zahl1 = 0;
            int zahl2 = 0;
            char op = '0';

            Console.WriteLine("Zahl 1: ");
            zahl1 = int.Parse(Console.ReadLine());

            Console.WriteLine("op: ");
            op = Console.ReadKey().KeyChar;

            Console.WriteLine("Zahl 2: ");
            zahl2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine(zahl1 + zahl2); break;
                case '-': Console.WriteLine(zahl1 - zahl2); break;
                case '*': Console.WriteLine(zahl1 * zahl2); break;
                case '/':
                    {
                        if (zahl2 == 0) 
                        { 
                            Console.WriteLine("Falsche Eingabe"); break; 
                        }
                        Console.WriteLine(zahl1 / zahl2); break;
                    }
                default:  Console.WriteLine("Falsche Eingabe"); break;
            }

        }

    }

}
