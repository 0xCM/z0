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
    public readonly struct ClrFieldValue<T>
    {
        public readonly FieldInfo Field;

        public readonly T Value;

        [MethodImpl(Inline)]
        public ClrFieldValue(FieldInfo field, T value)
        {
            Field = field;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrFieldValue<T>((FieldInfo field, T value) src)
            => new ClrFieldValue<T>(src.field, src.value);
    }
}