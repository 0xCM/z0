//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    public interface IAsmTrigger<S>
    {
        bool CanFire(in S src);

        void FireOnMatch(in S src);
    }

    public interface IAsmFxTrigger : IAsmTrigger<Instruction>
    {

    }

    public interface IAsmFxPipe
    {
        AsmFxList Flow(in AsmFxList fxList);
    }

    public interface IAsmFxFlow
    {
        AsmFxList[] Push(IAsmFxPipe fxPipe);
    }
}