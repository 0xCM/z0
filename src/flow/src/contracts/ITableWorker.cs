//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Konst;
    using static z;

    public interface ITableWorker : IWfWorker
    {
        
    }

    public interface ITableWorker<T> : ITableWorker
        where T : struct, ITable
    {
        
    }

    public interface ITableWorker<H,T> : ITableWorker, IWfWorker<H>
        where T : struct, ITable
        where H : struct, ITableWorker<H,T>
    {
        
    }

}