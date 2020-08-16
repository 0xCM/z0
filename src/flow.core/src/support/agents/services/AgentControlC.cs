//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public abstract class AgentControl<S,C> : IAgentControl<S,C>
        where S : IAgentControl
        where C : IAgentContext         
    {
        protected AgentControl(IAppBase context)
        {
            Context = context;
        }

        public AgentStats SummaryStats {get; protected set;}

        public IAppBase Context {get;}

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

}