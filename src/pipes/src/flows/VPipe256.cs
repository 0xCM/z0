//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    using System;
    using System.Runtime.CompilerServices;

    using static SFx;

    public struct VPipe256<P,S,T> : IVPipe256<S,T>
        where P : IVMap256<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        P VMap;

        uint Counter;

        [MethodImpl(Inline)]
        public VPipe256(P vmap)
        {
            VMap = vmap;
            Counter = 0;
        }

        [MethodImpl(Inline)]
        public uint Flow(in SpanBlock256<S> src, SpanBlock256<T> dst)
        {
            var count = src.BlockCount;
            for(var i=0; i<count; i++)
            {
                gcpu.vstore(VMap.Invoke(gcpu.vload(src,i)), dst,i);
                Counter++;
            }
            return Counter;
        }
    }
}