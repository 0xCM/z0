//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static z;

    public delegate ApiHostRoutines HostBlockDecoder(in ApiHostCode blocks);

    public readonly struct CodeBlockDecoder
    {
        public static void decode(PartId part, HostBlockDecoder decoder, in ApiCodeBlocks src, ref ApiPartRoutines dst)
        {
            var hosts = src.Hosts.Where(h => h.Owner == part).View;
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

        public static AsmInstructionBlock[] decode(params ApiCodeBlock[] src)
        {
            var count = src.Length;
            var dst = alloc<AsmInstructionBlock>(count);
            decode(src, dst);
            return dst;
        }

        public static int decode(ReadOnlySpan<ApiCodeBlock> src, Span<AsmInstructionBlock> dst)
        {
            var decoder = Capture.Services.RoutineDecoder();
            var count = src.Length;
            for(var i=0u; i<count; i++)
                 seek(dst,i) = decoder.Decode(skip(src,i)).ValueOrDefault(AsmInstructionBlock.Empty);
            return count;
        }

        public static AsmInstructionBlock[] decode(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = alloc<AsmInstructionBlock>(count);
            decode(src, dst);
            return dst;
        }
    }
}