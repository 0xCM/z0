//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    
    static class RngSurrogates
    {
        internal static FixedEmitterSurrogate<F> value<F>(IPolyrand random)
            where F : unmanaged, IFixed
                => random.ToFixedSurrogate<F>();

        internal static FixedEmitterSurrogate<F,T> value<F,T>(IPolyrand random)
            where F : unmanaged, IFixed
            where T : unmanaged
                => random.ToFixedSurrogate<F,T>();

        internal static FixedSpanEmitterSurrogate<F> span<F>(IPolyrand random, int length)
            where F : unmanaged, IFixed
        {
            Span<F> emit()            
            {
                var emitter = RngEmitters.fixedValue<F>(random);
                Span<F> dst = new F[length];
                for(var i=0; i<length; i++)
                    dst[i] = emitter.Invoke();
                return dst;
            }
            
            var name = $"fixed_span_rng_{bitsize<F>()}";
            return new FixedSpanEmitterSurrogate<F>(emit, name);
        }

        internal static FixedSpanEmitterSurrogate<F,T> span<F,T>(IPolyrand random, int length)
            where F : unmanaged, IFixed
            where T : unmanaged
        {
            Span<F> emit()            
            {
                var emitter = RngEmitters.fixedValue<F,T>(random);
                Span<F> dst = new F[length];
                for(var i=0; i<length; i++)
                    dst[i] = emitter.Invoke();                
                return dst;
            }
            
            var name = $"fixed_span_rng_{default(F).FixedBitCount}x{bitsize<T>()}";
            return new FixedSpanEmitterSurrogate<F,T>(emit, name);
        }

       static FixedEmitterSurrogate<F,T> ToFixedSurrogate<F,T>(this IPolyrand random)
            where F : unmanaged, IFixed
            where T : unmanaged
        {
            var name = $"fixed_rng_{default(F).FixedBitCount}x{bitsize<T>()}";
            var width = (FixedWidth)default(F).FixedBitCount;
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
                        return surrogate<F,T>(f8i, name);
                    case NumericKind.U8:
                        return surrogate<F,T>(f8u, name);
                    case NumericKind.I16:
                        return surrogate<F,T>(f16i, name);
                    case NumericKind.U16:
                        return surrogate<F,T>(f16u, name);
                    case NumericKind.I32:
                        return surrogate<F,T>(f32i, name);
                    case NumericKind.U32:
                        return surrogate<F,T>(f32u, name);
                    case NumericKind.I64:
                        return surrogate<F,T>(f64i, name);
                    case NumericKind.U64:
                        return surrogate<F,T>(f64u, name);
                    case NumericKind.F32:
                        return surrogate<F,T>(f32f, name);
                    case NumericKind.F64:
                        return surrogate<F,T>(f64f, name);
                }   
            }
            else
            {
                switch(width)
                {
                    case FixedWidth.W128:
                        return surrogate<F,T>(f128, name);
                    case FixedWidth.W256:
                        return surrogate<F,T>(f256, name);
                    case FixedWidth.W512:
                        return surrogate<F,T>(f512, name);
                }
            }

            return surrogate<F,T>(() => default, name);            
        }

       static FixedEmitterSurrogate<F> ToFixedSurrogate<F>(this IPolyrand random)
            where F : unmanaged, IFixed
        {
            var name = $"fixed_rng_{bitsize<F>()}";
            var width = (FixedWidth)default(F).FixedBitCount;
            var kind = typeof(F).NumericKind();

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
                        return surrogate<F>(f8i, name);
                    case NumericKind.U8:
                        return surrogate<F>(f8u, name);
                    case NumericKind.I16:
                        return surrogate<F>(f16i, name);
                    case NumericKind.U16:
                        return surrogate<F>(f16u, name);
                    case NumericKind.I32:
                        return surrogate<F>(f32i, name);
                    case NumericKind.U32:
                        return surrogate<F>(f32u, name);
                    case NumericKind.I64:
                        return surrogate<F>(f64i, name);
                    case NumericKind.U64:
                        return surrogate<F>(f64u, name);
                    case NumericKind.F32:
                        return surrogate<F>(f32f, name);
                    case NumericKind.F64:
                        return surrogate<F>(f64f, name);
                }   
            }
            else
            {
                switch(width)
                {
                    case FixedWidth.W128:
                        return surrogate<F>(f128, name);
                    case FixedWidth.W256:
                        return surrogate<F>(f256, name);
                    case FixedWidth.W512:
                        return surrogate<F>(f512, name);
                }
            }

            return surrogate<F>(() => default, name);            
        }

        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        internal static FixedEmitterSurrogate<F,T> surrogate<F,T>(Func<F> f, string name, T t = default)
            where F : unmanaged, IFixed
            where T :unmanaged
                => new FixedEmitterSurrogate<F,T>(f,name);        

        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        internal static FixedEmitterSurrogate<F> surrogate<F>(Func<F> f, string name)
            where F : unmanaged, IFixed
                => new FixedEmitterSurrogate<F>(f,name);        

    }
}