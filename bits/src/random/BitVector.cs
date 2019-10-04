//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    using BV = Z0.BitVector;

    public static partial class BitRng
    {
        [MethodImpl(Inline)]
        static IRandomStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : unmanaged
                =>  new RandomStream<T>(rng,src);

        /// <summary>
        /// Produces a 16-bit bitvector with a specified effective width <= 16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="width">The with</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector(this IPolyrand random, N16 n16, int effwidth)
        {
            var v = random.Next<ushort>();
            return (v >>= (16-effwidth));
        }

        /// <summary>
        /// Produces a random 4-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector4 BitVector(this IPolyrand random, N4 n)
            => random.Next<byte>(0,17);

        /// <summary>
        /// Produces a random 8-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector(this IPolyrand random, N8 n)
            => random.Next<byte>();

        /// <summary>
        /// Produces a 16-bit bitvector with a specified effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="width">The with</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector(this IPolyrand random, N16 n, int? effwidth = null)
        {
            var v = random.Next<ushort>();
            return effwidth == null ? v : (v >>= (16-effwidth));
        }

        /// <summary>
        /// Produces a 32-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The singleton value for n=32</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector(this IPolyrand random, N32 n)
            => random.Next<uint>();

        /// <summary>
        /// Produces a random 8-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector(this IPolyrand random, N64 n)
            => random.Next<ulong>();

        /// <summary>
        /// Produces a random 128-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector128 BitVector(this IPolyrand random, N128 n)
            => (random.Next<ulong>(), random.Next<ulong>());


        /// <summary>
        /// Produces a generic bitvector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> BitVector<N,T>(this IPolyrand random, N len = default, T rep = default)
            where T : unmanaged
            where N : ITypeNat, new()
                => BV.Load<N,T>(random.Stream<T>().TakeSpan(BV.CellCount<N,T>()));

        /// <summary>
        /// Produces a random generic bitvector of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, BitSize len)
            where T : unmanaged
                => BV.Load<T>(random.Stream<T>().TakeSpan(BV.CellCount<T>(len)), len);

        /// <summary>
        /// Produces a random generic bitvector of randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The inclusive minimum bitvector length</param>
        /// <param name="maxlen">The inclusive maximum bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, BitSize minlen, BitSize maxlen)
            where T : unmanaged
        {
            var len = random.Next<int>(minlen,++maxlen);
            return BV.Load<T>(random.Stream<T>().TakeArray(BV.CellCount<T>(len),len));
        }

        /// <summary>
        /// Produces a generic bitvector of randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="range">The range of potential bitvector lengths</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, Interval<int> range)
            where T : unmanaged
                => random.BitVector<T>(range.Left, range.Right);
                        

    }

}