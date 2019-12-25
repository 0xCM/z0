//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Characterizes an operator that materializes a value from a string without further context
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IParser<V> : IOp
        where V : struct
    {
        V Invoke(string src);
    }

    /// <summary>
    /// Characterizes an operator that materializes a value from a string with a supporting context
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IParser<C,V> : IOp
        where V : struct
    {
         V Invoke(string src, C context);
    }

    /// <summary>
    /// Characterizes an operator that materializes a primal value from a string
    /// </summary>
    /// <typeparam name="T">The primal value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalParser<T> : IParser<T>, IPrimalOp<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes an operator that materializes a primal value from a string with a supporting context
    /// </summary>
    /// <typeparam name="T">The primal value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalParser<C,T> : IParser<C,T>, IPrimalOp<T>
        where T : unmanaged
    {
        
    }

}