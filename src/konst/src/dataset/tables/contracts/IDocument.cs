//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IDocument
    {

    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface IDocument<F> : IDocument
        where F : unmanaged, Enum
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IDocument<F,T> : IDocument<F>
        where F : unmanaged, Enum
        where T : struct, IDocument<F,T>
    {

    }    
}