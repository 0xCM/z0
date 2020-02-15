//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    using static zfunc;


    /// <summary>
    /// Defines a means by which agents can be queried and directed
    /// </summary>
    public interface IAgentControl : IDisposable
    {
        AgentStats SummaryStats {get;}        

        Task Configure(IAgentContext config);

    }

    public interface IAgentControl<S,C> : IAgentControl
        where S : IAgentControl
        where C : IAgentContext
    {
        ServiceDesignator ServiceId
            => new ServiceDesignator(typeof(S), AppServiceAttribute.GetLabel(GetType()));

        Task Configure(C config);

        Task IAgentControl.Configure(IAgentContext context)
            => Configure(context);

        event Action<C> Configured;
        
    }
}