//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class ApiShell<A,C> : Shell<A,C>, IApiShell<A>
        where A : ApiShell<A,C>, new()
        where C : IContext
    {
        readonly IAppMsgQueue MsgQueue;

        public virtual IPart[] Resolved {get;}

        protected ApiShell(C context)
            : base(context)
        {
            this.MsgQueue = AppMessages.queue();
        }

        public void Deposit(IAppMsg msg)
            => MsgQueue.Deposit(msg);

        protected IApiShell Shelled => this;

        PartId AppId => typeof(A).Assembly.Id();

        public override void OnFatalError(Exception e)
        {
            Print(AppMsg.Error(e));            
        }
                    
        protected override void OnDispose()
        {
            MsgQueue.Emit(Shelled.AppLogPath);
        }        

        protected void Print(object content, AppMsgColor? color = null)
            => Shelled.Print(content, color);
    }
}