/*
 *  Etscheidungsfrage 1
 *  - Entscheidung A
 *      Etscheidungsfrage 1.1
 *          - Entscheidung A
 *              Führt zu Entscheidung 2
 *          - Entscheidung B
 *              Game Over
 *  - Entscheidung B
 *      Führt zu Entscheidung 2
 *  - Entscheidung C
 *      Etscheidungsfrage 1.3
 *          - Entscheidung A
 *              Führt zu Entscheidung 2
 *          - Entscheidung B
 *              Führt zu Entscheidung 2
 *  - Entscheidung D
 *      Game Over
 *      
 *  Entscheidungsfrage 2
 *  ...
 */



namespace Textetventure1
{
    internal class Example
    {
        static void Main(string[] args)
        {
            int antwort = 0;
            int gegenstand = 0;
            int raum = 1;
            Console.WriteLine("Fragetext1(A1,B2,C3,D4)");
            antwort = int.Parse(Console.ReadLine());

            if (antwort == 1 && raum == 1)
            {
                Console.WriteLine("Beschreibungstext oder Fragetext Gegenstand aufheben?");
                antwort = int.Parse(Console.ReadLine());
                if (antwort == 1)
                {
                    Console.WriteLine("Gegenstand aufgehoben");
                    gegenstand = 1;
                }
                else if (antwort == 2)
                {
                    Console.WriteLine("Gegenstand liegen gelassen");
                }
            }
            else if (antwort == 2)
            {
                Console.WriteLine("Gehe in Raum 2");
                antwort = int.Parse(Console.ReadLine());
            }
            else if (antwort == 3)
            {
                Console.WriteLine("Beschreibungstext oder Fragetext");
                antwort = int.Parse(Console.ReadLine());
            }
            else if (antwort == 4)
            {
                Console.WriteLine("Beschreibungstext oder Fragetext");
                antwort = int.Parse(Console.ReadLine());
            }

            if (raum == 2)
            {
                if (gegenstand == 1)
                {
                    Console.WriteLine("Du besiegst Monster mit dem Gegenstand");
                    raum = 4;
                }
                else if (antwort == 2)
                {
                    Console.WriteLine("Du wirst vom Monster besiegt");
                }
            }

            if (raum == 3)
            {

            }

            if (raum == 4)
            {
                Console.WriteLine("You Win");
            }

            if(raum == 0)
            {
                Console.WriteLine("Game Over");
            }
        }
    }
}
