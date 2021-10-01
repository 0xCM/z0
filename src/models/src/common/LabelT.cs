//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct Label<T> : IEquatable<Label<T>>
        where T : unmanaged, IEquatable<T>
    {
        public readonly T Value;

        [MethodImpl(Inline)]
        public Label(T value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public bool Equals(Label<T> src)
            => Value.Equals(src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Label<T>(T src)
            => new Label<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Label(Label<T> src)
            => new Label(u64(src.Value));
    }
}