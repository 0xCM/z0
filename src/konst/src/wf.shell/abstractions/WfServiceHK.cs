//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [WfService]
    public abstract class WfService<H,K> : WfService<H>, IWfService<H,K>
        where H : WfService<H,K>, new()
    {
        public override Type ContractType => typeof(K);

        protected WfService()
        {

        }

        protected WfService(IWfShell wf)
            : base(wf)
        {

        }
    }
}