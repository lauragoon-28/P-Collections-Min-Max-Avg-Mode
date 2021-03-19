using System;
using System.Collections.Generic;

namespace P_Collections_Min_Max_Avg_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ask the user to enter all of their exam grades.  Once they are done, calculate the minimum score, the maximum 
            score, the mode score and the average score for all of their scores.Perform this using at least 2 Loops(can be the 
            same type of loop) and not any built in functions.*/

            double testScore = 0;

            List<double> examScores = new List<double>();

            while (testScore != -1)
            {
                Console.WriteLine("Please enter in an exam grade.(Enter -1 when done)");
                string answer = Console.ReadLine();

                while (double.TryParse(answer, out testScore) == false)
                {
                    Console.WriteLine("Invalid response. Please enter a number!!");
                    Console.WriteLine("Please enter in an exam grade.(Enter -1 when done)");
                    answer = Console.ReadLine();
                }

                if (testScore != -1)
                {
                    examScores.Add(testScore);
                }
            }
            // 100, 99, 50, 81, 60, 81
            double minScore = examScores[0];
            double maxScore = examScores[0];
            double combinedScore = 0; 
            for (int i = 0; i < examScores.Count; i++)
            {
                if (examScores[i] < minScore )
                {
                    minScore = examScores[i];
                }

                if (examScores[i] > maxScore)
                {
                    maxScore = examScores[i];
                }

                combinedScore = combinedScore + examScores[i];

            }
            double averageScore = combinedScore / examScores.Count;

            Dictionary<double, double> modeDictionary = new Dictionary<double, double>();

            for (int i = 0; i < examScores.Count; i++)
            {
                if (modeDictionary.ContainsKey(examScores[i]) == true)
                {
                    modeDictionary[examScores[i]] += 1;
                }
                else
                {
                    modeDictionary.Add(examScores[i], 1); 
                }
            }

            double mode = 0;
            double max = 0;
            for (int i = 0; i < examScores.Count; i++)
            {
                if (modeDictionary[examScores[i]] > max)
                {
                    max = modeDictionary[examScores[i]];
                    mode = examScores[i];
                }
            }

            Console.WriteLine($"Your minimum exam grade is {minScore.ToString("N2")}!");
            Console.WriteLine($"Your maximum exam grade is {maxScore.ToString("N2")}!");
            Console.WriteLine($"Your mode exam grade is {mode.ToString("N2")}!");
            Console.WriteLine($"Your average exam grade is {averageScore.ToString("N2")}!");


        }
    }
}
