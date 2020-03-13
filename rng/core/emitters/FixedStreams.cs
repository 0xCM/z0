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

    partial class RngEmitters    
    {
        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> StreamFixed<F>(this IPolyrand random, NumericKind cellkind = default)
            where F: unmanaged, IFixed
        {
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

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N8 w, Sign sign = Sign.Pos)
            where T :unmanaged, IFixed
        {
            if(sign.IsNonNegative())
            {
                while(true)
                {
                    Fixed8 next = random.Next<byte>();
                    yield return Unsafe.As<Fixed8, T>(ref next);
                }
            }
            else
            {
                while(true)
                {
                    Fixed8 next = random.Next<sbyte>();
                    yield return Unsafe.As<Fixed8, T>(ref next);
                }
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N16 w, Sign sign = Sign.Pos)
            where T :unmanaged, IFixed
        {
            if(sign.IsNonNegative())
            {
                Fixed16 next = random.Next<ushort>();
                yield return Unsafe.As<Fixed16, T>(ref next);
            }
            else
            {
                Fixed16 next = random.Next<short>();
                yield return Unsafe.As<Fixed16, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N32 w, Sign sign = Sign.Pos)
            where T :unmanaged, IFixed
        {
            if(sign.IsNonNegative())
            {
                while(true)
                {
                    Fixed32 next = random.Next<uint>();
                    yield return Unsafe.As<Fixed32, T>(ref next);
                }
            }
            else
            {
                while(true)
                {
                    Fixed32 next = random.Next<int>();
                    yield return Unsafe.As<Fixed32, T>(ref next);
                }

            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N64 w, Sign sign = Sign.Pos)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                Fixed64 next = random.Next<ulong>();
                yield return Unsafe.As<Fixed64, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N128 w, Sign sign = Sign.Pos)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                Fixed128 next = random.NextPair<ulong>();
                yield return Unsafe.As<Fixed128, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N256 w, Sign sign = Sign.Pos)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                Fixed256 next = (random.Fixed(n128), random.Fixed(n128));
                yield return Unsafe.As<Fixed256, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N512 w, Sign sign = Sign.Pos)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                Fixed512 next = (random.Fixed(n256), random.Fixed(n256));
                yield return Unsafe.As<Fixed512, T>(ref next);
            }
        }
    }
}