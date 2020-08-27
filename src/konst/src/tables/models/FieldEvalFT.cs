//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct FieldEval<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        public TableFields<F> Fields {get;}

        public NamedValues<object> Values {get;}

        [MethodImpl(Inline)]
        public FieldEval(TableFields<F> fields, NamedValue<object>[] values)
        {
            Fields = fields;
            Values = values;
        }

        [MethodImpl(Inline)]
        public ref NamedValue<object> Value(string field)
            => ref Values[field];

        public ref NamedValue<object> this[string name]
        {
            [MethodImpl(Inline)]
            get => ref Value(name);
        }

        public ref NamedValue<object> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Values[index];
        }
    }
}