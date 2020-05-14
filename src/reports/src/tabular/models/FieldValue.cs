//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    public readonly struct FieldValue<F>
        where F : unmanaged, Enum
    {
        public F Field {get;}

        public object Value {get;}

        [MethodImpl(Inline)]
        public FieldValue(F field, object value)
        {
            Field = field;
            Value = value;
        }

        public string Format()
        {
            if(Value is null)
                return Null.Value.Format();
            else if(Value is ITextual t)
                return t.Format();
            else
                return Value.ToString();
        }

        public override string ToString()
            => Format();
    }

}