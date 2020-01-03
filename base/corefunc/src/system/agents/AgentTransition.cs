//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct AgentStats
    {
        public int AgentCount;
    }

    /// <summary>
    /// Specifies a transition that occurred 
    /// </summary>
    public readonly struct AgentTransition
    {
        /// <summary>
        /// Specifies the agent that experienced the transition
        /// </summary>
        public readonly AgentIdentity Agent;

        /// <summary>
        /// Indicates the relative time at which the transition ocurred
        /// </summary>
        public readonly ulong Timestamp;
        
        /// <summary>
        /// Specifies the state of the agent before the transition
        /// </summary>
        public readonly AgentState SourceState;

        /// <summary>
        /// Specifies the state of the agent ater the transition
        /// </summary>
        public readonly AgentState TargetState;

        public AgentTransition(AgentIdentity Agent, ulong Timestamp, AgentState SourceState, AgentState TargetState)
        {
            this.Agent = Agent;
            this.Timestamp = Timestamp;
            this.SourceState = SourceState;
            this.TargetState = TargetState;
        }

        public override string ToString()
            => $"Agent {Agent}: {SourceState} -> {TargetState}";
    }
}