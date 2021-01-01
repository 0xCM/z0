//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfService]
    public abstract class WfService<H,K,C> : WfService<H>, IWfService<H,K>
        where H : WfService<H,K,C>, new()
    {
        public override Type ContractType => typeof(K);

        protected C Context {get; private set;}

        /// <summary>
        /// Creates and initializes the service
        /// </summary>
        /// <param name="wf">The source workflow</param>
        public static H init(IWfShell wf, C context)
        {
            var service = create();
            service.Context = context;
            service.Init(wf);
            return service;
        }

        protected WfService()
        {

        }

        protected WfService(IWfShell wf, C context)
            : base(wf)
        {

        }
    }
}