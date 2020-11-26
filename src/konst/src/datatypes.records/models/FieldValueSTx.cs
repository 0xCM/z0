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
    public readonly struct FieldValue<S,T> : IFieldValue<S,T>
    {
        public S Source {get;}

        public FieldInfo Field {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public FieldValue(S src, FieldInfo field, T value)
        {
            Source = src;
            Field = field;
            Value = value;
        }
    }
}