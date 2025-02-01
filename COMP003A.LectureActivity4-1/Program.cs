﻿namespace COMP003A.LectureActivity4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an array to store 5 grades
            int[] grades = new int[5];

            // Collect, validate, then store the grades
            for (int i = 0; i < grades.Length; i++)
            {
                int grade = -1; // Initialize with an invalid to ensure validation starts
                while (grade < 0 || grade > 100)
                {
                    Console.Write($"Enter grade for student {i + 1} (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out grade))
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("Grade must be between 0 and 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        grade = -1; // Reset grade to an invalid value to re-enter the loop
                    }
                }
            }
        }
    }
}
