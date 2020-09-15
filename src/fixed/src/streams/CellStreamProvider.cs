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

    class CellStreamProvider<F,W,T> : ICellStreamProvider<F,W,T>
        where F : unmanaged, IDataCell
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        readonly IPolyrand Random;

        readonly string Name;

        readonly CellWidth Width;

        readonly NumericKind Kind;

        readonly Func<F> ValueEmitter;

        readonly Interval<T> CellDomain;

        public CellStreamProvider(IPolyrand src, Interval<T>? domain = null)
        {
            Random = src;
            Name = $"fixed_rng_{default(F).BitWidth}x{bitsize<T>()}";
            Width = (CellWidth)default(F).BitWidth;
            Kind = typeof(T).NumericKind();
            ValueEmitter = CreateEmitter();
            CellDomain = domain ?? src.Domain<T>();
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
            => Fixed(Random.Next<sbyte>());

        [MethodImpl(Inline)]
        F f8u()
            => Fixed(Random.Next<byte>());

        [MethodImpl(Inline)]
        F f16u()
            => Fixed(Random.Next<ushort>());

        [MethodImpl(Inline)]
        F f16i()
            => Fixed(Random.Next<short>());

        [MethodImpl(Inline)]
        F f32i()
            => Fixed(Random.Next<int>());

        [MethodImpl(Inline)]
        F f32u()
            => Fixed(Random.Next<uint>());

        [MethodImpl(Inline)]
        F f64u()
            => Fixed(Random.Next<ulong>());

        [MethodImpl(Inline)]
        F f64i()
            => Fixed(Random.Next<long>());

        [MethodImpl(Inline)]
        F f32f()
            => Fixed(Random.Next<float>());

        [MethodImpl(Inline)]
        F f64f()
            => Fixed(Random.Next<double>());

        [MethodImpl(Inline)]
        F f128()
            => Fixed(Random.Cell(w128));

        [MethodImpl(Inline)]
        F f256()
            => Fixed(Random.Cell(w256));

        [MethodImpl(Inline)]
        F f512()
            => Fixed(Random.Cell(w512));

        [MethodImpl(Inline)]
        public Cell128 f128V(W128 w)
            => Random.NextPair<ulong>();

        [MethodImpl(Inline)]
        public Cell256 Fixed(W256 w)
            =>  (Random.Cell(w128), Random.Cell(w128));

        [MethodImpl(Inline)]
        public Cell512 Fixed(W512 w)
            => (Random.Cell(w256), Random.Cell(w256));
    }
}