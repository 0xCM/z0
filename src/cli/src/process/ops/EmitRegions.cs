//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Windows;
    using System.Diagnostics;

    using static ProcessMemory;


    partial class ProcessContextPipe
    {

        [Op]
        public static Index<MemoryRegion> regions()
            => ImageServices.pages(MemoryNode.snapshot().Describe());

        [Op]
        public static Index<MemoryRegion> regions(int procid)
            => ImageServices.pages(MemoryNode.snapshot(procid).Describe());

        [Op]
        public static Index<MemoryRegion> regions(Process src)
            => ImageServices.pages(MemoryNode.snapshot(src.Id).Describe());

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
            var _regions = regions(process);
            EmitRegions(_regions,dst);
            return _regions;
        }

        public Index<MemoryRegion> EmitRegions(FS.FilePath dst)
        {
            var _regions = regions();
            EmitRegions(_regions,dst);
            return _regions;
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