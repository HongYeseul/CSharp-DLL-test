using System;
using System.Collections.Generic;
using myCalc;
using myPeopleDLL;

namespace CSharp_DLL_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 + 2 = {0}", Calculator.Add(3, 2));
            Console.WriteLine("3 - 2 = {0}", Calculator.Sub(3, 2));

            List<Friend> listFriends = new List<Friend>();
            listFriends.Add(new Friend("Onion", "deliciousOnion", 15, false));
            listFriends.Add(new Friend("Chemi", "Queen_Chemi", 17, false));
            listFriends.Add(new Friend("mikong", "GoMiko45", 19, false));
            listFriends.Add(new Friend("Nacho", "Nacho_0101", 31, false));
            listFriends.Add(new Friend("Onga", "OngChan99", 22, false));
            listFriends.Add(new Friend("Sara", "OwO_OwO", 21, false));
            listFriends.Add(new Friend("bunny", "Rabbit12", 28, false));
            listFriends.Add(new Friend("choco", "ChocoChan", 17, false));
            listFriends.Add(new Friend("Mitte", "mitteLOVE", 21, false));

            foreach (Friend a in listFriends)
            {
                Console.WriteLine(a.Name + " " + a.Id);
            }
        }
    }
}
