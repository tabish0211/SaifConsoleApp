namespace SaifConsoleApp
{
    internal class Program
    {

        //CLR--common lanaguage runtime---JVM---Program.Main()
        //entry point method---any subroutine written inside class it is called
        
        
        static void Main()
        {
            //WAP swap the two variables using 3rd varaiable and without variable
            int x = 10, y = 20;
            Console.WriteLine($"Before swapping x={x} and y={y}");
            //int temp;
            //temp = x;
            //x = y;
            //y = temp;
            x = x + y;//30
            y = x - y;//30-20=10
            x = x - y;//30-10=20
            Console.WriteLine($"After swapping x={x} and y={y}");
            //assignment using--xor gate--
            Console.ReadLine();

        }
    }
}
