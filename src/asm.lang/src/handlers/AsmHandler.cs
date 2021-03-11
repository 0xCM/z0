//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static AsmInstructions;

    public interface IAsmHandler<H,I>
        where H : AsmHandler<H,I>, new()
        where I : struct, IAsmInstruction<I>
    {
        void Handle(I instruction);
    }

    public abstract class AsmHandler<H,I> : WfService<H>, IAsmHandler<H,I>
        where H : AsmHandler<H,I>, new()
        where I : struct, IAsmInstruction<I>
    {
        public abstract void Handle(I instruction);
    }
}