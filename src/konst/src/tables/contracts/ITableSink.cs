//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Security;
    
    using static Konst;

    public interface ITableSink<T> : ISink<T>
        where T : struct, ITable
    {
        
    }

    public interface ITableSink<F,T> : ITableSink<T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>         
    {
        
    }    
}