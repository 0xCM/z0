//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;

    partial class BitVector
    {
        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector<T> msb<T>(BitVector<T> x, int n)                
            where T : unmanaged
            => between(x, BitVector<T>.Width - n, BitVector<T>.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector4 msb(BitVector4 x, int n)                
            => between(x, BitVector4.Width - n, BitVector4.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 msb(BitVector8 x, int n)                
            => between(x, BitVector8.Width - n, BitVector8.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 msb(BitVector16 x, int n)                
            => BitVector.between(x.data, BitVector16.Width - n, BitVector16.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector32  msb(BitVector32 x, int n)                
            => BitVector.between(x.data, BitVector32.Width - n, BitVector32.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector64  msb(BitVector64 x, int n)                
            => BitVector.between(x.data, BitVector64.Width - n, BitVector64.Width - 1);
    }
}