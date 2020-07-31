//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using Z0.Asm;

    using static Option;

    partial class XTend
    {
        public static void Running(this IAppContext context, string worker)
            => context.Deposit(new StepExecuting(worker));

        public static void Running(this IAppContext context, string worker, string detail)
            => context.Deposit(new StepExecuting(worker, detail));

        public static void Running(this IAsmContext context, string worker)
            => context.Deposit(new StepExecuting(worker));

        public static void Running(this IAsmContext context, string worker, string detail)
            => context.Deposit(new StepExecuting(worker, detail));

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