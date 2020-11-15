//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines base type for event originators
    /// </summary>
    public abstract class SourcedEventEmitter : WorkflowAgent, IEventEmitter
    {
        protected SourcedEventEmitter(IAgentContext Context, AgentIdentity Identity)
            :base(Context,Identity)
        {

        }
    }
}