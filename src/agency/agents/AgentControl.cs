//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;


    public class AgentControl : AgentControl<IAgentControl,IAgentContext>, IAgentControl
    {
        public static IAgentControl FromContext(IAppEnv Context)
            => new AgentControl(Context);
        
        public AgentControl(IAppEnv Context)
            : base(Context)
        {

        }

        IAgentContext AgentContext;        

        void UpdateAgentContext(IAgentContext context)
        {
            this.AgentContext = context;
            SummaryStats = new AgentStats(context.Memberhsip.Count());
        }

        protected override async Task Configure(IAgentContext context)
        {
            await Task.Factory.StartNew(() => UpdateAgentContext(context));
        }

        Task IAgentControl.Configure(IAgentContext context)
            => Configure(context);
    }
}