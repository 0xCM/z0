//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Base type for event type-specific event originators
    /// </summary>
    public abstract class EventEmitter<E> : SourcedEventEmitter
    {
        protected EventEmitter(AgentContext Context, AgentIdentity Identity)
            :base(Context,Identity)
        {
            
        }

    }
}