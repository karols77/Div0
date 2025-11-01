using System.Reflection.Metadata.Ecma335;

namespace Div0;

class Program
{
    class MyExpetion : Exception { }
    static void Main(string[] args)
    {
        Console.WriteLine("Program do wykrywania dzielenia przez 0");
        try
        {
            Console.WriteLine($"3/2 = {ProcedureDiv(3d, 2d)}");
            Console.WriteLine($"3/1 = {ProcedureDiv(3d, 1d)}");
            Console.WriteLine($"3/4 = {ProcedureDiv(3d, 4d)}");
        }
        catch (MyExpetion)
        {
            Console.WriteLine("Wystąpiło dzielenie przez 0!");
        }
        finally
        {
            Console.WriteLine("Działanie zakończone!!!");
        }
    }
    static double ProcedureDiv(double a, double b)
    {
        if (b == 0d)
        {
            throw new MyExpetion();
        }
        return a / b;
    }
}
