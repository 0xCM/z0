//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RowKey<I>
        where I : unmanaged
    {
        public I Value {get;}

        [MethodImpl(Inline)]
        public RowKey(I value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator RowKey<I>(I value)
            => new RowKey<I>(value);

        [MethodImpl(Inline)]
        public static implicit operator RowKey(RowKey<I> src)
            => memory.unsigned(src.Value);
    }
}