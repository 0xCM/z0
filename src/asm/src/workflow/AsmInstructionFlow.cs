//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    public readonly struct AsmInstructionFlow : IAsmInstructionFlow
    {        
        readonly AsmInstructionList[] Inxs;

        readonly AsmTriggerSet Triggers;

        [MethodImpl(Inline)]
        public static IAsmInstructionFlow Create(AsmInstructionList[] inxs, AsmTriggerSet triggers)
            => new AsmInstructionFlow(inxs, triggers);

        [MethodImpl(Inline)]
        AsmInstructionFlow(AsmInstructionList[] inxs, AsmTriggerSet triggers)
        {
            this.Inxs  = inxs;
            this.Triggers = triggers;
        }

        public IEnumerable<AsmInstructionList> Flow(IAsmInstructionPipe pipe)
        {
            for(var i=0; i<Inxs.Length; i++)
            {
                Triggers.FireOnMatch(Inxs[i]);
                yield return pipe.Flow(Inxs[i]);
            }
        }        
    }
}