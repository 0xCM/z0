//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct InstructionTests
    {
        public static bool IsRelCall(Instruction src, W32 w)
            => src.Code == OpCodeId.Call_rel32_32;

    }
}