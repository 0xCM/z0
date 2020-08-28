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
    using static z;

    public struct TableFieldEval
    {
        public object Source {get;}

        public TableFields Fields {get;}

        public NamedValues<object> Values {get;}

        [MethodImpl(Inline)]
        public TableFieldEval(object src, TableFields fields, NamedValue<object>[] values)
        {
            Source = src;
            Fields = fields;
            Values = values;
        }

        [MethodImpl(Inline)]
        public TableFieldEval(object src, TableFields fields, NamedValues<object> values)
        {
            Source = src;
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
    }
}