//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes an event that describes an error
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IAppError : IAppEvent
    {
        MessageFlair IAppEvent.Flair
            => MessageFlair.Red;

        bool IAppEvent.IsError
            => true;
    }

    /// <summary>
    /// Characterizes an error event reification
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IAppError<F> : IAppError, IAppEvent<F>
        where F : struct, IAppError<F>
    {

    }
}