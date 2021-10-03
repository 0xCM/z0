//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Var<T>
    {
        public readonly Label Name;

        public readonly T Value;

        [MethodImpl(Inline)]
        public Var(Label name, T value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public Var<T> Assign(T src)
            => new Var<T>(Name,src);

        [MethodImpl(Inline)]
        public static implicit operator Var<T>((Label name, T value) src)
            => new Var<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator Var(Var<T> src)
            => new Var(src.Name, src.Value);
    }
}