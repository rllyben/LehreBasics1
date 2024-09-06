namespace Dreiecksberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben Sie bitte die Basis Länge ein:");
            int basis = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie bitte die Schänkel Länge ein:");
            int schenkel = int.Parse(Console.ReadLine());

            int umfang = 2 * schenkel + basis;
            Console.WriteLine("Umfang:" + umfang);

            Console.WriteLine("Geben Sie bitte die Höhe des Dreiecks ein:");
            int hoehe = int.Parse(Console.ReadLine());

            // bessere Formel waere basis * hoehe / 2
            int flaeche = (int)(0.5 * basis * hoehe);
            Console.WriteLine("Fläche:" + flaeche);


        }
    }
}
