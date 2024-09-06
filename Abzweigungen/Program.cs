namespace Abzweigungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstellung integer
            int test = 0;

            // Eingabe mit try/catch
            Console.WriteLine("Bitte gebe eine Zahl ein: ");
            try
            {
                test = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // if else zusammen mit else if Abzweigung
            if (test > 10)
            {
                Console.WriteLine("Zahl ist größer als 10");
            }
            else if (test == 10)
            {
                Console.WriteLine("Zahl ist 10");
            }
            else
            {
                Console.WriteLine("Zahl ist kleiner als 10");
            }

            Console.WriteLine("Hier ist das Ende!");



        }

    }

}
