using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encriptacion.Models
{
    public static class Octal
    {
        
        public static Dictionary<char, String> Codificacion { get; } = new Dictionary<char, String>()
        {
            {'A' , "100"},
            {'B' , "101"},
            {'C' , "102"},
            {'D' , "103"},
            {'E' , "104"},
            {'F' , "105"},
            {'G' , "106"},
            {'H' , "107"},
            {'I' , "108"},
            {'J' , "109"},
            {'K' , "110"},
            {'L' , "111"},
            {'M' , "112"},
            {'N' , "113"},
            {'O' , "114"},
            {'P' , "115"},
            {'Q' , "116"},
            {'R' , "117"},
            {'S' , "118"},
            {'T' , "119"},
            {'U' , "120"},
            {'V' , "121"},
            {'W' , "122"},
            {'X' , "123"},
            {'Y' , "124"},
            {'Z' , "125"},
            {'0' , "60"},
            {'1' , "61"},
            {'2' , "62"},
            {'3' , "63"},
            {'4' , "64"},
            {'5' , "65"},
            {'6' , "66"},
            {'7' , "67"},
            {'8' , "68"},
            {'9' , "69"},
        };
    }
}
