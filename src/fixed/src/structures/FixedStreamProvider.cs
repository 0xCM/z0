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

    using static Seed;
    using static Widths;
    using static Fixed;

    public static class FixedStream
    {
        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, F f = default, T t = default)
            where F : unmanaged, IFixed
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new FixedStreamProvider<F,W,T>(random, random.Domain<T>()).Stream;

        public static IEnumerable<F> Create<F,W,T>(IPolyrand random, Interval<T> celldomain)
            where F : unmanaged, IFixed
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new FixedStreamProvider<F,W,T>(random, celldomain).Stream;
    }

    public interface IFixedStreamProvider<F> : IStreamProvider<F>
        where F : unmanaged, IFixed
    {
        new IEnumerable<F> Stream {get;}   

        IEnumerable<F> IStreamProvider<F>.Stream
            => Stream;
    }

    public interface IFixedStreamProvider<F,W,T> : IFixedStreamProvider<F>
        where F : unmanaged, IFixed
        where W : unmanaged, ITypeWidth
        where T : unmanaged            
    {

    }

    class FixedStreamProvider<F,W,T> : IFixedStreamProvider<F,W,T>
        where F : unmanaged, IFixed
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        readonly IPolyrand random;
        
        readonly string Name;

        readonly FixedWidth Width;

        readonly NumericKind Kind;

        readonly Func<F> ValueEmitter;
        
        readonly Interval<T> CellDomain;

        public FixedStreamProvider(IPolyrand random, Interval<T>? domain = null)
        {
            this.random = random;
            this.Name = $"fixed_rng_{default(F).BitWidth}x{bitsize<T>()}";
            this.Width = (FixedWidth)default(F).BitWidth;
            this.Kind = typeof(T).NumericKind();            
            this.ValueEmitter = CreateEmitter();
            this.CellDomain = domain ?? random.Domain<T>();
        }

        public IEnumerable<F> Stream
        {
            get
            {
                while(true)
                    yield return ValueEmitter();
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

        F f128() => Fixed(random.Fixed(w128));

        F f256() => Fixed(random.Fixed(w256));

        F f512() => Fixed(random.Fixed(w512));    

        [MethodImpl(Inline)]
        public Fixed128V f128V(W128 w)
            => random.NextPair<ulong>();

        [MethodImpl(Inline)]
        public Fixed256V Fixed(W256 w)
            =>  (random.Fixed(w128), random.Fixed(w128));

        [MethodImpl(Inline)]
        public Fixed512V Fixed(W512 w)
            => (random.Fixed(w256), random.Fixed(w256));
    }
}