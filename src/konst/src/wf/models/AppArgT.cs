//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppArg<T> : IAppArg<T>
        where T : struct
    {
        public T Content {get;}

        [MethodImpl(Inline)]
        public AppArg(T content)
            => Content = content;

        [MethodImpl(Inline)]
        public string Format()
            => Content.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AppArg<T>(T src)
            => new AppArg<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator AppArg(AppArg<T> src)
            => new AppArg(src.Format());
    }
}