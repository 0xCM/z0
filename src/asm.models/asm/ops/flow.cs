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
    using static z;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmFxFlow flow(AsmFxList[] fxList, in AsmTriggerSet triggers, params AsmFxHandler[] handlers)
            => new AsmFxFlow(fxList, triggers, handlers);
    }
}