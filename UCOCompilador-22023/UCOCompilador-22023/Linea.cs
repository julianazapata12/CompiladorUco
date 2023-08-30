using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOCompilador_22023
{
    internal class linea

    {
        private int numeroLinea;
        private string contenido;

        private linea(int numeroLinea, string contenido)
        {
            NumeroLinea = numeroLinea;
            Contenido = contenido;

        }
        public static linea Crear(int numeroLinea, string contenido)
        {
            return new linea(numeroLinea, contenido);
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public string Contenido { get => contenido; set => contenido = value; }
    }
}

