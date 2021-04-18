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

    partial class ProcessContextPipe
    {
        public FS.FileName ProcPartHashFile(string process, Timestamp ts, Identifier subject)
            => FS.file(string.Format("{0}.{1}.{2}.hashes", Tables.tableid<ProcessPartition>(), process, ts.Format()), FS.Csv);

        public FS.FilePath ProcPartHashPath(FS.FolderPath dst, string process, Timestamp ts, Identifier subject)
            => dst + ProcPartHashFile(process, ts, subject);

        public FS.FileName ProcPartFile(Process process, Timestamp ts)
            => FS.file(string.Format("{0}.{1}.{2}", Tables.tableid<ProcessPartition>(), process.ProcessName, ts.Format()), FS.Csv);

        public FS.FilePath ProcPartPath(FS.FolderPath dst, Process process, Timestamp ts)
            => dst + ProcPartFile(process,ts);

        public Index<ProcessPartition> EmitProcParts(Process process, FS.FilePath dst)
        {
            var summaries = procparts(ImageRecords.locate(process));
            EmitProcParts(summaries,dst);
            return summaries;
        }

        public Count EmitProcParts(Index<ProcessPartition> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<ProcessPartition>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }

        [Op]
        public static Index<ProcessPartition> procparts(Index<LocatedImage> src)
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