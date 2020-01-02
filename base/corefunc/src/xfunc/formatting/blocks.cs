//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Text;

    using static zfunc;
    using static nfunc;

    partial class xfunc
    {
        /// <summary>
        /// Formats a span as [c0   c1 ...  cm]  where m = length - 1
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="cellpad">The width of a padded cell, if applicable</param>
        /// <param name="padchar">The character to use for cell padding, if applicable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatCellBlocks<T>(this ReadOnlySpan<T> src, int? cellpad = null, char? padchar = null, bool padright = true)
            where T : unmanaged
        {
            var padlen = cellpad ?? Unsafe.SizeOf<T>()*4;
            var filler = padchar ?? ' ';
            var pad = GetPadFunc<T>(padright);
            var sb = new StringBuilder();  
            sb.Append("[");
            for(var i = 0; i< src.Length; i++)
            {
                var fmt = $"{src[i]}";
                if(i != src.Length - 1)
                    sb.Append(pad(fmt,padlen));
                else
                    sb.Append(fmt);

            }
            sb.Append("]");
            return sb.ToString();
        }

        /// <summary>
        /// Formats a span as [c0   c1 ...  cm]  where m = length - 1
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="cellpad">The width of a padded cell, if applicable</param>
        /// <param name="padchar">The character to use for cell padding, if applicable</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatCellBlocks<T>(this Span<T> src, int? cellpad = null, char? padchar = null, bool padright = true)        
            where T : unmanaged
                => src.ReadOnly().FormatCellBlocks(cellpad, padchar, padright);
    }
}