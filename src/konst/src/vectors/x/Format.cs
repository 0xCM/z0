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

    partial class VXTend
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string Format<T>(SpanBlock128<T> x, SpanBlock128<T> y, Vector128<T> expect, Vector128<T> actual, Vector128<T> result)
            where T : unmanaged
        {
            var dst = text.build();
            dst.Label("left", LabelDelimiter, x.Format());
            dst.Label("right", LabelDelimiter, y.Format());
            dst.Label("expect", LabelDelimiter, expect.Format());
            dst.Label("actual", LabelDelimiter, actual.Format());
            dst.Label("result", LabelDelimiter, result.Format());
            return dst.ToString();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string Format<T>(SpanBlock256<T> x, SpanBlock256<T> y, Vector256<T> expect, Vector256<T> actual, Vector256<T> result)
            where T : unmanaged
        {
            var dst = text.build();
            dst.Label("left", LabelDelimiter, x.Format());
            dst.Label("right", LabelDelimiter, y.Format());
            dst.Label("expect", LabelDelimiter, expect.Format());
            dst.Label("actual", LabelDelimiter, actual.Format());
            dst.Label("result", LabelDelimiter, result.Format());
            return dst.ToString();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string FormatHex<T>(this Vector128<T> src, char sep = ItemDelimiter, bool specifier = false)
            where T : unmanaged
                => z.vspan(src).FormatHex(sep, specifier);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string FormatHex<T>(this Vector256<T> src, char sep = ItemDelimiter, bool specifier = false)
             where T : unmanaged
                => z.vspan(src).FormatHex(sep, specifier);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string Format<T>(this Vector128<T> src, char sep = ItemDelimiter, int pad = 2)
            where T : unmanaged
                => z.vspan(src).Format(sep,0,pad,true);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string Format<T>(this Vector256<T> src, char sep = ItemDelimiter, int pad = 2)
            where T : unmanaged
                => z.vspan(src).Format(sep, 0, pad, true);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string Format<T>(this Vector512<T> src, char sep = ItemDelimiter, int pad = 2)
            where T : unmanaged
                => text.bracket(
                        text.concat(
                            z.vspan(src).Format(sep, 0, pad, false),
                            sep, Chars.Space,
                            z.vspan(src).Format(sep, 0, pad, false)
                        )
                    );

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string FormatLanes<T>(this Vector256<T> src, char sep = ItemDelimiter, int pad = 2)
            where T : unmanaged
                => text.concat(
                    src.GetLower().Format(sep, pad), Chars.Space,
                    src.GetUpper().Format(sep, pad));
   }
}