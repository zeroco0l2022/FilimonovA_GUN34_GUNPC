// See https://aka.ms/new-console-template for more information


class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");

        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number");
            return;
        }

        Console.WriteLine("Enter second number: ");

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number");
            return;
        }

        Console.WriteLine("Enter sigh (& | ^): ");

        var s = Console.ReadLine();
        if (s.Length != 1)
        {
            Console.WriteLine("Wrong operator");
            return;
        }

        switch (s[0])
        {
            case '&':
                Console.WriteLine("Decimal: {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine("Binary: {0:B} & {1:B} = {2:B}", a, b, a & b);
                Console.WriteLine("Hex: 0x{0:X} & 0x{1:X} = 0x{2:X}", a, b, a & b);
                break;

            case '|':
                Console.WriteLine("Decimal: {0} | {1} = {2}", a, b, a | b);
                Console.WriteLine("Binary: {0:B} | {1:B} = {2:B}", a, b, a | b);
                Console.WriteLine("Hex: 0x{0:X} | 0x{1:X} = 0x{2:X}", a, b, a | b);
                break;

            case '^':
                Console.WriteLine("Decimal: {0} ^ {1} = {2}", a, b, a ^ b);
                Console.WriteLine("Binary: {0:B} ^ {1:B} = {2:B}", a, b, a ^ b);
                Console.WriteLine("Hex: 0x{0:X} ^ 0x{1:X} = 0x{2:X}", a, b, a ^ b);
                break;

            default:
                Console.WriteLine("Wrong operator");
                break;
        }
      

    }

}

