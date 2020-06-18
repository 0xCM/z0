//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppMsgReceiver : IService
    {
        IAppMsgSink Sink {get;}

        void Report(IAppEvent e, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(e.Format(), color);                
    }
}