//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Iced = Iced.Intel;

    partial class IceExtractors
    {
        [MethodImpl(Inline)]
        public static Func<UsedMemory[]> UsedMemoryDefer(Iced.InstructionInfo src)
            => () => UsedMemory(src);


        [MethodImpl(Inline)]
        public static Func<UsedRegister[]> UsedRegistersDefer(Iced.InstructionInfo src)
            => () => src.GetUsedRegisters().Map(x => Deicer.Thaw(x));

        [MethodImpl(Inline)]
        public static Func<InstructionInfo> InxsInfoDefer(Iced.Instruction src)
            => () => FxInfo(src);

        [MethodImpl(Inline)]
        public static Func<OpAccess[]> OpAccessDefer(Iced.InstructionInfo src)
            => () => OpAccess(src);

        [MethodImpl(Inline)]
        public static Func<AsmFlowInfo> FlowInfoDefer(Iced.Code src)
            => () => FxFlow(src);

        static IceConversion Deicer => IceConversion.Service;
    }
}