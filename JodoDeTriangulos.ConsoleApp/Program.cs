namespace JodoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("triangulos");
                Console.WriteLine("---------------------------------");

                Console.Write("informe x");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("informe y");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("informe z");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------------------------");
                Console.WriteLine("valores informados: ");
                Console.WriteLine("lado X" + ladoX);
                Console.WriteLine("lado Y" + ladoY);
                Console.WriteLine("lado Z" + ladoZ);

                bool medidasTriangulosValidos =
                    ladoX + ladoY > ladoZ &&
                    ladoX + ladoZ > ladoY &&
                    ladoY + ladoZ > ladoX;

                if (medidasTriangulosValidos == true)
                    Console.WriteLine("triangulo valido!");

                else
                {
                    Console.WriteLine("triangulo invalido!");
                }

                    Console.WriteLine("---------------------------------");
                Console.Write("deseja continuar? (s/n)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
                
                    
                }
            }
    }
}
