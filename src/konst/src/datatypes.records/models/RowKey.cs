//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RowKey
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public RowKey(ulong value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator RowKey(ulong value)
            => new RowKey(value);
    }

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

    public readonly struct RowKey<I,T>
        where T : struct, IRecord<T>
        where I : unmanaged
    {
        public I Value {get;}

        [MethodImpl(Inline)]
        public RowKey(I value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator RowKey<I,T>(I value)
            => new RowKey<I,T>(value);

        [MethodImpl(Inline)]
        public static implicit operator RowKey<I>(RowKey<I,T> src)
            => new RowKey<I>(src.Value);

        [MethodImpl(Inline)]
        public static implicit operator RowKey(RowKey<I,T> src)
            => memory.unsigned(src.Value);
    }
}