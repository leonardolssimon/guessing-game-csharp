Random rnd = new Random();
int num = rnd.Next(100);
bool runGame = true;

Console.WriteLine("Guess the number:");

while (runGame){
    int guessedNumber = Convert.ToInt32(Console.ReadLine());

    if (guessedNumber < num){
        Console.WriteLine("You choose a number lower than the actual number.");
    }
    else if (guessedNumber > num){
        Console.WriteLine("You choose a number higher than the actual number.");
    }
    else {
        Console.WriteLine("Congratulations! You nailed it!");
        runGame = false;
    }
}