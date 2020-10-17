//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class AppShell<A,C> : Shell<A,C>, IAppShell<A>
        where A : AppShell<A,C>, new()
        where C : IWfContext
    {
        public virtual IPart[] Resolved {get;}

        protected AppShell(C context)
            : base(context)
        {

        }

        protected AppShell(C context, IMultiSink sink)
            : base(context, sink)
        {

        }

        public void Deposit(IAppMsg msg)
        {
            Sink.Deposit(msg);
        }

        public void Raise<T>(T @event)
            where T : IAppEvent
        {

            Sink.Deposit(@event);
        }

        protected override void OnDispose()
        {
            try
            {
                Sink.Dispose();
            }
            catch(Exception e)
            {
                OnFatalError(e);
            }
        }
    }
}