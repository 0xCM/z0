//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRecordSet
    {
        TableId TableId {get;}

        uint RowCount {get;}

        Type RecordType {get;}
    }

    [Free]
    public interface IRecordSet<T> : IRecordSet
        where T : struct, IRecord<T>
    {
        Span<T> Edit {get;}

        ReadOnlySpan<T> View {get;}

        uint IRecordSet.RowCount
            => (uint)View.Length;

        TableId IRecordSet.TableId
            => TableId.identify<T>();

        Type IRecordSet.RecordType
            => typeof(T);
    }
}