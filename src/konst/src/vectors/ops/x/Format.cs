//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string FormatHex<T>(this Vector128<T> src, char sep = Chars.Comma, bool specifier = false)
            where T : unmanaged
                => z.vspan(src).FormatHex(sep, specifier);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string FormatHex<T>(this Vector256<T> src, char sep = Chars.Comma, bool specifier = false)
             where T : unmanaged
                => z.vspan(src).FormatHex(sep, specifier);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string Format<T>(this Vector128<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => z.vspan(src).Format(sep,0,pad,true);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string Format<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => z.vspan(src).Format(sep, 0, pad, true);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string Format<T>(this Vector512<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => text.bracket(
                        text.concat(
                            z.vspan(src).Format(sep, 0, pad, false),
                            sep, Chars.Space,
                            z.vspan(src).Format(sep, 0, pad, false)
                        )
                    );

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string FormatLanes<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => text.concat(
                    src.GetLower().Format(sep, pad), Chars.Space,
                    src.GetUpper().Format(sep, pad));
   }
}