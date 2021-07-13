//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    using System;
    using System.Runtime.CompilerServices;

    public struct VPipe128<P,S,T> : ISpanPipe128<S,T>
        where P : IVMap128<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        P VMap;

        [MethodImpl(Inline)]
        public VPipe128(P vmap)
        {
            VMap = vmap;
        }

        [MethodImpl(Inline)]
        public uint Flow(in SpanBlock128<S> src, in SpanBlock128<T> dst)
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