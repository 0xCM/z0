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
            where F : struct, IFixed
                => new FixedSource<F>(provider);

        [MethodImpl(Inline), Op]
        public static FixedSource create(IValueSource provider)
            => new FixedSource(provider);        
        
        [MethodImpl(Inline), Op]
        public FixedSource(IValueSource provider)
            => Provider = provider;

        [MethodImpl(Inline), Op]
        public Fixed8 next(W8 w)
            => create<Fixed8>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed16 next(W16 w)
            => create<Fixed16>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed32 next(W32 w)
            => create<Fixed32>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed64 next(W64 w)
            => create<Fixed64>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed128 next(W128 w)
            => create<Fixed128>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed256 next(W256 w)
            => create<Fixed256>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed512 next(W512 w)
            => create<Fixed512>(Provider).Next();

    }
}