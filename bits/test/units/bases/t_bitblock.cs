//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public abstract class t_bitblock<X> : t_bits<X>
        where X : t_bitblock<X>, new()
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
                Claim.eq(bc.Width, n.NatValue);
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
                Claim.yea(a == b);            
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
                    Trace($"nbc {n}x{suffix<T>()} is a problem");
                Claim.yea(a == b);            
            }
        }

        protected void bitspan_from_bitstring_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)            
            {
                var bs = Random.BitString(5,233);
                var bc = BitBlocks.from<T>(bs);
                Claim.eq(bs.Length, bc.BitCount);
                for(var j=0; j<bs.Length; j++)
                {                
                    if(bc[j] != bs[j])
                    {
                        Trace("bs", bs.Format());
                        Trace("bc", bc.Format());
                    }
                    Claim.eq(bc[j],bs[j]);
                }
            }
        }

        protected void bitspan_create_check<N,T>(N _ = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            int n = natval<N>();
            var rep = default(N);
            var segcount = BitCalcs.mincells<T>(n);
            Claim.eq(BitBlock<N,T>.CellCount, segcount);
            var totalcap = BitBlock<N,T>.BitCapacity;
            var segcap = bitsize<T>();
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
                    Claim.eq(gbits.test(x,j), bc[j]);     
            }
        }

        protected void bb_create_check<T>(int bitcount)
            where T : unmanaged
        {
            var segcount = BitCalcs.mincells<T>(bitcount);
            var src = Random.Span<T>(RepCount);
            for(var i=0; i<RepCount; i += segcount)
            {
                var data = src.Slice(i, segcount);
                var bc = data.ToBitCells(bitcount);
                var bs = data.ToBitString(bitcount);
                Claim.eq(bc.BitCount, bitcount);
                Claim.eq(bs.Length, bitcount);
                
                for(var j=0; j<bc.BitCount; j++)
                    Claim.eq(bc[j], bs[j]);
            }
        }

        protected void bitblock_pop_check<N,T>(N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {            
            var len = (int)(Mod8.div((uint)n.NatValue) + (Mod8.mod((uint)n.NatValue) != 0 ? 1 : 0));            
            var src = Random.Span<byte>(len);

            var bc = BitBlocks.load<N,T>(src);
            var pc1 = bc.Pop();

            var bs = BitString.scalars(src);
            var pc2 = bs.PopCount();

            Claim.eq(pc1,pc2);
        }
    }
}