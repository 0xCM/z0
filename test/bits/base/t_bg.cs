//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public abstract class t_bitgrids<X> : t_bitgrids_base<X>
        where X : t_bitgrids<X>, new()
    {
        protected override int RepCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void bg_and_check<T>(uint m, uint n, T t = default)
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            base.Claim.eq((uint)gz.BlockCount, (BitVector64)GridCalcs.blocks<T>(n256, m, n));
            base.Claim.eq((uint)gz.CellCount, (BitVector64)GridCalcs.cellcount<T>(m, n));

            BitGrid.and(gx,gy,gz);

            for(var block=0; block<gx.BlockCount; block++)
                Claim.veq(gcpu.vand(gx[block], gy[block]), gz[block]);

        }

        protected void bg_xor_check<T>(uint m, uint n, T t = default)
            where T : unmanaged
        {
            var gx = Random.BitGrid(m,n,t);
            var gy = Random.BitGrid(m,n,t);
            var gz = BitGrid.alloc(m,n,t);

            base.Claim.eq((uint)gz.BlockCount, (BitVector64)GridCalcs.blocks<T>(n256, m, n));
            base.Claim.eq((uint)gz.CellCount, (BitVector64)GridCalcs.cellcount<T>(m, n));

            BitGrid.xor(gx,gy,gz);

            for(var block=0; block<gx.BlockCount; block++)
                Claim.veq(gvec.vxor(gx[block], gy[block]), gz[block]);
        }
    }
}