using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            long pumps = long.Parse(Console.ReadLine());
            long[] PetrolFromPumps = new long[pumps];
            long[] DistanceToPumps = new long[pumps];

            for (int i = 0; i < pumps; i++)
            {
                long[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                PetrolFromPumps[i] = input[0];
                DistanceToPumps[i] = input[1];
            }
            long gas = 0;
            bool CompletedTour = true;

            for (int i = 0; i < pumps; i++)
            {
                long temp = i;
                for (int o = 0; o < pumps; o++)
                {
                    gas += PetrolFromPumps[temp];                   
                    if (gas >= DistanceToPumps[temp])
                    {
                        gas -= DistanceToPumps[temp];
                        CompletedTour = true;

                    }
                    else
                    {
                        CompletedTour = false;
                        gas = 0;
                        break;
                    }
                    if (temp == pumps - 1)
                    {
                        temp = 0;
                    }
                    else
                        temp++;
                }
                if (CompletedTour == true)
                {
                    Console.WriteLine(i);
                    return;
                    
                }
                
            }

        }
    }
}
