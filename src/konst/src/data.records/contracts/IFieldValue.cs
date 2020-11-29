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

    public interface IFieldValue
    {
        object Source {get;}

        FieldInfo Field {get;}

        object Value {get;}
    }

    public interface IFieldValue<S> : IFieldValue
    {
        new S Source {get;}

        object IFieldValue.Source
            => Source;

    }

    public interface IFieldValue<S,T> : IFieldValue<S>
    {
        new T Value {get;}

        object IFieldValue.Value
            => Value;
    }
}