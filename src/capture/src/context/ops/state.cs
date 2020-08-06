//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static Flow;

    partial struct WfBuilder
    {
        /// <summary>
        /// Builds a default workflow state 
        /// </summary>
        /// <param name="root">The root context</param>
        /// <param name="ct">The token to confer to the constructed state</param>
        /// <param name="args">Process arguments</param>
        [MethodImpl(Inline), Op]
        public static WfState state(IAppContext root, CorrelationToken ct, string[] args)
        {                    
            var wfContext = Flow.context(root, ct, settings(root, ct), termsink(ct));                        
            return new WfState(wfContext, asm(root), args, ct);     
        }    
    }
}