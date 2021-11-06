//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    using System;
    using System.Runtime.CompilerServices;

    public struct SBlockProjector128<P,S,T> : ISpanBlockProjector128<S,T>
        where P : IVMap128<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        P VMap;

        [MethodImpl(Inline)]
        public SBlockProjector128(P vmap)
        {
            VMap = vmap;
        }

        [MethodImpl(Inline)]
        public uint Map(in SpanBlock128<S> src, in SpanBlock128<T> dst)
        {
            var count = src.BlockCount;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                gcpu.vstore(VMap.Invoke(gcpu.vload(src,i)), dst,i);
                counter++;
            }
            return counter;
        }
    }
}