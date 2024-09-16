using ConsoleRPG;


namespace ConsoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char mainAction = '0';


            Console.WriteLine("please name your caracter to start:");

            Hero hero = new Hero() { name= Console.ReadLine() };
            Console.WriteLine("Your character name is: " + hero.name);
            while (hero.curHealth > 0 && mainAction != '4')
            {
                int error = 0;
                if (hero.curHealth > hero.maxHealth) 
                    hero.curHealth = hero.maxHealth;

                while (mainAction == '0')
                {
                    Console.WriteLine("\nMain Menue:" +
                        "\n1. stats        2. adventure" +
                        "\n3. shop         4. exit");

                    while (mainAction == '0' || error == 1)
                    {
                        error = 0;
                        mainAction = Console.ReadKey().KeyChar;

                        if (mainAction != '0' && mainAction != '1' && mainAction != '2' && mainAction != '3' && mainAction != '4') { error = 1; Console.WriteLine("\nwrong input please try again!"); }

                    }

                }

                switch (mainAction) 
                {
                    case '1':
                    {
                        Console.Clear();

                        Console.WriteLine("\n" + hero.name + "   Level:" + hero.lvl +
                                          "\nMax HP: " + hero.maxHealth +  "          dmg: " + hero.damage + "            action speed: " + hero.actionSpeed);
                        mainAction = '0';
                        break;
                    }
                    case '2':
                        {
                            Console.Clear();
                            char atventureAction = ' ';

                        while (atventureAction == ' ')
                        {
                        
                            Console.WriteLine("Adventure");
                            Console.WriteLine("\nWhere do you want to go?" +
                                              "\n1. Village of Roumen          2. City of Elderine" +
                                              "\n3. City of Uruga              4. City of Adelia");
                            Console.WriteLine("back with 0");

                            atventureAction = Console.ReadKey().KeyChar;

                            if (atventureAction == '0') 
                            {
                                mainAction = '0'; atventureAction = ' '; break; 
                            }

                            switch (atventureAction)
                            {
                                case '1':
                                {
                                    Console.Clear();
                                    char roumenAction = ' ';
                                    while (atventureAction == '1')
                                    {

                                        Console.WriteLine("\nYou enter Roumen. What do you want to do?\n" +
                                                          "2. Search for Quests           3. Go to the Healer\n" +
                                                          "4. Enter the Forest of Mist    5. Go to the Sandy Beach\n" +
                                                          "5. Go to the Blacksmith");
                                        Console.WriteLine("back with 0");

                                        roumenAction = Console.ReadKey().KeyChar;

                                        if (roumenAction == '0') { roumenAction = ' '; atventureAction = ' '; break; }

                                        switch (roumenAction)
                                        {
                                            case '1':
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nQuests are currently unavailable");
                                                roumenAction = ' ';
                                                break;
                                            }

                                            case '2':
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nThe Healer heals you to your full HP");
                                                hero.curHealth = hero.maxHealth;
                                                roumenAction = ' ';
                                                break;
                                            }

                                            case '3':
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nYou enter the Forest of Mist!\n");
                                                Console.WriteLine("");
                                                break;
                                            }

                                            case '4':
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nYou enter the Sandy Beach!\n");
                                                Console.WriteLine("");
                                                break;
                                            }

                                            case '5':
                                                {
                                                Console.Clear();
                                                while (roumenAction == '5')
                                                {
                                                    char jamesAction = ' ';
                                                    Console.WriteLine("\nYou go to the James the Blacksmith");
                                                    Console.WriteLine("What do you want to do?");
                                                    Console.WriteLine("2. Buy a Weapon          3. Buy an Armor\n" +
                                                                      "4. Sell loot             5. Smith a Weapon\n" +
                                                                      "6. Smith an Armor        7. upgrade your Weapon\n");
                                                    Console.WriteLine("back with 0");

                                                    jamesAction = Console.ReadKey().KeyChar;

                                                    if (jamesAction == '0') { roumenAction = ' '; jamesAction = ' '; break; }

                                                    switch (jamesAction)
                                                    {
                                                        case '1':
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nJames has the following Weapons for you");
                                                            Console.WriteLine("1. Adventurer Bow (lvl: 1; dmg: 5; actionSpeed: 2) 10$\n" +
                                                                              "2. Iron Sword (lvl: 5; dmg: 15; actionSpeed: 1) 20$\n" +
                                                                              "3. Iron Hammer (lvl: 15; dmg: 80 actionSpeed: 5)  40$");
                                                            Console.WriteLine("which one do you want to buy?\nback with 0");

                                                            break;
                                                        }

                                                    }

                                                }
                                                break;
                                            }

                                        }

                                    }
                                    break;
                                }

                            }

                        }
                        break;
                    }


                }

            }

            if (mainAction == '3')
            {
                Console.WriteLine("\nthe shop is currently unavailable");
            }

            if (mainAction == '4')
            {
                Console.WriteLine("\nclosing now ...");
            }

            if (hero.curHealth <= 0)
            {
                Console.WriteLine("\n Game Over");
            }

        }

    }

}

