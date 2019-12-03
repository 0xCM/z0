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

    using BV = Z0.BitVector;

    public static partial class BitRng
    {
        [MethodImpl(Inline)]
        static IRandomStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : unmanaged
                =>  RandomStream.From(src,rng);
        
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
        /// Produces an 8-bit primal bitvector of a specified maximial effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="wmax">The effecive width</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector(this IPolyrand random, N8 n, int wmax)
        {
            var v = random.Next<byte>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)wmax);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 16-bit primal bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector(this IPolyrand random, N16 n)
            => random.Next<ushort>();

        /// <summary>
        /// Produces a 16-bit primal bitvector of a specified maximial effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="wmax">The effected width</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector(this IPolyrand random, N16 n, int wmax)
        {
            var v = random.Next<ushort>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)wmax);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 32-bit primal bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector(this IPolyrand random, N32 n)
            => random.Next<uint>();

        /// <summary>
        /// Produces a 32-bit primal bitvector of a specified maximial effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="wmax">The maximum effected width</param>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector(this IPolyrand random, N32 n, int wmax)
        {
            var v = random.Next<uint>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)wmax);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 64-bit primal bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector(this IPolyrand random, N64 n)
            => random.Next<ulong>();

        /// <summary>
        /// Produces a 64-bit primal bitvector of maximal effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        /// <param name="wmax">The maximum effected width</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector(this IPolyrand random, N64 n, int wmax)
        {
            var v = random.Next<ulong>();
            var clamp = natval(n) - (int)math.min(natval(n), (uint)wmax);
            return (v >>= clamp);
        }

        /// <summary>
        /// Produces a 128-bit primal bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The primal bitvector selector</param>
        [MethodImpl(Inline)]
        public static BitVector128 BitVector(this IPolyrand random, N128 n)
            => (random.Next<ulong>(), random.Next<ulong>());

        /// <summary>
        /// Produces a stream of random 4-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        public static IRandomStream<BitVector4> BitVectors(this IPolyrand random, N4 n)
        {
            IEnumerable<BitVector4> produce()
            {            
                while(true)
                    yield return random.BitVector(n4);
            }

            return stream(produce(), random.RngKind);            
        }

        /// <summary>
        /// Produces a generic bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random)        
            where T : unmanaged
                => random.Next<T>();

        /// <summary>
        /// Produces a generic bitvector of a specified maximum effective width
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, int wmax)        
            where T : unmanaged
        {
            var v = random.Next<T>();
            int clamp = bitsize<T>() - math.min(bitsize<T>(), (uint)wmax);
            return gmath.srl(v,clamp);
        }    

        /// <summary>
        /// Produces a natural bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The bit width selector</param>
        /// <typeparam name="N">The bit width type</typeparam>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> BitVector<N,T>(this IPolyrand random, N n = default, T t = default)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var v = random.Next<T>();
            int clamp = bitsize<T>() - math.min(bitsize<T>(), natval(n));
            return gmath.srl(v,clamp);
        }    

        [MethodImpl(Inline)]
        public static BitVector128<N,T> BitVector<N,T>(this IPolyrand random, N128 block, N n = default, T t = default)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var w = Z0.BitVector128<N,T>.MaxWidth;
            var v = random.CpuVector<T>(w);
            var clamp = w - math.min(w, natval(n));
            return ginx.vsrlx(v,(byte)clamp);
        }




    }
}