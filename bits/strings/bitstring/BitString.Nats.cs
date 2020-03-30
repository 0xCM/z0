//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static root;

    public static class BitStringNatX
    {
       /// <summary>
        /// Pretends the source bitstring is an mxn matrix and computes the transposition maxtrix of dimension nxm encoded as a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString Transpose<M,N>(this BitString src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var bitcount = (int)NatCalc.mul(m,n);
            if(src.Length < bitcount)
                return BitString.Empty;

            var dst = BitString.alloc(bitcount);

            var cols = (int)TypeNats.value(n);
            var k = 0;

            for(var col = 0; col < cols; col++)
            for(var j = col; j<bitcount; j+=cols, k++)
                dst[k] = src[j];

            return dst;
        }        
        
        public static BitString Transpose(this BitString bs, int m, int n)        
            => BitString.transpose(bs,m,n);                         
    }
}