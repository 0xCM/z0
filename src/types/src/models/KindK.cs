//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Kind<K> : ITextual
        where K : unmanaged
    {
        readonly K Value {get;}

        [MethodImpl(Inline)]
        public Kind(K src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Kind<K>(K src)
            => new Kind<K>(src);

        [MethodImpl(Inline)]
        public static implicit operator K(Kind<K> src)
            => src.Value;
    }
}