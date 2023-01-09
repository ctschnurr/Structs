using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        //structs
        struct Vector2
        {
            public int x;
            public int y;
        }

        struct Entity
        {
            public string name;
            public int health;
            public int healthMax;
            public int damage;
            public Vector2 position;
        }

        static Vector2 position;
        static Entity player;

        static void Main(string[] args)
        { 
            player.name = "Baymax";
            player.health = 10;
            player.healthMax = 10;
            player.damage = 5;
            player.position.x = 2;
            player.position.y = 3;

            Console.WriteLine("Name: " + player.name);
            Console.WriteLine("Health: " + player.health + "/" + player.healthMax);
            Console.WriteLine("Damage: " + player.damage);
            Console.WriteLine("Position: " + player.position.x + " - " + player.position.y);
          
            Console.ReadKey(true);

            Console.WriteLine("You leveled up! Health Max increased by 5!");
            player.healthMax = player.healthMax + 5;

            Console.WriteLine("Name: " + player.name);
            Console.WriteLine("Health: " + player.health + "/" + player.healthMax);
            Console.WriteLine("Damage: " + player.damage);
            Console.WriteLine("Position: " + player.position.x + " - " + player.position.y);

            Console.ReadKey(true);

        }
    }
}
