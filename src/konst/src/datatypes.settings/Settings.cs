//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Settings
    {
        [MethodImpl(Inline)]
        public static Settings<S> create<S>(S settings = default)
            where S : ISettings<S>, new()
                => new Settings<S>(settings ?? new S());

        [MethodImpl(Inline)]
        public static Settings<S> create<S>(Func<S> factory)
            where S : ISettings<S>, new()
                => new Settings<S>(factory());
    }

    public readonly struct Settings<S> : ISettings<S>
        where S : ISettings<S>, new()
    {
        public S Content {get;}

        [MethodImpl(Inline)]
        public Settings(S src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator S(Settings<S> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Settings<S>(S src)
            => new Settings<S>(src);
    }
}