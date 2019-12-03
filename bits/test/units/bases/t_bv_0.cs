//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitVector;

    public abstract class t_bv<X> : t_bits<X>
        where X : t_bv<X>, new()
    {
        protected override int SampleSize => Pow2.T08;

        protected override int CycleCount => Pow2.T03;

        /// <summary>
        /// Verifies the generic bitvector dot product operation
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        protected void gbv_dot_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector<T>();
                var y = Random.BitVector<T>();
                var actual = BitVector.dot(x,y);
                var expect = modprod(x,y);
                Claim.yea(actual == expect);            
            }
        }

        /// <summary>
        /// Verifies the natural bitvector dot product operation
        /// </summary>
        /// <param name="n">The bitvector width</param>
        /// <param name="t">A scalar representative</param>
        /// <typeparam name="N">The bitvector width type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void nbv_dot_check<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var opname = $"nbv_dot_{n}x{moniker<T>()}";
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = Random.BitVector<N,T>();
                bit a = x % y;
                var b = BitVector.modprod(x,y);
                if(a != b)
                {
                    Trace($"{opname} failed for operands {x} and {y}: {a} != {b}");
                    Claim.fail(); 
                }
            }
        }

        protected void nbv_dot_check_128<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector(n128, n, t);
                var y = Random.BitVector(n128,n, t);
                Claim.lteq(BitVector.nlz(x), x.Width);

                var a = x % y;
                var xc = x.ToBitCells();
                var yc = y.ToBitCells();
                var b = xc % yc;
                Claim.eq(a,b);

            }
        }

        protected void nbv_rev_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = BitVector.rev(x);
                var z = x.ToBitString().Reverse().ToNatBits<N,T>();
                Claim.eq(y,z);
            }
        }

        protected  void nbv_bs_check<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = x.ToBitString();
                Claim.eq(natval<N>(), x.Width);
                Claim.eq(x.Width, y.Length);
                
                var z = y.ToNatBits<N,T>();                        
                Claim.eq(x,z);
            }           
        }

        protected void gbv_xorw_check<T>(int width)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector<T>(width);
                Claim.lteq(BitVector.effwidth(x),width);
                
                var y = Random.BitVector<T>(width);
                Claim.lteq(BitVector.effwidth(y),width);

                var z = x ^ y;
                Claim.eq(gmath.xor(x.Scalar, y.Scalar), z.Scalar);

                var xbs = x.ToBitString().Truncate(width);
                Claim.eq(width, xbs.Length);

                var ybs = y.ToBitString().Truncate(width);
                Claim.eq(width, ybs.Length);

                var zbs = xbs.Xor(ybs);

                Claim.eq(zbs, z.ToBitString().Truncate(width));
            }
        }

        protected void gbv_rank_check<T>()
            where T : unmanaged
        {
            var x = Random.BitVector<T>();
            var pos = Random.Next(1,bitsize<T>() - 2);
            
            var actual = gbits.rank(x.Scalar,(uint)pos);
            var expect = 0u;
            for(var i=0; i<= pos; i++)
                expect += (x[i] ? 1u : 0u);
            Claim.eq(expect, actual);
        }    

    }
}