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
    /// Pairs a field with a (compatible) value
    /// </summary>
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