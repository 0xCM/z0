//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class WfRouter<H,S> : IWfRouter<S>
        where H : WfRouter<H,S>
    {
        protected IWfShell Wf {get;}

        readonly WfStepId Step;

        readonly WfHost Host;

        protected WfRouter(IWfShell wf)
        {
            RouterType = typeof(H);
            Host = WfSelfHost.create(RouterType);
            Wf = wf.WithHost(Host);
            Step = typeof(H);
            var uri = ApiIdentity.identify(RouterType);
            RouterId = (ulong)uri.Part |((ulong)uri.HostId << 32);
            Wf.Created();
        }

        public Type RouterType {get;}

        public virtual WfRouterId RouterId {get;}

        protected virtual void Disposing() {}

        public void Dispose()
        {
            Disposing();
            Wf.Disposed();
        }

        protected abstract void Execute(S src);

        public Outcome Route(S src)
        {
            using var flow = Wf.Running();

            try
            {
                Execute(src);
                return true;
            }
            catch(Exception e)
            {
                Wf.Error(e, Wf.Ct);
                return e;
            }
        }
    }
}