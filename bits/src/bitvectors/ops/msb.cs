//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

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
                => between(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector4 msb(BitVector4 x, int n)                
            => between(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 msb(BitVector8 x, int n)                
            => between(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 msb(BitVector16 x, int n)                
            => BitVector.between(x.data, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 msb(BitVector32 x, int n)                
            => BitVector.between(x.data, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 msb(BitVector64 x, int n)                
            => BitVector.between(x.data, x.Width - n, x.Width - 1);
    }
}