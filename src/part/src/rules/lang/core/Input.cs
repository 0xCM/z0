//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Input<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Input(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator Input<T>(T src)
            => new Input<T>(src);
    }
}