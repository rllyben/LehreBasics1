namespace Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float zahl1= 0;
            float zahl2= 0;
            int error = 0;
            string rechenzeichen = "";

            Console.WriteLine("Zahl 1:");
            try
            {
                zahl1 = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                error = 1;
            }

            Console.WriteLine("Rechenzeichen (+ - * /)");
            rechenzeichen = Console.ReadLine();

            Console.WriteLine("Zahl 2:");
            try
            {
                zahl2 = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                error = 1;
            }

            if (rechenzeichen == "+" && error != 1)
            {
                Console.WriteLine(zahl1 + zahl2);
            }
            else if (rechenzeichen == "-" && error != 1)
            {
                Console.WriteLine(zahl1 - zahl2);
            }
            else if (rechenzeichen == "*" && error != 1)
            {
                Console.WriteLine(zahl1 * zahl2);
            }
            else if (rechenzeichen == "/" && error != 1)
            {
                Console.WriteLine(zahl1 / zahl2);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }

        }

    }

}
