
bool ContinueWindow = true;


do
{
    if(ContinueWindow){

        Console.WriteLine("Press any key...");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine("Menu: \n1. Digital Calculator.\n2. Investment Calculator. \n3. Exit.");

    int choice;
    bool isValidChoice=int.TryParse(Console.ReadLine(), out choice);
    switch (choice)
    {
            case 1:
            DigitalCalculator();
            break;

            case 2:
            InvestmentCalculator();
            break;

            case 3:
            ContinueWindow = false;
            break;

    }

}
while (ContinueWindow);


static void DigitalCalculator()
{
    Console.Write("Enter First Number: ");
    int? num1=Convert.ToInt32(Console.ReadLine()?? "0");
    Console.Write("Enter Second Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine()?? "0");
    Console.Write("Select an Operator \"+,-,*,/\" : ");
    char? Operator = Convert.ToChar(Console.ReadLine() ?? "0");

    if (Operator == '+')
    {
        Console.WriteLine($"Sum of {num1} and {num2} = "+ (num1+num2));
    }
    else if (Operator == '-')
    {
        Console.WriteLine($"Subraction of {num1} and {num2} = " + (num1 - num2));
    }
    else if (Operator == '*')
    {
        Console.WriteLine($"Multiplication of {num1} and {num2} = " + (num1 * num2));
    }
    else if (Operator == '/')
    {
        Console.WriteLine($"Division of {num1} and {num2} = " + (num1 / num2));
    }
    else
    {
        Console.WriteLine("Invalid Operator");
    }

}

static void InvestmentCalculator() {

    Console.Write("How much you Want to invest: ");
    int InvestmentVar=Convert.ToInt32((Console.ReadLine() ?? "0"));

    Console.Write("How much be the Duration (years): ");
    int DurationVar = Convert.ToInt32((Console.ReadLine() ?? "0"));

    float PercentageVar = 0.1f;

    int TotalProfit =Convert.ToInt32(InvestmentVar * PercentageVar + DurationVar);

    Console.WriteLine("Total Profit = "+TotalProfit);

}

