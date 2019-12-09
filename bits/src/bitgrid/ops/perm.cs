//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {        

        [MethodImpl(Inline)]
        public static SubGrid32<N8,N3,uint> perm(Perm8 p)
            => (uint)p;

        [MethodImpl(Inline)]
        public static SubGrid32<N8,N3,uint> perm(NatPerm<N8> p)
            => (uint)p.ToLiteral();


        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> perm(Perm16 p)
            => (ulong)p;


        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> perm(NatPerm<N16> p)
        {
            var dst = 0ul;
            int length = n16;
            int m = n16;
            int n = n4;
            for(var i=0; i<length; i++)
                dst |= ((ulong)p[i] << i*n);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Perm16 perm(BitGrid64<N16,N4,ulong> g)
            => (Perm16)g.Data;

        public static SubGrid256<N32,N5,ulong> perm(NatPerm<N32> p)
        {
            var m = n32;
            var n = n5;
            var w = n256;
            var dst = DataBlocks.alloc<ulong>(w);
            var mask = BitMasks.Lsb64x8x5;
            var bs = BitString.alloc(w);
            for(int i=0, j=0 ; i< p.Length; i++, j+=5)
                bs.BitMap(p[i].ToBitString(),j, 5);
            return BitGrid.subgrid(bs.ToCpuVector<ulong>(w), m,n);
        }

        
    }

}