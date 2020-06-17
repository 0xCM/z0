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

    partial class gbits
    {
        [MethodImpl(Inline), Parse, Closures(UnsignedInts)]
        public static ref T parse<T>(ReadOnlySpan<char> src, byte offset, out T dst)
            where T : unmanaged
        {            
            var last = math.min(bitsize<T>(), src.Length) - 1;
            ref readonly var input = ref head(src);            
            dst = default;

            for(int i=offset, pos = 0; i<= last; i++, pos++)
                if(skip(input,i) == bit.One)
                    dst = gbits.enable(dst, pos);                        
            return ref dst;
        }
    }
}