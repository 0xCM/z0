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

    public readonly struct FieldValues
    {
        readonly FieldValue[] Data;

        [MethodImpl(Inline)]
        public static implicit operator FieldValues(FieldValue[] src)
            => new FieldValues(src);

        [MethodImpl(Inline)]
        public static implicit operator FieldValues((FieldInfo field, object value)[] src)
            => new FieldValues(src.Select(x => new FieldValue(x.field, x.value)));

        [MethodImpl(Inline)]
        public static implicit operator FieldValue[](FieldValues src)
            => src.Data;

        [MethodImpl(Inline)]
        public FieldValues(params FieldValue[] src)
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ReadOnlySpan<FieldValue> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref FieldValue this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref FieldValue this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}