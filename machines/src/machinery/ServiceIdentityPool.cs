//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Runtime.CompilerServices;
    
    using static root;

    public class ServiceIdentityPool
    {
        const uint FirstAgentId = 111;

        const uint FirstServerId = 222;

        /// <summary>
        /// Retrieves the next server-relative agent identity
        /// </summary>
        /// <param name="ServerId">The owning server</param>
        [MethodImpl(Inline)]
        public static AgentIdentity NextAgentId(uint ServerId)
            => (ServerId, TheOnly.Agents.AddOrUpdate(ServerId, _ => FirstAgentId, (_,v) => ++v));    

        /// <summary>
        /// Retrieves the next server id 
        /// </summary>
        public static uint NextServerId()
            => (uint)Interlocked.Increment(ref TheOnly.LastServerId);

        int LastServerId = (int)(FirstServerId - 1);
        
        static ServiceIdentityPool TheOnly = new ServiceIdentityPool();

        ConcurrentDictionary<uint,uint> Agents {get;}
            = new ConcurrentDictionary<uint, uint>();
        
        ServiceIdentityPool()
        {

        }
    }
}