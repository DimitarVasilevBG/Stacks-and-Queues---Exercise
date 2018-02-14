using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int plantsCount = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            var plantsToRemove = new List<int>();
            for (int i = 0; true ; i++)
            {
                int listCount = plants.Count;
                for (int o= 1; o < plants.Count; o++)
                {
                    if (plants[o] > plants[o - 1])
                        plantsToRemove.Add(plants[o]);

                }
                foreach (var item in plantsToRemove)
                {
                    plants.Remove(item);
                }
                plantsToRemove.Clear();
                if(listCount==plants.Count)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
        }
    }
}
