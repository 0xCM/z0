//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    readonly struct AsmInstructionFlow : IAsmInstructionFlow
    {
        public IAsmContext Context {get;}
        
        readonly IAsmInstructionSource Source;

        readonly AsmTriggerSet Triggers;

        public static IAsmInstructionFlow Create(IAsmContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => new AsmInstructionFlow(context, source, triggers);

        AsmInstructionFlow(IAsmContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
        {
            this.Context = context;
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