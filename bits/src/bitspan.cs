//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    public static class bitspan
    {                        
        static uint pop(in ulong src, int len)
        {
            var count = 0u;
            var current = 0;
            do
                count += Bits.pop(skip(in src, current));                
            while(++current < len);

            return count;
        }

        [MethodImpl(Inline)]
        public static uint pop<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => pop(in head(src.AsUInt64()), src.Length);

        [MethodImpl(Inline)]
        public static uint pop<T>(Span<T> src)
            where T : unmanaged
                => pop(in head(src.AsUInt64()), src.Length);

    }

}
