//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppArg : IAppArg
    {
        public utf8 Content {get;}

        [MethodImpl(Inline)]
        public AppArg(string content)
            => Content = content ?? EmptyString;

        [MethodImpl(Inline)]
        public AppArg(utf8 content)
            => Content = content;

        [MethodImpl(Inline)]
        public static implicit operator AppArg(string src)
            => new AppArg(src);

        [MethodImpl(Inline)]
        public static implicit operator AppArg(utf8 src)
            => new AppArg(src);

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();
    }
}