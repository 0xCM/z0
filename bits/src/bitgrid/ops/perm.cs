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
        public static BitGrid32<uint> from(Perm8 src)
            => (uint)src;


        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> from(Perm16 src)
            => (ulong)src;

        public static SubGrid256<N32,N5,ulong> from(NatPerm<N32> src)
        {
            var m = n32;
            var n = n5;
            var w = n256;
            var dst = DataBlocks.alloc<ulong>(w);
            var mask = BitMasks.Lsb64x8x5;
            var bs = BitString.alloc(w);
            for(int i=0, j=0 ; i< src.Length; i++, j+=5)
                bs.Inject(src[i].ToBitString(),j, 5);
            return BitGrid.subgrid(bs.ToCpuVector<ulong>(w), m,n);

            // for(int i=0, j=0, k=0; i<src.Length; i++, j+=5)
            // {
            //     if(j >= 63)
            //     {
            //         j = 0;
            //         k++;
            //     }

            //     dst[k] |= (ulong)src[i] << j;
            // }
            //return BitGrid.subgrid(dst.LoadVector(),m, n);
        }

        
        [MethodImpl(Inline)]
        public static Perm16 perm(BitGrid64<N16,N4,ulong> src)
            => (Perm16)src.Data;
    }

}