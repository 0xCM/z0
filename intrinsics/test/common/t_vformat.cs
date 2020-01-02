//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vformat : t_vinx<t_vformat>
    {   
        public static string DescribeShuffle<T>(Vector256<T> src, byte spec, Vector256<T> dst)
            where T : unmanaged
        {
            var xFmt = src.FormatHex();
            var specFmt = spec.ToBitString();
            var dstFmt = dst.FormatHex();

            var fmt = text();
            var dataType = typeof(T).DisplayName();
            fmt.AppendLine(new string(AsciSym.Minus, 80));
            fmt.AppendLine($"shuffle256:Vec256<{dataType}> -> spec:byte -> {specFmt}");
            fmt.AppendLine(xFmt);
            fmt.AppendLine(dstFmt);
            return fmt.ToString();
        }

        public static string Describe2x128Perm<T>(Vector256<T> x, Vector256<T> y, byte spec, Vector256<T> dst)
            where T : unmanaged
        {
            var xFmt = x.FormatHex();
            var yFmt = y.FormatHex();
            var dstFmt = dst.Format();
            var specFmt = spec.ToBitString();
            var fmt = text();
            var dataType = typeof(T).DisplayName();
            fmt.AppendLine(new string(AsciSym.Minus, 80));
            fmt.AppendLine($"permute2x128:Vec256<{dataType}> -> Vec256<{dataType}> -> {specFmt}");
            fmt.AppendLine(xFmt);
            fmt.AppendLine($"{yFmt}");
            fmt.AppendLine(dstFmt);
            return fmt.ToString();
        }

        public static string Format<S,T>(Vector128<S> x, Vector128<T> y)
            where S : unmanaged
            where T : unmanaged
        {
            var srcType = moniker<S>();
            var srcCount = x.Length();
            var dstType = moniker<T>();
            var dstCount = y.Length();
            var srcWidth = srcCount * bitsize<S>();
            var dstWidth = dstCount * bitsize<T>();
            var srcLabel = $"v{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:{x.FormatHex(true)} -> {y.FormatHex(true)}";
            return formatted;
        }

        public static string Format<S,T>(Block64<S> x, Vector128<T> y)
            where S : unmanaged
            where T : unmanaged
        {
            var srcType = moniker<S>();
            var srcCount = x.CellCount;
            var dstType = moniker<T>();
            var dstCount = y.Length();
            var srcWidth = srcCount * bitsize<S>();
            var dstWidth = dstCount * bitsize<T>();
            var srcLabel = $"m{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:{x.Data.FormatHex(true)} -> {y.FormatHex(true)}";
            return formatted;
        }


        public void Report<T>(Block128<T> x, Block128<T> y, Vector128<T> expect, Vector128<T> actual, Vector128<T> result)
            where T : unmanaged
        {
            var pad = 5;
            Trace("left", x.FormatList(pad:pad));
            Trace("right", y.FormatList(pad:pad));
            Trace("expect", expect.FormatList(pad:pad));
            Trace("actual", actual.FormatList(pad:pad));
            Trace("result", result.FormatList(pad:pad));

        }

        public void Report<T>(Block256<T> x, Block256<T> y, Vector256<T> expect, Vector256<T> actual, Vector256<T> result)
            where T : unmanaged
        {
            var pad = 5;
            Trace("left", x.FormatList(pad:pad));
            Trace("right", y.FormatList(pad:pad));
            Trace("expect", expect.FormatList(pad:pad));
            Trace("actual", actual.FormatList(pad:pad));
            Trace("result", result.FormatList(pad:pad));

        }
    }
}