// Make a "guessing game" where there is a target number, and as the user makes guesses, the output returns higher or lower until the user is correct. 
Console.WriteLine("*** Guessing Game ***");

var isGuessed = false;
var numberToGuess = new Random().Next(10);
var times = 0;

while (!isGuessed)
{
    var number = Console.ReadLine();
    if (Convert.ToInt32(number) < numberToGuess)
    {
        Console.WriteLine("higher");
    }
    if (Convert.ToInt32(number) > numberToGuess)
    {
        Console.WriteLine("lower");
    }
    if (Convert.ToInt32(number) == numberToGuess)
    {
        isGuessed = true;
    }
    times++;
}

Console.WriteLine($"Correct! You won in: {times} guesses!");