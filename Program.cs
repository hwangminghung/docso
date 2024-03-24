using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số cần đọc:");
        int number = int.Parse(Console.ReadLine());

        if (number < 10)
        {
            ReadSingleDigit(number);
        }
        else if (number < 20)
        {
            ReadTwoDigitUnderTwenty(number);
        }
        else if (number < 100)
        {
            ReadTwoDigitAboveTwenty(number);
        }
        else if (number < 1000)
        {
            ReadThreeDigit(number);
        }
        else
        {
            Console.WriteLine("Out of ability");
        }
    }

    static void ReadSingleDigit(int number)
    {
        switch (number)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
        }
    }

    static void ReadTwoDigitUnderTwenty(int number)
    {
        switch (number)
        {
            case 10:
                Console.WriteLine("ten");
                break;
            case 11:
                Console.WriteLine("eleven");
                break;
            case 12:
                Console.WriteLine("twelve");
                break;
            case 13:
                Console.WriteLine("thirteen");
                break;
            case 14:
                Console.WriteLine("fourteen");
                break;
            case 15:
                Console.WriteLine("fifteen");
                break;
            case 16:
                Console.WriteLine("sixteen");
                break;
            case 17:
                Console.WriteLine("seventeen");
                break;
            case 18:
                Console.WriteLine("eighteen");
                break;
            case 19:
                Console.WriteLine("nineteen");
                break;
        }
    }

    static void ReadTwoDigitAboveTwenty(int number)
    {
        int tens = number / 10;
        int ones = number % 10;

        string tensWord = "";
        string onesWord = "";

        switch (tens)
        {
            case 2:
                tensWord = "twenty";
                break;
            case 3:
                tensWord = "thirty";
                break;
            case 4:
                tensWord = "forty";
                break;
            case 5:
                tensWord = "fifty";
                break;
            case 6:
                tensWord = "sixty";
                break;
            case 7:
                tensWord = "seventy";
                break;
            case 8:
                tensWord = "eighty";
                break;
            case 9:
                tensWord = "ninety";
                break;
        }

        if (ones > 0)
        {
            ReadSingleDigit(ones);
            onesWord = "";
        }

        Console.WriteLine(tensWord + " " + onesWord);
    }

    static void ReadThreeDigit(int number)
    {
        int hundreds = number / 100;
        int remaining = number % 100;

        ReadSingleDigit(hundreds);
        Console.Write(" hundred");

        if (remaining > 0)
        {
            Console.Write(" and ");

            if (remaining < 10)
            {
                ReadSingleDigit(remaining);
            }
            else if (remaining < 20)
            {
                ReadTwoDigitUnderTwenty(remaining);
            }
            else
            {
                ReadTwoDigitAboveTwenty(remaining);
            }
        }

        Console.WriteLine();
    }
}