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
        public static InstructionInfo FxInfo(Iced.Instruction src)
            => Deicer.Thaw(src.GetInfo());

    }
}