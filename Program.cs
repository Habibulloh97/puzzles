using System;
using System.Collections.Generic;



namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] numbers = RandomArray();
            // int max= numbers[0];
            // int min= numbers[0];
            // int sum=0;

            // for (int i=0; i<numbers.Length; i++)
            // {
            //     if (numbers[i]>max)
            //     {
            //         max=numbers[i];
            //     }
            //     if (numbers[i]<min)
            //     {
            //         min=numbers[i];
            //     }
            //     sum+=numbers[i];
            // }
            // Console.WriteLine($"Max value is {max} Min Value is {min} Sum value is {sum}");

            Names();


        }

        public static int[] RandomArray()
        {
            int [] numbers= new int [10];
            Random rand = new Random();
            for ( int i=0; i<numbers.Length; i++)
            {
                numbers[i]=rand.Next(5,25);
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }


        public static string TossCoin()
        {
            Random rand = new Random();
            int TossedCoin=rand.Next(1,3);
            if (TossedCoin==1)
            {
                return "Heads";
            }
            else return "Tails";
        }
        public static List <string> Names()
        {
            // List<string> newlist= new List<string>();
            List<string> name= new List<string>();
            name.Add("Todd");
            name.Add("Tiffany");
            name.Add("Charlie");
            name.Add("Geneva");
            name.Add("Sydney");
            // Random rand = new Random();
            // int randuser=rand.Next(name.Count);
            // int randnum=0;
            // while (newlist.Count!=name.Count)
            // {
            //     if 
            // }
            // foreach(string list in newlist)
            // {
            //     Console.WriteLine(list);
            // }
            for (int i=0; i<name.Count; i++)
            {
                if (name[i].Length<5)
                {
                    name.RemoveAt(i);
                }
            }
            foreach (string x in name)
            {
                Console.WriteLine(x);
            }
            return name;
        }
    }
}
