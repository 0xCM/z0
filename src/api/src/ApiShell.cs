//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public abstract class ApiShell<A,C> : Shell<A,C>, IApiShell<A>
        where A : ApiShell<A,C>, new()
        where C : IApiContext
    {
        protected void Print(object content, AppMsgColor? color = null)
            => Shelled.Print(content,color);
            
        public virtual IPart[] Resolved {get;}

        protected IAppMsgQueue Messaging {get;}

        protected ApiShell(C context)
            : base(context)
        {
            Messaging = context.Messaging;
        }

        public void Deposit(IAppMsg msg)
            => Messaging.Deposit(msg);

        protected IApiShell Shelled => this;
                    
        protected override void OnDispose()
        {
            Messaging.Emit(Shelled.AppLogPath);
        }        
    }
}