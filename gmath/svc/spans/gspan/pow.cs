//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static SFuncs;
    using static refs;

    partial class gspan
    {
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
        public static Span<T> pow<T>(ReadOnlySpan<T> src, uint exp, Span<T> dst)
            where T : unmanaged
        {
            var count = dst.Length;
            ref readonly var bases = ref head(src);
            ref var results = ref head(dst);

            for(var i = 0; i<count; i++) 
                seek(ref results,i) = gmath.pow(skip(bases,i), exp);
            
            return dst;
        }
    }
}