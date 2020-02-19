//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public interface IFieldIndexEntry
    {
        int Index {get;}

        string FieldName {get;}

        Enum FieldValue {get;}

    }

    public interface IFieldIndexEntry<F> : IFieldIndexEntry, IFormattable<F>, IEquatable<F>, IComparable<F>
        where F : struct, IFieldIndexEntry<F>
    {
    }

    public interface IFieldIndexEntry<T,E> : IFieldIndexEntry<T>
        where E : unmanaged, Enum
        where T : struct, IFieldIndexEntry<T,E>
    {
        new E FieldValue {get;}

        Enum IFieldIndexEntry.FieldValue => FieldValue;
    }
}