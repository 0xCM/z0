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
        [MethodImpl(Inline), Abs, Closures(Floats)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = src.Length;
            ref var a = ref head(dst);
            ref readonly var b = ref head(src);
            for(var i =0; i<count; i++)
                seek(ref a, i) = gfp.abs(skip(b, i));
            return dst;
        }
    }
}