namespace feedPercyGame.v1
{
    using System;

        class versionOne
        {
            static void Main(string[] args)
            {
                int happiness = 0, health = 0, direction = 0, round = 0;
                Random r = new Random();
                bool win = false;
                Console.Write("What is your name? ");
                string name = Console.ReadLine();
                initValues(ref happiness, ref health, r);
                while (happiness > 0 && health > 0 && win == false)
                {
                    direction = chooseDirection();
                    /* the direction impacts the number passed to the actions method
                     * if they choose left, they will only receive bad outcomes
                     * if they choose right, they have a better chance of receiving 
                     * good outcomes along with the bad outcomes */
                    if (direction == 1)
                        actions(r.Next(4), ref happiness, ref health);
                    else
                        actions(r.Next(10), ref happiness, ref health);
                    checkResults(ref round, ref happiness, ref health, ref win);
                }
                if (win)
                    Console.WriteLine("Congratulations on successfully taking care of Percy the Pig!");
                else if (happiness <= 0)
                    Console.WriteLine("Percy the Pig feels overwhelming sadness and will no longer interact with you.");
                else if (health <= 0)
                    Console.WriteLine("Percy the Pig suddenly feels ill and faints. He will no longer interact with you.");

            }

            private static void checkResults(ref int round, ref int happiness, ref int health, ref bool win)
            {
                while (round < 10)
                {
                    Console.WriteLine($"~~~~~~~~~~~~~~~~Round {round}~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"Happiness:{happiness} Health:{health}");
                    round++;
                    return;
                }
                if (round >= 10)
                {
                    Console.WriteLine("Congratuations on succesfully taking care of Percy the Pig");
                }
                if (happiness == 15)
                {
                    Console.WriteLine("Congratuations of making Percy a happy pig!");
                }
            }

            private static void actions(int v, ref int happiness, ref int health)
            {
                switch (v)
                {
                    case 0:
                        Console.WriteLine("You fed Percy a hot dog.");
                        Console.WriteLine("Percy lost 2 units of health and 3 units of happiness.");
                        health -= 2;
                        happiness -= 3;
                        break;
                    case 1:
                        Console.WriteLine("You fed Percy a slice of pepperoni pizza.");
                        Console.WriteLine("Percy lost 1 unit of health and 1 unit of happiness");
                        health -= 1;
                        happiness -= 1;
                        break;
                    case 2:
                        Console.WriteLine("You fed Percy a fried pork chop.");
                        Console.WriteLine("Percy lost 2 units of health and 2 units of happiness");
                        health -= 2;
                        happiness -= 2;
                        break;
                    case 3:
                        Console.WriteLine("You fed Percy a Cuban sandwich.");
                        Console.WriteLine("Percy lost 1 unit of health and 1 unitl of happiness");
                        health -= 1;
                        happiness -= 1;
                        break;
                    case 4:
                        Console.WriteLine("You fed Percy carnitas tacos.");
                        Console.WriteLine("Percy lost 2 units of health");
                        health -= 2;
                        break;
                    case 5:
                        Console.WriteLine("You fed Percy an apple.");
                        Console.WriteLine("Percy gained 2 units of health and 2 units of happiness");
                        health += 2;
                        happiness += 2;
                        break;
                    case 6:
                        Console.WriteLine("You fed Percy an ear of corn.");
                        Console.WriteLine("Percy gained 3 units of health and 1 unit of happiness");
                        health += 3;
                        happiness += 1;
                        break;
                    case 7:
                        Console.WriteLine("You fed Percy a strawberry.");
                        Console.WriteLine("Percy gained 1 unit of health and 2 units of happiness");
                        health += 1;
                        happiness += 2;
                        break;
                    case 8:
                        Console.WriteLine("You fed Percy some string beans.");
                        Console.WriteLine("Percy gained 2 units of health");
                        health += 2;
                        break;
                    case 9:
                        Console.WriteLine("You fed Percy an orange.");
                        Console.WriteLine("Percy gained 3 units of health and 1 unit of happiness");
                        health += 3;
                        happiness += 1;
                        break;
                    default:
                        Console.WriteLine("You fed Percy some ice cream.");
                        Console.WriteLine("Percy gained 3 units of happiness");
                        happiness += 3;
                        break;
                }
            }

            private static int chooseDirection()
            {
                Console.WriteLine("A friendly pig named Percy approaches you, enter 1 to feed Percy leftover food from the fridge and 2 to feed Percy a fruit or vegetable");
                int direction = int.Parse(Console.ReadLine());
                while (direction != 1 && direction != 2)
                {
                    Console.WriteLine("You entered an invalid number, please enter a 1 for fruit or a 2 for vegetable");
                    direction = int.Parse(Console.ReadLine());
                }
                return direction;
            }

            private static void initValues(ref int happiness, ref int health, Random r)
            {
                happiness = r.Next(5) + 5;
                health = r.Next(5) + 5;
                return;
            }
        }
    }