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
        readonly IAsmInstructionSource Source;

        readonly AsmTriggerSet Triggers;

        [MethodImpl(Inline)]
        public static IAsmInstructionFlow Create(IAsmInstructionSource source, AsmTriggerSet triggers)
            => new AsmInstructionFlow(source, triggers);

        [MethodImpl(Inline)]
        AsmInstructionFlow(IAsmInstructionSource source, AsmTriggerSet triggers)
        {
            this.Source  = source;
            this.Triggers = triggers;
        }

        public IEnumerable<AsmInstructionList> Flow(IAsmInstructionPipe pipe)
        {
            foreach(var i in Source.Instructions)
            {
                Triggers.FireOnMatch(i);
                yield return pipe.Flow(i);
            }            
        }        
    }
}