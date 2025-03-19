
using System;

namespace JodoDeTriangulos.ConsoleApp
{
    class ClassificadorDeTriangulos
    {
        public static bool MedidasFormamTrianguloValido(int ladoX, int ladoY, int ladoZ)
        {
            bool MedidasFormamTrianguloValidas =
                ladoX + ladoY > ladoZ &&
                ladoX + ladoZ > ladoY &&
                ladoY + ladoZ > ladoX;

            return MedidasFormamTrianguloValidas;
        }
        public static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
        {
            string tipoTriangulo = "nao classificado";

            if (ladoX == ladoY && ladoY == ladoZ)
                tipoTriangulo = "equilatero";

            else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                tipoTriangulo = "escaleno";

            else
                tipoTriangulo = "isosceles";

            return tipoTriangulo;
        }
    }
}
