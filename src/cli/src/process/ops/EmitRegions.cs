//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using static Images;

    partial class ProcessContextPipe
    {
        public FS.FileName MemoryRegionHashFile(string process, Timestamp ts, Identifier subject)
            => FS.file(string.Format("memory.hash.detail.{0}.{1}", process, ts.Format()), FS.Csv);

        public FS.FileName MemoryRegionFile(Process process, Timestamp ts)
            => FS.file(string.Format("{0}.{1}.{2}", Tables.tableid<MemoryRegion>(), process.ProcessName, ts.Format()), FS.Csv);

        public FS.FilePath MemoryRegionPath(FS.FolderPath dst, Process process, Timestamp ts)
            => dst + MemoryRegionFile(process, ts);

        public FS.FilePath MemoryRegionHashPath(FS.FolderPath dst, string process, Timestamp ts, Identifier subject)
            => dst + MemoryRegionHashFile(process, ts, subject);

        public Index<MemoryRegion> EmitRegions(Process process, FS.FilePath dst)
        {
            var regions = SystemMemory.regions(process);
            EmitRegions(regions,dst);
            return regions;
        }

        public Index<MemoryRegion> EmitRegions(FS.FilePath dst)
        {
            var regions = SystemMemory.regions();
            EmitRegions(regions,dst);
            return regions;
        }

        public Count EmitRegions(Index<MemoryRegion> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<MemoryRegion>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
            return count;
        }
    }
}