//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IAppMsgSink : IMessageSink<AppMsg>
    {
        void Notify(string msg, AppMsgKind? kind = null)
            => Notify(AppMsg.NoCaller(msg, kind));

        void IMessageSink<AppMsg>.Displayed(AppMsg msg)
            => Notify(msg.Printed());

        void NotifyConsole(object content, AppMsgColor color)
        {
            var msg = AppMsg.Colorize(content, color);
            term.print(msg, color);
            Displayed(msg);            
        }
    }
}