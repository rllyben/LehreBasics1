namespace Operatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben Sie eine Länge ein:");
            int laenge = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie eine Breite ein:");
            int breite = int.Parse(Console.ReadLine());
            int umfang;
            int flaeche;

            umfang = laenge + breite * 2;
            flaeche = laenge * breite;

            Console.WriteLine("der Umpfang ist: " + umfang);
            Console.WriteLine("die Fläche ist: " + flaeche);



        }
    }
}
