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

    public readonly struct FieldValues<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public readonly FieldValue<E,T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator FieldValues<E,T>(FieldValue<E,T>[] src)
            => new FieldValues<E,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator FieldValues<E,T>((FieldInfo field, E eValue, T tValue)[] src)
            => new FieldValues<E,T>(src.Select(x => new FieldValue<E,T>(x.field, x.eValue, x.tValue)));

        [MethodImpl(Inline)]
        public static implicit operator FieldValue<E,T>[](FieldValues<E,T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public FieldValues(params FieldValue<E,T>[] src)
        {
            Data = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly FieldValue<E,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public Span<FieldValue<E,T>> ToSpan()
            => Data;
    }
}