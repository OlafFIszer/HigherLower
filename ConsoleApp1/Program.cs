
    class Program
    {
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 10;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {

                Console.WriteLine("Wybierz liczbę między" + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess" + guess);


                if (guess > number)
                {
                    Console.WriteLine(guess + "Zbyt wysoko");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + "Zbyt nisko");
                }
                guesses++;
            }
            Console.WriteLine("Liczba" + number);
            Console.WriteLine("Wygrałeś");
            Console.WriteLine("Guesses" + guesses);

            Console.WriteLine("Chcesz zagrać jeszcze raz? (Y/N): ");
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


            Console.WriteLine("Dziękuję za grę");

            Console.ReadKey();


        }
        

    }

}
