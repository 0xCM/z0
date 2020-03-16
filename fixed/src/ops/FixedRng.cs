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

    using static Root;
    using static Nats;

    public static partial class FixedRngOps
    {
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
                    yield return Unsafe.As<Fixed16, T>(ref next);
                }
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
            if(sign.IsNonNegative())
            {
                while(true)
                {
                    Fixed64 next = random.Next<ulong>();
                    yield return Unsafe.As<Fixed64, T>(ref next);
                }
            }
            else
            {
                while(true)
                {
                    Fixed64 next = random.Next<long>();
                    yield return Unsafe.As<Fixed64, T>(ref next);
                }

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
 


        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static HomPoints<N2,F> FixedHomPointIndex<F>(this IPolyrand random, int count, N2 n, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = random.StreamFixed<F>().Take(count);
            var s2 = random.StreamFixed<F>().Take(count);
            return s1.Zip(s2).Select(a =>  Points.hom(a.First, a.Second)).ToArray();
        }

        /// <summary>
        /// Produces an homogenous point index of dimension 2
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to load into the index</param>
        /// <typeparam name="T">The coordinate domain</typeparam>
        public static HomPoints<N3,F> FixedHomPointIndex<F>(this IPolyrand random, int count, N3 n, F t = default)
            where F : unmanaged, IFixed
        {
            var s1 = random.StreamFixed<F>().Take(count);
            var s2 = random.StreamFixed<F>().Take(count);
            var s3 = random.StreamFixed<F>().Take(count);
            return s1.Zip(s2).Zip(s3).Select(a =>  Points.hom(a.First.First, a.First.Second, a.Second)).ToArray();
        }


        public static NatSpan<N,T> Contract<N,T>(this NatSpan<N,T> src, NatSpan<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = Z0.NatSpan.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Scale.contract(src[i],max[i]);
            return dst;
        }

   }

}