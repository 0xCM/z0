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
    
    partial class VectorExtensions
    {
        /// <summary>
        /// Formats a 128-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string FormatAsList<T>(this Vector128<T> src, int pad = 0)
            where T : unmanaged
        {
            var sfmt = SequenceFormatKind.List;
            var sep = ',';
            var bracketed = true;
            var elements = vgeneric.span(src);
            return sfmt == SequenceFormatKind.Vector 
                ? elements.FormatAsVector(sep.ToString()) 
                : elements.FormatDataList(sep,0,pad,bracketed);
        }

        /// <summary>
        /// Formats a 128-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector128<T> src, SequenceFormatKind sfmt, char sep = ',', int pad = 0, bool bracketed = true)
            where T : unmanaged
        {
            var elements = vgeneric.span(src);
            return sfmt == SequenceFormatKind.Vector 
                ? elements.FormatAsVector(sep.ToString()) 
                : elements.FormatDataList(sep,0,pad,bracketed);
        }

        /// <summary>
        /// Formats a 256-bit cpu vector as indicated by the specified options
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="sfmt">The format classifier</param>
        /// <param name="sep">The character that intersperses the vector components</param>
        /// <param name="pad">The component padding length</param>
        /// <typeparam name="T">The component type type</typeparam>
        public static string Format<T>(this Vector256<T> src, SequenceFormatKind sfmt = SequenceFormatKind.List, char sep = ',', int pad = 0, bool bracketed = true,  bool seplanes = false)
            where T : unmanaged
        {
            if(seplanes)
                return $"{src.GetLower().Format(sfmt, sep, pad)} {src.GetUpper().Format(sfmt, sep, pad)}";
            else
            {
                var elements = vgeneric.span(src);
                return sfmt == SequenceFormatKind.Vector 
                    ? elements.FormatAsVector(sep.ToString()) 
                    : elements.FormatDataList(sep,0,pad,bracketed);
            }
        }

        public static string Format<T>(this Vector512<T> src, char sep = ',', int pad = 0)
            where T : unmanaged
            => text.bracket(text.concat(
                    src.Lo.Format(sep:sep, pad:pad, bracketed:false), 
                    $"{sep} ",
                    src.Hi.Format(sep:sep, pad:pad, bracketed:false)));

        public static string Format<T>(this Vector1024<T> src, char sep = ',', int pad = 0)
            where T : unmanaged
            => text.bracket(text.concat(
                    src.A.Format(sep:Chars.Comma, bracketed:false), $"{sep} ",
                    src.B.Format(sep:Chars.Comma,bracketed:false), $"{sep} ",
                    src.C.Format(sep:Chars.Comma,bracketed:false), $"{sep} ",
                    src.D.Format(sep:Chars.Comma,bracketed:false))
                    ); 
    }
}