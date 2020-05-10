using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosExtensao
{
    public static class StringExtensions
    {
        public static string InverterCaixas(this string str, bool estadoInicial)
        {
            bool isUpperCase = estadoInicial;
            string resultado = string.Empty;
            foreach (char i in str)
            {
                resultado += isUpperCase ? i.ToString().ToUpper() : i.ToString().ToLower();
                isUpperCase = !isUpperCase;
            }

            return resultado; 
        }
    }
}
