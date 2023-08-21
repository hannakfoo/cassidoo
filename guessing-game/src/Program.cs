// Make a "guessing game" where there is a target number, and as the user makes guesses, the output returns higher or lower until the user is correct. 
Console.WriteLine("*** Guessing Game ***");

var isGuessed = false;
var numberToGuess = new Random().Next(10);
var times = 0;

while (!isGuessed)
{
    var number = Convert.ToInt32(Console.ReadLine());

    bool IsGuessed()
    {
        if (number < numberToGuess)
        {
            Console.WriteLine("higher");
        }

        if (number > numberToGuess)
        {
            Console.WriteLine("lower");
        }

        if (number == numberToGuess)
        {
            isGuessed = true;
        }

        times++;
        return isGuessed;
    }

    isGuessed = IsGuessed();
}

Console.WriteLine($"Correct! You won in: {times} guesses!");