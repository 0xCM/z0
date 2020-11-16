//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a means by which agents can be queried and directed
    /// </summary>
    public interface IWfAgentControl : IDisposable
    {
        AgentStats SummaryStats {get;}

        Task Configure(IAgentContext config);
    }

    public interface IWfAgentControl<S,C> : IWfAgentControl
        where S : IWfAgentControl
        where C : IAgentContext
    {
        Task Configure(C config);

        Task IWfAgentControl.Configure(IAgentContext context)
            => Configure(context);

        event Action<C> Configured;
    }
}