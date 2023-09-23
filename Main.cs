// Made by Benjamin Espenschied
// V1.2

using System;

namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //put code here
        }
    }
    
    static class Store
    {
        public void Exchange(CatanPlayer player, string input, string output)
        {
            int price = 4;
            switch (input, output) 
            {
                // Ore Trades
                case "ore", "brick":
                    player.ore -= price;
                    player.brick++;
                    break;
                case "ore", "sheep":
                    player.ore -= price;
                    player.sheep++;
                    break;
                case "ore", "grain":
                    player.ore -= price;
                    player.grain++;
                    break;
                case "ore", "wood":
                    player.ore -= price;
                    player.wood++;
                    break;
                // Brick Trades
                case "brick", "ore":
                    player.brick -= price;
                    player.ore++;
                    break;
                case "brick", "sheep":
                    player.brick -= price;
                    player.sheep++;
                    break;
                case "brick", "grain":
                    player.brick -= price;
                    player.grain++;
                    break;
                case "brick", "wood":
                    player.brick -= price;
                    player.wood++;
                    break;
                // Sheep Trades
                case "sheep", "ore":
                    player.sheep -= price;
                    player.ore++;
                    break;
                case "sheep", "brick":
                    player.sheep -= price;
                    player.brick++;
                    break;
                case "sheep", "grain":
                    player.sheep -= price;
                    player.grain++;
                    break;
                case "sheep", "wood":
                    player.sheep -= 4;
                    player.wood++;
                    break;
                // Grain Trades
                case "grain", "ore":
                    player.grain -= 4;
                    player.ore++;
                    break;
                case "grain", "brick":
                    player.grain -= 4;
                    player.brick++;
                    break;
                case "grain", "sheep":
                    player.grain -= 4;
                    player.sheep++;
                    break;
                case "grain", "wood":
                    player.grain -= 4;
                    player.wood++;
                    break;
            }
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
    }
}
