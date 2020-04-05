//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    partial class XTend
    {
        public static string Format<T>(this Vector128<T> src, SequenceFormatKind sfmt = SequenceFormatKind.List, 
            char sep = Chars.Comma, int pad = 0, bool bracketed = true)
                where T : unmanaged
                => sfmt == SequenceFormatKind.Vector 
                 ? VCore.span(src).FormatAsVector(sep.ToString()) 
                 : VCore.span(src).FormatDataList(sep,0,pad,bracketed);

        /// <summary>
        /// Formats a 256-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector256<T> src, SequenceFormatKind sfmt = SequenceFormatKind.List, 
            char sep = Chars.Comma, int pad = 0, bool bracketed = true,  bool seplanes = false)
                where T : unmanaged
        {
            if(seplanes)
                return text.concat(
                    src.GetLower().Format(sfmt, sep, pad, bracketed), Chars.Space, 
                    src.GetUpper().Format(sfmt, sep, pad, bracketed));
            else
            {
                return sfmt == SequenceFormatKind.Vector 
                    ? VCore.span(src).FormatAsVector(sep.ToString()) 
                    : VCore.span(src).FormatDataList(sep,0,pad,bracketed);
            }
        }

        public static string Format<T>(this Vector512<T> src, char sep = ',', int pad = 0)
            where T : unmanaged
                => text.bracket(
                        text.concat(
                                src.Lo.Format(sep:sep, pad:pad, bracketed:false), sep, Chars.Space, 
                                src.Hi.Format(sep:sep, pad:pad, bracketed:false)
                            )
                        );
    }
}