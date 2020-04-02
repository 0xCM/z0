//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Core;

    public static class AgentX
    {
        /// <summary>
        /// Searches a context for an active agent wth a specified identity
        /// </summary>
        /// <param name="context">The context to search</param>
        /// <param name="identity">The identity to match</param>
        public static Option<ISystemAgent> Agent(this IAgentContext context, AgentIdentity identity)
        {
            var agent = context.Memberhsip.FirstOrDefault(a => a.AgentId == identity.AgentId && a.ServerId == identity.ServerId);
            return agent != null ? some(agent) : none<ISystemAgent>();
        }
    }
}