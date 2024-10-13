using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Task 1");

        int num1 = 8;
        int num2 = 17;

        int sum = num1 + num2;
        int difference = num2 - num1;
        int product = num1 * num2;
        double quotient = (double)num1 / num2;
        int remainder = num1 % num2;

        Console.WriteLine("sum: " + num1 + " + " + num2 + " = " + sum);
        Console.WriteLine("difference: " + num2 + " - " + num1 + " = " + difference);
        Console.WriteLine("product: " + num1 + " * " + num2 + " = " + product);
        Console.WriteLine("quotient: " + num1 + " / " + num2 + " = " + quotient);
        Console.WriteLine("remainder: " + num1 + " % " + num2 + " = " + remainder);

        Console.WriteLine();
        Console.WriteLine("//----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Task 2");
        Console.WriteLine();

        // float სიზუსტე 7 ციფრამდე 
        // double სიზუსტე 15-16 ციფრამდე
        //decimal სიზუსტე 28-29 ციფრამდე

        float floatVal = 1.0f / 7.0f;
        double doubleVal = 1.0 / 7.0;
        decimal decimalVal = 1.0m / 7.0m;

        float floatResult = floatVal * 7;
        double doubleResult = doubleVal * 7;
        decimal decimalResult = decimalVal * 7;

        Console.WriteLine($"Float : 1.0 / 7.0 * 7 = {floatResult}");
        Console.WriteLine($"Double: 1.0 / 7.0 * 7 = {doubleResult}");
        Console.WriteLine($"Decimal: 1.0 / 7.0 * 7 = {decimalResult}");

        Console.WriteLine();
        Console.WriteLine("//----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Task 3");
        Console.WriteLine();

        int myInt = 10;
        double myDouble = 8.47;
        float myFloat = 9.45f;
        decimal myDecimal = 27.49m;

        // Implicit 
        double fromIntToDouble = myInt;
        decimal fromIntToDecimal = myInt;
        double fromFloatToDouble = myFloat;

        // Explicit
        int fromDoubleToInt = (int)myDouble;
        float fromDoubleToFloat = (float)myDouble;
        int fromDecimalToInt = (int)myDecimal;
        double fromDecimalToDouble = (double)myDecimal;
        int fromFloatToInt = (int)myFloat;


        Console.WriteLine($"int to double: {myInt} -> {fromIntToDouble} ");
        Console.WriteLine($"int to decimal: {myInt} -> {fromIntToDecimal} ");
        Console.WriteLine($"float to double: {myFloat} -> {fromFloatToDouble} ");
        Console.WriteLine($"double to int: {myDouble} -> {fromDoubleToInt} ");
        Console.WriteLine($"double to float: {myDouble} -> {fromDoubleToFloat} ");
        Console.WriteLine($"decimal to int: {myDecimal} -> {fromDecimalToInt} ");
        Console.WriteLine($"decimal to double: {myDecimal} ->  {fromDecimalToDouble} ");
        Console.WriteLine($"float to int: {myFloat} -> {fromFloatToInt} ");

        Console.WriteLine();
        Console.WriteLine("//----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Task 4");
        Console.WriteLine();

        int x = 8;
        int b = 18;

        Console.WriteLine($"Before swap: x = {x}, b = {b}");

        int temp = x;
        x = b;
        b = temp;

        Console.WriteLine($"After swap: x = {x}, b = {b}");

        Console.WriteLine();
        Console.WriteLine("//----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Task 5");
        Console.WriteLine();

        Console.Write("PLease enter your height (for example: 1.75): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enteer your weight, use kg-s: ");
        double weight = Convert.ToDouble(Console.ReadLine());


        double bmi = weight / (height * height);

        Console.WriteLine($"Your  BMI is: {bmi}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Your weight is low. Weight gain is recommended.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Your weight is within the normal range. Maintain a healthy lifestyle.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Your weight is too much. Physical activity and a healthy diet are recommended.");
        }
        else
        {
            Console.WriteLine("Your weight indicates obesity.");

        }
    }
}


