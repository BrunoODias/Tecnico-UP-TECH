using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModelsServicesInterfaces
{
    public static class Extencoes
    {
        public static string RemoveSpecialCharacter(this string text, string replace="_"){
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            return rgx.Replace(text,replace);
        }
    }
}
