namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Deklaration der Zahl Variablen
            float a, b;

            // Einlesen der Zahl Variablen
            Console.WriteLine("Eingabe erste Zahl:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Eingabe zweite Zahl:");
            b = float.Parse(Console.ReadLine());

            // Deklaration der ausgabe Variablen + Rechnungen
            float add = a + b;
            float sub = a - b;
            float mul = a * b;
            float div = a / b;

            // Ausgabe der Ergebnisse
            Console.WriteLine("Die Addition ist: " + add);
            Console.WriteLine("Die Subtraktion ist: " + sub);
            Console.WriteLine("Die Multiplikation ist: " + mul);
            Console.WriteLine("Die Division ist: " + div);
            */
            
            // Variante mit nur 3 Variablen
            float a, b, ergebnis;

            // Besser wären einzelne try/catchs nur für die Eingaben
            try
            {
                Console.WriteLine("Eingabe erste Zahl: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Eingabe zweite Zahl: ");
                b = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                a = 1; b = 1;
            }
            // Addition
            ergebnis = a + b;
            Console.WriteLine("Additions Ergebnis: " + ergebnis);

            // Subtraktion
            ergebnis = a - b;
            Console.WriteLine("Subtraktions Ergebnis: " + ergebnis);

            // Multiplikation
            ergebnis = a * b;
            Console.WriteLine("Multiplikations Ergebnis: " + ergebnis);

            // Division
            ergebnis = a / b;
            Console.WriteLine("Divisions Ergebnis" + ergebnis);

        }

    }

}
