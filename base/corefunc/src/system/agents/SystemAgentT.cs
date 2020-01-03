//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines an agent with a type-specific configuration
    /// </summary>
    /// <typeparam name="C">The configuration type</typeparam>
    public abstract class SystemAgent<C> : SystemAgent, ISystemAgent<C>
    {
        protected SystemAgent(AgentContext Context, AgentIdentity Identity)
            : base(Context, Identity)
        {

        }
        
        protected abstract Task Configure(C config);

        async Task IAppService<C>.Configure(C config)
        {
            await Configure(config);
            OnConfigured(config);
        }

        void OnConfigured(C config)
        {
            Configured?.BeginInvoke(config, new AsyncCallback(x => {}), this);
        }

        public event Action<C> Configured;

        protected override sealed void OnConfigure(dynamic config)
            => (this as ISystemAgent<C>).Configure((C)config);
    }
}