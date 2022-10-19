/*
Carlos Felipe Sales
9-16-22
Mini Challenge #7 - Reverse It
This code takes in a user's input and displays it. It then 
reverses the order of the input and displays the reverse. 
Top code works ONLY for integers values
and
bottom code works ONLY for string values
Peer review: Jeremy
READY TO GO.
*/

Console.Clear();

string play = "yes";
bool isNumber;
bool run = true;
long validNum = 0;

while(run)
{
    Console.Write("\nI am the Reverser!\nEnter a sequence of integers and I will reverse their order: ");
    string num = Console.ReadLine();
    isNumber = Int64.TryParse(num, out validNum);
    if(isNumber){
        string reverseName = "";
        for (int i = num.Length - 1; i >= 0; i--)
        {
            reverseName = reverseName + num[i];              //shorthand reverseName += reverseName[i]
        }
        Console.Write($"\nYour number is {num}\nThe reverse is {reverseName}\nPlay again?\nType in YES or NO: ");
        string runChoice = Console.ReadLine().ToUpper();
        while(runChoice != "YES" && runChoice != "NO"){
            Console.Write("\nI said 'YES' or 'NO'\nTry again: ");
            runChoice = Console.ReadLine().ToUpper();
        }
        if(runChoice == "NO"){
            run = false;
            Console.WriteLine("My power frightens you...");
        }
    }
    else
    {
        Console.WriteLine("\nThat is not a sequence of integers. Try Again.");
    }
}


// Mathematical way to reverse it, idk how it works
/*
int userInput, reverse=0, rem;
userInput = int.Parse(Console.ReadLine());
Console.WriteLine("Your number is " + userInput);

while(userInput!=0){
rem = userInput%10;
reverse = reverse*10+rem;
userInput/=10;
}
Console.WriteLine("The reverse is: " + reverse);*/


//This is Reverse It but for string values ONLY
/*
string start = "yes";
bool notText;
long validText = 0;

while (start == "yes")
{
    Console.WriteLine("I am the Reverser!");
    Console.WriteLine("Enter a word and I will reverse its order.");
    string text = Console.ReadLine();
    notText = Int64.TryParse(text, out validText);
    if (notText == true)
    {
        Console.WriteLine("That is not a word. Try Again? ");
        Console.WriteLine("Type in 'yes' or 'no'");
        start = Console.ReadLine();
    }
    else
    {
        string reverseName = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverseName = reverseName + text[i];              //shorthand reverseName += reverseName[i]
        }
        Console.WriteLine("Your word is " + text);
        Console.WriteLine("The reverse is " + reverseName);
        Console.WriteLine("Play again?");
        Console.WriteLine("Type in 'yes' or 'no'");
        start = Console.ReadLine();
    }
}
Console.WriteLine("Run the program again if you change your mind.");
*/




