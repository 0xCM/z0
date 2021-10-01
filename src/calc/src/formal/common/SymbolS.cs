//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Symbol<S>
        where S : unmanaged
    {
        public S Value {get;}

        [MethodImpl(Inline)]
        public Symbol(S value)
        {
            Value = value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => u64(Value) == 0ul;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => u64(Value) != 0ul;
        }

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(S src)
            => new Symbol<S>(src);

        public static Symbol<S> Empty => default;
    }
}