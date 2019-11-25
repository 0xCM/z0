//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public abstract class t_bc<X> : t_bits<X>
        where X : t_bc<X>, new()
    {
        protected void gbc_disable_check<T>(BitSize n)
            where T : unmanaged
        {
            for(var k=0; k<SampleSize; k++)
            {
                var bv = Random.BitCells<T>(n);
                var bs = bv.ToBitString();
                Claim.eq(bv.Length, n);
                Claim.eq(bv.Length, bs.Length);
                for(var i=0; i<bv.Length; i+= 2)
                {
                    bv[i] = bit.Off;
                    bs[i] = bit.Off;
                }

                Claim.eq(bv.ToBitString(),bs);
            }
        }

        protected void nbc_disable_check<N,T>(N n = default, T rep = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            for(var k=0; k<SampleSize; k++)
            {
                var bc = Random.BitCells<N,T>();
                var bs = bc.ToBitString();
                Claim.eq(bc.Length, n.NatValue);
                Claim.eq(bc.Length, bs.Length);
                for(var i=0; i<bc.Length; i+= 2)
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
        protected void gbc_dot_check<T>(int n)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitCells<T>(n);
                var y = Random.BitCells<T>(n);
                var a = x % y;
                var b = BitCells.modprod(x,y);
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
        protected void nbc_dot_check<N,T>(N n = default, T zero = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitCells<N,T>();
                var y = Random.BitCells<N,T>();
                bit a = x % y;
                var b = BitCells.modprod(x,y);
                if(a != b)
                    Trace($"nbc {n}x{moniker<T>()} is a problem");
                Claim.yea(a == b);            
            }
        }

        protected void gbc_from_bs_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bs = Random.BitString(5,233);
                var bc = BitCells<T>.From(bs);
                Claim.eq(bs.Length, bc.Length);
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

        protected void nbc_span_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            int n = natval<N>();
            var rep = default(N);
            var segcount = BitSize.Segments<T>(n);
            Claim.eq(BitCells<N,T>.SegCount, segcount);
            var totalcap = BitCells<N,T>.TotalCapacity;
            var unusedcap = BitCells<N,T>.UnusedCapacity;
            var segcap = bitsize<T>();
            Claim.eq(BitCells<N,T>.SegWidth, segcap);

            var src = Random.Span<T>(SampleSize);
            for(var i=0; i<SampleSize; i+= segcount)
            {
                var bcSrc = src.Slice(i,segcount);
                var bc = bcSrc.ToCells(rep);
                ClaimEqual(bc,bc.ToBitString());
                Claim.eq(n, bc.Length);
                Claim.eq(segcap * segcount, totalcap);
                Claim.eq(totalcap - n, unusedcap);

                var x = src[i];
                for(byte j = 0; j < n; j++)
                    Claim.eq(gbits.test(x,j), bc[j]);     
            }
        }

        protected void gbc_span_check<T>(int bitcount)
            where T : unmanaged
        {
            var segcount = BitSize.Segments<T>(bitcount);
            var src = Random.Span<T>(SampleSize);
            for(var i=0; i<SampleSize; i += segcount)
            {
                var data = src.Slice(i, segcount);
                var bc = data.ToBitCells(bitcount);
                var bs = data.ToBitString(bitcount);
                Claim.eq(bc.Length, bitcount);
                Claim.eq(bs.Length, bitcount);
                for(var j=0; j<bc.Length; j++)
                    Claim.eq(bc[j], bs[j]);

            }
        }
    }
}
