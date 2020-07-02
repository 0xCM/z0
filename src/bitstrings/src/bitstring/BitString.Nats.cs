//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static Root;
    
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
                => BitString.transpose(src, value(m), value(n));
        
        public static BitString Transpose(this BitString bs, int m, int n)        
            => BitString.transpose(bs,m,n);                         
    }
}