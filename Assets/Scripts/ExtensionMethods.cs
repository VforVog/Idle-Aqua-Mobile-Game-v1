using System;
using System.Collections;
using UnityEngine;

public static class ExtensionMethods
{
    public static string SciFormat(this double num)     //"Sci" = scientific
    {
        //afto to kaloume me .SciFormat() piso apo to numero pou theloume na allaksoume 
        return num.ToString("0.00E+0");
    }

    public static string NumberFormating(this double num)
    {
        //afto to kaloume me .NumberFormating() piso apo to numero pou theloume na allaksoume 
        string[] suffixes = new string[] { "", "a", "b", "c", "d", "e", "f", "g", "e", "h", "i", "j", "k", "l", "m", "n", "o", "o", "p", "q", "r" };
        int thousands = 0;
        while (num >= 1000)
        {
            num /= 1000;
            thousands++;
        }
        return num.ToString("0") + suffixes[thousands]; //aferei tin ypodiastoli

    }
}
