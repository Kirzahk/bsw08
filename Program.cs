using System;
using static System.Console;

namespace Ejemplo08___argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                WriteLine("Tienes que indicar 2 colores y dimensiones");
                return; //detiene la ejecución
            }
            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor), 
                value: args[0], 
                ignoreCase: true);

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true);
            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
        }
    }
}
