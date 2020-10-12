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

    using static Konst;
    using static z;

    public delegate ApiHostRoutines HostBlockDecoder(in ApiHostCodeBlocks blocks);

    public readonly struct CaptureIndexBuilder
    {
        public static void DecodePart(PartId part, HostBlockDecoder decoder, in ApiCodeBlockIndex src, ref ApiPartRoutines dst)
        {
            var hosts = @readonly(src.Hosts.Where(h => h.Owner == part));
            var count = hosts.Length;
            var buffer = alloc<ApiHostRoutines>(count);
            ref var _dst = ref first(span(buffer));
            for(var j=0; j<count; j++)
            {
                ref readonly var host = ref skip(hosts,j);
                var blocks = src[host];
                var decoded = decoder(blocks);
                seek(_dst,j) = decoded;
            }
            dst = new ApiPartRoutines(part, buffer);
        }

        public static ApiHostRoutines DecodeBlocks(IAsmDecoder decoder, in ApiHostCodeBlocks blocks)
        {
            var instructions = list<ApiRoutineObsolete>();
            var ip = MemoryAddress.Empty;
            var target = list<Instruction>();
            var count = blocks.Length;

            for(var i=0; i<count; i++)
            {
                target.Clear();

                ref readonly var block = ref blocks[i];
                decoder.Decode(block, x => target.Add(x));

                if(i == 0)
                    ip = target[0].IP;

                instructions.Add(AsmProjections.project(ip, block, target.ToArray()));
            }

            return new ApiHostRoutines(blocks.Host, instructions.ToArray());
        }
    }
}