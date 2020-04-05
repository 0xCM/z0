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
        public static string FormatHex<T>(this Vector128<T> src, char sep = Chars.Comma, bool specifier = false)
            where T : unmanaged
                => Vectors.span(src).FormatHex(sep, specifier);

        public static string FormatHex<T>(this Vector256<T> src, char sep = Chars.Comma, bool specifier = false)
             where T : unmanaged
                => Vectors.span(src).FormatHex(sep, specifier);
     
        public static string Format<T>(this Vector128<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => Vectors.span(src).Format(sep,0,pad,true);

        public static string Format<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => Vectors.span(src).Format(sep, 0, pad, true);

        public static string Format<T>(this Vector512<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => text.bracket(
                        text.concat(
                            Vectors.span(src).Format(sep, 0, pad, false),
                            sep, Chars.Space, 
                            Vectors.span(src).Format(sep, 0, pad, false)
                        )
                    );

        public static string FormatLanes<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => text.concat(
                    src.GetLower().Format(sep, pad), Chars.Space, 
                    src.GetUpper().Format(sep, pad));
   }
}