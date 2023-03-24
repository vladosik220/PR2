using System;

public class QuadraticEquationSolver
{
    private double a;
    private double b;
    private double c;
    private double root1;
    private double root2;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetA()
    {
        return a;
    }

    public double GetB()
    {
        return b;
    }

    public double GetC()
    {
        return c;
    }

    public double GetRoot1()
    {
        return root1;
    }

    public double GetRoot2()
    {
        return root2;
    }

    private double CalculateDiscriminant()
    {
        return b * b - 4 * a * c;
    }

    public void CalculateRoots()
    {
        double discriminant = CalculateDiscriminant();

        if (discriminant < 0)
        {
            throw new Exception("Equation has no real roots.");
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            root2 = root1;
        }
        else
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
    }
}

// Использование класса в программе:

using System;

public class Program
{
    public static void Main()
    {
        double a, b, c;
        Console.WriteLine("Enter the coefficients of the quadratic equation:");
        Console.Write("a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        c = double.Parse(Console.ReadLine());

        QuadraticEquationSolver solver = new QuadraticEquationSolver(a, b, c);
        try
        {
            solver.CalculateRoots();
            Console.WriteLine("Roots: {0}, {1}", solver.GetRoot1(), solver.GetRoot2());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
