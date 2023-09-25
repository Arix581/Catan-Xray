// Made by Benjamin Espenschied
// V1.2.3

using System;

namespace myProgram
{
    class Program
    {
        CatanPlayer[] players;
        int playerCount = 1;
        string mode = "startup";
        CatanPlayer targetPlayer1;
        CatanPlayer targetPlayer2;
        static void Main(string[] args)
        {
            //put code here
            
            Console.WriteLine("Welcome to Catan! How many players would you like?");
            playerCount = (int)Console.ReadLine();
            players = new CatanPlayer[playerCount];
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("What is the name of the " + (i+1).ToString() + "th player? ");
                players[i] = new CatanPlayer(Console.ReadLine());
            }
            
            while (mode != "end")
            {
                Console.WriteLine("What would you like to do now?");
                Console.WriteLine("You can 'add resourses', 'buy', 'exchange', 'trade', or 'show'. ");
                
                mode = Console.ReadLine();
                
                if (mode = "add resourses")
                {
                    Console.WriteLine("Who would you like to add to?");
                    mode = Console.ReadLine();
                    foreach (var player in players)
                    {
                        if (player.name == mode)
                        {
                            Console.WriteLine("What Material?");
                            mode = Console.ReadLine();
                            Console.WriteLine("How much?");
                            player.AddResources(mode, (int)Console.ReadLine());
                        }
                    }
                }
            }
        }
    }
    
    class Product
    {
        public int oreCost;
        public int brickCost;
        public int sheepCost;
        public int grainCost;
        public int woodCost;
        
        public Product(int ore, int brick, int sheep, int grain, int wood)
        {
            oreCost = ore;
            brickCost = brick;
            sheepCost = sheep;
            grainCost = grain;
            woodCost = wood;
        }
    }
    
    static class Store
    {
        static public void Exchange(CatanPlayer player, string input, string output, int price = 4)
        {
            switch (input, output) 
            {
                // Ore Trades
                case ("ore", "brick"):
                    player.ore -= price;
                    player.brick++;
                    break;
                case ("ore", "sheep"):
                    player.ore -= price;
                    player.sheep++;
                    break;
                case ("ore", "grain"):
                    player.ore -= price;
                    player.grain++;
                    break;
                case ("ore", "wood"):
                    player.ore -= price;
                    player.wood++;
                    break;
                // Brick Trades
                case ("brick", "ore"):
                    player.brick -= price;
                    player.ore++;
                    break;
                case ("brick", "sheep"):
                    player.brick -= price;
                    player.sheep++;
                    break;
                case ("brick", "grain"):
                    player.brick -= price;
                    player.grain++;
                    break;
                case ("brick", "wood"):
                    player.brick -= price;
                    player.wood++;
                    break;
                // Sheep Trades
                case ("sheep", "ore"):
                    player.sheep -= price;
                    player.ore++;
                    break;
                case ("sheep", "brick"):
                    player.sheep -= price;
                    player.brick++;
                    break;
                case ("sheep", "grain"):
                    player.sheep -= price;
                    player.grain++;
                    break;
                case ("sheep", "wood"):
                    player.sheep -= price;
                    player.wood++;
                    break;
                // Grain Trades
                case ("grain", "ore"):
                    player.grain -= price;
                    player.ore++;
                    break;
                case ("grain", "brick"):
                    player.grain -= price;
                    player.brick++;
                    break;
                case ("grain", "sheep"):
                    player.grain -= price;
                    player.sheep++;
                    break;
                case ("grain", "wood"):
                    player.grain -= price;
                    player.wood++;
                    break;
                // Grain Trades
                case ("wood", "ore"):
                    player.wood -= price;
                    player.ore++;
                    break;
                case ("wood", "brick"):
                    player.wood -= price;
                    player.brick++;
                    break;
                case ("wood", "sheep"):
                    player.wood -= price;
                    player.sheep++;
                    break;
                case ("wood", "grain"):
                    player.wood -= price;
                    player.grain++;
                    break;
            }
        }
        
        static public void Buy(CatanPlayer player, Product product)
        {
            player.ore -= product.oreCost;
            player.brick -= product.brickCost;
            player.sheep -= product.sheepCost;
            player.grain -= product.grainCost;
            player.wood -= product.woodCost;
        }
    }
    
    class CatanPlayer
    {
        public int ore;
        public int brick;
        public int sheep;
        public int grain;
        public int wood;
        public string name;
        
        public CatanPlayer(string _name)
        {
            ore = 0;
            brick = 0;
            sheep = 0;
            grain = 0;
            wood = 0;
            name = _name;
        }
        
        public void showStuff()
        {
            Console.WriteLine(name + " has " + ore + " ore, " + brick + " brick");
        }
        
        public void AddResources(string resource, int howMuch)
        {
            if (resource == "ore") {
                ore += howMuch;
            } else if (resource == "brick") {
                brick += howMuch;
            } else if (resource == "sheep") {
                sheep += howMuch;
            } else if (resource == "grain") {
                grain += howMuch;
            } else if (resource == "wood") {
                wood += howMuch;
            }
        }
    }
}
