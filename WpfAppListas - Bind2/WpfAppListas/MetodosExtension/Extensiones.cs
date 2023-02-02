using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppListas.MetodosExtension
{
    public static class Extensiones
    {
        public static Double ElevadoA(this int valor,int exponente)
        {
            return Math.Pow(valor, exponente);
        }
        public static String Iniciales(this string valor)
        {
            string resultado="";
            string[] palabras=valor.Split(' ');
            foreach(string palabra in palabras)
            {
                resultado += palabra[0]+".";
            }
            return resultado;
        }
    }
}
