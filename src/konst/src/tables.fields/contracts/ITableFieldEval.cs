//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableFieldEval
    {
        TableFieldIndex Fields {get;}

        Type SourceType {get;}

        NamedValues<object> Values {get;}

        ref NamedValue<object> Value(string field)
            => ref Values[field];

        ref NamedValue<object> this[string name]
        {
            get => ref Value(name);
        }
    }

    public interface ITableFieldEval<F,T> : ITableFieldEval
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {

        new TableFieldIndex<F> Fields {get;}

        Type ITableFieldEval.SourceType
            => typeof(T);
    }
}