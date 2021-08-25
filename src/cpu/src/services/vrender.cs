//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct vrender
    {
        const NumericKind Closure = UInt64k;

        [Op, Closures(Closure)]
        public static void outcome<T>(SpanBlock128<T> x, SpanBlock128<T> y, Vector128<T> expect, Vector128<T> actual, Vector128<T> result, ITextBuffer dst)
            where T : unmanaged
        {
            dst.Label("left", Chars.Colon, x.Format());
            dst.Label("right", Chars.Colon, y.Format());
            dst.Label("expect", Chars.Colon, expect.Format());
            dst.Label("actual", Chars.Colon, actual.Format());
            dst.Label("result", Chars.Colon, result.Format());
        }

        [Op, Closures(Closure)]
        public static void outcome<T>(SpanBlock256<T> x, SpanBlock256<T> y, Vector256<T> expect, Vector256<T> actual, Vector256<T> result, ITextBuffer dst)
            where T : unmanaged
        {
            dst.Label("left", Chars.Colon, x.Format());
            dst.Label("right", Chars.Colon, y.Format());
            dst.Label("expect", Chars.Colon, expect.Format());
            dst.Label("actual", Chars.Colon, actual.Format());
            dst.Label("result", Chars.Colon, result.Format());
        }

        [Op, Closures(Closure)]
        public static void asmhex<T>(Vector128<T> src, ITextBuffer dst)
            where T : unmanaged
                => dst.Append(gcpu.vspan(src).FormatHex(Chars.Space, false));

        [Op, Closures(Closure)]
        public static void asmhex<T>(Vector256<T> src, ITextBuffer dst)
            where T : unmanaged
            => dst.Append(gcpu.vspan(src).FormatHex(Chars.Space, false));

        [Op, Closures(Closure)]
        public static void asmhex<T>(Vector512<T> src, ITextBuffer dst)
            where T : unmanaged
                => dst.Append(gcpu.vspan(src).FormatHex(Chars.Space, false));

        [Op, Closures(Closure)]
        public static void lanes<T>(Vector256<T> src, char sep, int pad, ITextBuffer dst)
            where T : unmanaged
        {
            dst.Append(string.Format("{0} {1}", src.GetLower().Format(sep, pad), src.GetUpper().Format(sep, pad)));
        }

        [Op, Closures(Closure)]
        public static void hex<T>(Vector128<T> src, ITextBuffer dst,  char sep = Chars.Comma, bool specifier = false)
            where T : unmanaged
                => dst.Append(gcpu.vspan(src).FormatHex(sep, specifier));

        [Op, Closures(Closure)]
        public static void hex<T>(Vector256<T> src, ITextBuffer dst, char sep = Chars.Comma, bool specifier = false)
             where T : unmanaged
                => dst.Append(gcpu.vspan(src).FormatHex(sep, specifier));

       public static void projection<S,T>(Vector128<S> a, Vector128<T> b, ITextBuffer dst)
            where S : unmanaged
            where T : unmanaged
        {
            var srcType = TypeIdentity.numeric<S>();
            var srcCount = a.Length();
            var dstType = TypeIdentity.numeric<T>();
            var dstCount = b.Length();
            var srcWidth = srcCount * width<S>();
            var dstWidth = dstCount * width<T>();
            var srcLabel = $"v{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:[{a.FormatHex()}] -> [{b.FormatHex()}]";
            dst.Append(formatted);
        }

        public static void projection<S,T>(SpanBlock64<S> a, Vector128<T> b, ITextBuffer dst)
            where S : unmanaged
            where T : unmanaged
        {
            var sep = Chars.Space;
            var srcType = TypeIdentity.numeric<S>();
            var srcCount = a.CellCount;
            var dstType = TypeIdentity.numeric<T>();
            var dstCount = b.Length();
            var srcWidth = srcCount * width<S>();
            var dstWidth = dstCount * width<T>();
            var srcLabel = $"m{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:[{a.Storage.FormatHex(sep, false)}] -> [{b.FormatHex(sep, false)}]";
            dst.Append(formatted);
        }
    }
}