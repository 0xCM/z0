//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmTriggerSet : IAsmTriggerSet, INullary<AsmTriggerSet>
    {
        public static AsmTriggerSet Empty => Define(array<IAsmFunctionTrigger>(), array<IAsmInstructionTrigger>());
                    
        [MethodImpl(Inline)]
        public static AsmTriggerSet Define(IEnumerable<IAsmFunctionTrigger> fTriggers, IEnumerable<IAsmInstructionTrigger> iTriggers)
            => new AsmTriggerSet(fTriggers, iTriggers);

        [MethodImpl(Inline)]
        public static AsmTriggerSet Define(params IAsmInstructionTrigger[] iTriggers)
            => new AsmTriggerSet(array<IAsmFunctionTrigger>(), iTriggers);

        [MethodImpl(Inline)]
        AsmTriggerSet(IEnumerable<IAsmFunctionTrigger> fTriggers, IEnumerable<IAsmInstructionTrigger> iTriggers)
        {
            FunctionTriggers = fTriggers.ToReadOnlyList();
            InstructionTriggers = iTriggers.ToReadOnlyList();
        }
        
        public IReadOnlyList<IAsmInstructionTrigger> InstructionTriggers {get;}

        public IReadOnlyList<IAsmFunctionTrigger> FunctionTriggers {get;}

        public bool IsEmpty 
            => InstructionTriggers.Count == 0 && FunctionTriggers.Count == 0;
        
        AsmTriggerSet INullary<AsmTriggerSet>.Empty 
            => Empty;

        public void FireOnMatch(AsmInstructionList instructions)
        {
            iter(InstructionTriggers, trigger =>  iter(instructions, i => trigger.FireOnMatch(i)));
        }

        public void FireOnMatch(AsmFunction f)
        {
            iter(FunctionTriggers, trigger => trigger.FireOnMatch(f));
        }
    }
}