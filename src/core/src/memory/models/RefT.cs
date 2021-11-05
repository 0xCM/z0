//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Ref<T> : IRef<T>
    {
        readonly StrongBox<T> Box;

        [MethodImpl(Inline)]
        public Ref(T value)
        {
            Box = new StrongBox<T>(value);
        }

        [MethodImpl(Inline)]
        public T Target()
            => Box.Value;

        [MethodImpl(Inline)]
        public static implicit operator T(Ref<T> src)
            => src.Target();

        [MethodImpl(Inline)]
        public static implicit operator Ref<T>(T src)
            => new Ref<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Ref(Ref<T> src)
            => new Ref(src.Target());
    }
}