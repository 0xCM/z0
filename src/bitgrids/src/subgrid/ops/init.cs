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

    partial class SubGrid
    {
        [MethodImpl(Inline), Init]
        public static SubGrid32<N8,N3,uint> init(Perm8L p)
            => (uint)p;

        [MethodImpl(Inline), Init]
        public static SubGrid32<N8,N3,uint> init(NatPerm<N8> p)
            => init(p.ToLiteral());

        [Init]
        public static SubGrid256<N32,N5,ulong> init(NatPerm<N32> p)
        {
            var m = n32;
            var n = n5;
            var w = n256;
            var dst = SpanBlocks.alloc<ulong>(w);
            var mask = MaskLiterals.Lsb64x8x5;
            var bs = BitString.alloc(w);
            for(int i=0, j=0 ; i< p.Length; i++, j+=5)
                bs.BitMap(p[i].ToBitString(),j, 5);
            return BitGrid.subgrid(bs.ToCpuVector<ulong>(w), m,n);
        }
    }
}