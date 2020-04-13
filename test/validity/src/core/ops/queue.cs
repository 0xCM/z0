//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class TestContext<U>
    {
        public void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg, severity);

        public void NotifyConsole(IAppMsg msg)            
            => Queue.NotifyConsole(msg, msg.Color);

        public void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => NotifyConsole(AppMsg.Colorize(content, color));

        public IReadOnlyList<IAppMsg> Dequeue()
            => Queue.Dequeue();

        public void Deposit(IAppMsg msg)
            => Queue.Deposit(msg);

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => Queue.Flush(e);
            
        public void Flush(Exception e, IAppMsgSink target)
            => Queue.Flush(e, target);

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);        
    }
}