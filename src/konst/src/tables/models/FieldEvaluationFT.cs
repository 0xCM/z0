//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;
    
    using static Konst;
    using static z;

    public struct FieldEvaluation<F,T> : IFieldEvaluation<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        public TableFields<F> Fields {get;}

        public NamedValues<object> Values {get;}

        [MethodImpl(Inline)]
        public static implicit operator FieldEvaluation(FieldEvaluation<F,T> src)
            => new FieldEvaluation(typeof(T), src.Fields, src.Values);
        
        [MethodImpl(Inline)]
        public FieldEvaluation(TableFields<F> fields, NamedValue<object>[] values)
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