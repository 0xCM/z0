//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IRecordFormatter
    {
        string Format(IRecord src);

        Type RecordType {get;}

        TableId TableId {get;}

        RecordFields Fields();

        RowFormatSpec FormatSpec {get;}

        string FormatHeader()
            => FormatSpec.Header.Format();
    }

    public interface IRecordFormatter<T> : IRecordFormatter
        where T : struct, IRecord<T>
    {
        string Format(in T src);

        TableId IRecordFormatter.TableId
            => default(T).TableId;

        RecordFields IRecordFormatter.Fields()
            => default(T).Fields();

        string IRecordFormatter.Format(IRecord src)
            => Format((T)src);

        Type IRecordFormatter.RecordType
            => typeof(T);
    }
}