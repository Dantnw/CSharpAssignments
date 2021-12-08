class Class1
{
    static void Main()
    {

        while (true)
        {
            // HeightCheck();
            //NumberComparison();
        }
 }
    static void HeightCheck()
    {

        System.Console.WriteLine("Plese enter a height in cm (whole number)");

        int height = 0;

        try
        {
            height = int.Parse(System.Console.ReadLine());
        }
        catch
        {
            System.Console.WriteLine("That doesn't seem like a whole number.");
            System.Environment.Exit(0);
        }

        System.Console.WriteLine("Height: " + height);

        if (height < 150)
        {
            System.Console.WriteLine("Classification: Vertically challenged");
        }
        else if (150 <= height && height < 165)
        {
            System.Console.WriteLine("Classification: Average Height");
        }
        else if (165 <= height && height < 195)
        {
            System.Console.WriteLine("Classification: Tall");
        }
        else
        {
            System.Console.WriteLine("Classification: Ridiculously Tall");
        }
    }

    static void NumberComparison()
    {
        System.Console.WriteLine("Enter Three Integers:");
        System.Console.WriteLine("Number 1");
        int int1 = 0;
        int int2 = 0;
        int int3 = 0;
        try
        {
            int1 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Number 2");
            int2 = int.Parse(System.Console.ReadLine());
            if (int1 == int2)
            {
                System.Console.WriteLine("Adding 1 to Number 2 - they can't be the same!");
                int2++;
            }
            System.Console.WriteLine("Number 3");
            int3 = int.Parse(System.Console.ReadLine());
            if (int1 == int2 | int1 == int3 | int2 == int3)
            {
                System.Console.WriteLine("Setting Number 1 to 1, Number 2 to 2, and Number 3 to 3");
                int1 = 1;
                int2 = 2;
                int3 = 3;
            }
        }
        catch
        {
            System.Console.WriteLine("That's not an integer (probably)");
            
        }

        if (int1 > int2)
        {
            if (int1 > int3) {
                System.Console.WriteLine(int1 + " is the biggest number");
            }
            else
            {
                System.Console.WriteLine(int3 + " is the biggest number");
            }

        }
        else 
        {
            if (int2 > int3)
            {
                System.Console.WriteLine("int2 is the biggest number");
            }
            else
            {
                System.Console.WriteLine("int3 is the biggest number"); 
            }
        }
    }

}