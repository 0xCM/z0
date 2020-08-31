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
            where F : struct, IFixedCell
                => new FixedSource<F>(provider);

        [MethodImpl(Inline), Op]
        public static FixedSource create(IValueSource provider)
            => new FixedSource(provider);

        [MethodImpl(Inline), Op]
        public FixedSource(IValueSource provider)
            => Provider = provider;

        [MethodImpl(Inline), Op]
        public FixedCell8 next(W8 w)
            => create<FixedCell8>(Provider).Next();

        [MethodImpl(Inline), Op]
        public FixedCell16 next(W16 w)
            => create<FixedCell16>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed32 next(W32 w)
            => create<Fixed32>(Provider).Next();

        [MethodImpl(Inline), Op]
        public FixedCell64 next(W64 w)
            => create<FixedCell64>(Provider).Next();

        [MethodImpl(Inline), Op]
        public FixedCell128 next(W128 w)
            => create<FixedCell128>(Provider).Next();

        [MethodImpl(Inline), Op]
        public FixedCell256 next(W256 w)
            => create<FixedCell256>(Provider).Next();

        [MethodImpl(Inline), Op]
        public FixedCell512 next(W512 w)
            => create<FixedCell512>(Provider).Next();

    }
}