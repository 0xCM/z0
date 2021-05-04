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
            => Images.pages(MemoryNode.snapshot().Describe());

        [Op]
        public static Index<MemoryRegion> regions(int procid)
            => Images.pages(MemoryNode.snapshot(procid).Describe());

        [Op]
        public static Index<MemoryRegion> regions(Process src)
            => Images.pages(MemoryNode.snapshot(src.Id).Describe());

        public Index<MemoryRegion> EmitRegions(Process process, FS.FilePath dst)
        {
            var _regions = regions(process);
            EmitRegions(_regions,dst);
            return _regions;
        }

        public Index<MemoryRegion> EmitRegions(Process process, Timestamp ts)
        {
            var _regions = regions(process);
            var dst = Paths.MemoryRegionPath(process,ts);
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