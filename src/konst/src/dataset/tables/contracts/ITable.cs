//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ITable : ITextual
    {
        string ITextual.Format()
            => "Unformatted";
    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface ITable<F> : ITable
        where F : unmanaged, Enum
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITable<F,T> : ITable<F>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {

    }    
}