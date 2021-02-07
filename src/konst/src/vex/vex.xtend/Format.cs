//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial class XVex
    {
        [Op, Closures(Closure)]
        public static string Format<T>(SpanBlock128<T> x, SpanBlock128<T> y, Vector128<T> expect, Vector128<T> actual, Vector128<T> result)
            where T : unmanaged
        {
            var dst = text.buffer();
            dst.Label("left", Chars.Colon, x.Format());
            dst.Label("right", Chars.Colon, y.Format());
            dst.Label("expect", Chars.Colon, expect.Format());
            dst.Label("actual", Chars.Colon, actual.Format());
            dst.Label("result", Chars.Colon, result.Format());
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string Format<T>(SpanBlock256<T> x, SpanBlock256<T> y, Vector256<T> expect, Vector256<T> actual, Vector256<T> result)
            where T : unmanaged
        {
            var dst = text.buffer();
            dst.Label("left", Chars.Colon, x.Format());
            dst.Label("right", Chars.Colon, y.Format());
            dst.Label("expect", Chars.Colon, expect.Format());
            dst.Label("actual", Chars.Colon, actual.Format());
            dst.Label("result", Chars.Colon, result.Format());
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string FormatHex<T>(this Vector128<T> src, char sep = Chars.Comma, bool specifier = false)
            where T : unmanaged
                => gcpu.vspan(src).FormatHex(sep, specifier);


        [Op, Closures(Closure)]
        public static string FormatHex<T>(this Vector256<T> src, char sep = Chars.Comma, bool specifier = false)
             where T : unmanaged
                => gcpu.vspan(src).FormatHex(sep, specifier);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string Format<T>(this Vector128<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => gcpu.vspan(src).FormatList(sep,0,pad,true);

        [Op, Closures(Closure)]
        public static string Format<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => gcpu.vspan(src).FormatList(sep, 0, pad, true);

        [Op, Closures(Closure)]
        public static string Format<T>(this Vector512<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => text.bracket(
                        text.concat(
                            gcpu.vspan(src).FormatList(sep, 0, pad, false),
                            sep, Chars.Space,
                            gcpu.vspan(src).FormatList(sep, 0, pad, false)
                        )
                    );

        [Op, Closures(Closure)]
        public static string FormatLanes<T>(this Vector256<T> src, char sep = Chars.Comma, int pad = 2)
            where T : unmanaged
                => text.concat(
                    src.GetLower().Format(sep, pad), Chars.Space,
                    src.GetUpper().Format(sep, pad));

        [Op, Closures(Closure)]
        public static string FormatAsmHex<T>(this Vector128<T> src)
            where T : unmanaged
                => gcpu.vspan(src).FormatHex(Chars.Space, false);

        [Op, Closures(Closure)]
        public static string FormatAsmHex<T>(this Vector256<T> src)
            where T : unmanaged
                => gcpu.vspan(src).FormatHex(Chars.Space, false);

        [Op, Closures(Closure)]
        public static string FormatAsmHex<T>(this Vector512<T> src)
            where T : unmanaged
                => gcpu.vspan(src).FormatHex(Chars.Space, false);
   }
}