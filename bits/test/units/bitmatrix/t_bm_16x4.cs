//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bm_16x4 : BitMatrixTest<t_bm_16x4>
    {

        public void bm_16x4_and()
            => bm_16x4_check(BitMatrix.and, math.and);

        public void bm_16x4_or()
            => bm_16x4_check(BitMatrix.or, math.or);

        public void bm_16x4_xor()
            => bm_16x4_check(BitMatrix.xor, math.xor);

        public void bm_16x4_not()
            => bm_16x4_check(BitMatrix.not, math.not);

        public void bm_16x4_negate()
            => bm_16x4_check(BitMatrix.negate, math.negate);

        public void bm_16x4_rows()
        {
            var m = n16;
            var n = n4;

            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.Next<ulong>().ToPrimalBits(m,n);
                var bs = A.ToBitString();
                for(var j = 0; j< m; j++)
                {
                    var r1 = A[j];
                    var r2 = bs.Slice(4*j,4).ToBitVector(n4);
                    Claim.eq(r1, r2);                        
                }
            }
        }

        public void bm_16x4_transpose()
        {
            var m = n16;
            var n = n4;

            for(var i=0; i<SampleSize;i++)
            {
                var A = Random.Next<ulong>().ToPrimalBits(m,n);
                var B = BitMatrix.transpose(A);
                Claim.eq(B.ToBitString(), A.ToBitString().Transpose(m,n));
            }

        }

        public void bm_16x4_cols()
        {

            var m = n16;
            var n = n4;
            int bitcount = NatMath.mul(m,n);
            int rowcount = m;
            int colcount = n;

            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.Next<ulong>().ToPrimalBits(m,n);
                var bs = A.ToBitString();
                var bsT = BitString.transpose(bs,m,n);

                var c0 = A[n0];
                var c1 = A[n1];
                var c2 = A[n2];
                var c3 = A[n3];

                var colidx = 0;
                var bs0 = BitString.alloc(rowcount);
                for(int j=colidx, k=0; j<bitcount; j+=colcount, k++)
                    bs0[k] = bs[j];
                var bv0 = bs0.ToBitVector(m);
                Claim.eq(bsT.Slice(rowcount*colidx,rowcount), bs0);

                colidx++;
                var bs1 = BitString.alloc(rowcount);
                for(int j=colidx, k=0; j<bitcount; j+=colcount, k++)
                    bs1[k] = bs[j];
                var bv1 = bs1.ToBitVector(m);                
                Claim.eq(bsT.Slice(rowcount*colidx,rowcount), bs1);

                colidx++;
                var bs2 = BitString.alloc(rowcount);
                for(int j=colidx, k=0; j<bitcount; j+=colcount, k++)
                    bs2[k] = bs[j];
                var bv2 = bs2.ToBitVector(m);                
                Claim.eq(bsT.Slice(rowcount*colidx,rowcount), bs2);

                colidx++;
                var bs3 = BitString.alloc(rowcount);
                for(int j=colidx, k=0; j<bitcount; j+=colcount, k++)
                    bs3[k] = bs[j];
                var bv3 = bs3.ToBitVector(m);                
                Claim.eq(bsT.Slice(rowcount*colidx,rowcount), bs3);


                if(bv0 != c0 || bv1 != c1 || bv2 != c2 || bv3 != c3)
                    Trace(A.Format());

                if(bv0 != c0)                
                {
                    Trace($"col 0", c0.Reverse().Format());
                    Trace($"bs  0", bv0.Reverse().Format());
                }

                if(bv1 != c1)                
                {
                    Trace($"col 1", c1.Reverse().Format());
                    Trace($"bs  1", bv1.Reverse().Format());
                }

                if(bv2 != c2)                
                {
                    Trace($"col 2", c2.Reverse().Format());
                    Trace($"bs  2", bv2.Reverse().Format());
                }

                if(bv3 != c3)                
                {
                    Trace($"col 3", c3.Reverse().Format());
                    Trace($"bs  3", bv3.Reverse().Format());
                }


                Claim.eq(c0, bv0);
                Claim.eq(c1, bv1);
                Claim.eq(c2, bv2);
                Claim.eq(c3, bv3);
            }

        }

        void bm_16x4_check(Func<BitMatrix16x4,BitMatrix16x4,BitMatrix16x4> f, Func<ulong,ulong,ulong> g)
        {
            var m = n16;
            var n = n4;
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.Next<ulong>().ToPrimalBits(m,n);
                var B = Random.Next<ulong>().ToPrimalBits(m,n);
                var C = f(A,B);
                var Z = g(A,B).ToPrimalBits(m,n);
                var cbs = C.ToBitString();
                var zbs = Z.ToBitString();
                Claim.eq(zbs,cbs);
            }
        }

        void bm_16x4_check(Func<BitMatrix16x4,BitMatrix16x4> f, Func<ulong,ulong> g)
        {
            var m = n16;
            var n = n4;
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.Next<ulong>().ToPrimalBits(m,n);
                var C = f(A);
                var Z = g(A).ToPrimalBits(m,n);
                var cbs = C.ToBitString();
                var zbs = Z.ToBitString();
                Claim.eq(zbs,cbs);
            }
        }

    }

}
