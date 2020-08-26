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
        public static UsedMemory[] UsedMemory(Iced.InstructionInfo src)
            => src.GetUsedMemory().Map(x => Deicer.Thaw(x));
    }
}