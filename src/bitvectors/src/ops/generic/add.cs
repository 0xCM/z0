//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitVector
    {
        /// <summary>
        /// Computes the arithmetic sum z := x + y for generic bitvectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitVector<T> add<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.add(x.Data, y.Data);

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
            var sum = z.vadd(z.v64u(x.Data), z.v64u(y.Data));
            Bit32 carry = x.Lo > z.vcell(sum,0);
            return  z.generic<T>(z.vadd(sum, z.vbroadcast(n128, (ulong)carry)));
        }
    }
}