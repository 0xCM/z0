//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IRecordFieldValues
    {
        RecordFields Fields {get;}

        IndexedSeq<RecordFieldValue> Values {get;}

        object Source {get;}
    }

    public interface IRecordFieldValues<T> : IRecordFieldValues
        where T : struct
    {
        new T Source {get;}

        object IRecordFieldValues.Source
            => Source;
    }
}