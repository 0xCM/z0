//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ITableIndex<F,T,I> : ITableContent<T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
        where I : unmanaged
    {
        ref T this[I index]{get;}
    }    

    [SuppressUnmanagedCodeSecurity]
    public interface ITableIndex<F,T,D,I> : ITableIndex<F,T,I>
        where F : unmanaged, Enum
        where D : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where I : unmanaged
    {

    }    
}