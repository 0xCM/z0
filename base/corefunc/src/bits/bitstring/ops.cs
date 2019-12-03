//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial struct BitString
    {
        /// <summary>
        /// Computes the bitwise complement of the source
        /// </summary>
        /// <param name="src">The source bits</param>
        public static BitString not(BitString src)
        {            
            var len = src.Length;
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = ~src[i];
            return dst;
        }

        /// <summary>
        /// Computes the bitwise and between the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        public static BitString and(BitString lhs, BitString rhs)
        {            
            var len = length(lhs.bitseq, rhs.bitseq);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

        /// <summary>
        /// Computes the bitwise or between the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        public static BitString or(BitString lhs, BitString rhs)
        {            
            var len = length(lhs.bitseq, rhs.bitseq);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;
        }

        public static BitString xor(BitString lhs, BitString rhs)
        {            
            var len = length(lhs.bitseq,rhs.bitseq);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = lhs[i] ^ rhs[i];
            return dst;
        }

        public static BitString srl(BitString lhs, int offset)
        {            
            var dst = alloc(lhs.Length);
            for(var i=lhs.Length - offset; i>=0; i--)
                dst[i] = lhs[i];
            return dst;
        }

        public static BitString sll(BitString lhs, int offset)
        {            
            var dst = alloc(lhs.Length);
            for(var i=offset; i<dst.Length; i++)
                dst[i] = lhs[i];
            return dst;
        }

        /// <summary>
        /// Extracts the even bits from the source
        /// </summary>
        public static BitString even(BitString src)
        {
            var count = src.Length>>1;
            var dst = BitString.alloc(count);            
            for(int i=0,j=0; i<src.Length; i+=2,j++)
                dst[j] = src[i];
            return dst;
        }

        /// <summary>
        /// Extracts the odd bits from the source
        /// </summary>
        public static BitString odd(BitString src)
        {
            var count = src.Length>>1;
            var dst = BitString.alloc(count);            
            for(int i=1,j=0; i<src.Length; i+=2,j++)
                dst[j] = src[i];
            return dst;
        }

        /// <summary>
        /// Pretends the source bitstring is an mxn matrix and computes the transposition maxtrix of dimension nxm encoded as a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString transpose(BitString src, int m, int n)
        {
            var bitcount = m*n;
            if(src.Length < bitcount)
                return BitString.Empty;

            var k = 0;
            var dst = BitString.alloc(bitcount);
            for(var colidx = 0; colidx < n; colidx++)
            for(int j=colidx; j<bitcount; j+=n, k++)
                dst[k] = src[j];

            return dst;
        }

        /// <summary>
        /// Pretends the source bitstring is an mxn matrix and computes the transposition maxtrix of dimension nxm encoded as a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString transpose<M,N>(BitString src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var bitcount = NatMath.mul(m,n);
            if(src.Length < bitcount)
                return BitString.Empty;

            var dst = BitString.alloc(bitcount);

            var cols = natval(n);
            var k = 0;

            for(var col = 0; col < cols; col++)
            for(var j = col; j<bitcount; j+=cols, k++)
                dst[k] = src[j];

            return dst;
        }

        /// <summary>
        /// Overwrites selected target bits with lower bits from the source
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <param name="start">The target index at which to begin</param>
        /// <param name="len">The number of bits to overwrite</param>
        /// <returns></returns>
        public static BitString inject(BitString src, BitString dst, int start, int len)
        {
            for(int i=start, j=0; i< start + len; i++, j++)
                dst[i] = src[j];
            return dst;
        }

        public static BitString intersperse(BitString src, BitString value)
        {
            var len = Math.Min(src.Length, value.Length);            
            var dst = BitString.alloc(len*2);
            for(int i=0, j=0; i< dst.Length; i+=2, j++)
            {
                dst[i] = src[j];

                if(i+1 < dst.Length)
                    dst[i+1] = value[j];
            }
            return dst;
        }

        public static BitString clear(BitString src, int i0, int i1)
        {
            for(var i=i0; i<=i1; i++)
                src[i] = off;
            return src;
        }
    }
}