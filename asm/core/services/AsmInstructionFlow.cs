//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Root;

    readonly struct AsmInstructionFlow : IAsmInstructionWorkflow
    {
        public IAsmContext Context {get;}
        
        readonly IAsmInstructionSource Source;

        readonly AsmTriggerSet Triggers;

        [MethodImpl(Inline)]
        public static IAsmInstructionWorkflow Create(IAsmContext context, IAsmInstructionSource source, AsmTriggerSet triggers)
            => new AsmInstructionFlow(context, source, triggers);

        [MethodImpl(Inline)]
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