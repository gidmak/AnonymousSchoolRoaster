using System;
using System.Collections.Generic;

namespace AnonymousSchoolRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** ANONYMOUS SCHOOL ROASTER *****");

            Random numberOfStudents = new Random();
            List<int> scores = new List<int>();

            
            for(int i = 0; i < numberOfStudents.Next(20,150); i++)
            {
                scores.Add(numberOfStudents.Next(1,100));
            }

            int firstTier = 0;
            int secondTier = 0;
            int failed = 0;
            
            for(int j = 0; j < scores.Count; j++)
            {
                if(scores[j] >= 70)
                {
                    firstTier++;
                }
                else if(scores[j] >= 50)
                {
                    secondTier++;
                }
                else
                {
                    failed++;
                }
                
            }
            Console.WriteLine("TOTAL STUDENTS: " + scores.Count);
            Console.WriteLine("ABOVE 70: " + firstTier);
            Console.WriteLine("BETWEEN 50 AND 69: " + secondTier);
            Console.WriteLine("BELOW 50: " + failed);
            //Console.WriteLine(examScores.Next(1,100));

            int roll = 0;
            foreach(int totalScore in scores)
            {
                roll++;
                Console.WriteLine(roll+") " + totalScore);
            }
        }
    }
}
