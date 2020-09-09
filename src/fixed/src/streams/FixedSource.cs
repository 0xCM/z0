//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct FixedSource
    {
        readonly IValueSource Provider;

        [MethodImpl(Inline)]
        public static FixedSource<F> create<F>(IValueSource provider)
            where F : struct, IDataCell
                => new FixedSource<F>(provider);

        [MethodImpl(Inline), Op]
        public static FixedSource create(IValueSource provider)
            => new FixedSource(provider);

        [MethodImpl(Inline), Op]
        public FixedSource(IValueSource provider)
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