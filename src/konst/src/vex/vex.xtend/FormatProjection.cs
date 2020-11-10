//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class XVex
    {
       public static string FormatProjection<S,T>(this Vector128<S> x, Vector128<T> y)
            where S : unmanaged
            where T : unmanaged
        {
            var srcType = TypeIdentity.numeric<S>();
            var srcCount = x.Length();
            var dstType = TypeIdentity.numeric<T>();
            var dstCount = y.Length();
            var srcWidth = srcCount * BitSize.measure<S>();
            var dstWidth = dstCount * BitSize.measure<T>();
            var srcLabel = $"v{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:[{x.FormatHex()}] -> [{y.FormatHex()}]";
            return formatted;
        }

        public static string FormatProjection<S,T>(this SpanBlock64<S> x, Vector128<T> y)
            where S : unmanaged
            where T : unmanaged
        {
            var sep = Chars.Space;
            var srcType = TypeIdentity.numeric<S>();
            var srcCount = x.CellCount;
            var dstType = TypeIdentity.numeric<T>();
            var dstCount = y.Length();
            var srcWidth = srcCount * BitSize.measure<S>();
            var dstWidth = dstCount * BitSize.measure<T>();
            var srcLabel = $"m{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:[{x.Data.FormatHex(sep, false)}] -> [{y.FormatHex(sep, false)}]";
            return formatted;
        }
    }
}