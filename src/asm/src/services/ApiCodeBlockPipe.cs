//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    [ApiHost]
    public class ApiCodeBlockPipe : AppService<ApiCodeBlockPipe>
    {

        [Op]
        public uint Run(ApiHostBlocks src, Action<ApiCodeBlock> receiver)
        {
            var blocks = src.Blocks.View;
            var count = blocks.Length;
            var counter = 0u;

            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                receiver(block);
                counter++;
            }

            return counter;
        }
    }
}