//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ITableIndex<T> : Z0.Data.IDataIndex<T>
        where T : struct, ITable
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableIndex<F,T> : ITableIndex<T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {

    }    
}