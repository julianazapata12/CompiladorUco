using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOCompilador_22023.DataCache
{
    public class DataCache
    {
        private static Dictionary<int, Linea> programaFuente = new Dictionary<int, Linea>();
        public static void Limpiar()
        {
            programaFuente.Clear();

        }
        public static void AgregarLinea(string Linea)
        {
            if (Linea != null)
            {
                int numero Linea = ObtenerProximaLinea();
                Linea lineaRetorno = Linea.Crear(numeroUltimaLinea, "@EOF");

                if (numeroLinea <= 0)
                {
                    throw new Exception("Numero de linea invalido");
                }
                else if (numeroLinea <= programaFuente.Count)
                {
                    lineaRetorno = programaFuente[numeroLinea];

                }
                return lineaRetorno;
            }
        }
}
