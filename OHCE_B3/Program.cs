using System.Text;

static string getMirrorString(string str)
{
    StringBuilder stringBuilder = new StringBuilder();

    var reversed = new string(str.Reverse().ToArray());

    stringBuilder.Append(reversed);

    return stringBuilder.ToString();
}

string inputUSer = Console.ReadLine();

Console.WriteLine("Bonjour !");

string reversedInputUser = getMirrorString(inputUSer);

Console.WriteLine(reversedInputUser);

if(inputUSer == reversedInputUser)
{
    Console.WriteLine("Bien dit !");
}

Console.WriteLine("Au revoir");




