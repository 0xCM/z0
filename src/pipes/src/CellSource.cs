//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.CellSource, true)]
    public readonly struct CellSource
    {
        const NumericKind Closure = UnsignedInts;

        readonly ISource Provider;

        [MethodImpl(Inline), Op]
        public CellSource(ISource provider)
            => Provider = provider;

        [MethodImpl(Inline), Op]
        public Cell8 next(W8 w)
            => Sources.cellsource<Cell8>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell16 next(W16 w)
            => Sources.cellsource<Cell16>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell32 next(W32 w)
            => Sources.cellsource<Cell32>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell64 next(W64 w)
            => Sources.cellsource<Cell64>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell128 next(W128 w)
            => Sources.cellsource<Cell128>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell256 next(W256 w)
            => Sources.cellsource<Cell256>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell512 next(W512 w)
            => Sources.cellsource<Cell512>(Provider).Next();

        [MethodImpl(Inline), Op]
        public static Func<Cell64> emitter(ISource source, W64 w, NumericKind nk)
            => emitter<Cell64>(source, CellWidth.W64, nk);

        [Op, Closures(Closure)]
        public static Func<F> emitter<F>(ISource source, CellWidth width, NumericKind nk)
            where F : unmanaged
        {
            if(width <= CellWidth.W64)
            {
                switch(nk)
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
                    case CellWidth.W128:
                        return f128;
                    case CellWidth.W256:
                        return f256;
                    case CellWidth.W512:
                        return f512;
                }
            }

            return () => default;

            [MethodImpl(Inline)]
            F f8i() => @as<sbyte,F>(source.Next<sbyte>());

            [MethodImpl(Inline)]
            F f8u() => @as<byte,F>(source.Next<byte>());

            [MethodImpl(Inline)]
            F f16u() => @as<ushort,F>(source.Next<ushort>());

            [MethodImpl(Inline)]
            F f16i() => @as<short,F>(source.Next<short>());

            [MethodImpl(Inline)]
            F f32i() => @as<int,F>(source.Next<int>());

            [MethodImpl(Inline)]
            F f32u() => @as<uint,F>(source.Next<uint>());

            [MethodImpl(Inline)]
            F f64u() => @as<ulong,F>(source.Next<ulong>());

            [MethodImpl(Inline)]
            F f64i() => @as<long,F>(source.Next<long>());

            [MethodImpl(Inline)]
            F f32f() => @as<float,F>(source.Next<float>());

            [MethodImpl(Inline)]
            F f64f() => @as<double,F>(source.Next<double>());

            [MethodImpl(Inline)]
            F f128() => @as<Cell128,F>(source.Cell(w128));

            [MethodImpl(Inline)]
            F f256() => @as<Cell256,F>(source.Cell(w256));

            [MethodImpl(Inline)]
            F f512() => @as<Cell512,F>(source.Cell(w512));
        }
    }
}