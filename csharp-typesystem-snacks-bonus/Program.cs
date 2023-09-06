//Creare un menù dove mostro gli snacks all'utente e chiedo quale vuole eseguire.
//Una volta la scelta il programma esegue il snack corrispondente.

Console.WriteLine("Gli snack disponibili sono:\nSnack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.\nSnack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.\nSnack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.\nSnack 4: Calcola la somma e la media dei numeri da 2 a 10.\nSnack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.\nSnack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.\nSnack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.\nSnack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.\nSnack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.\nSnack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.");
Console.WriteLine("Inserisci il numero dello snack che vuoi eseguire:");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1: 
        Console.WriteLine("Snack 1 - Inserisci un numero");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci un altro numero");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"Il numero maggiore è: {(firstNumber >= secondNumber ? firstNumber : secondNumber)}");
        break;

    case 2:
        Console.WriteLine("Snack 2 - Inserisci una parola");
        string firstWord = Console.ReadLine();

        Console.WriteLine("Inserisci una seconda parola");
        string secondWord = Console.ReadLine();

        if (firstWord.Length >= secondWord.Length)
        {
            Console.WriteLine($"{secondWord} {firstWord}");
        }
        else
        {
            Console.WriteLine($"{firstWord} {secondWord}");
        }

        break;

    case 3:
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Snack 3 - Inserisci un numero");
            int userNumbers = int.Parse(Console.ReadLine());
            sum += userNumbers;

        }
        Console.WriteLine($"La somma dei numeri inseriti è: {sum}");
        break;

    case 4:
        Console.WriteLine("Snack 4");
        int sumTwoToTen = 0;
        int totaleNumbers = 0;

        for (int i = 2; i <= 10; i++)
        {
            sumTwoToTen += i;
            totaleNumbers++;
        }

        int average = sumTwoToTen / totaleNumbers;
        Console.WriteLine($"La somma è {sumTwoToTen} e la media è {average}");
        break;

    case 5:
        Console.WriteLine("Snack 5 - Inserisci un numero");
        int numberChosen = int.Parse(Console.ReadLine());

        if (numberChosen % 2 != 0)
        {
            Console.WriteLine(numberChosen + 1);
        }
        else
        {
            Console.WriteLine(numberChosen);
        }

        break;
    case 6:
        string[] guestList = { "Vlado Micov", "Nikola Mirotic", "Bogdan Bogdanovic", "Alexa Avramovic", "Nikola Jovic", "Stefan Markovic" };
        Console.WriteLine("Snack 6 - Inserisci il tuo nome");
        string userName = Console.ReadLine();
        if (guestList.Contains(userName))
        {
            Console.WriteLine($"Benvenuto alla festa {userName}");
        }
        else
        {
            Console.WriteLine("Spiace, non sei stato invitato");
        }

        break;
    case 7:
        int[] numbers = new int[6];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Snack 7 - Inserisci un numero");
            int numbersChosen = int.Parse(Console.ReadLine());

            if (numbersChosen % 2 == 1)
            {
                numbers[i] = numbersChosen;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
        }

        break;
    case 8:
        Console.WriteLine("Snack 8");
        int[] numbersArray = { 1, 2, 5, 55, 11, 6, 4, 10 };
        int oddSum = 0;

        for (int i = 0; i < numbersArray.Length; i++)
        {
            if (i % 2 == 1)
            {
                oddSum += numbersArray[i];
            }
        }

        Console.WriteLine($"La somma dei numeri dispari è: {oddSum}");

        break;

    case 9:
        int[] fiftyArray = new int[100];
        int sumToFifty = 0;

        do
        {
            Console.WriteLine("Snack 9 - Inserisci un numero");
            int roadToFifty = int.Parse(Console.ReadLine());
            sumToFifty += roadToFifty;

        } while (sumToFifty < 50);
        break;

    case 10:
        Console.WriteLine("Snack 10 - Scegli un numero");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            int[] nArray = new int[10];
            Random randomNumber = new Random();

            for (int j = 0; j < nArray.Length; j++)
            {
                nArray[j] = randomNumber.Next(1, 100);
            }

            foreach (int n in nArray)
            {
                Console.Write($"{n} ");
            }
        }
        break;

}


