//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Z0.Asm;

    using static Root;

    public class AsmWorkflowContext : AsmContext, IAsmWorkflowContext
    {
        public static IAsmWorkflowContext Rooted(IComposedContext composed, AsmFormatConfig format = null)
            => new AsmWorkflowContext(composed, AsmContextData.New(composed.Compostion, format));
        
        AsmWorkflowContext(IContext root, AsmContextData state)
            : base(root, state)
        {

        }
    }

}