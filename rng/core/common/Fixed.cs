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

        public static FixedWidth Width => default(F).FixedWidth;

        public static NumericKind NumericKind => typeof(T).NumericKind();
        
        readonly IPolyrand Random;
        
        readonly EmitterSurrogate<F> f;

        public OpIdentity Moniker => Identity.operation(Name,Width,NumericKind);

        [MethodImpl(Inline)]
        internal FixedEmitter(IPolyrand random, EmitterSurrogate<F> f)      
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
        static EmitterSurrogate<F> CreateEmissionFunc<F,T>(IPolyrand random)
            where F : unmanaged, IFixed
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

            if(width <= FixedWidth.W64)
            {
                switch(kind)
                {
                    case NumericKind.I8:
                        return OpSurrogates.emitter<F>(f8i, name);
                    case NumericKind.U8:
                        return OpSurrogates.emitter<F>(f8u, name);
                    case NumericKind.I16:
                        return OpSurrogates.emitter<F>(f16i, name);
                    case NumericKind.U16:
                        return OpSurrogates.emitter<F>(f16u, name);
                    case NumericKind.I32:
                        return OpSurrogates.emitter<F>(f32i, name);
                    case NumericKind.U32:
                        return OpSurrogates.emitter<F>(f32u, name);
                    case NumericKind.I64:
                        return OpSurrogates.emitter<F>(f64i, name);
                    case NumericKind.U64:
                        return OpSurrogates.emitter<F>(f64u, name);
                    case NumericKind.F32:
                        return OpSurrogates.emitter<F>(f32f, name);
                    case NumericKind.F64:
                        return OpSurrogates.emitter<F>(f64f, name);
                }   
            }

            return OpSurrogates.emitter<F>(() => default, name);            
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
            switch(t.FixedWidth)
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