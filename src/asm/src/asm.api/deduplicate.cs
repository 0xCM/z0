//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;

    partial struct asm
    {
        [Op]
        public static ApiInstructionLookup deduplicate(ApiInstruction[] src, out ApiInstructionDuplication stats)
        {
            var count = (uint)src.Length;
            var lookup = new ApiInstructionLookup((int)count);
            var success = 0u;
            var fail = 0u;
            var source = sys.span(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var located = ref z.skip(source,i);
                if(lookup.TryAdd(located.IP, located))
                    success++;
                else
                    fail++;
            }

            stats = new ApiInstructionDuplication(success, fail);
            return lookup;
        }
    }
}