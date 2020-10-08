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

    public abstract class t_bitspans<X> : t_bitgrids_base<X>
        where X : t_bitspans<X>, new()
    {
        protected void bitblock_disable_check<T>(BitSize n)
            where T : unmanaged
        {
            for(var k=0; k<RepCount; k++)
            {
                var bv = Random.BitBlock<T>(n);
                var bs = bv.ToBitString();
                Claim.eq(bv.BitCount, n);
                Claim.eq(bv.BitCount, bs.Length);
                for(var i=0; i<bv.BitCount; i+= 2)
                {
                    bv[i] = Bit32.Off;
                    bs[i] = Bit32.Off;
                }

                Claim.eq(bv.ToBitString(),bs);
            }
        }


        /// <summary>
        /// Verifies the generic bit cell dot product operation
        /// </summary>
        /// <param name="n">The maximum effective width of a cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        protected void bitblock_dot_check<T>(int n)
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitBlock<T>(n);
                var y = Random.BitBlock<T>(n);
                var a = x % y;
                var b = BitBlocks.modprod(x,y);
                Claim.Require(a == b);
            }
        }


        protected void bitblock_pop_check<N,T>(N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            //var size = (int)(Mod8.div((uint)n.NatValue) + (Mod8.mod((uint)n.NatValue) != 0 ? 1 : 0));
            var size = BitBlock<N,byte>.NeededCells;
            var src = Random.Span<byte>((int)size);
            var bc = BitBlocks.load<N,T>(src);

            var pc1 = bc.Pop();

            var bs = BitString.scalars(src);
            var pc2 = bs.PopCount();

            Claim.eq(pc1,pc2);
        }
    }
}