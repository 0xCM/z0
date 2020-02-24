//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using static zfunc;

    public abstract class AgentControl<S,C> : IAgentControl<S,C>
        where S : IAgentControl
        where C : IAgentContext         
    {
        protected AgentControl(IRngContext AppContext)
        {
            this.Context = AppContext;
        }

        public AgentStats SummaryStats {get; protected set;}

        public IRngContext Context {get;}

        public event Action<C> Configured;

        protected abstract Task Configure(C config);

        async Task IAgentControl<S,C>.Configure(C config)
        {
            await Configure(config);
            OnConfigured(config);
        }

        void OnConfigured(C context)
        {
            Configured?.BeginInvoke(context, new AsyncCallback(x => {}), this);
        }

        public async Task Configure(dynamic config)
        {
            await Configure((C)config);
        }

        protected virtual void OnConfigure(dynamic config) {}        

        public virtual void Dispose() {}
    }

    public class AgentControl : AgentControl<IAgentControl,IAgentContext>, IAgentControl
    {
        public static IAgentControl FromContext(IRngContext Context)
            => new AgentControl(Context);
        
        public AgentControl(IRngContext Context)
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