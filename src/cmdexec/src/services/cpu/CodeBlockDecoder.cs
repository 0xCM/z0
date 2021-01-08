//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static z;

    public readonly struct CodeBlockDecoder
    {
        public static void decode(PartId part, HostBlockDecoder decoder, in ApiCodeBlockIndex src, ref ApiPartRoutines dst)
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

        public static AsmInstructions[] decode(params ApiCodeBlock[] src)
        {
            var count = src.Length;
            var dst = alloc<AsmInstructions>(count);
            decode(src, dst);
            return dst;
        }

        public static int decode(ReadOnlySpan<ApiCodeBlock> src, Span<AsmInstructions> dst)
        {
            var decoder = Capture.Services.RoutineDecoder();
            var count = src.Length;
            for(var i=0u; i<count; i++)
                 seek(dst,i) = decoder.Decode(skip(src,i)).ValueOrDefault(AsmInstructions.Empty);
            return count;
        }

        public static AsmInstructions[] decode(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = alloc<AsmInstructions>(count);
            decode(src, dst);
            return dst;
        }
    }
}