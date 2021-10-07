using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] test_Scores;

    public Student() { }
    public Student(string firstName, string lastName, int identification, int[] testScores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
        this.test_Scores = testScores;
    }

    /*    
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    public char Calculate()
    {
        int num_Scores = 0;
        int sum_grades = 0;
        int avg_grades = 0;
        char letter_grades = 'X';

        foreach (int x in test_Scores)
        {
            num_Scores = num_Scores + 1;
            sum_grades = sum_grades + x;
        }
        avg_grades = sum_grades / num_Scores;

        if (avg_grades >= 90) letter_grades = 'O';
        else
        {
            if (avg_grades >= 80 && avg_grades < 90) letter_grades = 'E';
            else
            {
                if (avg_grades >= 70 && avg_grades < 80) letter_grades = 'A';
                else
                {
                    if (avg_grades >= 55 && avg_grades < 70) letter_grades = 'P';
                    else
                    {
                        if (avg_grades >= 40 && avg_grades < 55) letter_grades = 'D';
                        else letter_grades = 'T';
                    }
                }
            }
        }
        return letter_grades;
    }
}
class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}