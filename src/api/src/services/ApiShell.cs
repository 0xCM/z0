//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class ApiShell<A,C> : Shell<A,C>, IApiShell<A>, IAppMsgSink
        where A : ApiShell<A,C>, new()
        where C : IApiContext
    {
        readonly IAppMsgQueue MsgQueue;

        public virtual IPart[] Resolved {get;}

        protected ApiShell(C context)
            : base(context)
        {
            this.MsgQueue = AppMessages.queue();
            this.Resolved = context.Compostion.Resolved;
        }

        public string Format()
            => GetType().Name;

        public void Notify(AppMsg msg)
            => MsgQueue.Accept(msg);

        public override void OnFatalError(Exception e)
            => Control.iter(MsgQueue.Flush(e), term.print);
    }
}