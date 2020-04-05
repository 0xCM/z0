//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Seed;
    
    partial class XTend
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
            var formatted = $"{label}:{x.FormatHex(true)} -> {y.FormatHex(true)}";
            return formatted;
        }

        public static string FormatProjection<S,T>(this Block64<S> x, Vector128<T> y)
            where S : unmanaged
            where T : unmanaged
        {
            var srcType = TypeIdentity.numeric<S>();
            var srcCount = x.CellCount;
            var dstType = TypeIdentity.numeric<T>();
            var dstCount = y.Length();
            var srcWidth = srcCount * BitSize.measure<S>();
            var dstWidth = dstCount * BitSize.measure<T>();
            var srcLabel = $"m{srcWidth}x{srcType}";
            var dstLabel = $"v{dstWidth}x{dstType}";
            var label = $"{srcLabel}_{dstLabel}";
            var formatted = $"{label}:{x.Data.FormatHex(true,' ',false)} -> {y.FormatHex(true,' ',false)}";
            return formatted;
        }
    }
}