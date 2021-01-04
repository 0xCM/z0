//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IRowType : ITextual
    {
        TableId Table {get;}

        string ITextual.Format()
            => Table.Format();
    }

    public interface IRowType<T> : IRowType
        where T : struct, IRecord<T>
    {
        new TableId<T> Table {get;}

        TableId IRowType.Table
            => Table;
    }

    public interface IRowType<I,T> : IRowType<T>
        where T : struct, IRecord<T>
        where I : unmanaged
    {
        new TableId<I,T> Table {get;}
        I TableIndex {get;}

        TableId<T> IRowType<T>.Table
            => Table;
    }
}