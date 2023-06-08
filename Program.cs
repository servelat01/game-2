using System;

namespace game_practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Text text = new Text();
            text.Welcome();
            Player player = new Player("Люсьен", 100, 1500, 0);
            Skelet skelet = new Skelet("Костантин", 20, 500);
            Ork ork = new Ork("Ляррррва", 40, 700);
            Wizard wizard = new Wizard("Якубович", 55, 900);







            while (true)
            {

              






                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Poison_hp();
                }
                else if (choise == 2)
                {
                    Poison_damage();
                }
                else if (choise == 3)
                {
                    Battle_Skelet();
                }
                else if (choise == 4)
                {
                    Battle_Ork();
                }
                else if (choise == 5)
                {
                    Battle_Wizard();
                }
                else if (choise == 6)
                {
                    Poison_damage();
                }

                void Poison_hp()
                {
                    player.Health = player.Health += 800;
                    
                    Console.WriteLine($"вы выбрали бафф хп, количество ваших хп {player.Health}");
                    Console.WriteLine($"Монет осталось: {player.Coins -=6}");

                }

                void Poison_damage()
                {
                    player.Damage = player.Damage += 15;
                    Console.WriteLine($"вы выбрали бафф урона, количество вашего урона {player.Damage}");
                    Console.WriteLine($"Монет осталось: {player.Coins -= 8}");

                }


                void Battle_Skelet()
                {
                    Console.WriteLine($"Вы начали битву со скелетом по имени Константин");
                    while (player.Health > 0 && skelet.Health > 0)
                    {

                        Console.WriteLine($"Люсьен бьет оставляя Константину {skelet.Health -= player.Damage} здоровья");
                        Console.WriteLine($"Константин бьет оставляя Люсьену {player.Health -= skelet.Damage} здоровья");
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"Вы победили и получили 1 монетку.  Монет в сумке {player.Coins += 1}");
                }


                void Battle_Ork()
                {
                    Console.WriteLine($"Вы начали битву со орком по имени Ляррррва");
                    while (player.Health > 0 && ork.Health > 0)
                    {
                        Console.WriteLine($"Люсьен бьет оставляя Ляррррве {ork.Health -= player.Damage} здоровья");
                        Console.WriteLine($"Ляррррва бьет оставляя Люсьену{player.Health -= ork.Damage} здоровья");
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"Вы победили и получили 3 монетки.  Монет в сумке {player.Coins += 3}");
                }

                void Battle_Wizard()
                {
                    Console.WriteLine($"Вы начали битву с магом по имени Якубович");
                    while (player.Health > 0 && wizard.Health > 0)
                    {
                        Console.WriteLine($"Люсьен бьет оставляя Якубовичу {wizard.Health -= player.Damage} здоровья");
                        Console.WriteLine($"Якубович бьет оставляя Люсьену {player.Health -= wizard.Damage} здоровья");
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"Вы победили и получили 7 монеток.  Монет в сумке {player.Coins += 7}");
                }

            }

        }
    }
}