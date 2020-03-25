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

    using static Texting;

    partial class TextingOps
    {
        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatDataList<T>(this ReadOnlySpan<T> src, char sep = ',', int offset = 0, int pad = 0, bool bracketed = true)
        {
            if(src.Length == 0)
                return string.Empty;

            var sb = new StringBuilder();
            
            for(var i = offset; i< src.Length; i++)
            {
                var item =$"{src[i]}";
                sb.Append(pad != 0 ? item.PadLeft(pad) : item);                
                if(i != src.Length - 1)
                {
                    sb.Append(sep);
                    sb.Append(AsciSym.Space);
                }
            }
            return bracketed ? $"[{sb.ToString()}]" : sb.ToString();
        }

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatDataList<T>(this Span<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            => src.ReadOnly().FormatDataList(delimiter, offset, pad, bracketed);

        /// <summary>
        /// Formats an array as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatDataList<T>(this T[] src, char delimiter = ',', int offset = 0)
            => src.ToSpan().FormatDataList(delimiter, offset);
    }
}