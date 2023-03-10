//Create an application that stores client bank balances.
//You will need to read in two separate files, one with the client names, and the other with their bank balances.
//You will store this information in parallel arrays.
//Then, your application should output all of the client names, ask the user whose balance they would like to see, and output the correct balance for that user.


using System.Collections.Concurrent;

string[] CustomerNames = new string[1000]; 
double[] AccountBalances = new double[1000];

string[] nameLines = File.ReadAllLines("CustomerNames.csv");
string[] balanceLines = File.ReadAllLines("AccountBalances.csv");

for (int i = 1; i < nameLines.Length; i++)
{
    if (string.IsNullOrWhiteSpace(nameLines[i]) == true)
    {

    }
    
    
    CustomerNames[i-1] = nameLines[i-1] = nameLines[i];

    string balance = balanceLines[i]; //$8389.38
    balance = balance.Replace("$", "");
    AccountBalances[i-1] =Convert.ToDouble(balance);

}
Console.WriteLine("Whose account do you want to look up? ");

foreach ( string name in CustomerNames)
{
    Console.WriteLine(name);
}
string answer = Console.ReadLine();

Console.WriteLine();

for (int i = 0; i < CustomerNames.Length; i++)
{
    if (answer.ToLower() == CustomerNames[i].ToLower())
    {
        Console.WriteLine($"{answer} has a balance of {AccountBalances[i].ToString("C")}!");
    }
}