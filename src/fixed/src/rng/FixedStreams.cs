//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Widths;

    partial class XRng
    {
        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> FixedStream<F>(this IPolyrand random)
            where F: unmanaged, IFixed
        {
            var w = (FixedWidth)default(F).BitWidth;
            switch(w)
            {
                case FixedWidth.W8: return random.FixedStream<F>(w8);
                case FixedWidth.W16: return random.FixedStream<F>(w16);
                case FixedWidth.W32: return random.FixedStream<F>(w32);
                case FixedWidth.W64: return random.FixedStream<F>(w64);
                case FixedWidth.W128: return random.FixedStream<F>(w128);
                case FixedWidth.W256: return random.FixedStream<F>(w256);
                case FixedWidth.W512: return random.FixedStream<F>(w512);
                default: return Root.seq<F>();                    
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, W8 w, SignKind sign = SignKind.Positive)
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

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, W16 w, SignKind sign = SignKind.Positive)
            where T :unmanaged, IFixed
        {
            if(sign.IsNonNegative())
            {
                while(true)
                {
                    Fixed16 next = random.Next<ushort>();
                    yield return Unsafe.As<Fixed16, T>(ref next);
                }
            }
            else
            {
                while(true)
                {
                    Fixed16 next = random.Next<short>();
                    yield return Unsafe.As<Fixed16,T>(ref next);
                }
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, W32 w, SignKind sign = SignKind.Positive)
            where T :unmanaged, IFixed
        {
            if(sign.IsNonNegative())
            {
                while(true)
                {
                    Fixed32 next = random.Next<uint>();
                    yield return Unsafe.As<Fixed32,T>(ref next);
                }
            }
            else
            {
                while(true)
                {
                    Fixed32 next = random.Next<int>();
                    yield return Unsafe.As<Fixed32,T>(ref next);
                }
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, W64 w, SignKind sign = SignKind.Positive)
            where T :unmanaged, IFixed
        {
            if(sign.IsNonNegative())
            {
                while(true)
                {
                    Fixed64 next = random.Next<ulong>();
                    yield return Unsafe.As<Fixed64,T>(ref next);
                }
            }
            else
            {
                while(true)
                {
                    Fixed64 next = random.Next<long>();
                    yield return Unsafe.As<Fixed64,T>(ref next);
                }
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, W128 w, SignKind sign = SignKind.Positive)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                Fixed128 next = random.NextPair<ulong>();
                yield return Unsafe.As<Fixed128,T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, W256 w, SignKind sign = SignKind.Positive)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                Fixed256 next = (random.Fixed(w128), random.Fixed(w128));
                yield return Unsafe.As<Fixed256,T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, W512 w, SignKind sign = SignKind.Positive)
            where T :unmanaged, IFixed
        {
            while(true)
            {
                Fixed512 next = (random.Fixed(w256), random.Fixed(w256));
                yield return Unsafe.As<Fixed512,T>(ref next);
            }
        }
    }
}