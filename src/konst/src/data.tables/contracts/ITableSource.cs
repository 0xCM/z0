//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableSource<T>
        where T : struct
    {
        TableSpan<T> Pull();

        uint Pull(uint requested, ref T dst);
    }

    public interface ITableTarget<T>
        where T : struct
    {
        void Push(TableSpan<T> src);

        void Push(in T src);
    }

    public interface ITableExchange<S,T> : ITableSource<S>, ITableTarget<T>
        where S : struct
        where T : struct

    {

    }
}