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

    public class t_bm_bitlogic : BitMatrixTest<t_bm_bitlogic>
    {        
        public void bm_and_4x4()
        {
            var n = n4;
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n);
                var B = Random.BitMatrix(n);
                var Z = A & B;
                
                var a = (ushort)A;
                var b = (ushort)B;
                var z = (ushort)Z;
                Claim.eq(math.and(a,b),z);
            }
        }

        public void bm_and_8x8()
        {
            var n = n8;
            Span<byte> dst = stackalloc byte[8];
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n8);
                var B = Random.BitMatrix(n8);
                for(var j=0; j<dst.Length; j++)
                    dst[j] = (byte)(A.Bytes[j] & B.Bytes[j]);
                var expect = BitMatrix.primal(n,dst);
                var C = A & B;
                Claim.yea(expect == C);                
            }
        }

        public void bm_and_32x32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix32();
                var B = Random.BitMatrix32();
                var C = A & B;

                var D = BitMatrix32.From(mathspan.and(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }

        public void bm_and_64x64()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix64();
                var B = Random.BitMatrix64();
                var C = A & B;

                var D = BitMatrix64.From(mathspan.and(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }

        public void xor_8x8g()
            => xor_generic_check<byte>();

        public void xor_16x16g()
            => xor_generic_check<ushort>();

        public void xor_32x32g()
            => xor_generic_check<uint>();

        public void xor_64x64g()
            => xor_generic_check<ulong>();
        
        public void bm_or_32x32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n32);
                var B = Random.BitMatrix(n32);
                var C = A | B;

                var D = BitMatrix32.From(mathspan.or(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }

        public void not_32x32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n32);
                var B = BitMatrix.not(A);
                var C = BitMatrix32.From(mathspan.not(A.Bytes.Replicate()));
                Claim.yea(B == C);
                
            }
        }

        public void cnotimply_8x8()
        {
            var lhs = Random.BitMatrix8();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void cnotimply_16x16()
        {
            var lhs = Random.BitMatrix16();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        public void cnotimply_64x64()
        {
            var lhs = Random.BitMatrix64();
            var rhs = lhs.Replicate();
            Claim.yea(lhs.AndNot(rhs).IsZero());
        }

        void xor_generic_check<T>()
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<T>();
                var B = Random.BitMatrix<T>();
                BitMatrix.xor(A,B, ref Z);

                for(var j =0; j< Z.Order; j++)
                {
                    var a = A[i];
                    var b = B[i];                    
                    var z = Z[i];

                    var x = BitVector.xor(a,b);
                    Claim.yea(x == z);
                }
            }
        }
    }

}