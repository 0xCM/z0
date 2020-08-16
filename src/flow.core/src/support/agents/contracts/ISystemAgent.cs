//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Characterizes a thread of control with independent volition
    /// </summary>
    public interface ISystemAgent : IDisposable
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
        AgentStatus State {get;}

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
}