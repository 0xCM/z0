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
    /// Covers a field along with a value that was either extracted from a field instance or that may be pushed into a field instance
    /// </summary>
    /// <typeparam name="T">The field value type</param>
    public readonly struct FieldValue<T>
    {
        public readonly FieldInfo Field;

        public readonly T Value;

        [MethodImpl(Inline)]
        public static implicit operator FieldValue<T>((FieldInfo field, T value) src)
            => new FieldValue<T>(src.field, src.value);

        [MethodImpl(Inline)]
        public FieldValue(FieldInfo field, T value)
        {
            Field = field;
            Value = value;
        }
    }
}