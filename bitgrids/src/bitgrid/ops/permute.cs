//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class BitGrid
    {        
        /// <summary>
        /// Derives a 4x4 bitgrid from a permutation of length 4
        /// </summary>
        /// <param name="spec">The permutaton spec</param>
        /// <example>
        /// Permutation: [11 10 00 01] (ABCD -> BACD)
        /// Grid: [1000 | 0000 | 0100 | 1100]
        /// </example>
        [MethodImpl(Inline)]
        public static BitGrid16<N4,N4,ushort> from(Perm4L spec)
            => (ushort)spec;

        [MethodImpl(Inline)]
        public static BitGrid16<N4,N4,ushort> from(NatPerm<N4> spec)
            => from(spec.ToLiteral());

        [MethodImpl(Inline)]
        public static SubGrid32<N8,N3,uint> from(Perm8L p)
            => (uint)p;

        [MethodImpl(Inline)]
        public static SubGrid32<N8,N3,uint> from(NatPerm<N8> p)
            => from(p.ToLiteral());

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> from(Perm16L p)
            => (ulong)p;

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> from(NatPerm<N16> p)
            => from(p.ToLiteral());


        [MethodImpl(Inline)]
        public static Perm16L from(BitGrid64<N16,N4,ulong> g)
            => (Perm16L)g.Data;

        public static SubGrid256<N32,N5,ulong> from(NatPerm<N32> p)
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