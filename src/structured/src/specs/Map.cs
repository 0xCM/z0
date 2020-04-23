//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a structural transformation function
    /// </summary>
    /// <typeparam name="A">The source domain type</typeparam>
    /// <typeparam name="B">The target domain type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFMap<A,B> : ISFunc<A,B>
    {

    }

    /// <summary>
    /// Characterizes an operator that materializes a primal value from a string
    /// </summary>
    /// <typeparam name="T">The primal value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFParser<T> : ISFunc<string,T>
        where T : unmanaged
    {
        
    }
}