//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    /// <summary>
    /// Characterizes an operator that materializes a value from a string given a supporting context
    /// </summary>
    /// <typeparam name="V">The value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IParser<C,V> : IFunc<string,C,V>
        where V : struct
    {
         
    }

    /// <summary>
    /// Characterizes an operator that materializes a primal value from a string
    /// </summary>
    /// <typeparam name="T">The primal value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IParser<T> : IFunc<string,T>
        where T : unmanaged
    {
        
    }
}