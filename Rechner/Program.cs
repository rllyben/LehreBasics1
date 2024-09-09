namespace Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float zahl1= 0;
            float zahl2= 0;
            int error = 0;
            char rechenzeichen = '0';
            int loop = 0;

            while (loop == 0 || error != 0)
            {
                error = 0;
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
                // hello h[0]e[1]l[2]l[3]o[4]
                // rechenzeichen = Console.ReadLine()[0];

                // Readkey liefert keinen primitiven Datentypen
                // man musss mit .KeyChar auf das Zeichen zugreifen
                // erzeugt keine neue Zeile
                rechenzeichen = Console.ReadKey().KeyChar;
                
                //erzeugt eine neue Zeile
                //Console.WriteLine();

                // Formatstring fuer einen Zeilenumbruch: \n
                Console.WriteLine("\nZahl 2:");
                try
                {
                    zahl2 = float.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    error = 1;
                }

                if (error == 1)
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
                loop++;
            }


            if (rechenzeichen == '+' && error != 1)
            {
                Console.WriteLine("Ergebnis: {0}", zahl1 + zahl2);
            }
            else if (rechenzeichen == '-' && error != 1)
            { 
                // {0} kann als Platzhalter fuer eine Variable verwendet werden
                Console.WriteLine("Ergebnis: {0}", (zahl1 - zahl2));
            }
            else if (rechenzeichen == '*' && error != 1)
            {
                Console.WriteLine("Ergebnis: {0}", zahl1 * zahl2);
            }
            else if (rechenzeichen == '/' && error != 1 && zahl2 != 0)
            {
                Console.WriteLine("Ergebnis: {0}", zahl1 / zahl2);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }

        }

    }

}
