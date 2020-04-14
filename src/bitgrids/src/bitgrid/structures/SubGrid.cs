//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    partial class SubGrid
    {
        [MethodImpl(Inline),Op]
        public static SubGrid32<N8,N3,uint> define(Perm8L p)
            => (uint)p;

        [MethodImpl(Inline) ,Op]
        public static SubGrid32<N8,N3,uint> define(NatPerm<N8> p)
            => define(p.ToLiteral());

        [Op]
        public static SubGrid256<N32,N5,ulong> define(NatPerm<N32> p)
        {
            var m = n32;
            var n = n5;
            var w = n256;
            var dst = Blocks.single<ulong>(w);
            var mask = BitMasks.Lsb64x8x5;
            var bs = BitString.alloc(w);
            for(int i=0, j=0 ; i< p.Length; i++, j+=5)
                bs.BitMap(p[i].ToBitString(),j, 5);
            return BitGrid.subgrid(bs.ToCpuVector<ulong>(w), m,n);
        }                
    }
}