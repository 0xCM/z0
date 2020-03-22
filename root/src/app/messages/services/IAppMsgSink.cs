//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    public interface IAppMsgSink : IMessageSink<AppMsg>
    {
        /// <summary>
        /// Posts a text message to the context queue with optional severity
        /// </summary>
        /// <param name="msg">The message to post</param>
        void Notify(string msg, AppMsgKind? kind = null)
            => Notify(AppMsg.NoCaller(msg, kind));

        void IMessageSink<AppMsg>.Displayed(AppMsg msg)
            => Notify(msg.Printed());

        void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => NotifyConsole(AppMsg.Colorize(content, color));
    }
}