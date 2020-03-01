//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    class WyHash64Suite<N> : IPointSource<N, ulong>
        where N : unmanaged, ITypeNat

    {
        static readonly int MemberCount = (int)new N().NatValue;
        
        readonly WyHash64[] Generators = new WyHash64[MemberCount];

        public WyHash64Suite(in NatSpan<N,ulong> Seed)
        {
            for(var i=0; i<MemberCount; i++)
                Generators[i] = new WyHash64(Seed[i]);
        }
        
        public NatSpan<N, ulong> Next()
        {
            var dst = NatSpan.alloc<N,ulong>();
            var next = Generators.Mapi((index ,g) => (index, value: g.Next()));
            foreach(var item in next)
                dst[item.index] = item.value;
            return dst;
            
        }
    }
}