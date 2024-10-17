using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1BMP
{
    public static class ArrayDebugHelper
    {
        public static string Test2D(this Array source, int pad = 15)
        {
            var result = "";
            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                    result += source.GetValue(i, j).ToString()+"\t";
                result += "\n";
            }
            return result;
        }       
        public static string Test2DA(this Array source, int pad = 15)
        {
            var result = "[\n";
            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                result += "[";
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                {
                    string value = source.GetValue(i, j).ToString();
                    value = value.Replace(',', '.');
                    result += value;
                    if (j < source.GetUpperBound(1))
                        result += ", ";
                }
                if (i<source.GetUpperBound(0))
                    result += "],\n";
                else
                    result += "]\n";
            }
            return result+"]";
        }
    }
}
