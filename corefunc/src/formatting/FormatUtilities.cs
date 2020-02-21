//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;         

    partial class xfunc
    {

        /// <summary>
        /// Formats the supplied decimal value as currency to two decimal places
        /// </summary>
        /// <param name="d">The decimal value</param>
        public static string FormatAsCurrency(this decimal src, int scale = 2)
            => String.Format(embrace($"0:C{scale}"), src);

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this short src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this ushort src)
                => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this int src)
                => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this uint src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this long src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this ulong src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this float src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        public static string CommaSeparated(this double src)
            => src.ToString("#,#");

        public static char ToDecimalChar(this byte src)
        {
            if(src == 0)
                return '0';
            else if(src == 1)
                return '1';
            else if(src == 2)
                return '2';
            else if(src == 3)
                return '3';
            else if(src == 4)
                return '4';
            else if(src == 5)
                return '5';
            else if(src == 6)
                return '6';
            else if(src == 7)
                return '7';
            else if(src == 8)
                return '8';
            else if(src == 9)
                return '9';
            else
                return '∅';                        
        }
    }
}