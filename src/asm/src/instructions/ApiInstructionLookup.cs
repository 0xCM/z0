//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static z;

    public sealed class ApiInstructionLookup : Dictionary<MemoryAddress, ApiInstruction>
    {
        [MethodImpl(Inline)]
        public ApiInstructionLookup(int capacity)
            : base(capacity)
        {

        }
    }
}