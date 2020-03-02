//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;
 
    /// <summary>
    /// Characterizes a source of T-valued patterns
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPatternSource<T> : IFunc<T>
    {
        
    }



}