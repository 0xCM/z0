//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes an unlimited value emitter that produces one value at a time
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IValueSource<T> : ISource<T>
        where T : struct
    {

    }    
}