//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ITableCells<T> : ICellular<T>
        where T : struct, ITable
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableCells<F,T> : ITableCells<T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        
    }        
}