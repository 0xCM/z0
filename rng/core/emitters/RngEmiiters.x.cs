//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class CoreRngOps
    {
        /// <summary>
        /// Creates a numeric emitter predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static NumericRngEmitter<T> NumericEmitter<T>(this IPolyrand random)
            where T : unmanaged
                => RngEmitters.numeric<T>(random);

        /// <summary>
        /// Creates a fixed F-emitter predicated on a T-random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public static IFixedEmitter<F,T> FixedEmitter<F,T>(this IPolyrand random)
            where F : unmanaged, IFixed
            where T : unmanaged
                => RngEmitters.fixedValue<F,T>(random);

        /// <summary>
        /// Creates a fixed F-celled span emitter over T-segmented cells
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public static IFixedSpanEmitter<F> FixedSpanEmitter<F>(this IPolyrand random, int length)
            where F : unmanaged, IFixed
                => RngEmitters.fixedSpan<F>(random, length);

        /// <summary>
        /// Creates a fixed F-celled span emitter over T-segmented cells
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        /// <typeparam name="T">The numeric type</typeparam>
        public static IFixedSpanEmitter<F,T> FixedSpanEmitter<F,T>(this IPolyrand random, int length)
            where F : unmanaged, IFixed
            where T : unmanaged
                => RngEmitters.fixedSpan<F,T>(random, length);

        public static IEnumerable<F> FixedStream<F>(this IPolyrand random, F t = default)
            where F:unmanaged, IFixed
                => RngEmitters.stream<F>(random);         

        [MethodImpl(Inline)]
        public static Fixed8 Fixed(this IPolyrand random, N8 w)
            => random.Next<byte>();

        [MethodImpl(Inline)]
        public static Fixed16 Fixed(this IPolyrand random, N16 w)
            => random.Next<ushort>();

        [MethodImpl(Inline)]
        public static Fixed32 Fixed(this IPolyrand random, N32 w)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static Fixed64 Fixed(this IPolyrand random, N64 w)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static Fixed128 Fixed(this IPolyrand random, N128 w)
            => random.NextPair<ulong>();

        [MethodImpl(Inline)]
        public static Fixed256 Fixed(this IPolyrand random, N256 w)
            =>  (random.Fixed(n128), random.Fixed(n128));

        [MethodImpl(Inline)]
        public static Fixed512 Fixed(this IPolyrand random, N512 w)
            => (random.Fixed(n256), random.Fixed(n256));
    }    
}