using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite um dos numeros pra escolher.\n" +
                          "1: int -> short\n" +
                          "2: int -> long\n" +
                          "3: float -> int\n" +
                          "4: int -> float\n" +
                          "5: int -> double\n" +
                          "6: bool -> string\n" +
                          "7: int -> string\n" +
                          "8: boxing -> (qualquer tipo para objeto)\n" +
                          "9: unboxing -> (objeto para qualquer tipo)\n");
        Console.WriteLine("Escolha qual dados você deseja converter:");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                ConvertIntToShort();
                break;
            case 2:
                ConvertIntToLong();
                break;
            case 3:
                ConvertFloatToInt();
                break;
            case 4:
                ConvertIntToFloat();
                break;
            case 5:
                ConvertIntToDouble();
                break;
            case 6:
                ConvertBoolToString();
                break;
            case 7:
                ConvertIntToString();
                break;
            case 8:
                BoxingConvert();
                break;
            case 9:
                UnboxingConvert();
                break;
            default:
                Console.WriteLine("Ocorreu um erro!");
                break;
        }
    }

    static void ConvertIntToShort()
    {
        Console.WriteLine("Sua escolha foi de int para short.");
        Console.WriteLine("Que numero você está tentando converter? ");
        int numberInt = Convert.ToInt32(Console.ReadLine());

        short convertShort = (short)numberInt;
        Console.WriteLine($"Int para Short: {convertShort}");
    }

    static void ConvertIntToLong()
    {
        Console.WriteLine("Sua escolha foi de int para long.");
        Console.WriteLine("Que numero você está tentando converter? ");
        int numberInt = Convert.ToInt32(Console.ReadLine());

        long convertlong = (long)numberInt;
        Console.WriteLine($"Int para Long: {convertlong}");
    }

    static void ConvertFloatToInt()
    {
        Console.WriteLine("Sua escolha foi de float para int.");
        Console.WriteLine("Que numero você está tentando converter? ");
        float numberFloat = Convert.ToSingle(Console.ReadLine());

        int convertedInt = Convert.ToInt32(numberFloat);
        Console.WriteLine($"Float para Int: {convertedInt}");
    }

    static void ConvertIntToFloat()
    {
        Console.WriteLine("Sua escolha foi de int para float.");
        Console.WriteLine("Que numero você está tentando converter? ");
        int numberInt = Convert.ToInt32(Console.ReadLine());

        float convertedFloat = Convert.ToSingle(numberInt);
        Console.WriteLine($"Int para Float: {convertedFloat}");
    }

    static void ConvertIntToDouble()
    {
        Console.WriteLine("Sua escolha foi de int para double.");
        Console.WriteLine("Que numero você está tentando converter? ");
        int numberInt = Convert.ToInt32(Console.ReadLine());

        double convertedDouble = Convert.ToDouble(numberInt);
        Console.WriteLine($"Int para Double: {convertedDouble}");
    }

    static void ConvertBoolToString()
    {
        Console.WriteLine("Sua escolha foi de bool para string.");
        Console.WriteLine("Que valor booleano você está tentando converter? ");
        bool valueBool = Convert.ToBoolean(Console.ReadLine());

        string convertedString = Convert.ToString(valueBool);
        Console.WriteLine($"Bool para String: {convertedString}");
    }

    static void ConvertIntToString()
    {
        Console.WriteLine("Sua escolha foi de int para string.");
        Console.WriteLine("Que numero você está tentando converter? ");
        int numberInt = Convert.ToInt32(Console.ReadLine());

        string convertedString = ConvertIntToString(numberInt);
        Console.WriteLine($"Int para String: {convertedString}");
    }

    static string ConvertIntToString(int valor)
    {
        return valor.ToString();
    }

    static void BoxingConvert()
    {
        Console.WriteLine("Qual valor você quer converter?");
        object boxedObject = Console.ReadLine();
        Console.WriteLine($"Valor convertido para objeto: {boxedObject}");
    }

    static void UnboxingConvert()
    {
        Console.WriteLine("Digite um valor para ser armazenado no objeto:");
        object boxedObject = Console.ReadLine();

        if (boxedObject is int)
        {
            int unboxedInt = (int)boxedObject;
            Console.WriteLine($"Objeto convertido para int: {unboxedInt}");
        }
        else if (boxedObject is float)
        {
            float unboxedFloat = (float)boxedObject;
            Console.WriteLine($"Objeto convertido para float: {unboxedFloat}");
        }
        else if (boxedObject is string)
        {
            string unboxedString = (string)boxedObject;
            Console.WriteLine($"Objeto convertido para string: {unboxedString}");
        }
        else if (boxedObject is bool)
        {
            bool unboxedString = (bool)boxedObject;
            Console.WriteLine($"Objeto convertido para boolean: {unboxedString}");
        }
        else if (boxedObject is double)
        {
            double unboxedString = (double)boxedObject;
            Console.WriteLine($"Objeto convertido para double: {unboxedString}");
        }
        else
        {
            Console.WriteLine("Esse tipo de objeto não é suportado para unboxing.");
        }
    }
}
