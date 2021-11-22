Class program

{
    static void Main(string[] args)

}
Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
Strine response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.next(min, max + 1);

    while (guess != number)
    {
        Console.WriteLine("Gissa ett nummer mellan " +min +" - " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);
    
        if(guess > number)
        {
            Console.Writeline(guess + "är för högt!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + "är för lågt!");
        }
        guesses++;

    }
    Console.WriteLine("Number; " + number);
    Console.WriteLine("DU VANN!!");
    Console.WriteLine("Guesses" + guesses);

    Console.WriteLine("Skulle du vilja spela igen? Y/N: ");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}
    Console.WriteLine("Tack för att du spelade!")

    Console.Readkey();
}

