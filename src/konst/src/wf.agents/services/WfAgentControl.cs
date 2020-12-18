//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class WfAgentControl : AgentControl<IWfAgentControl,IAgentContext>, IWfAgentControl
    {
        IAgentContext AgentContext;

        public WfAgentControl(IWfContext Context)
            : base(Context)
        {

        }

        void UpdateAgentContext(IAgentContext context)
        {
            this.AgentContext = context;
            SummaryStats = new AgentStats(context.Members.Count());
        }

        protected override async Task Configure(IAgentContext context)
            => await Task.Factory.StartNew(() => UpdateAgentContext(context));

        Task IWfAgentControl.Configure(IAgentContext context)
            => Configure(context);
    }
}