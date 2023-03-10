//Joseline Rivera Blas CP 2/28




string text = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");

Console.WriteLine("Input what word you want to look for in the above sentence.");
string input = Console.ReadLine();

Console.WriteLine("Input what word you want to change it to.");
string change = Console.ReadLine();




if (text.Contains(input) == true)
{
    text.Replace(input, change);
    Console.WriteLine(text.Replace(input, change));
}
else
{
        Console.WriteLine($"Sorry, I could not find your word {input}.");
    for (int i = change.Length-1; i >= 0; i--)
    {

        Console.Write($"{change[i]}");
     
    }
        
}


