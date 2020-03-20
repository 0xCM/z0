//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Text;

    using static Root;

    /// <summary>
    /// Exposes formatting capabilites via exension methods
    /// </summary>
    partial class FormattingOps
    {
        /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this ReadOnlySpan<T> src, char? delimiter = null, int offset = 0)
            where T : ICustomFormattable
        {
            if(src.Length == 0)
                return string.Empty;

            var sep = delimiter ?? text.comma();
            var dst = text.factory.Builder();
            
            for(var i = offset; i< src.Length; i++)
            {
                if(i!=offset)
                {
                    dst.Append(sep);
                    dst.Append(text.space());
                }
                dst.Append(src[i].Format());
            }
            return dst.ToString();
        }

        /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this IEnumerable<T> items, char? delimiter = null, int offset = 0)
            where T : ICustomFormattable
                => string.Join(delimiter ?? AsciSym.Comma, items.Skip(0).Select(x => x.Format()));
    }
}