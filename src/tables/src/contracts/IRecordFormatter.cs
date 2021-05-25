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

        string Format(IRecord src, RecordFormatKind kind);

        Type RecordType {get;}

        TableId TableId {get;}

        RowFormatSpec FormatSpec {get;}

        string FormatHeader()
            => FormatSpec.Header.Format();
    }

    public interface IRecordFormatter<T> : IRecordFormatter
        where T : struct, IRecord<T>
    {
        string Format(in T src);

        string Format(in T src, RecordFormatKind kind);

        TableId IRecordFormatter.TableId
            => default(T).TableId;

        string IRecordFormatter.Format(IRecord src)
            => Format((T)src);

        string IRecordFormatter.Format(IRecord src, RecordFormatKind kind)
            => Format((T)src, kind);

        Type IRecordFormatter.RecordType
            => typeof(T);
    }
}