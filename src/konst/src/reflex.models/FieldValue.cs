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
    /// Pairs a field with a weakly-typed value
    /// </summary>
    public readonly struct FieldValue
    {
        public readonly FieldInfo Field;

        public readonly object Value;

        [MethodImpl(Inline)]
        public static implicit operator FieldValue((FieldInfo field, object value) src)
            => new FieldValue(src.field, src.value);

        [MethodImpl(Inline)]
        public FieldValue(FieldInfo field, object value)
        {
            Field = field;
            Value = value;
        }
    }
}