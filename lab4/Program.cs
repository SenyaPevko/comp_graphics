using System;

namespace lab4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Выберите фрактал:");
            Console.WriteLine("2 - 2D фрактал");
            Console.WriteLine("3 - 3D фрактал");
        
            var choice = Console.ReadLine();

            if (choice == "2")
                using (var window = new FractalWindow(800, 600))
                    window.Run();
            
            else if (choice == "3")
                using (var window = new FractalWindow3D(800, 600))
                    window.Run();
        }
    }
}