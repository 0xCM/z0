//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FieldValue<F,T>
        where F : unmanaged, Enum
    {
        public F Field {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public FieldValue(F field, T value)
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