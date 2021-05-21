//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using api = CliRows;

    public interface ICliRecord : IRecord
    {
        CliTableKind TableKind {get;}
    }

    public interface ICliRecord<T> : ICliRecord, IRecord<T>
        where T : unmanaged, ICliRecord<T>
    {
        CliTableKind ICliRecord.TableKind
            => api.kind<T>();

        TableId IRecord.TableId
            => new TableId(typeof(T), TableKind.ToString());
    }
}