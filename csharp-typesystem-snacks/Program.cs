//Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("Inserisci un numero");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci un altro numero");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"Il numero maggiore è: {(firstNumber >= secondNumber ? firstNumber : secondNumber)}");

//Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("Inserisci una parola");
string firstWord = Console.ReadLine();

Console.WriteLine("Inserisci una seconda parola");
string secondWord = Console.ReadLine();

if(firstWord.Length >= secondWord.Length)
{
    Console.WriteLine($"{secondWord} {firstWord}");   
}
else
{
    Console.WriteLine($"{firstWord} {secondWord}");
}

//Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma
//di tutti i numeri inseriti.

int sum = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero");
    int userNumbers = int.Parse(Console.ReadLine());
    sum += userNumbers;
    
}
Console.WriteLine($"La somma dei numeri inseriti è: {sum}");

//Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

int sumTwoToTen = 0;
int totaleNumbers = 0;

for (int i = 2; i <= 10; i++)
{
    sumTwoToTen += i;
    totaleNumbers++;
}

int average = sumTwoToTen / totaleNumbers;
Console.WriteLine($"La somma è {sumTwoToTen} e la media è {average}");

//Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari,
//stampa il numero successivo.

Console.WriteLine("Inserisci un numero");
int numberChosen = int.Parse(Console.ReadLine());

if(numberChosen % 2 != 0)
{
    Console.WriteLine(numberChosen + 1);
}else
{
    Console.WriteLine(numberChosen);
}

//Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] guestList = { "Vlado Micov", "Nikola Mirotic", "Bogdan Bogdanovic", "Alexa Avramovic", "Nikola Jovic", "Stefan Markovic" };
Console.WriteLine("Inserisci il tuo nome");
string userName = Console.ReadLine();
if (guestList.Contains(userName))
{
    Console.WriteLine($"Benvenuto alla festa {userName}");
}else
{
    Console.WriteLine("Spiace, non sei stato invitato");
}

//Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

int[] numbers = new int[6];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Inserisci un numero");
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

//Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] numbersArray = { 1, 2, 5, 55, 11, 6, 4, 10 };
int oddSum = 0;

for (int i = 0;i < numbersArray.Length; i++)
{
    if(i % 2 == 1)
    {
        oddSum += numbersArray[i];
    }
}

Console.WriteLine($"La somma dei numeri dispari è: {oddSum}");


//Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

int[] fiftyArray = new int[100];
int sumToFifty = 0;

do
{
    Console.WriteLine("Inserisci un numero");
    int roadToFifty = int.Parse(Console.ReadLine());
    sumToFifty += roadToFifty;

} while (sumToFifty < 50);

//Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.

Console.WriteLine("Scegli un numero");
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

