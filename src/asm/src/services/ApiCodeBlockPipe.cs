//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Threading;

    using static Part;
    using static memory;

    [ApiHost]
    public class ApiCodeBlockPipe : WfService<ApiCodeBlockPipe>
    {
        [Op]
        public uint Run(ApiBlockIndex src, Action<ApiCodeBlock> receiver)
        {
            var hosts = src.Hosts.View;
            var count = hosts.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var code = src.HostCodeBlocks(host);
                counter += Run(code, receiver);
            }
            return counter;
        }

        [Op]
        public uint Run(ApiBlockIndex src, Action<ApiHostCode> receiver)
        {
            var hosts = src.Hosts.View;
            var count = hosts.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var code = src.HostCodeBlocks(host);
                receiver(code);
                counter += code.Blocks.Count;
            }
            return counter;
        }

        [Op]
        public uint Run(ApiHostCode src, Action<ApiCodeBlock> receiver)
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