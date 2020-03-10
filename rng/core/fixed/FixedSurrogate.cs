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
    
    partial class FixedRng
    {    
        /// <summary>
        /// Creates a fixed emitter that produces F-values defined over numeric T-cells
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IFixedEmitter<F,T> emitter<F,T>(IPolyrand random)
            where F : unmanaged, IFixedWidth
            where T : unmanaged
                => new FixedEmitter<F, T>(random, random.FixedSurrogate<F, T>());
    }

    partial class FixedRngOps
    {
        /// <summary>
        /// Creates a primal emitter predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static NumericEmitter<T> NumericEmitter<T>(this IPolyrand random)
            where T : unmanaged
                => new NumericEmitter<T>(random);

        public static IFixedEmitter<F,T> FixedEmitter<F,T>(this IPolyrand random)
            where F : unmanaged, IFixedWidth
            where T : unmanaged
                => FixedRng.emitter<F,T>(random);
    }

    static class FixedRngSurrogateOps
    {
        internal static FixedEmitterSurrogate<F,T> FixedSurrogate<F,T>(this IPolyrand random)
            where F : unmanaged, IFixedWidth
            where T : unmanaged
                => random.ToFixedSurrogate<F,T>();

       static FixedEmitterSurrogate<F,T> ToFixedSurrogate<F,T>(this IPolyrand random)
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
    }
}