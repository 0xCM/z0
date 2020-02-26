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

    using static zfunc;

    public class AsmTriggerSet : IAsmTriggerSet
    {
        public static AsmTriggerSet Empty => Define(array<IAsmFunctionTrigger>(), array<IAsmInstructionTrigger>());
            
        public static AsmTriggerSet Define(IEnumerable<IAsmFunctionTrigger> fTriggers, IEnumerable<IAsmInstructionTrigger> iTriggers)
            => new AsmTriggerSet(fTriggers, iTriggers);

        public static AsmTriggerSet Define(params IAsmInstructionTrigger[] iTriggers)
            => new AsmTriggerSet(array<IAsmFunctionTrigger>(), iTriggers);

        AsmTriggerSet(IEnumerable<IAsmFunctionTrigger> fTriggers, IEnumerable<IAsmInstructionTrigger> iTriggers)
        {
            FunctionTriggers = fTriggers.ToReadOnlyList();
            InstructionTriggers = iTriggers.ToReadOnlyList();
        }
        
        public IReadOnlyList<IAsmInstructionTrigger> InstructionTriggers {get;}

        public IReadOnlyList<IAsmFunctionTrigger> FunctionTriggers {get;}

        public bool IsEmpty 
            => InstructionTriggers.Count == 0 && FunctionTriggers.Count == 0;

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