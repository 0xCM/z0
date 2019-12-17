//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Text.RegularExpressions;
    using System.Text;

    using static zfunc;
    using static nfunc;

    partial class xfunc
    {
        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string FormatList<T>(this ReadOnlySpan<T> src, char sep = ',', int offset = 0, int pad = 0, bool bracketed = true)
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
            return bracketed ? bracket(sb.ToString()) : sb.ToString();
        }

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this Span<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            => src.ReadOnly().FormatList(delimiter, offset, pad, bracketed);


        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this Block128<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Data.FormatList(delimiter, offset, pad, bracketed);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this Block256<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Data.FormatList(delimiter, offset, pad,bracketed); 

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this ConstBlock128<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Data.FormatList(delimiter, offset, pad,bracketed);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<T>(this ConstBlock256<T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where T : unmanaged
            => src.Data.FormatList(delimiter, offset, pad,bracketed);

        /// <summary>
        /// Formats a span of natural length as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]        
        public static string FormatList<N,T>(this NatBlock<N,T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where N : unmanaged, ITypeNat
            where T : unmanaged 
                => src.Data.FormatList(delimiter,offset,pad,bracketed);

        /// <summary>
        /// Formats vector content for console/file output
        /// </summary>
        /// <param name="src">The vector to format</param>
        /// <param name="sep">The component separator</param>
        /// <param name="pad">The per-component padding</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static string FormatList<T>(this Vector128<T> src, char sep = ',', int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Format(SeqFmtKind.List, sep, pad, bracketed);

        /// <summary>
        /// Formats vector content for console/file output
        /// </summary>
        /// <param name="src">The vector to format</param>
        /// <param name="sep">The component separator</param>
        /// <param name="pad">The per-component padding</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static string FormatList<T>(this Vector256<T> src, char sep = ',', int pad = 0, bool bracketed = true)
            where T : unmanaged
                => src.Format(SeqFmtKind.List,sep,pad, bracketed);
    }
}