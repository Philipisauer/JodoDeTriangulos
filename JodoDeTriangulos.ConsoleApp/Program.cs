using System;

namespace JodoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirCabecalho();

                int ladoX = LerDado("X: ");
                int ladoY = LerDado("Y: ");
                int ladoZ = LerDado("Z: ");

                ExibirValoresInformados(ladoX, ladoY, ladoZ);

                bool medidasFormamTrianguloValido =
                    ClassificadorDeTriangulos.MedidasFormamTrianguloValido(ladoX, ladoY, ladoZ);

                if (medidasFormamTrianguloValido)
                {
                    string tipoTriangulo = ClassificadorDeTriangulos.ClassificarTriangulo(ladoX, ladoY, ladoZ);
                    Console.WriteLine($"O triangulo é {tipoTriangulo}.");
                }
                else
                    Console.WriteLine("os valores nao formam um triangulo invalido");

                Console.WriteLine("______________________________________________________");

                Console.Write("Deseja continuar? (S/N)");

                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("triangulos");
            Console.WriteLine("---------------------------------");
        }
        static int LerDado(string nomeLado)
        {
            int valor;

            while (true)
            {
                Console.Write($"informe o valor do lado {nomeLado}");

                bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);

                if (conseguiuConverter)
                    break;
            }
            return valor;
        }
        static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Valores informados: ");
            Console.WriteLine("lado X: " + ladoX);
            Console.WriteLine("lado Y: " + ladoY);
            Console.WriteLine("lado Z: " + ladoZ);
            Console.WriteLine("---------------------------------");
        }
    }
}