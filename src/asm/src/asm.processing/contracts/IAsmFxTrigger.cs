//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmTrigger<S>
    {
        bool CanFire(in S src);

        void FireOnMatch(in S src);
    }

    public interface IAsmFxTrigger : IConditionTest<IceInstruction>
    {
        void TryFire(in IceInstruction src);
    }

    public interface IAsmPipe
    {
        IceInstructionList Flow(in IceInstructionList fxList);
    }

}