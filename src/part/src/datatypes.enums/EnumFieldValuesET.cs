//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct EnumFieldValues<E,T>
        where E : unmanaged, Enum
    {
        public readonly EnumFieldValue<E,T>[] Data;

        [MethodImpl(Inline)]
        public EnumFieldValues(params EnumFieldValue<E,T>[] src)
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly EnumFieldValue<E,T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public Span<EnumFieldValue<E,T>> ToSpan()
            => Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumFieldValues<E,T>(EnumFieldValue<E,T>[] src)
            => new EnumFieldValues<E,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator EnumFieldValues<E,T>((FieldInfo field, E eValue, T tValue)[] src)
            => new EnumFieldValues<E,T>(src.Select(x => new EnumFieldValue<E,T>(x.field, x.eValue, x.tValue)));

        [MethodImpl(Inline)]
        public static implicit operator EnumFieldValue<E,T>[](EnumFieldValues<E,T> src)
            => src.Data;
    }
}