//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using Iced.Intel;
    

    using static Seed;

    using Iced = Iced.Intel;

    static partial class AsmSpecConversion
    {        
        [MethodImpl(Inline)]
        public static InstructionInfo ExtractZInfo(this Iced.Instruction src)
            => src.GetInfo().ToZAsm();

        [MethodImpl(Inline)]
        public static UsedMemory[] ExtractZAsmUsedMemory(this Iced.InstructionInfo src)
            => src.GetUsedMemory().Map(x => x.ToZAsm());

        [MethodImpl(Inline)]
        public static UsedRegister[] ExtractUsedRegisters(this Iced.InstructionInfo src)
            => src.GetUsedRegisters().Map(x => x.ToZAsm());

        [MethodImpl(Inline)]
        public static OpAccess[] ExtractZAsmOpAccess(this Iced.InstructionInfo src)
            => Memories.array(
                    src.Op0Access.ToZAsm(), 
                    src.Op0Access.ToZAsm(), 
                    src.Op2Access.ToZAsm(), 
                    src.Op3Access.ToZAsm(), 
                    src.Op4Access.ToZAsm()).Where(x => x != OpAccess.None);

        public static AsmFlowInfo ExtractFlowInfo(this Iced.Code src)    
            => new AsmFlowInfo
            {
                Code = src.ToZAsm(), 
                ConditionCode = src.GetConditionCode().ToZAsm(),
                IsStackInstruction = src.IsStackInstruction(), 
                FlowControl = src.FlowControl().ToZAsm(),
                IsJccShortOrNear = src.IsJccShortOrNear(),
                IsJccNear = src.IsJccNear(),
                IsJccShort = src.IsJccShort(),
                IsJmpShort = src.IsJmpShort(),
                IsJmpNear = src.IsJmpNear(),
                IsJmpShortOrNear = src.IsJmpShortOrNear(),
                IsJmpFar = src.IsJmpFar(),
                IsCallNear = src.IsCallNear(),
                IsCallFar = src.IsCallFar(),
                IsJmpNearIndirect = src.IsJmpNearIndirect(),
                IsJmpFarIndirect = src.IsJmpFarIndirect(),
                IsCallNearIndirect = src.IsCallNearIndirect(),
                IsCallFarIndirect = src.IsCallFarIndirect()                
            };
    }
}