//Ask the user to enter all of their exam grades.
//Once they are done, calculate the minimum score, the maximum score and the average score for all of their scores.
//Perform this using at least 2 Loops (can be the same type of loop) and not any built in functions.


using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

List<double> examscores = new List<double>();

do
{
    Console.WriteLine("Enter your exam grade. ");
    examscores.Add(Convert.ToDouble(Console.ReadLine()));

    Console.WriteLine("Do you have another exam grade?");

} while (Console.ReadLine().ToLower()[0] == 'y');

//Console.WriteLine("All your exam scores are:"); 

//foreach (var grade in examscores)
//{

//}


double max = 0;
double min = 100;


double total = 0; 


foreach ( var Scores in examscores)
{
    total += Scores;

    if (Scores > max)
    {
        max = Scores; 
    }
    if (Scores < min)
    {
        min = Scores; 
    }
    
}
double average = total / examscores.Count();

Console.WriteLine($"Your max examscore is {max}, your min examscore is {min}, and your average examscore is {average}.");
