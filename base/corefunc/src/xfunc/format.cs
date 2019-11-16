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
        /// Formats a readonly span of characters by forming the implied string
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Format(this ReadOnlySpan<char> src)
            => new string(src);

        /// <summary>
        /// Formats a span of characters by forming the implied string
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<char> src)
            => new string(src);

        /// <summary>
        /// Formats a stream as a delimited sequence with an optional custom value formatter
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <param name="formatter">An optional custom value formatter</formatter>
        /// <typeparam name="T">The item type</typeparam>
        public static string FormatSequence<T>(this IEnumerable<T> src, string sep = ", ",  Func<T,string> formatter = null)
            => string.Join(sep, src.Select(x => formatter?.Invoke(x) ?? x.ToString())).TrimEnd();

        static Func<string,int,string> GetPadFunc<T>(bool padright)
            => padright 
            ? new Func<string,int,string>((s,n) => s.PadRight(n)) 
            : new Func<string,int,string>((s,n) => s.PadLeft(n));


        /// <summary>
        /// Formats a 128-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector128<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0)
            where T : unmanaged
        {
            var elements = src.ToSpan();
            return sfmt == SeqFmtKind.Vector 
                ? elements.FormatAsVector(sep.ToString()) 
                : elements.FormatList(sep,0,pad);
        }

        /// <summary>
        /// Formats a 256-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector256<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0)
            where T : unmanaged
        {
            var elements = src.ToSpan();
            return sfmt == SeqFmtKind.Vector 
                ? elements.FormatAsVector(sep.ToString()) 
                : elements.FormatList(sep,0,pad);
        }
    }
}