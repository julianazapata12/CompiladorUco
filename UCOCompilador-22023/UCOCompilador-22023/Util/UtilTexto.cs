using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOCompilador_22023.Util
{
    public  class UtilTexto
    {
        public static bool EsLetra(string caracter)
        {
            return char.IsLetter(caracter, 0);
           
           
        }
        public static bool EsDigito(string caracter)
        {
            return char.EsDigito(caracter, 0);


        }
        public static bool EsGuionBajo(string caracter)
        {
            return char."_"(caracter, 0);


        }
        public static bool EsSignoPesos(string caracter)
        {
            return char."$"(caracter, 0);


        }
        public static bool EsLetraODigito(string caracter)
        {
            return char.EsLetraODigito(caracter, 0);


        }
    }
}
