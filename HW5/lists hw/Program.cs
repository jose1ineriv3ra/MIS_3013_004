//Create an application that stores and outputs a list of the user’s favorite things.
//The application should ask the user if they would like to add an item to their list of favorite things.
//If they say yes, the application should let the user add a new item to the list.
//Then, when the user is done adding items to the list, the application should output all of the list contents in three separate ways: 1) from the top to the bottom (ex: 1, 2, 3), 2) in reverse order (ex: 3, 2, 1), and 3) output every other entry in the list (ex: 1, 3).

List<string>favethings = new List<string>();

string answer;

do
{
    Console.WriteLine("What is a favorite thing that you want to add to the list? >>");
    answer = Console.ReadLine();
    favethings.Add(answer);

    Console.WriteLine("Do you have another thing to add? >>");
    answer = Console.ReadLine();
} while (answer.ToLower()[0]=='y');

Console.WriteLine("\n1) from the top to the bottom");

foreach (string favething in favethings)
{
    Console.WriteLine(favething);
}

Console.WriteLine("\n2) in reverse order");
for (int i = favethings.Count -1; i>= 0; i--)
{
    Console.WriteLine(favethings[i]);
}

Console.WriteLine("\n3) output every other entry in the list");
for (int i = 0; i < favethings.Count; i+=2)
{
    Console.WriteLine(favethings[i]);
}