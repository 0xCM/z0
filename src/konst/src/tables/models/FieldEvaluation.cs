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
    
    using Z0.Data;
    
    public struct FieldEvaluation : IFieldEvaluation
    {
        public TableFields Fields {get;}

        public Type SourceType {get;}

        public NamedValues<object> Values {get;}

        [MethodImpl(Inline)]
        public FieldEvaluation(Type src, TableFields fields, NamedValue<object>[] values)
        {
            SourceType = src;
            Fields = fields;
            Values = values;
        }    

        [MethodImpl(Inline)]
        public FieldEvaluation(Type src, TableFields fields, NamedValues<object> values)
        {
            SourceType = src;
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