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

    /// <summary>
    /// Covers a sequence of T-valued fields
    /// </summary>
    /// <typeparam name="T">The field value type</param>
    public readonly struct ClrFieldValues<T>
    {
        readonly ClrFieldValue<T>[] Data;

        [MethodImpl(Inline)]
        public ClrFieldValues(params ClrFieldValue<T>[] src)
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly ClrFieldValue<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly ClrFieldValue<T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public Span<ClrFieldValue<T>> ToSpan()
            => Data;

        [MethodImpl(Inline)]
        public static implicit operator ClrFieldValues<T>(ClrFieldValue<T>[] src)
            => new ClrFieldValues<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrFieldValues<T>((FieldInfo field, T value)[] src)
            => new ClrFieldValues<T>(src.Select(x => new ClrFieldValue<T>(x.field, x.value)));

        [MethodImpl(Inline)]
        public static implicit operator ClrFieldValue<T>[](ClrFieldValues<T> src)
            => src.Data;
    }
}