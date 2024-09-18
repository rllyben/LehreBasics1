using ConsoleRPG;


namespace ConsoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char mainAction = ' ';
            char atventureAction = ' ';
            char roumenAction = ' ';
            char jamesAction = ' ';

            Console.WriteLine("please name your caracter to start:");
            Hero hero = new Hero() { name= Console.ReadLine() };
            Console.WriteLine("Your character name is: " + hero.name);

            while (hero.curHealth >= 0 && mainAction != '0')
            {
                if (hero.curHealth > hero.maxHealth) 
                    hero.curHealth = hero.maxHealth;

                while (mainAction == ' ')
                {
                    Console.WriteLine("\nMain Menue:" +
                        "\n1. stats        2. adventure" +
                        "\n3. shop         0. exit");

                    mainAction = Console.ReadKey().KeyChar;

                }

                switch (mainAction)
                {
                    case '0':
                    {
                        break;
                    }
                    case '1':
                    {
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n" + hero.name + "   Level:" + hero.lvl);
                        Console.ResetColor();
                        Console.WriteLine("\n       Max HP: " + hero.maxHealth + "\n       dmg: " + hero.damage + "\n       action speed: " + hero.actionSpeed + "\n");
                        mainAction = ' ';
                        break;
                    }
                    case '2':
                    {
                        Console.Clear();

                        while (atventureAction == ' ')
                        {

                        Console.WriteLine("Adventure");
                        Console.WriteLine("\nWhere do you want to go?" +
                                          "\n1. Village of Roumen          2. City of Elderine" +
                                          "\n3. City of Uruga              4. City of Adelia");
                            Console.WriteLine("back with 0");

                            atventureAction = Console.ReadKey().KeyChar;
                        }

                        switch (atventureAction)
                        {
                            case '0':
                            {
                                mainAction = ' ';
                                atventureAction = ' '; 
                                break;
                            }
                            case '1':
                            {
                                Console.Clear();
                                while (roumenAction == ' ')
                                {
                                    Console.WriteLine("\nYou enter Roumen. What do you want to do?\n" +
                                                      "1. Search for Quests           2. Go to the Healer\n" +
                                                      "3. Enter the Forest of Mist    4. Go to the Sandy Beach\n" +
                                                      "5. Go to the Blacksmith");
                                    Console.WriteLine("back with 0");

                                    roumenAction = Console.ReadKey().KeyChar;
                                }

                                switch (roumenAction)
                                {
                                    case '0':
                                    {
                                        roumenAction = ' ';
                                        atventureAction = ' ';
                                        break;
                                    }
                                    case '1':
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nQuests are currently unavailable");
                                        roumenAction = ' ';
                                        Console.ReadKey();
                                        break;
                                    }
                                    case '2':
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nThe Healer heals you to your full HP");
                                        hero.curHealth = hero.maxHealth;
                                        roumenAction = ' ';
                                        Console.ReadKey();
                                        break;
                                    }
                                    case '3':
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nYou enter the Forest of Mist!\n");
                                        Console.WriteLine("");
                                        Console.ReadKey();
                                        break;
                                    }
                                    case '4':
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nYou enter the Sandy Beach!\n");
                                        Console.WriteLine("");
                                        Console.ReadKey();
                                        break;
                                    }
                                    case '5':
                                    {
                                        Console.Clear();
                                        while (jamesAction == ' ')
                                        {
                                            Console.WriteLine("\nYou go to the James the Blacksmith");
                                            Console.WriteLine("What do you want to do?");
                                            Console.WriteLine("2. Buy a Weapon          3. Buy an Armor\n" +
                                                              "4. Sell loot             5. Smith a Weapon\n" +
                                                              "6. Smith an Armor        7. upgrade your Weapon\n");
                                            Console.WriteLine("back with 0");

                                            jamesAction = Console.ReadKey().KeyChar;
                                        }

                                        switch (jamesAction)
                                        {
                                            case '0':
                                            {
                                                jamesAction = ' ';
                                                roumenAction = ' ';
                                                break;
                                            }
                                            case '1':
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\nJames has the following Weapons for you");
                                                Console.WriteLine("1. Adventurer Bow (lvl: 1; dmg: 5; actionSpeed: 2) 10$\n" +
                                                                  "2. Iron Sword (lvl: 5; dmg: 15; actionSpeed: 1) 20$\n" +
                                                                  "3. Iron Hammer (lvl: 15; dmg: 80 actionSpeed: 5)  40$");
                                                Console.WriteLine("which one do you want to buy?\nback with 0");
                                                Console.ReadKey();
                                                break;
                                            }
                                            default:
                                                jamesAction = ' ';
                                                Console.WriteLine("Wrong input plese try again:");
                                                break;
                                            }
                                    break;

                                    }
                                    default:
                                        roumenAction = ' ';
                                        Console.WriteLine("Wrong input plese try again:");
                                        break;
                                }
                            break;
                            }
                            default:
                                atventureAction = ' ';
                                Console.WriteLine("Wrong input plese try again:");
                                break;

                        }
                        break;
                    }
                    case '3':
                    {
                        Console.WriteLine("The shop is currently unavailable!");
                        mainAction = ' ';
                        Console.ReadKey();
                        break;
                    }
                    default:
                        Console.WriteLine("Wrong input please try again:");
                        mainAction = ' ';
                        Console.ReadKey();
                        break;

                }

            }

            if (hero.curHealth <= 0)
            {
                Console.WriteLine("\n Game Over");
            }

        }

    }

}

