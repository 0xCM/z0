//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class gbits
    {
        [MethodImpl(Inline), Parse, Closures(UnsignedInts)]
        public static ref T parse<T>(ReadOnlySpan<char> src, byte offset, out T dst)
            where T : unmanaged
        {
            var last = math.min(bitwidth<T>(), src.Length) - 1;
            ref readonly var input = ref first(src);
            dst = default;

            for(int i=offset, pos = 0; i<= last; i++, pos++)
                if(skip(input,i) == Bit32.One)
                    dst = gbits.enable(dst, pos);
            return ref dst;
        }
    }
}