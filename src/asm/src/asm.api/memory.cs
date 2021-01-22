//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmRegMemory memory(RegisterKind @base, AsmDisplacement dx, MemoryScale scale)
            => new AsmRegMemory(@base, dx, scale);
    }
}