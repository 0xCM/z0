//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

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
        public static string Format<T>(this Vector128<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0, bool bracketed = true)
            where T : unmanaged
        {
            var elements = src.ToSpan();
            return sfmt == SeqFmtKind.Vector 
                ? elements.FormatAsVector(sep.ToString()) 
                : elements.FormatList(sep,0,pad,bracketed);
        }

        /// <summary>
        /// Formats a 256-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector256<T> src, SeqFmtKind sfmt = SeqFmtKind.List, char sep = ',', int pad = 0, bool bracketed = true,  bool seplanes = false)
            where T : unmanaged
        {
            if(seplanes)
                return $"{src.GetLower().Format(sfmt, sep, pad)} {src.GetUpper().Format(sfmt, sep, pad)}";
            else
            {
                var elements = src.ToSpan();
                return sfmt == SeqFmtKind.Vector 
                    ? elements.FormatAsVector(sep.ToString()) 
                    : elements.FormatList(sep,0,pad,bracketed);
            }
        }
    }
}