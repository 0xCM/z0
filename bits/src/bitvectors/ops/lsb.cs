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

    partial class bitvector
    {
        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector<T> lsb<T>(BitVector<T> x, int n)                
            where T : unmanaged
                => between(x, 0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector<T> msb<T>(BitVector<T> x, int n)                
            where T : unmanaged
            => between(x, BitVector<T>.LastPos - n, BitVector<T>.LastPos);                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector4 lsb(BitVector4 x, int n)                
            => between(x, 0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector4 msb(BitVector4 x, int n)                
            => between(x, BitVector4.LastPos - n, BitVector4.LastPos);                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 lsb(BitVector8 x, int n)                
            => between(x,0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector8 msb(BitVector8 x, int n)                
            => between(x, BitVector8.LastPos - n, BitVector8.LastPos);                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 lsb(BitVector16 x, int n)                
            => bitvector.between(x.data,0,n-1);

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector16 msb(BitVector16 x, int n)                
            => bitvector.between(x.data, BitVector16.LastPos - n, BitVector16.LastPos);                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector32 lsb(BitVector32 x, int n)                
            => bitvector.between(x.data,0,n-1);

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector32  msb(BitVector32 x, int n)                
            => bitvector.between(x.data, BitVector32.LastPos - n, BitVector32.LastPos);                


        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector64 lsb(BitVector64 x, int n)                
            => bitvector.between(x.data,0,n-1);

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline)]
        public static BitVector64  msb(BitVector64 x, int n)                
            => bitvector.between(x.data, BitVector64.LastPos - n, BitVector64.LastPos);                

    }

}