//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;
    
    public class AsmWorkflowContext : AsmContext, IAsmWorkflowContext
    {
        public new IPolyrand Random {get;} 

        public static IAsmWorkflowContext Rooted(IComposedApiContext composed, IPolyrand random, AsmFormatConfig format = null)
            => new AsmWorkflowContext(composed, random, AsmContextData.New(composed.Compostion, format ?? AsmFormatConfig.New, composed.Settings, random));
        
        AsmWorkflowContext(IAppContext root, IPolyrand random, AsmContextData state)
            : base(root, state)
        {
            Random = random;            
        }
    }
}