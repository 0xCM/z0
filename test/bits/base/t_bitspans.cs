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
                    bv[i] = bit.Off;
                    bs[i] = bit.Off;
                }

                Claim.eq(bv.ToBitString(),bs);
            }
        }

        protected void bitblock_disable_check<N,T>(N n = default, T rep = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            for(var k=0; k<RepCount; k++)
            {
                var bc = Random.BitBlock<N,T>();
                var bs = bc.ToBitString();
                Claim.almost(bc.Width, n.NatValue);
                Claim.eq(bc.Width, bs.Length);
                for(var i=0; i<bc.Width; i+= 2)
                {
                    bc[i] = bit.Off;
                    bs[i] = bit.Off;
                }

                Claim.eq(bc.ToBitString(),bs);
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

        /// <summary>
        /// Verifies the natural bit cell dot product operation
        /// </summary>
        /// <param name="n">The bitvector width</param>
        /// <param name="zero">A scalar representative</param>
        /// <typeparam name="N">The bitvector width type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void bitblock_dot_check<N,T>(N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitBlock<N,T>();
                var y = Random.BitBlock<N,T>();
                bit a = x % y;
                var b = BitBlocks.modprod(x,y);
                if(a != b)
                    Notify($"nbc {n}x{ApiIdentityKinds.numeric<T>()} is a problem");
                Claim.Require(a == b);
            }
        }


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
                    Claim.Eq(gbits.testbit(x,j), bc[j]);
            }
        }

        protected void check_bitblock_create<T>(int bitcount)
            where T : unmanaged
        {
            var segcount = (int)GridCells.mincells<T>((ulong)bitcount);

            if(DiagnosticMode)
                term.print($"Executing {caller()}: {bitcount} bits covered by {segcount} segments of kind {typeof(T).DisplayName()}");

            var src = Random.Span<T>(RepCount);

            for(var i=0; i<RepCount; i += segcount)
            {
                var data = src.Slice(i, segcount);
                var bc = data.ToBitCells(bitcount);
                var bs = data.ToBitString(bitcount);
                Claim.eq(bc.BitCount, bitcount);
                Claim.eq(bs.Length, bitcount);

                for(var j=0; j<bc.BitCount; j++)
                    Claim.Eq(bc[j], bs[j]);
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