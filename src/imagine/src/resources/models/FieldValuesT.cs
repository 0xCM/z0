//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct FieldValues<T>
        where T : unmanaged
    {
        public readonly FieldValue<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator FieldValues<T>(FieldValue<T>[] src)
            => new FieldValues<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator FieldValues<T>((FieldInfo field, T value)[] src)
            => new FieldValues<T>(src.Select(x => new FieldValue<T>(x.field, x.value)));

        [MethodImpl(Inline)]
        public static implicit operator FieldValue<T>[](FieldValues<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public FieldValues(params FieldValue<T>[] src)
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly FieldValue<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public Span<FieldValue<T>> ToSpan()
            => Data;
    }
}