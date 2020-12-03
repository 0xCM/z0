//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an unlimited value emitter
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [Free]
    public interface IValueSource<T> : ISource<T>
        where T : struct
    {

    }
}