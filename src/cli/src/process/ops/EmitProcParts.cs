//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using static memory;
    using static Part;
    using static ProcessMemory;

    partial class ProcessContextPipe
    {
        public Index<ProcessPartition> EmitPartitions(Process process, FS.FilePath dst)
        {
            var summaries = partitions(Images.locate(process));
            EmitPartitions(summaries,dst);
            return summaries;
        }

        public Index<ProcessPartition> EmitPartitions(Process process, Timestamp ts)
        {
            var summaries = partitions(Images.locate(process));
            var dst = Paths.ProcessPartitionPath(process,ts);
            EmitPartitions(summaries,dst);
            return summaries;
        }

        public Count EmitPartitions(Index<ProcessPartition> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<ProcessPartition>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }

        [Op]
        public static Index<ProcessPartition> partitions(Index<LocatedImage> src)
        {
            var count = src.Count;
            var images = src.View;
            var buffer = alloc<ProcessPartition>(count);
            var summaries = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var image = ref skip(images, i);
                ref var dst = ref seek(summaries,i);
                dst.BaseAddress = image.BaseAddress;
                dst.EndAddress = image.EndAddress;
                dst.Size = image.Size;
                dst.ImageName = image.Name;

                if(i != 0)
                {
                    ref readonly var prior = ref skip(images, i - 1);
                    var gap = (ulong)(image.BaseAddress - prior.EndAddress);
                    dst.Gap = gap;
                }
            }

            return buffer;
        }
    }
}