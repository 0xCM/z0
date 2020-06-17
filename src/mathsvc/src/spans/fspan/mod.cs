//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; 
    using static Memories;
        
    partial class fspan
    {                
        [MethodImpl(Inline), Mod, Closures(Floats)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = math.min(lhs.Length, dst.Length);
            ref readonly var a = ref head(lhs);
            ref readonly var b = ref head(rhs);
            ref var c = ref head(dst);
            for(var i = 0; i< count; i++)
                seek(ref c, i) = gfp.mod(skip(a, i), skip(b, i));
            return dst;
        }
    }
}