//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Characterizes a volitionless set of operations with shared state that are invoked upon demand
    /// </summary>
    public interface IAppService : IDisposable
    {
        
    }


    /// <summary>
    /// Characterizes an application service that supports parametric configuration
    /// </summary>
    /// <typeparam name="TConfig">The configuration type</typeparam>
    public interface IAppService<TConfig> : IAppService
    {
        Task Configure(TConfig config);

        event Action<TConfig> Configured;
    }

    /// <summary>
    /// Characterizes a thread of control with independent volition
    /// </summary>
    public interface ISysemAgent : IAppService
    {
        /// <summary>
        /// Identifies the server on which the agent is executing
        /// </summary>
        uint ServerId {get;}

        /// <summary>
        /// Identifies the agent relative to the hosting server
        /// </summary>
        uint AgentId {get;}            
        
        /// <summary>
        /// Starts agent execution
        /// </summary>
        Task Start();

        /// <summary>
        /// Stops agent execution
        /// </summary>
        Task Stop();

        /// <summary>
        /// The agent state
        /// </summary>
        AgentState State {get;}

        /// <summary>
        /// Signals when the agents transitions from its current state to a different state
        /// </summary>
        event OnAgentTransition StateChanged;

        /// <summary>
        /// The global agent identity
        /// </summary>
        /// <param name="agent">The agent</param>
        AgentIdentity Identity
            => (ServerId, AgentId);
    }

    public interface ISystemAgent<C> : ISysemAgent, IAppService<C>
    {
        
    }

    public interface IAgentEventSink
    {
        void Pulse(PulseEvent e);
        
        void AgentTransitioned(AgentTransition data);
    }

    public interface IAgentContext : IContext
    {
        IEnumerable<ISysemAgent> Memberhsip {get;}   

        IAgentEventSink EventLog {get;}        
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


    [AttributeUsage(AttributeTargets.Class)]
    public class AppServiceAttribute : Attribute
    {
        public static string GetLabel(Type host)
            => host.CustomAttribute<AppServiceAttribute>().TryMap(x => x.Label).ValueOrDefault(string.Empty);
            
        public AppServiceAttribute(string Label = null)
        {
            this.Label = Label ?? string.Empty;
        }

        public string Label {get;}
    }
}