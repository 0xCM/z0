//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    [ApiHost]
    public readonly struct FixedSource
    {
        readonly IValueSource Provider;

        [MethodImpl(Inline), Op]
        public static FixedSource init(IValueSource provider)
            => new FixedSource(provider);        
        
        [MethodImpl(Inline), Op]
        public FixedSource(IValueSource provider)
            => Provider = provider;

        [MethodImpl(Inline), Op]
        public Fixed8 next(W8 w)
            => source<Fixed8>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed16 next(W16 w)
            => source<Fixed16>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed32 next(W32 w)
            => source<Fixed32>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed64 next(W64 w)
            => source<Fixed64>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed128 next(W128 w)
            => source<Fixed128>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed256 next(W256 w)
            => source<Fixed256>(Provider).Next();

        [MethodImpl(Inline), Op]
        public Fixed512 next(W512 w)
            => source<Fixed512>(Provider).Next();

        [MethodImpl(Inline)]
        static FixedSource<F> source<F>(IValueSource provider)
            where F : struct, IFixed
                => new FixedSource<F>(provider);
    }
}