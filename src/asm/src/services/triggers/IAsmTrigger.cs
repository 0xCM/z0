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
    
    }

    public interface IAsmTrigger<S> : IAsmTrigger
    {
        bool CanFire(in S src);

        void FireOnMatch(in S src);
    }
    
    public interface IInstructionTrigger : IAsmTrigger<Instruction>
    {

    }

    public interface IInstructionPipe
    {
        AsmInstructionList Flow(in AsmInstructionList instruction);
    }

    public interface IAsmInstructionFlow : IService
    {
        IEnumerable<AsmInstructionList> Flow(IInstructionPipe pipe);

        AsmInstructionList[] Push(IInstructionPipe pipe); 
    }
}