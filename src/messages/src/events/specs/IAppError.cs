//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppError : IAppEvent
    {
        AppMsgColor IAppEvent.Flair => AppMsgColor.Red;

        bool IAppEvent.IsError => true;

        IAppMsg IAppEvent.Message => AppMsg.NoCaller(Format(), AppMsgKind.Error);
    }

    public interface IAppError<F> : IAppError, IAppEvent<F>
        where F : struct, IAppError<F>
    {

    }

}