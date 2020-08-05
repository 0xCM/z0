//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a correlated message, accompanied by arbitrary content, 
    /// that describes an occurrence of something interesting
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IAppEvent : ICorrelated, ITextual, IChronic
    {
        AppMsgColor Flair 
            => AppMsgColor.Blue;

        bool IsError 
            => Flair == AppMsgColor.Red;
    }
}