//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    public interface ITableSink : IWfSink, ITableWorker
    {

    }

    public interface ITableSink<T> : IWfSink<T>, ITableWorker<T>
        where T : struct, ITable
    {

    }

    public interface ITableSink<H,T> : ITableSink<T>, IWfSink<H,T>
        where T : struct, ITable
        where H : struct, ITableSink<H,T>
    {

    }
}