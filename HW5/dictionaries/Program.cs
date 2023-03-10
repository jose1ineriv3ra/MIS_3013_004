//You will be creating a C# console application that will count the words in the given text file.
//The application will read in Jane Eyre and store each unique word.
//The application should also store the number of times each word appears in the file.
//Then, the application should display the contents of the dictionary with the word on the left and the count on the right.

using System.Numerics;
using System.Transactions;

string[] text = File.ReadAllLines("Jane Eyre.txt");

Dictionary<string,int> wordCount = new Dictionary<string,int>();

bool BeginningOfBook = false; 

foreach (string line in text)
{
    if (line.Contains("CHAPTER I") == true)
    {
        BeginningOfBook = true;
    }
    if (BeginningOfBook == false && string.IsNullOrWhiteSpace(line) == true) ;
    {
        continue; 
    }
    if (line.Contains("***END OF THE PROJECT GUTENBERG EBOOK JANE EYRE***") == true)
    {
        break;
    }

    string[] words = line.Split(" ");
    foreach (string word in words)
    {
        char[] punctuation = { ',', '\'', '.', '!', '?',';',':','"' };
        string current = word.ToLower().Trim(punctuation);
        if (wordCount.ContainsKey(current)==false)
        {
            wordCount.Add(current, 0);
        }

        wordCount[current] = wordCount[current] +1;

    }
}


Console.WriteLine("\n Jane Erye Dictionary");

Console.WriteLine($"{"Word".PadRight(25,' ')}\tCount");

foreach(string word in wordCount.Keys)
{
    Console.WriteLine($"{word.PadRight (25,' ')} \t{wordCount[word].ToString("N0")}");
}

Console.WriteLine("Do you want to search for a specific word?");
string answer = Console.ReadLine();
if (wordCount.ContainsKey(answer) == true)
{
    Console.WriteLine($"{answer} is found {wordCount[answer].ToString("N0")} times!");

}
else
{
    Console.WriteLine($"{answer} is not in the book.");
}