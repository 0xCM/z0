//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Reverses the order of the source bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]   
        public static BitString Reverse(this BitString src)
        {
            src.BitSeq.Reverse();
            return src;
        }

        /// <summary>
        /// Extracts the even bits
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString Even(this BitString src)
            => BitString.even(src);

        /// <summary>
        /// Extracts the odd bits
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString Odd(this BitString src)
            => BitString.odd(src);

        [MethodImpl(Inline)]
        public static BitString Intersperse(this BitString src, BitString value)
            => BitString.intersperse(src,value);
        
        [MethodImpl(Inline)]
        public static BitString Clear(this BitString src, int i0, int i1)
            => BitString.clear(src,i0,i1);

        [MethodImpl(Inline)]
        public static BitString BitMap(this BitString dst, BitString src, int start, int len)
            => BitString.inject(src,dst,start,len);

        [MethodImpl(Inline)]
        public static BitString Not(this BitString bs)
            => BitString.not(bs);

        [MethodImpl(Inline)]
        public static BitString And(this BitString xbs, BitString ybs)
            => BitString.and(xbs,ybs);

        [MethodImpl(Inline)]
        public static BitString Or(this BitString xbs, BitString ybs)
            => BitString.or(xbs,ybs);

        [MethodImpl(Inline)]
        public static BitString Xor(this BitString xbs, BitString ybs)
            => BitString.xor(xbs,ybs);
        
        [MethodImpl(Inline)]
        public static BitString Srl(this BitString bs, int shift)
            => BitString.srl(bs,shift);

        [MethodImpl(Inline)]
        public static BitString Sll(this BitString bs, int shift) 
            => BitString.sll(bs,shift);

        /// <summary>
        /// Rotates the bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        public static BitString RotL(this BitString bs, int offset)
            => BitString.rotl(bs, offset);

        /// <summary>
        /// Pretends the source bitstring is an mxn matrix and computes the transposition maxtrix of dimension nxm encoded as a bitstring
        /// </summary>
        /// <param name="bs">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString Transpose<M,N>(this BitString bs, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => BitString.transpose(bs,m,n);
        
        public static BitString Transpose(this BitString bs, int m, int n)        
            => BitString.transpose(bs,m,n);                        
    }

}
