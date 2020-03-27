//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static gmath;    
    using static Checks;
        
    partial class fspan
    {                
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale, Span<T> dst)
            where T : unmanaged
        {                        
            var count = length(src,dst);
            for(var i = 0; i< count; i++)
                dst[i] = gfp.round(src[i], scale);
            return dst;
        }

    }
}