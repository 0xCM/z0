//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;

    using static memory;
    using static Part;

    public sealed class ApiInstructionLookup : Dictionary<MemoryAddress,ApiInstruction>
    {
        public static ApiInstructionLookup create(ApiInstruction[] src, out ApiInstructionDuplication stats)
        {
            var count = (uint)src.Length;
            var lookup = new ApiInstructionLookup((int)count);
            var success = 0u;
            var fail = 0u;
            var source = sys.span(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var located = ref skip(source,i);
                if(lookup.TryAdd(located.IP, located))
                    success++;
                else
                    fail++;
            }

            stats = new ApiInstructionDuplication(success, fail);
            return lookup;
        }

        [MethodImpl(Inline)]
        public ApiInstructionLookup(int capacity)
            : base(capacity)
        {

        }
    }
}