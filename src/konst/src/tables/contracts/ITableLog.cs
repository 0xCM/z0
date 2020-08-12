//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using static Konst;
    
    public interface ITableLog : IDisposable
    {

    }
    
    public interface ITableLog<T> : ITableLog
        where T : struct, ITable
    {        
        void Deposit(params T[] src);    
    }

    public interface ITableLog<F,T> : ITableLog<T>
        where T : struct, ITable<F,T>
        where F : unmanaged, Enum
    {        
           
    }
}