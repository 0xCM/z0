//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFieldEval
    {
        TableFields Fields {get;}

        Type SourceType {get;}

        NamedValues<object> Values {get;}

        ref NamedValue<object> Value(string field)
            => ref Values[field];

        ref NamedValue<object> this[string name]
        {
            get => ref Value(name);
        }
    }

    public interface IFieldEval<F,T> : IFieldEval
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {

        new TableFields<F> Fields {get;}

        Type IFieldEval.SourceType
            => typeof(T);
    }
}