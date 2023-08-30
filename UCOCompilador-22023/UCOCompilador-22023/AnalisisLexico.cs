using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador_22023.Util;

namespace UCOCompilador_22023
{
    public class AnalisisLexico
    {
        private int numeroLineaActual= 0;
        private string contenidoLineaActual = "";
        private int puntero=0;
        private string caracterActual;
        private string lexema = "";
        private string categoria = "";
        private string estadoActual = "";
        private int posicionInicial = 0;
        private int posicionFinal = 0;
        private bool continuarAnalisis = false;
       
        public AnalizadorLexico()
        {
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {


                numeroLineaActual = numeroLineaActual + 1;
                contenidoLineaActual = DataCache.ObtenerLinea(numeroLineaActual).Contenido;
                numeroLineaActual = DataCache.ObtenerLinea(numeroLineaActual).NumeorLinea;
                    puntero = 1;
            }

        }
        private void LeerSiguienteCaracter()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                caracterActual = "@EOF@";
            } else if ( puntero > contenidoLineaActual.Length)
            {
                caracterActual = "@FL@";
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(puntero - 1, 1);
                puntero = puntero + 1;

            }


        }
        private void DevolverPuntero()
        {
            puntero = puntero - 1;

        }
        private void Concatenar ()
        {
            lexema = lexema + caracterActual;

        }
        private void Resetear()
        {
            estadoActual = "q0";
            lexema = "";
            categoria = "";
            posicionInicial = 0;
            posicionFinal = 0;
            caracterActual = "";
            continuarAnalisis = true;
        }
        public void DevolverSiguienteComponente()
        {
            Resetear();

            while (continuarAnalisis)
            {
                if ("q0".Equals(estadoActual))
                {
                    ProcesarEstado0();
                }
                else

                if ("q4".Equals(estadoActual))
                {
                    ProcesarEstado4();
                }


            }
            }
        }
        private void ProcesarEstado0()
        {
            DevorarEspaciosBlanco();

            if (UtilTexto.EsLetra(caracterActual) || UtilTexto.EsGuionBajo(caracterActual) || UtilTexto.EsSignoPesos(caracterActual);
            {
                estadoActual = "q4";

            }
        EventLogSession if ( UtilTexto.EsDigito( caracterActual))
        {
            estadoActual = "q1";

            }
        }
        private void ProcesarEstado4()
        {
            Concatenar();
           LeerSiguienteCaracter();

            if (UtilTexto.EsLetra(caracterActual) || UtilTexto.EsGuionBajo(caracterActual) || UtilTexto.EsSignoPesos(caracterActual);
        {
                estadoActual = "q4";
                {
                else
                }

            estadoActual = "q16";

            }
        

        }
       private void ProcesarEstado16()
    {
        DevolverPuntero();
        categoria = "IDENTIFICADOR";
        FormarComponenteLexico();
        continuarAnalisis = false;


        posicionInicial = puntero - lexema.Length;
        posicionFinal = puntero - 1;

        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Lexema: " + Lexema);
        Console.WriteLine("Numero Linea: " + Numero Linea);
        Console.WriteLine("Posicion Inicial: " + Posicion Inicial);
        Console.WriteLine("Posicion Final: " + Posicion Final);
    }
   
    private vood FormarComponenteLexico()
    {
        PosicionInicial = puntero - lexema.length;
        PosicionFinal = puntero - 1;

        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Lexema: " + Lexema);
        Console.WriteLine("Numero Linea: " + Numero Linea);
        Console.WriteLine("Posicion Inicial: " + Posicion Inicial);
        Console.WriteLine("Posicion Final: " + Posicion Final);
    }

}

private void DevorarEspaciosBlanco()
        {
            while(" ".Equals(caracterActual) || "   ".Equals (caracterActual))
            {
                LeerSiguienteCaracter();
            }
        }
  
