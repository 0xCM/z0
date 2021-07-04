//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class ApiExtractor
    {
        ReadOnlySpan<ProcessMemoryRegion> LogRegions(uint step)
        {
            var regions = ImageMemory.regions();
            Emit(regions.View, Db.Table<ProcessMemoryRegion>(SegDir, step.ToString()));
            return regions;
        }
    }
}