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
    using static As;

    partial class bitvector
    {
        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 flip(BitVector4 src)
            => TakeHi((byte)((byte)(~src.data) << 4));

        [MethodImpl(Inline)]
        static byte TakeHi(byte src)        
            => (byte)((src >> 4) & 0xF);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 flip(BitVector8 x)
            => math.flip(x.data);
            
        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 flip(BitVector16 x)
            => math.flip(x.data);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 flip(BitVector32 x)
            => math.flip(x.data);

        /// <summary>
        /// Computes the complememt bitvector ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 flip(BitVector64 x)
            => math.flip(x.data);
 
        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="z">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 flip(BitVector8 x, ref BitVector8 y)
        {
            y.data = math.flip(x.data);
            return ref y;
        }

        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 flip(BitVector16 x, ref BitVector16 y)
        {
            y.data = math.flip(x.data);
            return ref y;
        }

        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 flip(BitVector32 x, ref BitVector32 y)
        {
            y.data = math.flip(x.data);
            return ref y;
        }

        /// <summary>
        /// Computes the complement bitvector z = ~x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The target bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 flip(BitVector64 x, ref BitVector64 y)
        {
            y.data = math.flip(x.data);
            return ref y;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 flip(ref BitVector8 x)
        {
            math.flip(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 flip(ref BitVector16 x)
        {
            math.flip(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 flip(ref BitVector32 x)
        {
            math.flip(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Computes the complement of the source vector in-place
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 flip(ref BitVector64 x)
        {
            math.flip(ref x.data);
            return ref x;
        }


    }

}