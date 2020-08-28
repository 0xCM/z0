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

    public struct TableFieldEval<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        public T Source;

        public TableFields<F> Fields;

        public NamedValues<object> Values;

        [MethodImpl(Inline)]
        public TableFieldEval(T source, TableFields<F> fields, NamedValue<object>[] values)
        {
            Source = source;
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