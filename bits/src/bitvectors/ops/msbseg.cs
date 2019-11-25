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
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector<T> msbseg<T>(BitVector<T> x, int n)                
            where T : unmanaged
                => between(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector4 msbseg(BitVector4 x, int n)                
            => between(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 msbseg(BitVector8 x, int n)                
            => between(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 msbseg(BitVector16 x, int n)                
            => BitVector.between(x.data, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 msbseg(BitVector32 x, int n)                
            => BitVector.between(x.data, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 msbseg(BitVector64 x, int n)                
            => BitVector.between(x.data, x.Width - n, x.Width - 1);
    }
}