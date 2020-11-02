//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiDataType]
    public class t_bb_create : t_bitspans<t_bb_create>
    {
        CallingMember Caller;

        public void bb_create_124x8()
            => check_bitblock_create<byte>(124, z.caller(ref Caller));

        public void bb_create_128x8()
            => check_bitblock_create<byte>(128, z.caller(ref Caller));

        public void bb_create_13x16()
            => check_bitblock_create<ushort>(13, z.caller(ref Caller));

        public void bb_create_125x16()
            => check_bitblock_create<ushort>(125, z.caller(ref Caller));

        public void bb_create_128x16()
            => check_bitblock_create<ushort>(128, z.caller(ref Caller));

        public void bb_create_13x32()
            => check_bitblock_create<uint>(13, z.caller(ref Caller));

        public void bb_create_64x32()
            => check_bitblock_create<uint>(64, z.caller(ref Caller));

        public void bb_create_125x32()
            => check_bitblock_create<uint>(125, z.caller(ref Caller));

        public void bb_create_128x32()
            => check_bitblock_create<uint>(128, z.caller(ref Caller));

        public void bb_create_63x64()
            => check_bitblock_create<ulong>(63, z.caller(ref Caller));

        public void bb_create_127x64()
            => check_bitblock_create<ulong>(127, z.caller(ref Caller));

        public void bb_create_128x64()
            => check_bitblock_create<ulong>(128, z.caller(ref Caller));

        public void bb_create_n63x64u()
            => check_bitblock_range<N63,ulong>();

        public void bb_create_n13x16u()
            => check_bitblock_range<N13,ushort>();

        public void bb_create_n32x32u()
            => check_bitblock_range<N32,uint>();

         [MethodImpl(Inline), Ignore]
        protected void check_bitblock_create<T>(int bitcount, in CallingMember caller)
            where T : unmanaged
        {
            var kCells = (int)GridCells.mincells<T>((ulong)bitcount);

            if(DiagnosticMode)
                term.print($"Executing {caller.Name}: {bitcount} bits covered by {kCells} cells of kind {typeof(T).DisplayName()}");

            var src = Random.Span<T>(RepCount);

            for(var i=0; i<RepCount; i += kCells)
            {
                var data = src.Slice(i, kCells);
                var bc = data.ToBitBLock(bitcount);
                var bs = data.ToBitString(bitcount);
                Claim.eq(bc.BitCount, bitcount);
                Claim.eq(bs.Length, bitcount);

                for(var j=0; j<bc.BitCount; j++)
                    Claim.Eq(bc[j], bs[j]);
            }
        }


         [MethodImpl(Inline), Ignore]
         protected void check_bitblock_range<N,T>(N _ = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            int n = (int)nat64u<N>();
            var rep = default(N);
            var segcount = (int)GridCells.mincells<T>(nat64u<N>());
            Claim.eq(BitBlock<N,T>.NeededCells, segcount);
            var totalcap = BitBlock<N,T>.RequiredWidth;
            var segcap = bitwidth<T>();
            Claim.eq(BitBlock<N,T>.CellWidth, segcap);

            var src = Random.Span<T>(RepCount);
            for(var i=0; i<RepCount; i+= segcount)
            {
                var bcSrc = src.Slice(i,segcount);
                var bc = bcSrc.ToNatBits(rep);
                ClaimEqual(bc,bc.ToBitString());
                Claim.eq(n, bc.Width);
                Claim.eq(segcap * segcount, totalcap);

                var x = src[i];
                for(byte j = 0; j < n; j++)
                    Claim.Eq(gbits.testbit32(x,j), bc[j]);
            }
        }
    }
}