Console.WriteLine("Seleziona uno snack (1 a 12)");
int inputSnack = Convert.ToInt16(Console.ReadLine());
switch (inputSnack)
{
    case 1:
        snack1();
        break;
    case 2:
        snack2();
        break;
    case 3:
        snack3();
        break;
    case 4:
        snack4();
        break;
    case 5:
        snack5();
        break;
    case 6:
        snack6();
        break;
    case 7:
        snack7();
        break;
    case 8:
        snack8();
        break;
    case 9:
        snack9();
        break;
    case 10:
        snack10();
        break;
    case 11:
        snack11();
        break;
    case 12:
        snack12();
        break;
}

Console.ReadLine();


void snack1()
{
    Console.WriteLine("Inserisci un numero");
    var num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserisci un altro numero");
    var num2 = Convert.ToInt32(Console.ReadLine());
    var greater = num1 > num2 ? num1 : num2;

    if (num1 == num2)
    {
        Console.WriteLine("I due numeri sono uguali");
    }
    else
    {
        Console.WriteLine($"Il numero più grande è {greater}");
    }
}

void snack2()
{
    Console.WriteLine("Inserisci una parola");
    var word1 = Console.ReadLine() ?? "";
    Console.WriteLine("Inserisci un'altra parola");
    var word2 = Console.ReadLine() ?? "";
    var longer = word1.Length > word2.Length ? word1 : word2;
    var shorter = word1.Length < word2.Length ? word1 : word2;

    if (word1 == word2)
    {
        Console.WriteLine("Le due parole sono uguali");
    }
    else
    {
        Console.WriteLine($"La parola più lunga è {longer} mentre la parola più corta è {shorter}");
    }
}

void snack3()
{
    var numbers = new int[10];
    var sum = 0;

    for (var i = 0; i < 10; i++)
    {
        Console.WriteLine("Inserisci un numero");

        numbers[i] = Convert.ToInt32(Console.ReadLine());
        sum += numbers[i];
    }

    Console.WriteLine(sum);
}

void snack4()
{
    var sum = 0;

    for (var i = 2; i <= 10; i++)
    {
        sum += i;
    }

    var mean = sum / 9;

    Console.WriteLine($"la somma dei numeri da 2 a 10 è {sum} mentre la media è {mean}");
}

void snack5()
{
    Console.WriteLine("Inserisci un numero");

    var num1 = Convert.ToInt32(Console.ReadLine());

    var iseven = num1 % 2 == 0 ? num1 : num1 + 1;

    Console.WriteLine($"Il numemero pari più vicino è {iseven}");
}

void snack6()
{
    var guests = new string[] { "camillo musmeci", "dario costantini", "ludovico sforzo", "alessio allegrini" };

    Console.WriteLine("Qual è il suo nome?");

    var name = Console.ReadLine();

    bool isallowed = guests.Contains(name);

    Console.WriteLine(isallowed ? "Prego, può partecipare alla festa" : "No, non è presente nella lista. Si accomodi fuori.");
}

void snack7()
{
    var numbers = new int[6];
    var sum = 0;
    var index = 0;

    for (var i = 0; i < 6; i++)
    {
        Console.WriteLine("Inserisci un numero");
        var num = Convert.ToInt32(Console.ReadLine());


        if (num % 2 != 0)
        {
            numbers[index] = num;
            sum += num;
            index++;
        }

    }

    Console.WriteLine("I numeri dispari sono:");

    for (var i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
}

void snack8()
{
    var numbers = new int[] { 1, 45, 43, 22, 10, 6, 90 };
    var sum = 0;

    for (var i = 0; i < numbers.Length; i++)
    {
        if (Array.IndexOf(numbers, numbers[i]) % 2 != 0)
        {
            sum += numbers[i];
        }
    }

    Console.WriteLine($"La somma di tutti i numeri in posizione dispari è {sum}");
}

void snack9()
{

    var numbers = new int[50];
    var sum = 0;
    var index = 0;

    while (sum < 50)
    {
        Console.WriteLine("Inserisci un numero");
        var num = Convert.ToInt32(Console.ReadLine());
        numbers[index] = num;
        sum += num;
        index++;
    }

    Console.WriteLine(sum);
}

void snack10()
{
    Console.WriteLine("Inserisci un numero");
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();
    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];
        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }
        foreach (var num in ints)
        {
            Console.Write($"{num}");
        }
        Console.WriteLine();
    }
}

void snack11()
{
    bool isequal(string word1, string word2)
    {
        if (word1.Length == word2.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    Console.WriteLine("Inserisci una parola");
    var word1 = Console.ReadLine() ?? "";
    Console.WriteLine("Inserisci un'altra parola");
    var word2 = Console.ReadLine() ?? "";
    var longer = word1.Length > word2.Length ? word1 : word2;

    if (isequal(word1, word2))
    {
        Console.WriteLine($"{word1} {word2}");
    }
    else
    {
        Console.WriteLine(longer);
    }
}

void snack12()
{
    bool iseven(int number)
    {
        return number % 2 == 0;
    }

    Console.WriteLine("Inserisci un numero");

    var number = Convert.ToInt32(Console.ReadLine());

    if (iseven(number))
    {
        Console.WriteLine("pari");
    }
    else
    {
        Console.WriteLine("dispari");
    }
}








