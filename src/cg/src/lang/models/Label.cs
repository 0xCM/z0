//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Label<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Label(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator Label<T>(T src)
            => new Label<T>(src);
    }
}