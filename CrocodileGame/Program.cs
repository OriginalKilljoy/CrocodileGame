//Du skal bruke det du har lært til å programmere “krokodille spillet”.
// 
// [x]For hver runde skal det printes ut til skjermen et random tall mellom 1-11, et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5
// 
// Brukeren kan skrive inn <, > eller =
// 
// i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5
// 
// [x]Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
// [x]Det må verifiseres om brukeren har valgt riktig alternativ.
// [x]Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
// [x]Poengsummen printes til skjermen for hvert svar brukeren har gitt.
// []Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene


using System.Net.Mime;

int score = 0;

Console.WriteLine("Hello! Get ready to play the crocodile game!\nYou must answer with either '<', '>' or '=' depending on the right answer.\nGood luck!");
Thread.Sleep(500);
Run();

void Run()
{
    Random getRandom = new Random();
    int randomNumber1 = getRandom.Next(1, 12);
    int randomNumber2 = getRandom.Next(1, 12);

    Console.WriteLine($"Score: {score}");
    Console.WriteLine($"{randomNumber1} _ {randomNumber2}");
    var userAnswer = Console.ReadLine();

    if (userAnswer == "<" || userAnswer == ">" || userAnswer == "=")
    {

        if (randomNumber1 < randomNumber2 && userAnswer == "<")
        {
            Console.WriteLine("Correct! 1 point!");
            score++;
            Thread.Sleep(500);
            Run();
        }
        else if (randomNumber1 > randomNumber2 && userAnswer == ">")
        {
            Console.WriteLine("Correct! 1 point!");
            score++;
            Thread.Sleep(500);
            Run();
        }
        else if (randomNumber1 == randomNumber2 && userAnswer == "=")
        {
            Console.WriteLine("Correct! 1 point!");
            score++;
            Thread.Sleep(500);
            Run();
        }

        else
        {
            Console.WriteLine("Womp womp...");
            score--;
            Thread.Sleep(500);
            Run();
        }
    }
    else
    {
        Environment.Exit(0);
    }
}

