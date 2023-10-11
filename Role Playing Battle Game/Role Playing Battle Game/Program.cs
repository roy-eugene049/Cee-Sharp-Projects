using System;

class Program
{
    static void Main()
    {
        //Initialize Healths
        int heroHealth = 10;
        int monsterHealth = 10;

        //create Random object
        Random random = new Random();

        do
        {
            //Hero & Monster attack damage
            int heroAttackDamage = random.Next(1, 11);
            int monsterAttackDamage = random.Next(1, 11);

            //Hero's Turn
            Console.WriteLine($"Monster was damaged and lost {heroAttackDamage} health points and now has {monsterHealth - heroAttackDamage} health points remaining.");
            monsterHealth -= heroAttackDamage;

            //Monster's Turn
            Console.WriteLine($"Hero was damaged and lost {monsterAttackDamage} health points and now has {heroHealth - monsterAttackDamage} health points remaining.");
            heroHealth -= monsterAttackDamage;

            if (monsterHealth <= 0)
            {
                Console.WriteLine("Monster was defeated, Hero Wins!");
                break;
            }

            if (heroHealth <= 0)
            {
                Console.WriteLine("Hero was defeated, Monster Wins!");
                break;
            }


        } while (heroHealth > 0 && monsterHealth > 0);
    }
}