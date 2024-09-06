namespace Datentypen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bool
            // true or falsse
            bool testBool = true;
            bool falseBool = false;

            // Char 
            // ASCII (American Standart Code for Information Interchange) - Zeichen
            char testChar = 'z';
            char otherChar = 'a';


            // Byte - kein Vorzeichen!!!
            // 8bit 255
            byte testByte = 250;
            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;

            // sByte mit Vorzeichen!!!
            // 8bit -128 - 127
            sbyte testSByte = -127;
            sbyte maxSByte = sbyte.MaxValue;
            sbyte minSByte = sbyte.MinValue;

            // int mit Vorzeichen
            // 32bit -2Mrd - 2Mrd
            int testInt = 532649213;
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            // long mit Vorzeichen
            // 64bit 9Trd
            long testLong = 326568213453641894;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            // float
            float testFloat = 3.14f;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;

            // double
            double testDouble = 3.145d;
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;

            // decimal
            decimal testDecimal = 3.34352m;
            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;

            // string
            // Zeichenkette => so groß wie benoetigt
            string testString = "Bananana";


            Console.WriteLine(testBool);
            Console.WriteLine(testChar);
            Console.WriteLine(testByte);
            Console.WriteLine(testSByte);
            Console.WriteLine(testInt);
            Console.WriteLine(testLong);
            Console.WriteLine(testFloat);
            Console.WriteLine(testDouble);
            Console.WriteLine(testDecimal);
            Console.WriteLine(testString);

            Console.WriteLine(falseBool);
            Console.WriteLine(otherChar);
            Console.WriteLine(maxByte);
            Console.WriteLine(minByte);
            Console.WriteLine(maxSByte);
            Console.WriteLine(minSByte);
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);
            Console.WriteLine(maxLong);
            Console.WriteLine(minLong);
            Console.WriteLine(maxFloat);
            Console.WriteLine(minFloat);
            Console.WriteLine(maxDouble);
            Console.WriteLine(minDouble);
            Console.WriteLine(maxDecimal);
            Console.WriteLine(minDecimal);

            // Overflow 
            maxByte ++;
            Console.WriteLine(maxByte);
            maxSByte ++;
            Console.WriteLine(maxSByte);
            maxInt ++;
            Console.WriteLine(maxInt);
            // Error
            //maxDecimal ++;
            Console.WriteLine(maxDecimal);

            // Variable kann zur Laufzeit veraendert werden
            int newTest = 10;
            newTest = 15;
            Console.WriteLine(newTest);

            // Konstante unveraenderlich
            const int constTest = 20;
            //constTest ++;
            Console.WriteLine(constTest);


        }

    }

}
