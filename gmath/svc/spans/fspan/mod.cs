//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static gfp;    
        
    partial class fspan
    {                
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = lhs.Length;
            for(var i = 0; i< count; i++)
                dst[i] = gfp.mod(lhs[i], rhs[i]);
            return dst;
        }
    }
}