//var num1 = Convert.ToInt32(Console.ReadLine());
//var num2 = Convert.ToInt32(Console.ReadLine());
//var greater = num1 > num2 ? num1 : num2;

//if (num1 == num2)
//{
//    Console.WriteLine("The numbers are equal");
//} else
//{
//    Console.WriteLine(greater);
//}


//var word1 = Console.ReadLine() ?? "";
//var word2 = Console.ReadLine() ?? "";
//var longer = word1.Length > word2.Length ? word1 : word2;

//if (word1 == word2)
//{
//    Console.WriteLine("The words are equal");
//}
//else
//{
//    Console.WriteLine(longer);
//}

//var numbers = new int[10];
//var sum = 0;

//for (var i = 0; i < 10; i++)
//{
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//    sum += numbers[i];
//}

//Console.WriteLine(sum);


//var numbers = new int[9];
//var sum = 0;

//for (var i = 2; i <= 10; i++)
//{
//    numbers[i] = i;
//    sum += numbers[i];
//}

//Console.WriteLine(sum);

//DA RISOLVERE


//var num1 = Convert.ToInt32(Console.ReadLine());

//var isEven = num1 % 2 == 0 ? num1 : num1 + 1;

//Console.WriteLine(isEven);

//var guests = new string[] { "Camillo Musmeci", "Dario Costantini", "Ludovico Sforzo", "Alessio Allegrini" };

//var name = Console.ReadLine();

//bool isAllowed = guests.Contains(name);

//Console.WriteLine(isAllowed ? "Puoi partecipare alla festa" : "NON Puoi partecipare alla festa");


var numbers = new int[3];

for(var i = 0; i <= 6; i++)
{
    var num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 != 0)
    {
        numbers[i] = num;
    }

}

for (var i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}



//CICLO WHILE

