//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Output<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Output(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator Output<T>(T src)
            => new Output<T>(src);
    }
}