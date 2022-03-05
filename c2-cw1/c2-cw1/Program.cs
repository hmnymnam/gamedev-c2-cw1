using System;

namespace c2_cw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "hero";
            double characterSpeed = 3.3;
            int characterAge = 30;
            string superPower1 = "night vision";

            string superPower2 = "self healing";
                Console.WriteLine("my name is {0}, my super powers are {1} and {2} , my age is {3} and my speed is {4}" ,characterName, superPower1,superPower2, characterAge,characterSpeed);
        }
    }
}
