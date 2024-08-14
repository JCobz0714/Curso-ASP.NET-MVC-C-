// See https://aka.ms/new-console-template for more information
/*
 Write an algorithm that, given a number by the user, shows all its positive 
divisors. 
Remember that a divisor is one that divides the number exactly (with remainder 0). 
Example: Number: 14 Divisors: 1,2,7,14
 */

/*
Console.WriteLine("Please type any number");

string x = Console.ReadLine();

int y = Int32.Parse(x);

for (int i = 1; i <= y; i++)
{
    if((y % i) == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        continue;
    }
}
*/

/*
 If today is sunday, what is the day of the week after 7120 days?
 */

double days = 7121;

double weeks = days % 7;

Console.WriteLine(weeks);

switch (weeks)
{
    case 1:
        Console.WriteLine("Monday");
    break;

    case 2:
        Console.WriteLine("Tuesday");
    break;

    case 3:
        Console.WriteLine("Wednesday");
    break;

    case 4:
        Console.WriteLine("Thursday");
    break;

    case 5:
        Console.WriteLine("Friday");
    break;

    case 6:
        Console.WriteLine("Saturday");
    break;

    case 7:
        Console.WriteLine("Sunday");
    break;
}