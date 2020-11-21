//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CellSource, true)]
    public readonly partial struct CellSource
    {
        const NumericKind Closure = UnsignedInts;

        readonly IValueSource Provider;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T next<T>(in CellCycle<T> src)
            where T : unmanaged
                => ref src.Next();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CellCycle<T> cycle<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new CellCycle<T>(src);

        [MethodImpl(Inline), Op]
        public static Cell8 next(IValueSource source, W8 w)
            => source.Next<byte>();

        [MethodImpl(Inline), Op]
        public static Cell16 next(IValueSource source, W16 w)
            => source.Next<ushort>();

        [MethodImpl(Inline), Op]
        public static Cell32 next(IValueSource source, W32 w)
            => source.Next<uint>();

        [MethodImpl(Inline), Op]
        public static Cell64 next(IValueSource source, W64 w)
            => source.Next<ulong>();

        [MethodImpl(Inline), Op]
        public static Cell128 next(IValueSource source, W128 w)
            => source.NextPair<ulong>();

        [MethodImpl(Inline), Op]
        public static Cell256 next(IValueSource source, W256 w)
        {
            var dst = Cell256.Empty;
            ref var storage = ref Unsafe.As<Cell256,Vector256<ulong>>(ref dst);
            storage = storage.WithLower(next(source,w128));
            storage = storage.WithUpper(next(source,w128));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Cell512 next(IValueSource source, W512 w)
        {
            var lo = next(source,w256);
            var hi = next(source,w256);
            return new Cell512(lo,hi);
        }

        [MethodImpl(Inline)]
        public static CellSource<F> create<F>(IValueSource provider)
            where F : struct, IDataCell
                => new CellSource<F>(provider);

        [MethodImpl(Inline), Op]
        public static CellSource create(IValueSource provider)
            => new CellSource(provider);

        [MethodImpl(Inline), Op]
        public CellSource(IValueSource provider)
            => Provider = provider;

        [MethodImpl(Inline), Op]
        public Cell8 next(W8 w)
            => create<Cell8>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell16 next(W16 w)
            => create<Cell16>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell32 next(W32 w)
            => create<Cell32>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell64 next(W64 w)
            => create<Cell64>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell128 next(W128 w)
            => create<Cell128>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell256 next(W256 w)
            => create<Cell256>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Cell512 next(W512 w)
            => create<Cell512>(Provider).Next();
    }
}