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

    using static Konst;
    using static z;


    class FixedStreamProvider<F,W,T> : IFixedStreamProvider<F,W,T>
        where F : unmanaged, IDataCell
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        readonly IPolyrand random;

        readonly string Name;

        readonly CellWidth Width;

        readonly NumericKind Kind;

        readonly Func<F> ValueEmitter;

        readonly Interval<T> CellDomain;

        public FixedStreamProvider(IPolyrand random, Interval<T>? domain = null)
        {
            this.random = random;
            this.Name = $"fixed_rng_{default(F).BitWidth}x{bitsize<T>()}";
            this.Width = (CellWidth)default(F).BitWidth;
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
            where K : struct
                => As.@as<K,F>(ref As.edit(x));

        Func<F> CreateEmitter()
        {
            if(Width <= CellWidth.W64)
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
                    case CellWidth.W128:
                        return f128;
                    case CellWidth.W256:
                        return f256;
                    case CellWidth.W512:
                        return f512;
                }
            }

            return () => default;

        }

        [MethodImpl(Inline)]
        F f8i()
            => Fixed(random.Next<sbyte>());

        [MethodImpl(Inline)]
        F f8u()
            => Fixed(random.Next<byte>());

        [MethodImpl(Inline)]
        F f16u()
            => Fixed(random.Next<ushort>());

        [MethodImpl(Inline)]
        F f16i()
            => Fixed(random.Next<short>());

        [MethodImpl(Inline)]
        F f32i()
            => Fixed(random.Next<int>());

        [MethodImpl(Inline)]
        F f32u()
            => Fixed(random.Next<uint>());

        [MethodImpl(Inline)]
        F f64u()
            => Fixed(random.Next<ulong>());

        [MethodImpl(Inline)]
        F f64i()
            => Fixed(random.Next<long>());

        [MethodImpl(Inline)]
        F f32f()
            => Fixed(random.Next<float>());

        [MethodImpl(Inline)]
        F f64f()
            => Fixed(random.Next<double>());

        [MethodImpl(Inline)]
        F f128()
            => Fixed(random.Fixed(w128));

        [MethodImpl(Inline)]
        F f256()
            => Fixed(random.Fixed(w256));

        [MethodImpl(Inline)]
        F f512()
            => Fixed(random.Fixed(w512));

        [MethodImpl(Inline)]
        public Cell128 f128V(W128 w)
            => random.NextPair<ulong>();

        [MethodImpl(Inline)]
        public Cell256 Fixed(W256 w)
            =>  (random.Fixed(w128), random.Fixed(w128));

        [MethodImpl(Inline)]
        public Cell512 Fixed(W512 w)
            => (random.Fixed(w256), random.Fixed(w256));
    }
}