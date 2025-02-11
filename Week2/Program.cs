// See https://aka.ms/new-console-template for more information

Console.Writeline("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.Readline());
Console.Writeline("Please, enter your lastname:");

string userLastName = Console.Readline();

if (userGender == 'm') 
{
  Console.Writeline($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f') 
{
  Console.Writeline($"Welcome, Ms. {userLastName}!");
}
else 
{
  Console.Writeline("Welcome!");
}
