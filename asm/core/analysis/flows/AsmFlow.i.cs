//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;

    public interface IAsmTrigger
    {
        int Id {get;}
    }

    public interface IAsmTrigger<S> : IAsmTrigger
    {
        bool CanFire(S src);

        void FireOnMatch(S src);
    }
    public interface IAsmInstructionTrigger : IAsmTrigger<Instruction>
    {

    }

    public interface IAsmTriggerSet
    {
        void FireOnMatch(AsmInstructionList instructions);
        
        void FireOnMatch(AsmFunction function);
    }
    public interface IAsmInstructionPipe
    {
        AsmInstructionList Flow(AsmInstructionList instruction);
    }

    public interface IAsmInstructionFlow
    {
        IEnumerable<AsmInstructionList> Flow(IAsmInstructionPipe pipe);
    }

    public interface IAsmFunctionTrigger : IAsmTrigger<AsmFunction>
    {
        
    }

    public interface IAsmInstructionSource
    {
        IEnumerable<AsmInstructionList> Instructions {get;}
    }
}

