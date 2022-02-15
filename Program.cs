// See https://aka.ms/new-console-template for more information


/*
 * Console.WriteLine("Bitte eingeben: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bitte eingeben: ");
int b = Convert.ToInt32(Console.ReadLine());

AllEvenNumbers(a, b);
Console.ReadKey();

static void AllEvenNumbers(int from, int to)
{    

    while (from <= to)
    {
        if (from % 2 == 0)
        {
            Console.WriteLine(from);
        }
        from++;
    }
}
*/


while (true)
{
    Console.WriteLine("Taschenrechner\n");



    Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
    double zahl1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Bitte geben Sie eine zweite Zahl ein: ");
    double zahl2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Bitte geben Sie nun einen Operator ein: ");
    char operation = Convert.ToChar(Console.ReadLine());



    switch (operation)
    {
        case '+':
            Console.WriteLine("{0} {1} {2} = {3}\n", zahl1, operation, zahl2, zahl1 + zahl2);
            break;
        case '-':
            Console.WriteLine("{0} {1} {2} = {3}\n", zahl1, operation, zahl2, zahl1 - zahl2);
            break;
        case '/':
            Console.WriteLine("{0} {1} {2} = {3}\n", zahl1, operation, zahl2, zahl1 / zahl2);
            break;
        case '*':
            Console.WriteLine("{0} {1} {2} = {3}\n", zahl1, operation, zahl2, zahl1 * zahl2);
            break;
        default:
            Console.WriteLine("Ungültiger Wert");
            break;
    }
    Console.ReadKey();
    Console.Clear();
}
