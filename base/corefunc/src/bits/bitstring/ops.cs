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
        /// Constructs a bitstring from text
        /// </summary>
        /// <param name="src">The bit source</param>
        public static BitString parse(string src)                
        {
            src = src.RemoveWhitespace();
            var len = src.Length;
            var lastix = len - 1;
            Span<byte> dst = new byte[len];
            for(var i=0; i<= lastix; i++)
                dst[lastix - i] = src[i] == Bit.Zero ? (byte)0 : (byte)1;
            return new BitString(dst);                        
        }

        /// <summary>
        /// Computes the bitwise complement of the source operand
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
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        public static BitString and(BitString a, BitString b)
        {            
            var len = length(a.data, b.data);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = a[i] & b[i];
            return dst;
        }

        /// <summary>
        /// Computes the bitwise or between the operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        public static BitString or(BitString a, BitString b)
        {            
            var len = length(a.data, b.data);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = a[i] | b[i];
            return dst;
        }

        /// <summary>
        /// Computes the bitwise xor between the operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        public static BitString xor(BitString a, BitString b)
        {            
            var len = length(a.data,b.data);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = a[i] ^ b[i];
            return dst;
        }

        /// <summary>
        /// Applies a logical right-shift to the source
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="shift">The shift offset</param>
        public static BitString srl(BitString src, int shift)
        {            
            var dst = alloc(src.Length);
            for(var i=src.Length - shift; i>=0; i--)
                dst[i] = src[i];
            return dst;
        }

        /// <summary>
        /// Applies a logical left-shift to the source
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="shift">The shift offset</param>
        public static BitString sll(BitString src, int shift)
        {            
            var dst = alloc(src.Length);
            for(var i=shift; i<dst.Length; i++)
                dst[i] = src[i];
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
        /// Considers the source bitstring as a row-major encoding of an mxn matrix and computes 
        /// the transposition maxtrix of dimension nxm similary encoded as a bitstring
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
        /// Considers the source bitstring as a row-major encoding of an mxn matrix and computes 
        /// the transposition maxtrix of dimension nxm similary encoded as a bitstring
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
        public static BitString inject(BitString src, BitString dst, int start, int len)
        {
            for(int i=start, j=0; i< start + len; i++, j++)
                dst[i] = src[j];
            return dst;
        }

        /// <summary>
        /// Intersperses the source bitstring with content from another
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="value">The interspersal value</param>
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

        /// <summary>
        /// Clears a contiguous sequence of bits between two indices
        /// </summary>
        /// <param name="src">The source bistring</param>
        /// <param name="i0">The index of the first bit to clear</param>
        /// <param name="i1">The index of the last bit to clear</param>
        public static BitString clear(BitString src, int i0, int i1)
        {
            for(var i=i0; i<=i1; i++)
                src[i] = off;
            return src;
        }

        /// <summary>
        /// Rotates the bits leftwards by a specified offset
        /// </summary>
        /// <param name="shift">The magnitude of the rotation</param>
        public static BitString rotl(BitString bs, int shift)
        {
            Span<byte> dst = bs.data.Replicate();
            Span<byte> src = stackalloc byte[bs.Length];
            dst.CopyTo(src);
            var cut = bs.Length - shift;
            var seg1 = src.Slice(0, cut);
            var seg2 = src.Slice(cut);
            seg2.CopyTo(dst, 0);
            seg1.CopyTo(dst, shift);
            return BitString.bitseq(dst);
        }
    }
}