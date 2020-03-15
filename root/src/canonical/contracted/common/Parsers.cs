//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    /// <summary>
    /// Characterizes an operator that materializes a primal value from a string
    /// </summary>
    /// <typeparam name="T">The primal value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface INumericParser<T> : IUnaryFunc<string,T>
        where T : unmanaged
    {
        
    }
}