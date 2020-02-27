//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public static class AsmTriggerExtensions
    {
        /// <summary>
        /// Creates a flow over an instruction source
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when instructions satisfy criterea of interest</param>
        public static IAsmInstructionFlow Flow(this IAsmContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => AsmInstructionFlow.Create(context, source, triggers);
    }
}