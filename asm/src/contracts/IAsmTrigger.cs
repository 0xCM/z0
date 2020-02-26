//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
 
    using Z0.Asm;

    using static zfunc;

    public interface IAsmTrigger
    {
        int Id {get;}
    }

    public interface IAsmTrigger<S> : IAsmTrigger
    {
        bool CanFire(S src);

        void FireOnMatch(S src);
    }

    public interface IAsmFunctionTrigger : IAsmTrigger<AsmFunction>
    {
        
    }

    public interface IAsmInstructionTrigger : IAsmTrigger<Instruction>
    {

    }
}