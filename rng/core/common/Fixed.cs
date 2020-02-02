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

    using static zfunc;
    using static Z0.As;

    readonly struct FixedEmitter<F,T> : IFixedEmitter<F, T>
        where F : unmanaged, IFixed         
        where T :unmanaged
    {
        public const string Name = "fixedrand";

        public static FixedWidth Width => default(F).Width;

        public static NumericKind NumericKind => typeof(T).NumericKind();
        
        readonly IPolyrand Random;
        readonly SurrogateTypes.EmitterSurrogate<F> f;

        public Moniker Moniker => OpIdentities.define(Name,Width,NumericKind);

        [MethodImpl(Inline)]
        internal FixedEmitter(IPolyrand random, SurrogateTypes.EmitterSurrogate<F> f)      
        {      
            this.Random = random;
            this.f = f;
        }

        [MethodImpl(Inline)]
        public F Invoke()
            => f.Invoke();
    }

    partial class RngX
    {
        static Func<F> CreateEmissionFunc<F,T>(IPolyrand random)
            where F : unmanaged, IFixed
            where T : unmanaged
        {
            return () => default;
        }

        public static IFixedEmitter<F,T> FixedEmitter<F,T>(this IPolyrand random)
            where F : unmanaged, IFixed
            where T : unmanaged
                => new FixedEmitter<F,T>(random, CreateEmissionFunc<F,T>(random));

        public static Fixed8 Fixed(this IPolyrand random, N8 w)
            => random.Next<byte>();

        public static Fixed8 Fixed(this IPolyrand random, N8 w, N1 signed)
            => random.Next<sbyte>();

        public static Fixed16 Fixed(this IPolyrand random, N16 w)
            => random.Next<ushort>();

        public static Fixed16 Fixed(this IPolyrand random, N16 w, N1 signed)
            => random.Next<short>();

        public static Fixed32 Fixed(this IPolyrand random, N32 w)
            => random.Next<uint>();

        public static Fixed32 Fixed(this IPolyrand random, N32 w, N1 signed)
            => random.Next<int>();

        public static Fixed64 Fixed(this IPolyrand random, N64 w)
            => random.Next<ulong>();

        public static Fixed64 Fixed(this IPolyrand random, N64 w, N1 signed)
            => random.Next<long>();

        public static Fixed128 Fixed(this IPolyrand random, N128 w)
            => random.NextPair<ulong>();

        public static Fixed256 Fixed(this IPolyrand random, N256 w)
            => (random.Fixed(n128), random.Fixed(n128));

        public static IEnumerable<T> Fixed<T>(this IPolyrand random, T t = default)
            where T :unmanaged, IFixed
        {
            switch(t.Width)
            {
                case FixedWidth.W8: return random.FixedStream<T>(n8);
                case FixedWidth.W16: return random.FixedStream<T>(n16);
                case FixedWidth.W32: return random.FixedStream<T>(n32);
                case FixedWidth.W64: return random.FixedStream<T>(n64);
                case FixedWidth.W128: return random.FixedStream<T>(n128);
                case FixedWidth.W256: return random.FixedStream<T>(n256);
                default: return items<T>();                    
            }
        }

        public static IEnumerable<Fixed8> FixedStream(this IPolyrand random, N8 w)
        {
            while(true)
                yield return random.Fixed(w);
        }

        public static IEnumerable<Fixed16> FixedStream(this IPolyrand random, N16 w)
        {
            while(true)
                yield return random.Fixed(w);
        }

        public static IEnumerable<Fixed32> FixedStream(this IPolyrand random, N32 w)
        {
            while(true)
                yield return random.Fixed(w);
        }

        public static IEnumerable<Fixed64> FixedStream(this IPolyrand random, N64 w)
        {
            while(true)
                yield return random.Fixed(w);
        }

        public static IEnumerable<Fixed128> FixedStream(this IPolyrand random, N128 w)
        {
            while(true)
                yield return random.Fixed(w);
        }

        public static IEnumerable<Fixed256> FixedStream(this IPolyrand random, N256 w)
        {
            while(true)
                yield return random.Fixed(w);
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


    }

}