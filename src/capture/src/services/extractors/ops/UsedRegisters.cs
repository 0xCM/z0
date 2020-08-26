//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Iced.Intel;

    using static Konst;

    using Iced = Iced.Intel;

    partial class IceExtractors
    {
        [MethodImpl(Inline)]
        public static UsedRegister[] UsedRegisters(Iced.InstructionInfo src)
            => src.GetUsedRegisters().Map(x => Deicer.Thaw(x));
    }
}