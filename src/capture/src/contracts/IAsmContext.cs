//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines a nexus of shared state and services for assembly-related services
    /// </summary>
    public interface IAsmContext : IMessageQueue, IPolyrandProvider
    {
        /// <summary>
        /// The root of this context
        /// </summary>
        IAppContext ContextRoot {get;}

        IMessageQueue MessageQueue
            => ContextRoot.MessageQueue;
    }
}