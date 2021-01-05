//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [WfService]
    public abstract class WfService<H> : IWfService<H>
        where H : WfService<H>, new()
    {
        /// <summary>
        /// Instantites the serice without initialization
        /// </summary>
        [MethodImpl(Inline)]
        public static H create() => new H();

        /// <summary>
        /// Creates and initializes the service
        /// </summary>
        /// <param name="wf">The source workflow</param>
        public static H init(IWfShell wf)
        {
            var service = create();
            service.Init(wf);
            return service;
        }

        IWfEventCache Events {get; set;}

        public IWfShell Wf {get; private set;}

        protected WfHost Host {get; private set;}

        protected IWfDb Db {get; private set;}

        public abstract Type ContractType {get;}

        protected CmdBuilder CmdBuilder => Wf.CmdBuilder();

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(typeof(H));
            Wf = wf.WithHost(Host);
            Db = wf.Db();
            Events = EventCache.init(wf);

            OnInit();
        }

        protected WfService()
        {

        }

        protected WfService(IWfShell wf)
        {
            Host = WfShell.host(typeof(H));
            Wf = wf.WithHost(Host);
        }

        protected virtual void OnInit() {}

        public virtual void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}