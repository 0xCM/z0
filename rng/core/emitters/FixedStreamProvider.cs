//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;
    using static Nats;
    

    public interface IFixedStreamProvider<F>
        where F : unmanaged, IFixed
    {
        IEnumerable<F> Stream {get;}   
    }
    public static class FixedStreamProvider
    {   
        public static IFixedStreamProvider<F> Create<F,T>(IPolyrand random, Interval<T>? celldomain = null)
            where F : unmanaged, IFixed
            where T : unmanaged
                => new FixedStreamFactory<F,T>(random, celldomain);
    }

    public class FixedStreamFactory<F,T> : IFixedStreamProvider<F>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        readonly IPolyrand random;
        
        readonly string Name;

        readonly FixedWidth Width;

        readonly NumericKind Kind;

        readonly Func<F> Emitter;
        
        readonly Interval<T> CellDomain;
        public FixedStreamFactory(IPolyrand random, Interval<T>? domain = null)
        {
            this.random = random;
            this.Name = $"fixed_rng_{default(F).FixedBitCount}x{bitsize<T>()}";
            this.Width = (FixedWidth)default(F).FixedBitCount;
            this.Kind = typeof(T).NumericKind();            
            this.Emitter = CreateEmitter();
            this.CellDomain = domain ?? RngDefaults.get<T>().SampleDomain;
        }

        public IEnumerable<F> Stream
        {
            get
            {
                while(true)
                    yield return Emitter();
            }
        }
            
        [MethodImpl(Inline)]
        static F Fixed<K>(in K x)        
            where K : unmanaged
                => Unsafe.As<K,F>(ref Unsafe.AsRef(in x));
    
        Func<F> CreateEmitter()
        {
            if(Width <= FixedWidth.W64)
            {
                switch(Kind)
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
                switch(Width)
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

        F f8i() => Fixed(random.Next<sbyte>());

        F f8u() => Fixed(random.Next<byte>());

        F f16u() => Fixed(random.Next<ushort>());

        F f16i() => Fixed(random.Next<short>());

        F f32i() => Fixed(random.Next<int>());

        F f32u() => Fixed(random.Next<uint>());

        F f64u() => Fixed(random.Next<ulong>());

        F f64i() => Fixed(random.Next<long>());

        F f32f() => Fixed(random.Next<float>());

        F f64f() => Fixed(random.Next<double>());

        F f128() => Fixed(random.Fixed(n128));

        F f256() => Fixed(random.Fixed(n256));

        F f512() => Fixed(random.Fixed(n512));
    
    }

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