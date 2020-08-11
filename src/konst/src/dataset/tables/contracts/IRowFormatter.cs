//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IRowFormatter<F,T>
        where F : unmanaged, Enum        
    {
        T Format<S>(S src)
            where S : ITable;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IRowFormatter<F> : IRowFormatter<F,string>
        where F : unmanaged, Enum
    {

    }    
}