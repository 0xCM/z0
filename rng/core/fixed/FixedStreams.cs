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

    partial class FixedRngOps
    {
        public static IEnumerable<F> FixedStream<F>(this IPolyrand random, F t = default)
            where F:unmanaged, IFixed
                => FixedRng.stream<F>(random);         
    }    

    partial class FixedRng    
    {
        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> stream<F>(IPolyrand random)
            where F: unmanaged, IFixed
        {
            //var w = default(F).FixedWidth;
            var w = (FixedWidth)default(F).FixedBitCount;
            switch(w)
            {
                case FixedWidth.W8: return random.FixedStream<F>(n8);
                case FixedWidth.W16: return random.FixedStream<F>(n16);
                case FixedWidth.W32: return random.FixedStream<F>(n32);
                case FixedWidth.W64: return random.FixedStream<F>(n64);
                case FixedWidth.W128: return random.FixedStream<F>(n128);
                case FixedWidth.W256: return random.FixedStream<F>(n256);
                case FixedWidth.W512: return random.FixedStream<F>(n512);
                default: return items<F>();                    
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N8 w)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed8, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N16 w)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed16, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N32 w)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed32, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N64 w)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed64, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N128 w)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed128, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N256 w)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed256, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N512 w)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed512, T>(ref next);
            }
        }
    }
}