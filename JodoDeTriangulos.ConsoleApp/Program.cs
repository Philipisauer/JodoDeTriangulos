namespace JodoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.Clear();
                Console.WriteLine("triangulos");

                Console.Write("informe x");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("informe y");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("informe z");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("valores informados: ");
                Console.WriteLine("lado X" + ladoX);
                Console.WriteLine("lado Y" + ladoY);
                Console.WriteLine("lado Z" + ladoZ);


                Console.Write("deseja continuar? (s/n)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
                
                    
                }
            }
    }
}
