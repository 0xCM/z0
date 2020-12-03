//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CallingMember;
    using static z;

    public class t_nbb_create : t_bitspans<t_nbb_create>
    {
        public void nbb_create_n63x64u()
            => check_nbb_create<N63,ulong>();

        public void nbb_create_n13x16u()
            => check_nbb_create<N13,ushort>();

        public void nbb_create_n32x32u()
            => check_nbb_create<N32,uint>();

         [MethodImpl(Inline), Ignore]
         protected void check_nbb_create<N,T>(N _ = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            int n = (int)nat64u<N>();
            var rep = default(N);
            var segcount = (int)GridCalcs.mincells<T>(nat64u<N>());
            Claim.eq(BitBlock<N,T>.RequiredCells, segcount);
            var totalcap = BitBlock<N,T>.RequiredWidth;
            var segcap = bitwidth<T>();
            base.Claim.eq(BitBlock<N, T>.CellWidth, (BitVector32)segcap);

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
                    Claim.eq(gbits.testbit32(x,j), bc[j]);
            }
        }

        /// <summary>
        /// Asserts logical bitvector/bitstring equality
        /// </summary>
        /// <param name="bv">The bitvector to compare</param>
        /// <param name="bs">The bitstring to compare</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="S">The vector cell type</typeparam>
        protected void ClaimEqual<N,S>(BitBlock<N,S> bv, BitString bs)
            where N : unmanaged, ITypeNat
            where S : unmanaged
        {
            var n = (int)(new N().NatValue);
            Claim.eq(bs.Length, n);
            for(var i=0; i<n; i++)
                Claim.eq(bv[i], bs[i]);
        }
    }
}