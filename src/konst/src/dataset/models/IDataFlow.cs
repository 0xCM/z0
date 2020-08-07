//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a flow that represents a data movement from A -> B, or, in this case, S -> T
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IDataFlow<S,T>
    {
        S Source {get;}

        T Target {get;}
    }
}