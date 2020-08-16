//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IAsmFxTriggerSet
    {
        void FireOnMatch(in AsmFxList instructions);
        
        void FireOnMatch(in AsmRoutine function);
    }
}