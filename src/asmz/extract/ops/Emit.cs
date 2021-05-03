//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    using api = ApiExtraction;

    partial class ApiExtractor
    {
        uint Emit(ReadOnlySpan<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            var blocks = alloc<MemoryBlock>(count);
            var found = api.terminals(src, blocks);
            var packed = CodeBlocks.pack(blocks);
            HexPacks.Emit(packed, dst);
            Wf.Status(string.Format("Identified {0} terminals from {1} methods", found, count));
            return count;
        }

        uint Emit(ReadOnlySpan<ApiMemberExtract> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;
            var packed = CodeBlocks.pack(src);
            HexPacks.Emit(packed, dst);
            return count;
        }

        uint Emit(ReadOnlySpan<AsmRoutine> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                if(block.IsNonEmpty)
                    writer.Write(Formatter.Format(block));
            }
            Wf.EmittedFile(flow,count);

            return count;
        }
    }
}