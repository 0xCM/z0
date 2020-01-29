//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

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

        /// <summary>
        /// Creates a flow over an operation catalog
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        public static IAsmFunctionFlow Flow(this IAsmContext src, IOperationCatalog catalog)
            => AsmFunctionFlow.Create(src,catalog);        

        /// <summary>
        /// Creates a flow over an operation catalog
        /// </summary>
        /// <param name="context">The context within which the flow will be created</param>
        /// <param name="source">The instruction source</param>
        /// <param name="triggers">The triggers that fire when functions satisfy criterea of interest</param>
        public static IAsmFunctionFlow Flow(this IAsmContext src, IOperationCatalog catalog, AsmTriggerSet triggers)
            => AsmFunctionFlow.Create(src,catalog, triggers);        
    }
}