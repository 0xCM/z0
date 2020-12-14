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

    public readonly struct ClrFieldValue<T>
    {
        public FieldInfo Definition {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        internal ClrFieldValue(FieldInfo field, T value)
        {
            Definition = field;
            Value = value;
        }
    }
}