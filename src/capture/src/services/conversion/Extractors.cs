//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Iced = Iced.Intel;

    static class ZAsmExtractors
    {
        [MethodImpl(Inline)]
        public static Func<UsedMemory[]> UsedMemory(Iced.InstructionInfo src)
            => () => src.ExtractZAsmUsedMemory();

        [MethodImpl(Inline)]
        public static Func<UsedRegister[]> UsedRegisters(Iced.InstructionInfo src)
            => () => src.GetUsedRegisters().Map(x => x.ToZAsm());

        [MethodImpl(Inline)]
        public static Func<InstructionInfo> InstructionInfo(Iced.Instruction src)
            => () => src.GetInfo().ToZAsm();

        [MethodImpl(Inline)]
        public static Func<OpAccess[]> OpAccess(Iced.InstructionInfo src)
            => () => src.ExtractZAsmOpAccess();
        
        [MethodImpl(Inline)]
        public static Func<AsmFlowInfo> FlowInfo(Iced.Code src)    
            => () => src.ExtractFlowInfo();
    }
}