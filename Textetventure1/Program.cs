namespace Textetventure1
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Du befindest dich in der Küche!");
                Console.WriteLine("Was willst du tun?");
                Console.WriteLine("1. Ich gehe in's Wohnzimmer      3. Ich gehe in den Flur");
                Console.WriteLine("2. Ich gehe in den Garten        4. Ich mach mir ein Sandwitch");
                Console.WriteLine("Exit with 0");

                int action = 0;

                try
                {
                    action = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    action = 0;
                }


                if (action == 1)
                {
                    Console.WriteLine("Du gehst in's Wohnzimmer!");
                    Console.WriteLine("Du bist im Wohnzimmer, was willst du tun?");
                    Console.WriteLine("1. Ich setze mich auf die Coutch         3. Ich streichel meine Katze");
                    Console.WriteLine("2. Ich lege mich auf die Coutch          4. Ich gehe in den Flur");
                    Console.WriteLine("Exit with 0");

                    try
                    {
                        action = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        action = 0;
                    }
                    if (action == 1)
                    {
                        Console.WriteLine("Du setzt dich auf die Coutch");
                        Console.WriteLine("Was willst du tun?");
                        Console.WriteLine("1. Ich lege mich auf die Coutch         2. Ich streichel meine Katze");
                        Console.WriteLine("3. Ich gehe in den Flur");
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            action = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            action = 0;
                        }

                        if (action == 1)
                        {
                            Console.WriteLine("Du legst dich auf die Coutch");
                            Console.WriteLine("Was willst du tun?");
                            Console.WriteLine("1. Ich streichel meine Katze         2. Ich gehe in den Flur");
                            Console.WriteLine("Exit with 0");

                            try
                            {
                                action = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                action = 0;
                            }

                            if (action == 1)
                            {
                                Console.WriteLine("Du streichelst diene Katze");
                                Console.WriteLine("Du hast das Ziel des Spiels erreicht!");
                                Console.WriteLine("Exit with 0");

                                try
                                {
                                    action = int.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    action = 0;
                                }
                                if (action == 0)
                                {
                                    Console.WriteLine("now exiting");
                                }
                            }
                        }

                    }
                    else if (action == 2)
                    {
                        Console.WriteLine("Du legst dich auf die Coutch");
                        Console.WriteLine("Was willst du tun?");
                        Console.WriteLine("1. Ich streichel meine Katze");
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            action = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            action = 0;
                        }
                        if (action == 1)
                        {
                            Console.WriteLine("Du streichelst diene Katze");
                            Console.WriteLine("Du hast das Ziel des Spiels erreicht!");
                            Console.WriteLine("Exit with 0");

                            try
                            {
                                action = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                action = 0;
                            }
                            if (action == 0)
                            {
                                Console.WriteLine("now exiting");
                            }
                        }
                    }
                    else if (action == 3)
                    {
                        Console.WriteLine("Du streichelst diene Katze");
                        Console.WriteLine("Du hast das Ziel des Spiels erreicht!");
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            action = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            action = 0;
                        }
                        if (action == 0)
                        {
                            Console.WriteLine("now exiting");
                        }

                    }
                    else if (action == 4)
                    {
                        Console.WriteLine("Du gehst in den Flur");
                        Console.WriteLine("Du bist im Flur, was willst du tun?");
                        Console.WriteLine("1. Ich gehe in's Wohnzimmer          2. Ich gehe in den Garten");
                        Console.WriteLine("Exit with 0");

                        try
                        {
                            action = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            action = 0;
                        }

                    }
                    else
                    {
                        Console.WriteLine("now exeting!");
                    }
                }
                else if (action == 2)
                {
                    Console.WriteLine("Du gehst in den Garten!");
                    Console.WriteLine("Du bist im Garten, was willst du tun?");
                    Console.WriteLine("1. Ich lege mich auf den Rasen           3. Ich gehe in's Wohnzimmer");
                    Console.WriteLine("2. Ich gehe in den Flur                  4. Ich grüße den Nachbarn");
                    Console.WriteLine("Exit with 0");

                    try
                    {
                        action = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        action = 0;
                    }

                }
                else if (action == 3)
                {
                    Console.WriteLine("Du gehst in den Flur");
                    Console.WriteLine("Du bist im Flur, was willst du tun?");
                    Console.WriteLine("1. Ich gehe in's Wohnzimmer          2. Ich gehe in den Garten");
                    Console.WriteLine("Exit with 0");

                    try
                    {
                        action = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        action = 0;
                    }

                }
                else if (action == 4) 
                { 
                    Console.WriteLine("Du machst dir ein Sandwitch");
                    Console.WriteLine("Was willst du tun?");
                    Console.WriteLine("1. Ich gehe in's Wohnzimmer      3. Ich gehe in den Flur");
                    Console.WriteLine("2. Ich gehe in den Garten        4. Ich esse das Sandwitch");
                    Console.WriteLine("Exit with 0");

                    try
                    {
                        action = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        action = 0;
                    }

                }
                else
                {
                    Console.WriteLine("now exeting!");
                }

            }

        }

    }
