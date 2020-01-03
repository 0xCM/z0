//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector4 add(BitVector4 x, BitVector4 y)
            => new BitVector4(math.mod(math.add(x.Scalar, y.Scalar), (byte)4),true);

        /// <summary>
        /// Computes the arithmetic sum of two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector8 add(BitVector8 x, BitVector8 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector16 add(BitVector16 x, BitVector16 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector32 add(BitVector32 x, BitVector32 y)
            => gmath.add(x.data, y.data);

        /// <summary>
        /// Computes the arithmetic sum z := x + y for bitvectors x and y
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static BitVector64 add(BitVector64 x, BitVector64 y)
            => gmath.add(x.data, y.data);


        /// <summary>
        /// Computes the arithmetic difference z := x - y for generic bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> add<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.add(x.Scalar, y.Scalar);

        /// <summary>
        /// Computes the sum of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> add<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var sum = dinx.vadd(v64u(x.data), v64u(y.data));            
            bit carry = x.Lo > vcell(sum,0);
            return  As.vgeneric<T>(dinx.vadd(sum, CpuVector.vbroadcast(n128, (ulong)carry)));
        }

    }
}