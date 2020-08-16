//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using Z0.Asm;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmOperandInfo operand(MemoryAddress @base, Instruction src, int index)
            => default;
    }
}