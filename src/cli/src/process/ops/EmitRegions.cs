//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using static ProcessMemory;

    partial class ProcessContextPipe
    {
        public Index<MemoryRegion> EmitRegions(Process process, FS.FilePath dst)
        {
            var regions = ImageMemory.regions(process);
            EmitRegions(regions,dst);
            return regions;
        }

        public Index<MemoryRegion> EmitRegions(Process process, Timestamp ts)
        {
            var regions = ImageMemory.regions(process);
            var dst = Paths.MemoryRegionPath(process,ts);
            EmitRegions(regions,dst);
            return regions;
        }

        public Index<MemoryRegion> EmitRegions(FS.FilePath dst)
        {
            var regions = ImageMemory.regions();
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