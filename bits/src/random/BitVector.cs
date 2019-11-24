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
    using BC = Z0.BitCells;

    public static partial class BitRng
    {
        [MethodImpl(Inline)]
        static IRandomStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : unmanaged
                =>  RandomStream.From(src,rng);
        

        /// <summary>
        /// Produces a generic bitvector predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random)        
            where T : unmanaged
                => random.Next<T>();

        /// <summary>
        /// Produces a generic bitvector predicated on a random source and effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, int width)        
            where T : unmanaged
        {
            var v = random.Next<T>();
            int clamp = bitsize<T>() - math.min(bitsize<T>(), (uint)width);
            return gmath.srl(v,clamp);
        }    
            
        /// <summary>
        /// Produces a 4-bit primal bitvector predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector4 BitVector(this IPolyrand random, N4 n)
            => random.Next<byte>(0,17);

        /// <summary>
        /// Produces an 8-bit primal bitvector predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector(this IPolyrand random, N8 n)
            => random.Next<byte>();

        /// <summary>
        /// Produces an 8-bit primal bitvector with a specified effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="width">The effecive width</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector(this IPolyrand random, N8 n, int width)
        {
            var v = random.Next<byte>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)width);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 16-bit primal bitvector predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector(this IPolyrand random, N16 n)
            => random.Next<ushort>();

        /// <summary>
        /// Produces a 16-bit primal bitvector predicated on a random source and effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="width">The effected width</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector(this IPolyrand random, N16 n, int width)
        {
            var v = random.Next<ushort>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)width);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 32-bit primal bitvector predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector(this IPolyrand random, N32 n)
            => random.Next<uint>();

        /// <summary>
        /// Produces a 32-bit primal bitvector predicated on a random source and effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="width">The effected width</param>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector(this IPolyrand random, N32 n, int width)
        {
            var v = random.Next<uint>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)width);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 64-bit primal bitvector predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector(this IPolyrand random, N64 n)
            => random.Next<ulong>();

        /// <summary>
        /// Produces a 64-bit primal bitvector predicated on a random source and effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="width">The effected width</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector(this IPolyrand random, N64 n, int width)
        {
            var v = random.Next<ulong>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)width);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 128-bit primal bitvector predicated on a random source and effective width
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector128 BitVector(this IPolyrand random, N128 n)
            => (random.Next<ulong>(), random.Next<ulong>());

        /// <summary>
        /// Produces a generic bitvector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bitvector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<N,T> BitVector<N,T>(this IPolyrand random)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Z0.BitCells.from<N,T>(random.Stream<T>().ToSpan(BitCalcs.segcount<N,N1,T>()));

        /// <summary>
        /// Produces a random generic bitvector of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> BitCells<T>(this IPolyrand random, int len)
            where T : unmanaged
                => BC.from<T>(random.Stream<T>().ToSpan(BC.cellcount<T>(len)), len);

        /// <summary>
        /// Produces a random generic bitvector of randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The inclusive minimum bitvector length</param>
        /// <param name="maxlen">The inclusive maximum bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> BitCells<T>(this IPolyrand random, int minlen, int maxlen)
            where T : unmanaged
        {
            var len = random.Next<int>(minlen,++maxlen);
            return BC.from<T>(random.Stream<T>().TakeArray(BC.cellcount<T>(len),len));
        }

        /// <summary>
        /// Produces a generic bitvector of randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="range">The range of potential bitvector lengths</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> BitCells<T>(this IPolyrand random, Interval<int> range)
            where T : unmanaged
                => random.BitCells<T>(range.Left, range.Right);                    
    }
}