using System.ComponentModel;

int a = 25;

a = a + 4;

Console.WriteLine(a);

int b = 7;
b++;
Console.WriteLine(b);

int input1  = 13;

    if ((input1 % 2) == 0)
    {
    input1 *= 3;
    }
    else
    {
     input1 *= 2;
    }
Console.WriteLine(input1);

string s = "ahoj, ";
s+= "mi";
Console.WriteLine(s);

string x = "fgfg";
if (string.IsNullOrWhiteSpace(x))
{ 
    Console.WriteLine("prazdne");
}
else
{
     Console.WriteLine("neco tam je");
}


string input4 = "username";
Console.WriteLine(input4.Length);
if (input4.Length > 5 && input4.Length < 10)
{
    Console.WriteLine("Username nejde vytvořit");
}
else
{
    Console.WriteLine("Username v pořádku");
}

Console.WriteLine("zadej slovo");
string userInput = Console.ReadLine();

Console.WriteLine("uzivatel zadal" + userInput);
Console.WriteLine($"uzivatel zadal{userInput}");


int input5 = 10;
int result = 0;

if (input5 > 0)
{
    result = (input5 * -1);
}
else
{
    result = 10;
}
