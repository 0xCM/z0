//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static ApiRoutine routine(MemoryAddress @base, ApiHex uriCode, Instruction[] src)
            => new ApiRoutine(@base, ApiInstruction.map(uriCode, src));
    }
}