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

    public readonly struct FieldValue : IFieldValue<object,object>
    {
        public object Source {get;}

        public FieldInfo Field {get;}

        public object Value {get;}

        [MethodImpl(Inline)]
        public FieldValue(object src, FieldInfo field, object value)
        {
            Source = src;
            Field = field;
            Value = value;
        }
    }
}