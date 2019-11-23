//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.IO;
    
    using static zfunc;
    using static As;

    partial struct BitString
    {

        public static BitString not(BitString src)
        {            
            var len = src.Length;
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = ~src[i];
            return dst;
        }

        public static BitString and(BitString lhs, BitString rhs)
        {            
            var len = length(lhs.bitseq, rhs.bitseq);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

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
        /// Extracts the even bits
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
        /// Extracts the odd bits
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
        /// Pretends a bitstring is an mxn matrix and computes the transposition maxtrix of dimension nxm
        /// </summary>
        /// <param name="bs">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString transpose(BitString bs, int m, int n)
        {
            var bitcount = m*n;
            if(bs.Length < bitcount)
                return BitString.Empty;

            var k = 0;
            BitString dst = BitString.alloc(bitcount);
            for(var colidx = 0; colidx < n; colidx++)
            for(int j=colidx; j<bitcount; j+=n, k++)
                dst[k] = bs[j];

            return dst;
        }

        /// <summary>
        /// Pretends a bitstring is an mxn matrix and computes the transposition maxtrix of dimension nxm
        /// </summary>
        /// <param name="bs">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString transpose<M,N>(BitString bs, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var bitcount = NatMath.mul(m,n);
            if(bs.Length < bitcount)
                return BitString.Empty;

            BitString dst = BitString.alloc(bitcount);

            var cols = natval(n);
            var k = 0;

            for(var col = 0; col < cols; col++)
            for(var j = col; j<bitcount; j+=cols, k++)
                dst[k] = bs[j];

            return dst;
        }

    }
}