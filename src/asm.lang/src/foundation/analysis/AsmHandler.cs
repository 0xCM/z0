//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmHandler<H,I>
        where H : AsmHandler<H,I>, new()
        where I : struct, ITypedInstruction<I>
    {
        void Handle(I instruction);
    }

    public abstract class AsmHandler<H,I> : WfService<H>, IAsmHandler<H,I>
        where H : AsmHandler<H,I>, new()
        where I : struct, ITypedInstruction<I>
    {
        public abstract void Handle(I instruction);
    }
}