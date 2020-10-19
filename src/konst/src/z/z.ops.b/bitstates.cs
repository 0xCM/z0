//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        public static IEnumerable<BitState> bitstates<T>(T src)
            where T : struct
        {
            var size = z.size<T>();
            var buffer = sys.alloc<BitState>(size*8);
            bitstates(src, buffer);
            foreach(var bit in buffer)
                yield return bit;
        }

        [Op, Closures(Closure)]
        public static BitState[] bitstates<T>(in T src, BitState[] dst)
            where T : struct
        {
            var size = size<T>();
            ref var input = ref @as<T,byte>(src);
            ref var output = ref @as<BitState,ulong>(first(span(dst)));

            for(var i=0u; i<size; i++)
                seek(output, i) = unpack(skip(input,i));
            return dst;
        }
    }
}