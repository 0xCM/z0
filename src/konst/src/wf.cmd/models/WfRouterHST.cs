//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public abstract class WfRouter<H,S,T> : IWfRouter<S,T>
        where H : WfRouter<H,S,T>
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

        protected abstract void Execute(S src, out T dst);

        public Outcome Route(S src, out T dst)
        {
            using var flow = Wf.Running();

            try
            {
                Execute(src, out dst);
                return true;
            }
            catch(Exception e)
            {
                Wf.Error(e);
                dst = default;
                return e;
            }
        }
    }
}