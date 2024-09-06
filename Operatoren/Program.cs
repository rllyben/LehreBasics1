namespace Operatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eingabeaufforderung und Erstellung der entsprechenden Integer
            Console.WriteLine("Geben Sie eine Länge ein:");
            int laenge = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie eine Breite ein:");
            int breite = int.Parse(Console.ReadLine());
            
            // Erstellung Integer
            int umfang;
            int flaeche;

            // Berechnung
            umfang = laenge + breite * 2;
            flaeche = laenge * breite;

            // Ausgabe der Ergebnisse
            Console.WriteLine("der Umpfang ist: " + umfang);
            Console.WriteLine("die Fläche ist: " + flaeche);



        }
    }
}
