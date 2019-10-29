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

    partial class BitVector
    {
        /// <summary>
        /// Computes the two's complement of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> negate<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.negate(x.Data);

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 negate(BitVector4 x)
            => BitVector4.FromLo(math.negate(x.data));
            
        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 negate(BitVector8 x)
            => math.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 negate(BitVector16 x)
            => math.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 negate(BitVector32 x)
            => math.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The source bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 negate(BitVector64 x)
            => math.negate(x.data);

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector4 negate(ref BitVector4 x)
        {
            math.negate(ref x.data);
            x.data &= 0xF;
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector8 negate(ref BitVector8 x)
        {
            math.negate(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector16 negate(ref BitVector16 x)
        {
            math.negate(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 negate(ref BitVector32 x)
        {
            math.negate(ref x.data);
            return ref x;
        }

        /// <summary>
        /// Computes the two's complement bitvector -x from the source bitvector x
        /// </summary>
        /// <param name="x">The left bitvector</param>
        [MethodImpl(Inline)]
        public static ref BitVector64 negate(ref BitVector64 x)
        {
            math.negate(ref x.data);
            return ref x;
        }

    }

}