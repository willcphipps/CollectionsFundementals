using System;
using System.Collections.Generic;
namespace CollectionsPractice
{
    class Program
    {

// Create an array to hold integer values 0 through 9
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
// Create an array of length 10 that alternates between true and false values, starting with true
        static void ThreeBasicArrays()
        {
            int[] NumArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] StringArr;
            StringArr = new string[] { "tim", "martin", "nikki", "sara" };
            bool[] BoolArr = new bool[10];
            for (int i = 0; i < BoolArr.Length; i+=2){
                BoolArr[i] = true;
            }
            Console.WriteLine(NumArr);
            Console.WriteLine(StringArr);
            Console.WriteLine(BoolArr);
        }
        static void ListOfFlavors()
        {
            List<string> Flavors = new List<string>();
            Flavors.Add("Vanilla");
            Flavors.Add("Strawberry");
            Flavors.Add("Chocolate");
            Flavors.Add("Rainbow Sprinkle");
            Flavors.Add("Garlic Squash");
            Console.WriteLine(Flavors.Count);
            Console.WriteLine(Flavors[2]);
            Flavors.RemoveAt(2);
            Console.WriteLine(Flavors.Count);
        }
        static void UserInfoDictionary()
        {
            Dictionary<string, string> User = new Dictionary<string, string>();
            User.Add("tim", "Garlic Squash");
            User.Add("martin", "Rainbow Sprinkle");
            User.Add("nikki", "Vanilla");
            User.Add("sara", "Strawberry");
            foreach( var entry in User)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }
        }
            
        static void Main(string[] args)
        {
            ThreeBasicArrays();
            ListOfFlavors();
            UserInfoDictionary();
        }
    }
}
