// Made by Benjamin Espenschied
// V1.0

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
    
    class catanPlayer
    {
        public int ore;
        public int brick;
        public int sheep;
        public int grain;
        public int wood;
        public string name;
        
        public catanPlayer(string _name)
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
