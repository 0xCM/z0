//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IValueStreamSource<T> : IValueSource<T>
        where T : struct
    {        
        ValueStreamEmitter<T> Emitter {get;}        
    }          
}