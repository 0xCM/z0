//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static zfunc;

    public interface IContext
    {
        /// <summary>
        /// Takes messages from the context queue, and appends an optional number of messages to the result
        /// </summary>
        /// <param name="addenda">The messages to append, if any</param>
        /// <returns>Returns the dequeued messages concatenated with any addenda</returns>
        IReadOnlyList<AppMsg> DequeueMessages(params AppMsg[] addenda);

        /// <summary>
        /// Takes messages from the context queue, appends an optional number of messages to the result, 
        /// and finally, pushes the joined messages through the context output channel(s) as a a transactional
        /// block
        /// </summary>
        /// <param name="addenda">Additional mesages to enqueue prior to emission</param>
        void EmitMessages(params AppMsg[] addenda)
        {
            var messages = DequeueMessages(addenda);
            Terminal.Get().WriteMessages(messages);
            log(messages, LogArea.Test);            
        }


        /// <summary>
        /// Defines the context-specific RNG
        /// </summary>
        IPolyrand Random {get;}

    }

    public interface IAppService : IDisposable
    {
        Task Configure(dynamic config);
        
    }

    public interface IAppService<TConfig> : IAppService
    {
        Task Configure(TConfig config);

        event Action<TConfig> Configured;

    }

    public interface IServiceAgent : IAppService
    {
        uint ServerId {get;}

        uint AgentId {get;}            
        
        Task Start();

        Task Stop();

        AgentState State {get;}

        /// <summary>
        /// Signals when the agents transitions from its current state to a different state
        /// </summary>
        event OnAgentTransition StateChanged;

        /// <summary>
        /// Specifies the identiy of an agent
        /// </summary>
        /// <param name="agent">The agent</param>
        AgentIdentity Identity
            => (ServerId, AgentId);

    }

    public interface IServiceAgent<C> : IServiceAgent, IAppService<C>
    {
        
    }
    
    public interface IAgentContext : IContext
    {
        IEnumerable<IServiceAgent> Memberhsip {get;}   

        ISystemEvents EventLog {get;}        
    }
    
    /// <summary>
    /// Defines a means by which agents can be queried and directed
    /// </summary>
    public interface IAgentControl : IAppService<IAgentContext>
    {
        AgentStats SummaryStats {get;}        
    }

    public interface IAppService<TContract,TConfig> : IAppService<TConfig>
    {
        ServiceDesignator ServiceId
            => new ServiceDesignator(typeof(TContract), AppServiceAttribute.GetLabel(GetType()));
    }

    public delegate void OnAgentTransition(in AgentTransition transition);


    public interface ISystemEvents
    {
        void Pulse(PulseEvent e);
        
        void AgentTransitioned(AgentTransition data);
    }

}