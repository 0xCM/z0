//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public abstract class AppShell<A,C> : Shell<A,C>, IAppShell<A>
        where A : AppShell<A,C>, new()
        where C : IAppContext
    {
        protected void Print(object content, AppMsgColor? color = null)
            => Shelled.Print(content,color);
            
        public virtual IPart[] Resolved {get;}

        protected IAppMsgQueue Messaging {get;}

        protected AppShell(C context)
            : base(context)
        {
            Messaging = context.Messaging;
        }

        public void Deposit(IAppMsg msg)
            => Messaging.Deposit(msg);

        protected IAppShell Shelled => this;
                    
        protected override void OnDispose()
        {
            try
            {
                Messaging.Emit(Shelled.AppLogPath);
            }
            catch(Exception e)
            {
                term.red($"Error occurred during application log emission to {Shelled.AppLogPath}");
                OnFatalError(e);
            }
        }        
    }
}