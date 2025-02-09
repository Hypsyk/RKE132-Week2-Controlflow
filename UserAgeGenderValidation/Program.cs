// See https://aka.ms/new-console-template for more information

//rakendus küsib vanust
//kui vanus <13 ss konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul kuvatakse "Welcome to Instagram"
// "13"- heap, 13 - stack

Console.WriteLine("Enter your age:");

int userAge = int.Parse(Console.ReadLine()); //mac ei lase int32 panna

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");
}
