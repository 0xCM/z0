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
    /// Defines base type for event originators
    /// </summary>
    public abstract class EventEmitter : SystemAgent, IEventEmitter
    {        
        protected EventEmitter(AgentContext Context, AgentIdentity Identity)
            :base(Context,Identity)
        {
            
        }
    }

    /// <summary>
    /// Base type for event type-specific event originators
    /// </summary>
    public abstract class EventEmitter<E> : EventEmitter
    {
        protected EventEmitter(AgentContext Context, AgentIdentity Identity)
            :base(Context,Identity)
        {
            
        }
    }
}