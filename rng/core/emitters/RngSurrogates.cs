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
    
    partial class CoreRngOps
    {
        /// <summary>
        /// Creates a numeric emitter predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static NumericRngEmitter<T> NumericEmitter<T>(this IPolyrand random, T t = default)
            where T : unmanaged
                => new NumericRngEmitter<T>(random);

        /// <summary>
        /// Manufactures a function that produces fixed-width values upon invocation
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="x"></param>
        /// <param name="t"></param>
        /// <typeparam name="F"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static Func<F> FixedEmitter<F,T>(this IPolyrand random, F x = default, T t = default)
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
                        return f8i;
                    case NumericKind.U8:
                        return f8u;
                    case NumericKind.I16:
                        return f16i;
                    case NumericKind.U16:
                        return f16u;
                    case NumericKind.I32:
                        return f32i;
                    case NumericKind.U32:
                        return f32u;
                    case NumericKind.I64:
                        return f64i;
                    case NumericKind.U64:
                        return f64u;
                    case NumericKind.F32:
                        return f32f;
                    case NumericKind.F64:
                        return f64f;
                }   
            }
            else
            {
                switch(width)
                {
                    case FixedWidth.W128:
                        return f128;
                    case FixedWidth.W256:
                        return f256;
                    case FixedWidth.W512:
                        return f512;
                }
            }

            

            return () => default;
        }
        
    }
}