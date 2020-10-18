//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an event that describes an error
    /// </summary>
    [Free]
    public interface IAppError : IAppEvent
    {
        FlairKind IAppEvent.Flair
            => FlairKind.Error;

        bool IAppEvent.IsError
            => true;
    }

    /// <summary>
    /// Characterizes an error event reification
    /// </summary>
    [Free]
    public interface IAppError<F> : IAppError, IAppEvent<F>
        where F : struct, IAppError<F>
    {

    }
}