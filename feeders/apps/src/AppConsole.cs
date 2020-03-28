//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Apps;

    public abstract class ConsoleApp<A,C> : Shell<A,C>, IConsoleApp<A>, IAppMsgSink 
        where A : ConsoleApp<A,C>, new()
        where C : IApiContext
    {
        readonly IAppMsgQueue MsgQueue;

        public virtual IPart[] Resolved {get;}

        protected ConsoleApp(C context)
            : base(context)
        {
            this.MsgQueue = AppMsgQueue.Create();
            this.Resolved = context.Compostion.Resolved;
        }

        public string Format()
            => GetType().Name;

        public void Notify(AppMsg msg)
            => MsgQueue.Accept(msg);

        public override void OnFatalError(Exception e)
            => Streams.iter(MsgQueue.Flush(e), term.print);
    }
}