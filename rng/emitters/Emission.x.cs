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

    public static class FixedEmitX
    {
        /// <summary>
        /// Creates a primal emitter predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalEmitter<T> Emitter<T>(this IPolyrand random)
            where T : unmanaged
                => new PrimalEmitter<T>(random);

        public static IFixedEmitter<F,T> FixedEmitter<F,T>(this IPolyrand random)
            where F : unmanaged, IFixedWidth
            where T : unmanaged
                => new FixedEmitter<F,T>(random, FixedSurrogate<F,T>(random));

        [MethodImpl(Inline)]
        public static Fixed8 Fixed(this IPolyrand random, N8 w)
            => random.Next<byte>();

        [MethodImpl(Inline)]
        public static Fixed8 Fixed(this IPolyrand random, N8 w, N1 signed)
            => random.Next<sbyte>();

        [MethodImpl(Inline)]
        public static Fixed16 Fixed(this IPolyrand random, N16 w)
            => random.Next<ushort>();

        [MethodImpl(Inline)]
        public static Fixed16 Fixed(this IPolyrand random, N16 w, N1 signed)
            => random.Next<short>();

        [MethodImpl(Inline)]
        public static Fixed32 Fixed(this IPolyrand random, N32 w)
            => random.Next<uint>();

        [MethodImpl(Inline)]
        public static Fixed32 Fixed(this IPolyrand random, N32 w, N1 signed)
            => random.Next<int>();

        [MethodImpl(Inline)]
        public static Fixed64 Fixed(this IPolyrand random, N64 w)
            => random.Next<ulong>();

        [MethodImpl(Inline)]
        public static Fixed64 Fixed(this IPolyrand random, N64 w, N1 signed)
            => random.Next<long>();

        [MethodImpl(Inline)]
        public static Fixed128 Fixed(this IPolyrand random, N128 w)
            => random.NextPair<ulong>();

        [MethodImpl(Inline)]
        public static Fixed256 Fixed(this IPolyrand random, N256 w)
            =>  (random.Fixed(n128), random.Fixed(n128));

        [MethodImpl(Inline)]
        public static Fixed512 Fixed(this IPolyrand random, N512 w)
            => (random.Fixed(n256), random.Fixed(n256));

        public static IEnumerable<T> FixedStream<T>(this IPolyrand random, T t = default)
            where T:unmanaged, IFixedWidth
        {
            switch(t.FixedWidth)
            {
                case FixedWidth.W8: return random.FixedStream<T>(n8);
                case FixedWidth.W16: return random.FixedStream<T>(n16);
                case FixedWidth.W32: return random.FixedStream<T>(n32);
                case FixedWidth.W64: return random.FixedStream<T>(n64);
                case FixedWidth.W128: return random.FixedStream<T>(n128);
                case FixedWidth.W256: return random.FixedStream<T>(n256);
                case FixedWidth.W512: return random.FixedStream<T>(n512);
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

        public static IEnumerable<Fixed512> FixedStream(this IPolyrand random, N512 w)
        {
            while(true)
                yield return random.Fixed(w);
        }

        static FixedEmitterSurrogate<F,T> FixedSurrogate<F,T>(IPolyrand random)
            where F : unmanaged, IFixedWidth
            where T : unmanaged
        {
            const string name = "fixedrand";
            var width = default(F).FixedWidth;
            var kind = typeof(T).NumericKind();

            F f8u()
            {                
                var next = random.Next<byte>();
                return Unsafe.As<byte,F>(ref next);
            }

            F f8i()
            {
                var next = random.Next<sbyte>();
                return Unsafe.As<sbyte,F>(ref next);
            }

            F f16u()
            {                
                var next = random.Next<ushort>();
                return Unsafe.As<ushort,F>(ref next);
            }

            F f16i()
            {
                var next = random.Next<short>();
                return Unsafe.As<short,F>(ref next);
            }

            F f32u()
            {                
                var next = random.Next<uint>();
                return Unsafe.As<uint,F>(ref next);
            }

            F f32i()
            {
                var next = random.Next<int>();
                return Unsafe.As<int,F>(ref next);
            }

            F f64u()
            {                
                var next = random.Next<ulong>();
                return Unsafe.As<ulong,F>(ref next);
            }

            F f64i()
            {
                var next = random.Next<long>();
                return Unsafe.As<long,F>(ref next);
            }

            F f32f()
            {                
                var next = random.Next<float>();
                return Unsafe.As<float,F>(ref next);
            }

            F f64f()
            {
                var next = random.Next<double>();
                return Unsafe.As<double,F>(ref next);
            }

            F f128()
            {
                var next = random.Fixed(n128);
                return Unsafe.As<Fixed128,F>(ref next);
            }

            F f256()
            {
                var next = random.Fixed(n256);
                return Unsafe.As<Fixed256,F>(ref next);
            }

            F f512()
            {
                var next = random.Fixed(n512);
                return Unsafe.As<Fixed512,F>(ref next);
            }

            if(width <= FixedWidth.W64)
            {
                switch(kind)
                {
                    case NumericKind.I8:
                        return OpSurrogates.emitter<F,T>(f8i, name);
                    case NumericKind.U8:
                        return OpSurrogates.emitter<F,T>(f8u, name);
                    case NumericKind.I16:
                        return OpSurrogates.emitter<F,T>(f16i, name);
                    case NumericKind.U16:
                        return OpSurrogates.emitter<F,T>(f16u, name);
                    case NumericKind.I32:
                        return OpSurrogates.emitter<F,T>(f32i, name);
                    case NumericKind.U32:
                        return OpSurrogates.emitter<F,T>(f32u, name);
                    case NumericKind.I64:
                        return OpSurrogates.emitter<F,T>(f64i, name);
                    case NumericKind.U64:
                        return OpSurrogates.emitter<F,T>(f64u, name);
                    case NumericKind.F32:
                        return OpSurrogates.emitter<F,T>(f32f, name);
                    case NumericKind.F64:
                        return OpSurrogates.emitter<F,T>(f64f, name);
                }   
            }
            else
            {
                switch(width)
                {
                    case FixedWidth.W128:
                        return OpSurrogates.emitter<F,T>(f128, name);
                    case FixedWidth.W256:
                        return OpSurrogates.emitter<F,T>(f256, name);
                    case FixedWidth.W512:
                        return OpSurrogates.emitter<F,T>(f512, name);
                }
            }

            return OpSurrogates.emitter<F,T>(() => default, name);            
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
            where T :unmanaged, IFixedWidth
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed64, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N128 w)
            where T :unmanaged, IFixedWidth
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed128, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N256 w)
            where T :unmanaged, IFixedWidth
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed256, T>(ref next);
            }
        }

        static IEnumerable<T> FixedStream<T>(this IPolyrand random, N512 w)
            where T :unmanaged, IFixedWidth
        {
            while(true)
            {
                var next = random.Fixed(w);
                yield return Unsafe.As<Fixed512, T>(ref next);
            }
        }
    }
}